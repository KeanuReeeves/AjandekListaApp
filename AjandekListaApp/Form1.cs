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
        Ajandek a;
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
            ajandeklist.Items.Clear();
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
                    catch (SqlNullValueException)
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
            reszletesAdat.Items.Clear();
            a = (Ajandek)ajandeklist.SelectedItem;
            if (ajandeklist.SelectedIndex>0)
            {
                reszletesAdat.Items.Add(a.Id);
                reszletesAdat.Items.Add(a.Nev);
                if (a.Uzlet == null)
                {
                    reszletesAdat.Items.Add("Saját készítésű");
                }
                else
                {
                    reszletesAdat.Items.Add(a.Uzlet);
                }
                btntorol.Visible = true;
                UpdateGroup.Visible = true;
                nevUpdate.Text = a.Nev;
                UzletUpdate.Text = a.Uzlet;
            }
            else
            {
                btntorol.Visible = false;
                UpdateGroup.Visible = false;
            }
            
        }
        
        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            string sql = @"
            INSERT INTO ajandek(nev,uzlet)
            VALUES (@nev,@uzlet)";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            if (nevFelvesz.Text != "")
            {
                comm.Parameters.AddWithValue("@nev", nevFelvesz.Text);
            }
            else
            {
                MessageBox.Show("A név mező nem lehet üres");
            }
            if (uzletFelvesz.Text != "")
            {
                comm.Parameters.AddWithValue("@uzlet", uzletFelvesz.Text);
            }
            else
            {
                comm.Parameters.AddWithValue("@uzlet", null);
            }
            
            var insert = comm.ExecuteNonQuery();
            AdatBetoltes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            a = (Ajandek)ajandeklist.SelectedItem;
            string sql = @"
            UPDATE ajandek
            SET nev=@nev,
                uzlet=@uzlet
            WHERE id=@id";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", a.Id);
            if (nevUpdate.Text!="")
            {
                comm.Parameters.AddWithValue("@nev", nevUpdate.Text);
            }
            else
            {
                MessageBox.Show("A név mező nem lehet üres");
            }
            if (UzletUpdate.Text != "")
            {
                comm.Parameters.AddWithValue("@uzlet", UzletUpdate.Text);
            }
            else
            {
                comm.Parameters.AddWithValue("@uzlet", null);
            }
            var insert = comm.ExecuteNonQuery();
            ajandeklist.SelectedIndex = -1;
            AdatBetoltes();
            
        }

        private void btntorol_Click(object sender, EventArgs e)
        {
            a = (Ajandek)ajandeklist.SelectedItem;
            string sql = @"
            DELETE FROM ajandek
            WHERE id=@id";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@id", a.Id);
            string message = "Biztosan törölni szeretné?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result==System.Windows.Forms.DialogResult.Yes)
            {
                comm.ExecuteNonQuery();
                ajandeklist.SelectedIndex = -1;
            }
            AdatBetoltes();
            
        }
    }
}
