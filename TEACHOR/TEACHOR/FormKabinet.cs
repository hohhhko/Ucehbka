using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static TEACHOR.Program;

namespace TEACHOR
{
    public partial class FormKabinet : Form
    {
        private SQLiteConnection DB;
        public FormKabinet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStart frm = new FormStart();
            frm.Show();
            this.Hide();
        }

        private void FormKabinet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void FormKabinet_Load(object sender, EventArgs e)
        {
            this.Text = $"Кабинет {DataCase.NumberKab}";

            DB = new SQLiteConnection(DAB.ConnectionString);
            await DB.OpenAsync();

            SQLiteDataAdapter datapd = new SQLiteDataAdapter($"SELECT * FROM {Table_Kabinet.main} " +
                $"WHERE NumberKab = '" + DataCase.NumberKab + "'", DB);
            DataSet ds = new DataSet();

            datapd.Fill(ds, "Info");
            DataGridTechn.DataSource = ds.Tables[0];
        }
    }
}
