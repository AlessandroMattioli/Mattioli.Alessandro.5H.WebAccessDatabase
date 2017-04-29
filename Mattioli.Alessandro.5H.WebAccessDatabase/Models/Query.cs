using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Mattioli.Alessandro._5H.WebAccessDatabase.Models
{
    public class Query
    {
        string NomeServer = "";
        string tipoSicurezza = ";Persist Security Info=False";
        OleDbConnection OlDbConnect { get; set; }
        public string ConnectionString { get; set; }
        public Query() { }

        public Query(string DatabaseNamee)
        {
            string NomeFileDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\" + DatabaseNamee;
            ConnectionString = NomeServer + NomeFileDb + tipoSicurezza;
            OlDbConnect = new System.Data.OleDb.OleDbConnection(ConnectionString);
        }

        public DataTable Getdata(string query)
        {
            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, OlDbConnect);
            cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter());
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            return tbl;
        }
    }
}