using MySql.Data.MySqlClient;
using System.Data;

namespace Test_MySQL_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
        }

        public void load_data()
        {
            DataBase db = new DataBase();
            db.Open_DB();
            string query = "SELECT * FROM Users";
            MySqlCommand cmd = new MySqlCommand(query, db.mysqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource source = new BindingSource();
            source.DataSource = table;
            dataGridView1.DataSource = source;
            db.Close_DB();

        }

        private void addData_Click(object sender, EventArgs e)
        {
            string ID = textBox_ID.Text;
            string Name = textBox_name.Text;
            string number = textBox_Num.Text;
            string email = textBox_mail.Text;

            DataBase db = new DataBase();
            db.Open_DB();
            string query = "INSERT INTO Users (ID,Name,email,Num) VALUES (@ID,@Name,@Email,@Number)";
            MySqlCommand cmd = new MySqlCommand(query, db.mysqlConnection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Number", number);

            cmd.ExecuteNonQuery();
            db.Close_DB();
            load_data();
        }

        private void Refrech_Click(object sender, EventArgs e)
        {
            load_data();
        }

        void deleteData_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataBase db = new DataBase();
            db.Open_DB();
            string query = "DELETE FROM Users WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, db.mysqlConnection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            db.Close_DB();
            load_data();
        }

        


         
        private void button1_Click(object sender, EventArgs e)
        {
            deleteData_Click(sender, e);
        }
    }
}