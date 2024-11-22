using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static TEACHOR.Program;

namespace TEACHOR
{
    public partial class FormStorage : Form
    {
        private SQLiteConnection DB;
        private bool buttonclick = false;
        public FormStorage()
        {
            InitializeComponent();
            ContextMenus.Items.AddRange(new[] { ToolStripMenuErase, ToolStripMenuChange, ToolStripMenuDel });
            DataGridAll.ContextMenuStrip = ContextMenus;
            DataGridKab.ContextMenuStrip = ContextMenus;
            ToolStripMenuDel.Click += ToolStripMenuDel_Click;
            ToolStripMenuErase.Click += ToolStripMenuErase_Click;
            ToolStripMenuChange.Click += ToolStripMenuChange_Click;
        }

        async void ToolStripMenuErase_Click(object sender, EventArgs e)
        {
            int n = int.Parse(DataGridAll.CurrentRow.Index.ToString());
            string id1 = DataGridAll.Rows[n].Cells[0].Value.ToString();
            int s = int.Parse(DataGridKab.CurrentRow.Index.ToString());
            string id2 = DataGridKab.Rows[s].Cells[0].Value.ToString();


            if (buttonclick == true && TextBoxCost.Text == "")
            {
                SQLiteCommand del = new SQLiteCommand($"DELETE FROM [{Table_Storage.main}] " +
                    $"WHERE ID = {id1}", DB);

                SQLiteCommand ins = new SQLiteCommand($"INSERT INTO [{Table_Kabinet.main}](NumberKab,NameMain,Tecnik,Status,Date) " +
                    $"VALUES(@NumberKab,@NameMain,@Tecnik,@Status,@Date) ", DB);
                ins.Parameters.AddWithValue("NumberKab", ComboCabun.Text);
                ins.Parameters.AddWithValue("NameMain", ComboRespond.Text);
                ins.Parameters.AddWithValue("Tecnik", TextBoxName.Text);
                ins.Parameters.AddWithValue("Status", ComboStatus.Text);
                ins.Parameters.AddWithValue("Date", DateTEchn.Value);

                await ins.ExecuteNonQueryAsync();
                await del.ExecuteNonQueryAsync();

                buttonclick = false;
                MessageBox.Show("Техника перевредина");
            }
            else if (buttonclick == true && TextBoxCost.Text != "")
            {
                SQLiteCommand ins = new SQLiteCommand($"INSERT INTO [{Table_Storage.main}] (NameTechn,Cost,Status,Date) " +
                        $"VALUES(@NameTechn,@Cost,@Status,@Date)", DB);
                ins.Parameters.AddWithValue("NameTechn", TextBoxName.Text);
                ins.Parameters.AddWithValue("Cost", TextBoxCost.Text);
                ins.Parameters.AddWithValue("Status", ComboStatus.Text);
                ins.Parameters.AddWithValue("Date", DateTEchn.Value);

                SQLiteCommand del = new SQLiteCommand($"DELETE FROM [{Table_Storage.main}] " +
                    $"WHERE ID = {id2}", DB);

                await ins.ExecuteNonQueryAsync();
                await del.ExecuteNonQueryAsync();
                buttonclick = false;
                MessageBox.Show("Техника переведина на склад");
            }
            else
            {
                MessageBox.Show("Должна быть выделена строка");
            }
        }

        void ToolStripMenuChange_Click(object sender, EventArgs e)
        {
            buttonclick = true;
            foreach (DataGridViewRow row in DataGridKab.SelectedRows)
            {
                ComboCabun.Text = row.Cells[1].Value.ToString();
                ComboRespond.Text = row.Cells[2].Value.ToString();
                ComboStatus.Text = row.Cells[4].Value.ToString();
                TextBoxName.Text = row.Cells[3].Value.ToString();
                DateTEchn.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
            foreach (DataGridViewRow row in DataGridAll.SelectedRows)
            {
                TextBoxCost.Text = row.Cells[2].Value.ToString();
                ComboStatus.Text = row.Cells[3].Value.ToString();
                TextBoxName.Text = row.Cells[1].Value.ToString();
                DateTEchn.Value = Convert.ToDateTime(row.Cells[4].Value);
            }
        }

        async void ToolStripMenuDel_Click(object sendeer, EventArgs e)
        {
            int n = int.Parse(DataGridAll.CurrentRow.Index.ToString());
            string id1 = DataGridAll.Rows[n].Cells[0].Value.ToString();
            int s = int.Parse(DataGridKab.CurrentRow.Index.ToString());
            string id2 = DataGridKab.Rows[s].Cells[0].Value.ToString();

            if (DataGridAll.SelectedCells.Count == 1)
            {
                SQLiteCommand com = new SQLiteCommand($"DELETE FROM [{Table_Storage.main}] " +
                    $"WHERE id = {id1}", DB);
                await com.ExecuteNonQueryAsync();
                MessageBox.Show("Строка удалена");
            }
            else if (DataGridKab.SelectedCells.Count == 1)
            {
                SQLiteCommand com = new SQLiteCommand($"DELETE FROM [{Table_Kabinet.main}] " +
                    $"WHERE id = {id2}", DB);
                await com.ExecuteNonQueryAsync();
                MessageBox.Show("Строка удалена");
            }
            else
            {
                MessageBox.Show("Невозможно удалить возможно стока c ID не выделена");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStart frm = new FormStart();
            frm.Show();
            this.Hide();
        }

        private void FormStorage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void FormStorage_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DAB.ConnectionString);
            await DB.OpenAsync();

            SQLiteDataReader read;
            SQLiteCommand com1 = new SQLiteCommand($"SELECT * FROM [{Table_Kabinet.main}]", DB);
            read = com1.ExecuteReader();
            while (read.Read())
            {
                ComboCabun.Items.Add((string)read["NumberKab"]);
                ComboRespond.Items.Add((string)read["NameMain"]);
            }
            read.Close();
        }

        private void ButtonRefres_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter datapd = new SQLiteDataAdapter($"SELECT * FROM {Table_Kabinet.main} ", DB);
            DataSet ds = new DataSet();

            datapd.Fill(ds, "Info");
            DataGridKab.DataSource = ds.Tables[0];

            SQLiteDataAdapter datap = new SQLiteDataAdapter($"SELECT * FROM {Table_Storage.main} ", DB);
            DataSet d = new DataSet();

            datap.Fill(d, "Info");
            DataGridAll.DataSource = d.Tables[0];

            ComboStatus.Text = "";
            ComboRespond.Text = "";
            ComboCabun.Text = "";
            TextBoxCost.Text = "";
            TextBoxName.Text = "";
            DateTEchn.Value = DateTime.Now;
        }

        private async void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (TextBoxCost.Text != "" && TextBoxName.Text != "")
            {
                SQLiteCommand com = new SQLiteCommand($"INSERT INTO [{Table_Storage.main}] (NameTechn,Cost,Status,Date) " +
                    $"VALUES(@NameTechn,@Cost,@Status,@Date)", DB);
                com.Parameters.AddWithValue("NameTechn", TextBoxName.Text);
                com.Parameters.AddWithValue("Cost", TextBoxCost.Text);
                com.Parameters.AddWithValue("Status", ComboStatus.Text);
                com.Parameters.AddWithValue("Date", DateTEchn.Value);

                await com.ExecuteNonQueryAsync();
                MessageBox.Show("Техника добавлина на склад");

                ComboStatus.Text = "";
                ComboRespond.Text = "";
                ComboCabun.Text = "";
                TextBoxCost.Text = "";
                TextBoxName.Text = "";
                DateTEchn.Value = DateTime.Now;
            }
        }

        private void TextBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private async void ButtonUpadet_Click_1(object sender, EventArgs e)
        {
            int n = int.Parse(DataGridAll.CurrentRow.Index.ToString());
            string id1 = DataGridAll.Rows[n].Cells[0].Value.ToString();
            int s = int.Parse(DataGridKab.CurrentRow.Index.ToString());
            string id2 = DataGridKab.Rows[s].Cells[0].Value.ToString();

            if (buttonclick == true && ComboCabun.Text != "")
            {
                SQLiteCommand upd1 = new SQLiteCommand($"UPDATE [{Table_Kabinet.main}] " +
                    $"SET NumberKab = '{ComboCabun.Text}', NameMain = '{ComboRespond.Text}', Tecnik = '{TextBoxName.Text}', Status = '{ComboStatus.Text}', Date = '{DateTEchn.Value}' " +
                    $"WHERE id = '{id2}'", DB);
                await upd1.ExecuteNonQueryAsync();
                buttonclick = false;
                MessageBox.Show("Данные изменены");
            }
            else if (buttonclick == true)
            {
                SQLiteCommand upd2 = new SQLiteCommand($"UPDATE [{Table_Storage.main}] " +
                        $"SET NameTechn = '{TextBoxName.Text}', Cost = '{TextBoxCost.Text}', Status = '{ComboStatus.Text}', Date = '{DateTEchn.Value}' " +
                        $"WHERE id = '{id1}'", DB);
                await upd2.ExecuteNonQueryAsync();
                buttonclick = false;
                MessageBox.Show("Данные изменены");
            }
            else
            {
                MessageBox.Show("Должны быть заполнены");
            }
        }

        private void DataGridAll_Click(object sender, EventArgs e)
        {
            DataGridKab.ClearSelection();
        }

        private void DataGridKab_Click(object sender, EventArgs e)
        {
            DataGridAll.ClearSelection();
        }
    }
}
