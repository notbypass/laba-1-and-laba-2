using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace svetmakomisha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select employee.LName_e as L, employee.FName_e as F, employee.MName_e as M, apteka.title as Title from employee join apteka on employee.id_apteka = apteka.id_ap;";
            MySqlConnection conn = DBUtils.GetMySqlConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            { 
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2),rd.GetString(3)};
                        var listViemItem = new ListViewItem(row);
                        listView1.Items.Add(listViemItem);
                    }
                }

                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                MessageBox.Show("Подключение к БД прошло успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);

            }
            
        }



    }
}
