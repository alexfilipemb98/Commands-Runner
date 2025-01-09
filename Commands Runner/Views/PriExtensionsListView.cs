using Commands_Runner.Forms;
using Commands_Runner.Helpers;
using Commands_Runner.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commands_Runner.Views
{
    public partial class PriExtensionsListView : DevExpress.XtraEditors.XtraUserControl
    {
        public PriExtensionsListView() => InitializeComponent();

        public void LoadData()
        {
            gvExtensibilityConfiguration.BeginDataUpdate();
            gvExtensibilityConfiguration.ShowLoadingPanel();

            Task.Run(() =>
            {
                if (this.InvokeRequired)
                    this.Invoke((MethodInvoker)(() => ld()));
                else
                    ld();

                void ld()
                {
                    primaveraExtensionModelBindingSource.DataSource = PrimaveraExtensionModel.GetAll();
                }
            })
            .ContinueWith(t =>
            {
                gvExtensibilityConfiguration.EndDataUpdate();
                gvExtensibilityConfiguration.HideLoadingPanel();
            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void gvExtensibilityConfiguration_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu.ShowPopup(Control.MousePosition);
        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrimaveraExtensionModel extensibility = new PrimaveraExtensionModel();

            ExtensionsEditorForm frm = new ExtensionsEditorForm(extensibility, true);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrimaveraExtensionModel.Save(extensibility);
                AppHelper.SetStatus($"Extension created!", Color.Green);
                primaveraExtensionModelBindingSource.Add(extensibility);
            }
        }

        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrimaveraExtensionModel extensibility = GetObjectByRowHandle(gvExtensibilityConfiguration.FocusedRowHandle);

            if (extensibility == null) return;

            ExtensionsEditorForm frm = new ExtensionsEditorForm(extensibility);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                PrimaveraExtensionModel.Save(extensibility);
                AppHelper.SetStatus($"Extension saved!", Color.Green);
                gvExtensibilityConfiguration.UpdateCurrentRow();
            }
        }

        private void bbiExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "PriExtensionsList.pdf";
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Export PriExtensions.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    gvExtensibilityConfiguration.ExportToPdf(destinationFilePath);
                }
            }

        }

        private void bbiExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "PriExtensionsList.xls";
                saveFileDialog.Filter = "XLS Files (*.xls)|*.xls";
                saveFileDialog.Title = "Export PriExtensions.xls";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationFilePath = saveFileDialog.FileName;

                    gvExtensibilityConfiguration.ExportToXls(destinationFilePath);
                }
            }
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => LoadData();

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrimaveraExtensionModel extensibility = GetObjectByRowHandle(gvExtensibilityConfiguration.FocusedRowHandle);

            if (extensibility == null) return;

            DialogResult result = XtraMessageBox.Show($"Deseja apagar a configuração '{extensibility.AssemblyName}'?", "Apagar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                PrimaveraExtensionModel.Delete(extensibility.ID);
                primaveraExtensionModelBindingSource.Remove(extensibility);
            }
        }

        /// <summary>
        /// Gets the object by row handle
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        private PrimaveraExtensionModel GetObjectByRowHandle(int rowIndex)
        {
            if (rowIndex >= 0)
                return gvExtensibilityConfiguration.GetRow(rowIndex) as PrimaveraExtensionModel;
            else
                return null;
        }
    }
}
