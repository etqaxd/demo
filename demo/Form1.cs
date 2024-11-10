using System.Data.OleDb;


namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Partners_import";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbDataReader = dbCommand.ExecuteReader();

            if (dbDataReader.HasRows == false)
            {
                MessageBox.Show("������ ���");
            }
            else
            {
                while (dbDataReader.Read())
                {
                    dataGridView1.Rows.Add(dbDataReader["���"], dbDataReader["��� ��������"], dbDataReader["������������ ��������"], dbDataReader["��������"],
                    dbDataReader["����������� ����� ��������"], dbDataReader["������� ��������"], dbDataReader["����������� ����� ��������"], dbDataReader["���"],
                    dbDataReader["�������"]);
                }
            }
            dbDataReader.Close();
            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Products_import";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbDataReader = dbCommand.ExecuteReader();

            if (dbDataReader.HasRows == false)
            {
                MessageBox.Show("������ ���");
            }
            else
            {
                while (dbDataReader.Read())
                {
                    dataGridView2.Rows.Add(dbDataReader["���"], dbDataReader["��� ���������"], dbDataReader["������������ ���������"],
                        dbDataReader["�������"], dbDataReader["����������� ��������� ��� ��������"]);
                }
            }
            dbDataReader.Close();
            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("������ ���� ������");
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null ||
                dataGridView1.Rows[index].Cells[8].Value == null)

            {
                MessageBox.Show("�� ��� ������ �������");
            }

            string code_partner = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string partner_type = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string name_partner = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string director = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string mail_patner = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string phone_number = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string yur_addres = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string inn = dataGridView1.Rows[index].Cells[7].Value.ToString();
            string rating_partner = dataGridView1.Rows[index].Cells[8].Value.ToString();

            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO Partners_import VALUES (" + code_partner + ",'" + partner_type + "', '" + name_partner + "'," +
                " '" + director + "', '" + mail_patner + "', " + phone_number + ", '" + yur_addres + "', '" + inn + "', " + rating_partner + ")";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("������");
            else
                MessageBox.Show("������ ���������");


            dbConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("������ ���� ������");
            }

            int index = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null)

            {
                MessageBox.Show("�� ��� ������ �������");
            }

            string code_products = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string products_type = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string name_products = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string artikul = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string min_val_prod = dataGridView2.Rows[index].Cells[4].Value.ToString();

            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "INSERT INTO Products_import VALUES (" + code_products + ",'" + products_type + "', '" + name_products + "'," +
                " " + artikul + ", " + min_val_prod + ")";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("������");
            else
                MessageBox.Show("������ ���������");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("������ ���� ������");
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null ||
                dataGridView1.Rows[index].Cells[8].Value == null)

            {
                MessageBox.Show("�� ��� ������ �������");
            }

            string code_partner = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string partner_type = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string name_partner = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string director = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string mail_patner = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string phone_number = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string yur_addres = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string inn = dataGridView1.Rows[index].Cells[7].Value.ToString();
            string rating_partner = dataGridView1.Rows[index].Cells[8].Value.ToString();

            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "UPDATE Partners_import SET [��� ��������]='" + partner_type + "',[������������ ��������]='" + name_partner + "',��������='" + director + "',[����������� ����� ��������]='" + mail_patner + "',[������� ��������]='" + phone_number + "',[����������� ����� ��������]='" + yur_addres + "',���=" + inn + ",�������=" + rating_partner + " WHERE ���= " + code_partner;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("������");
            else
                MessageBox.Show("������ ���������");


            dbConnection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("������ ���� ������");
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null)

            {
                MessageBox.Show("�� ��� ������ �������");
            }

            string code_partner = dataGridView1.Rows[index].Cells[0].Value.ToString();


            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Partners_import WHERE ���= " + code_partner;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("������");
            else
                MessageBox.Show("������ �������");
            dataGridView1.Rows.RemoveAt(index);

            dbConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("������ ���� ������");
            }

            int index = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[index].Cells[0].Value == null ||
                dataGridView2.Rows[index].Cells[1].Value == null ||
                dataGridView2.Rows[index].Cells[2].Value == null ||
                dataGridView2.Rows[index].Cells[3].Value == null ||
                dataGridView2.Rows[index].Cells[4].Value == null)

            {
                MessageBox.Show("�� ��� ������ �������");
            }

            string code_products = dataGridView2.Rows[index].Cells[0].Value.ToString();
            string products_type = dataGridView2.Rows[index].Cells[1].Value.ToString();
            string name_products = dataGridView2.Rows[index].Cells[2].Value.ToString();
            string artikul = dataGridView2.Rows[index].Cells[3].Value.ToString();
            string min_val_prod = dataGridView2.Rows[index].Cells[4].Value.ToString();

            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "UPDATE Products_import SET [��� ���������]='" + products_type + "',[������������ ���������]='" + name_products + "',�������=" + artikul + ",[����������� ��������� ��� ��������]=" + min_val_prod + " WHERE ��� = " + code_products;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("������");
            else
                MessageBox.Show("������ ��������");
        }

        private void button8_Click(object sender, EventArgs e)
        {
   
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("������ ���� ������");
            }

            int index = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[index].Cells[0].Value == null)

            {
                MessageBox.Show("�� ��� ������ �������");
            }

            string code_products = dataGridView2.Rows[index].Cells[0].Value.ToString();


            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=pall.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Products_import WHERE ���= " + code_products;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("������");
            else
                MessageBox.Show("������ �������");
            dataGridView2.Rows.RemoveAt(index);

            dbConnection.Close();
        }
    }
}
