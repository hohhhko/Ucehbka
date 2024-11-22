using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static TEACHOR.Program;

namespace TEACHOR
{

    public partial class FormStart : Form
    {
        private SQLiteConnection DB;

        public FormStart()
        {
            InitializeComponent();
        }

        private void ButtonStorage_Click(object sender, EventArgs e)
        {
            FormStorage frm = new FormStorage();
            frm.Show();
            this.Hide();
        }

        private async void ButtonCab_Click(object sender, EventArgs e)
        {
            if (TextBoxNubKab.Text == "")
            {
                MessageBox.Show("Необходимо указать номер кабинета");
            }
            else
            {
                SQLiteDataReader read;
                SQLiteCommand com = new SQLiteCommand($"SELECT NumberKab FROM [{Table_Kabinet.main}]" +
                    $"WHERE {Table_Kabinet.NumberKab}= @NumberKab", DB);
                com.Parameters.AddWithValue("NumberKab", TextBoxNubKab.Text);
                read = (SQLiteDataReader)await com.ExecuteReaderAsync();
                if (await read.ReadAsync())
                {
                    DataCase.NumberKab = read[$"{Table_Kabinet.NumberKab}"].ToString();
                    FormKabinet frm = new FormKabinet();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Такого кабинета нет!");
                }
                read.Close();
            }

            if (CheckBoxNewCab.Checked && TextBoxNubKab.Text != "")
            {
                SQLiteCommand com = new SQLiteCommand($"INSERT INTO [{Table_Kabinet.main}] (NumberKab,NameMain,Tecnik,Status,Date)" +
                    $"VALUES (@NumberKab,@NameMain,@Tecnik,@Status,@Date)", DB);
                com.Parameters.AddWithValue("NumberKab", TextBoxNubKab.Text);
                com.Parameters.AddWithValue("NameMain", " ");
                com.Parameters.AddWithValue("Tecnik", " ");
                com.Parameters.AddWithValue("Status", " ");
                com.Parameters.AddWithValue("Date", " ");
                await com.ExecuteNonQueryAsync();

                MessageBox.Show($"Кабинет Номер: {TextBoxNubKab.Text} Создан");

                FormKabinet frm = new FormKabinet();
                frm.Show();
                this.Hide();
            }
        }

        private async void FormStart_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DAB.ConnectionString);
            await DB.OpenAsync();
        }

        private void FormStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxNubKab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}