using Commands_Runner.Helpers;
using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands_Runner.Models
{
    public class PrimaveraEmpresasModel
    {
        public string StringComcat { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public static List<PrimaveraEmpresasModel> GetAll()
        {
            string SQL = @"
                SELECT CONCAT(Codigo, ' - ', IDNome) AS StringComcat,
                       Codigo,
                       IDNome AS Nome
                FROM PRIEMPRE.dbo.Empresas;
            ";

            return AppHelper.SQL.LoadDataListOpen<PrimaveraEmpresasModel>(SQL);
        }
    }
}
