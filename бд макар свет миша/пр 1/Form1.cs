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

            MySqlConnection conn = DBUtils.GetMySqlConnection();
            try
            {
                conn.Open();
                conn.Close();
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
