using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            string source = "Server=localhost;Port=3306;Database=cs_form;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(source);
            string query = "select * from form";
            try//예외 처리
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader table = command.ExecuteReader();
                dataGridView1.Rows.Clear();
                for (int i = 0; table.Read(); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["grade"].Value = table["grade"].ToString();
                    dataGridView1.Rows[i].Cells["cclass"].Value = table["cclass"].ToString();
                    dataGridView1.Rows[i].Cells["no"].Value = table["no"].ToString();
                    dataGridView1.Rows[i].Cells["name"].Value = table["name"].ToString();
                    dataGridView1.Rows[i].Cells["score"].Value = table["score"].ToString();
                }
    
                table.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            String grade = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            String cclass = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            String no = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            String score = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

            string source = "Server=localhost;Port=3306;Database=cs_form;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(source);
            string query = "insert into form values(" + grade + ", '" + cclass + "', '" + no + "', '" + name + "', '"+ score + "')";

            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("성공");
                    dataGridView1.CurrentRow.Selected = false;
                    dataGridView1.Rows[0].Cells[0].Selected = true;
                }
                else
                {
                    Console.WriteLine("실패");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패 : " + ex.Message);
            }
            connection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {    
            int rowIndex = dataGridView1.CurrentRow.Index;
            int ColumnIndex = dataGridView1.CurrentCell.ColumnIndex;
            String Column_text = dataGridView1.Columns[ColumnIndex].HeaderText.ToString();
            String update_data = dataGridView1.CurrentCell.Value.ToString();
            String grade = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            string source = "Server=localhost;Port=3306;Database=cs_form;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(source);
            string query = "UPDATE form SET " + Column_text + " = '" + update_data + "' WHERE grade =" + grade + ";";

            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("성공");
                    dataGridView1.CurrentRow.Selected = false;
                    dataGridView1.Rows[0].Cells[0].Selected = true;
                }
                else
                {
                    Console.WriteLine("실패");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패 : " + ex.Message);
            }
            connection.Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            String grade = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

            string source = "Server=localhost;Port=3306;Database=cs_form;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(source);
            string query = "delete from form where grade =" + grade + ";";

            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("성공");
                    dataGridView1.Rows.Remove(dataGridView1.Rows[rowIndex]);
                    dataGridView1.CurrentRow.Selected = false;
                    dataGridView1.Rows[0].Cells[0].Selected = true;
                }
                else
                {
                    Console.WriteLine("실패");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("실패 : " + ex.Message);
            }
            connection.Close();
        }
    }
}
