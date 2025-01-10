using Commands_Runner.Helpers;
using Commands_Runner.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Commands_Runner.Forms
{
    public partial class ExtensionsEditorForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrimaveraExtensionModel extensibilityConfiguration;
        private bool isNew;

        public ExtensionsEditorForm(PrimaveraExtensionModel ec, bool isNew = false)
        {
            string cap = ec.AssemblyName ?? "New Extension";

            InitializeComponent();

            this.ribbon.ApplicationDocumentCaption = cap;
            this.isNew = isNew;

            if (isNew)
            {
                ec.ID = Guid.NewGuid().ToString()?.Replace("-", string.Empty);
                ec.FileVersion = "1.0.0.0";
                ec.HashCode = GenerateSimpleHash(ec.ID.ToString());
            }

            this.extensibilityConfiguration = ec;

            teID.Text = ec.ID;
            teFileName.Text = ec.FileName.RemoveAllWhitespace();
            teFileVersion.Text = ec.FileVersion;
            seExecutionQueue.EditValue = ec.ExecutionQueue;
            teHashCode.Text = ec.HashCode;
            teAssemblyName.Text = ec.AssemblyName.RemoveAllWhitespace();
            tsCommonExtension.IsOn = ec.CommonExtension;
            tsIsActive.IsOn = ec.IsActive;
            tsIsSystem.IsOn = ec.IsSystem;

            List<PrimaveraEmpresasModel> listaempresas = PrimaveraEmpresasModel.GetAll();
            ccbeCompanys.Properties.DataSource = listaempresas;
            if (!string.IsNullOrWhiteSpace(ec.Company))
            {
                ccbeCompanys.EditValue = ec.Company.Replace(';', ',');
            }
            ccbeCompanys.RefreshEditValue();

            teFileVersion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            teFileVersion.Properties.Mask.EditMask = @"\d+(\.?\d)*";
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isNew)
                extensibilityConfiguration.ID = teID.Text;

            extensibilityConfiguration.FileName = teFileName.Text.RemoveAllWhitespace();
            extensibilityConfiguration.FileVersion = teFileVersion.Text;
            extensibilityConfiguration.ExecutionQueue = int.Parse(seExecutionQueue.EditValue.ToString());
            extensibilityConfiguration.HashCode = teHashCode.Text;
            extensibilityConfiguration.Company = ccbeCompanys.EditValue.ToString().Replace(',', ';');
            extensibilityConfiguration.AssemblyName = teAssemblyName.Text.RemoveAllWhitespace();
            extensibilityConfiguration.CommonExtension = tsCommonExtension.IsOn;
            extensibilityConfiguration.IsActive = tsIsActive.IsOn;
            extensibilityConfiguration.IsSystem = tsIsSystem.IsOn;

            this.DialogResult = DialogResult.OK;
        }

        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void bbiReadFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DLL files (*.dll)|*.dll|All files (*.*)|*.*";
                openFileDialog.Title = "Select a DLL file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dllFilePath = openFileDialog.FileName;

                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(dllFilePath);

                    teFileName.Text = Path.GetFileName(dllFilePath);
                    teFileVersion.Text = fileVersionInfo.FileVersion ?? "1.0.0.0";
                    teHashCode.Text = GenerateFileHash(dllFilePath);
                    teAssemblyName.Text = Path.GetFileNameWithoutExtension(dllFilePath);
                }
            }
        }
        private string GenerateSimpleHash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Converte o hash para string hexadecimal
                return BitConverter.ToString(hashBytes).Replace("-", "").ToUpperInvariant();
            }
        }

        private string GenerateFileHash(string filePath)
        {
            using (MD5 md5 = MD5.Create())
            using (FileStream stream = File.OpenRead(filePath))
            {
                byte[] hashBytes = md5.ComputeHash(stream);

                // Converte o hash para string hexadecimal
                return BitConverter.ToString(hashBytes).Replace("-", "").ToUpperInvariant();
            }
        }

    }
}