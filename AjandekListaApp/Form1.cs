using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjandekListaApp
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=ajandekok;Uid=root;Pwd=");
            conn.Open();
            this.FormClosed += (sender, args) =>
              {
                  if (conn!=null)
                  {
                      conn.Close();
                  }
              };
            AdatBetoltes();
        }
        void AdatBetoltes()
        {
            string sql = @"
            SELECT id,nev,uzlet
            FROM ajandek
            ORDER BY nev";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    var ajandek = new Ajandek(id,nev,uzlet);
                    ajandeklist.Items.Add(ajandek);
                }
            }
        }

        private void ajandeklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
