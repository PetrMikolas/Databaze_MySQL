using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabazeMySQL {
    public partial class Form1 : Form {

        /// <summary>
        /// Instance třídy MySqlConnection
        /// </summary>
        private static readonly MySqlConnection connection = new(@"server=NAS;Port=3307;uid=test;pwd=Testovani*1;database=Skola");

        /// <summary>
        /// Instance třídy MySqlCommand
        /// </summary>
        private readonly MySqlCommand cmd = connection.CreateCommand();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            zobrazData();
        }               

        /// <summary>
        /// Zobrazí v dataGritView data uložená v databázi
        /// </summary>
        private void zobrazData() {
            try {
                connection.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student";
                cmd.ExecuteNonQuery();
                DataTable dt = new();
                MySqlDataAdapter da = new(cmd);
                da.Fill(dt);
                dataGridView.DataSource = dt;
                connection.Close();
                textBoxJmeno.Focus();
            }
            catch (MySqlException ex) { MessageBox.Show("Problém s připojením k databázi:\n" + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connection.Close(); }
        }

        /// <summary>
        /// Vymaže text ze všech textBoxů
        /// </summary>
        private void vymazTextBox() {
            foreach (Control item in panel1.Controls) { if (item is TextBox) { item.ResetText(); } }
            foreach (Control item in panel2.Controls) { if (item is TextBox) { item.ResetText(); } }
        }

        /// <summary>
        /// Vloží data do databáze
        /// </summary>
        private void vlozData() {
            if (!string.IsNullOrEmpty(textBoxJmeno.Text) && !string.IsNullOrEmpty(textBoxPrijmeni.Text) && !string.IsNullOrEmpty(textBoxPohlavi.Text) && !string.IsNullOrEmpty(textBoxIdTrida.Text)) {
                try {
                    connection.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into student values('0','" + textBoxJmeno.Text + "','" + textBoxPrijmeni.Text + "','" + textBoxPohlavi.Text + "','" + textBoxIdTrida.Text + "')";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    zobrazData();
                    vymazTextBox();
                    MessageBox.Show("Zápis do databáze byl úspěšný", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex) { MessageBox.Show("Chybná data k vložení do databáze:\n" + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connection.Close(); }
            }
            else {
                MessageBox.Show($"Vyplňte všechny údaje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Vrátí SQL dotaz pro hledání dat v databázi
        /// </summary>
        /// <returns>SQL dotaz nebo null</returns>
        private string sqlDotazHledej() {
            string jmeno = string.Empty, prijmeni = string.Empty, pohlavi = string.Empty, idTrida = string.Empty;
            if (!string.IsNullOrEmpty(textBoxJmeno.Text) || !string.IsNullOrEmpty(textBoxPrijmeni.Text) || !string.IsNullOrEmpty(textBoxPohlavi.Text) || !string.IsNullOrEmpty(textBoxIdTrida.Text) || !string.IsNullOrEmpty(textBoxID.Text)) {
                if (!string.IsNullOrEmpty(textBoxJmeno.Text)) {
                    jmeno = "select * from student where jmeno = '" + textBoxJmeno.Text + "'";
                }
                if (!string.IsNullOrEmpty(textBoxPrijmeni.Text)) {
                    if (!string.IsNullOrEmpty(textBoxJmeno.Text)) {
                        prijmeni = " intersect select * from student where prijmeni = '" + textBoxPrijmeni.Text + "'";
                    }
                    else {
                        prijmeni = "select * from student where prijmeni = '" + textBoxPrijmeni.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBoxPohlavi.Text)) {
                    if (!string.IsNullOrEmpty(textBoxJmeno.Text) || !string.IsNullOrEmpty(textBoxPrijmeni.Text)) {
                        pohlavi = " intersect select * from student where pohlavi = '" + textBoxPohlavi.Text + "'";
                    }
                    else {
                        pohlavi = "select * from student where pohlavi = '" + textBoxPohlavi.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBoxIdTrida.Text)) {
                    if (!string.IsNullOrEmpty(textBoxJmeno.Text) || !string.IsNullOrEmpty(textBoxPrijmeni.Text) || !string.IsNullOrEmpty(textBoxPohlavi.Text)) {
                        idTrida = " intersect select * from student where id_trida = '" + textBoxIdTrida.Text + "'";
                    }
                    else {
                        idTrida = "select * from student where id_trida = '" + textBoxIdTrida.Text + "'";
                    }
                }
                if (!string.IsNullOrEmpty(textBoxID.Text)) {
                    return "select * from student where id = '" + textBoxID.Text + "'";
                }
                else {
                    return $"{jmeno}{prijmeni}{pohlavi}{idTrida}";
                }
            }
            else {                
                MessageBox.Show($"Zadejte alespoň jeden údaj pro hledání", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Hledá data v databázi
        /// </summary>
        /// <returns>true pokud najde data v databázi, jinak false</returns>
        private bool hledejData() {
            if (sqlDotazHledej() != null) {
                try {
                    connection.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlDotazHledej();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new();
                    MySqlDataAdapter da = new(cmd);
                    int pocetRadku = da.Fill(dt);

                    if (pocetRadku != 0) {
                        dataGridView.DataSource = dt;
                        connection.Close();
                        return true;
                    }
                    else {
                        connection.Close();
                        zobrazData();
                        MessageBox.Show("Zadaný údaj nebo průnik zadaných údajů není v databázi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                catch (MySqlException ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { connection.Close(); }
                return false;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// Upraví data, která jsou již uložena v databázi
        /// </summary>
        private void upravData() {
            if (!string.IsNullOrEmpty(textBoxID.Text)) {
                bool IdExistuje = hledejData();
                if (IdExistuje) {
                    if (!string.IsNullOrEmpty(textBoxJmeno.Text) || !string.IsNullOrEmpty(textBoxPrijmeni.Text) || !string.IsNullOrEmpty(textBoxPohlavi.Text) || !string.IsNullOrEmpty(textBoxIdTrida.Text)) {
                        if (MessageBox.Show("Opravdu chceš upravit data v databázi?", "Výstraha", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                            try {
                                connection.Open();
                                cmd.CommandType = CommandType.Text;
                                if (!string.IsNullOrEmpty(textBoxJmeno.Text)) {
                                    cmd.CommandText = "update student set jmeno = '" + textBoxJmeno.Text + "' where id = '" + textBoxID.Text + "'";
                                    cmd.ExecuteNonQuery();
                                }
                                if (!string.IsNullOrEmpty(textBoxPrijmeni.Text)) {
                                    cmd.CommandText = "update student set prijmeni = '" + textBoxPrijmeni.Text + "' where id = '" + textBoxID.Text + "'";
                                    cmd.ExecuteNonQuery();
                                }
                                if (!string.IsNullOrEmpty(textBoxPohlavi.Text)) {
                                    cmd.CommandText = "update student set pohlavi = '" + textBoxPohlavi.Text + "' where id = '" + textBoxID.Text + "'";
                                    cmd.ExecuteNonQuery();
                                }
                                if (!string.IsNullOrEmpty(textBoxIdTrida.Text)) {
                                    cmd.CommandText = "update student set id_trida = '" + textBoxIdTrida.Text + "' where id = '" + textBoxID.Text + "'";
                                    cmd.ExecuteNonQuery();
                                }
                                connection.Close();
                                zobrazData();
                                vymazTextBox();
                                MessageBox.Show("Úprava dat v databázi byla úspěšná", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            catch (Exception ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            finally { connection.Close(); }
                        }
                        else {
                            vymazTextBox();
                        }
                    }
                    else {
                        MessageBox.Show($"Zadejte alespoň jeden údaj pro úpravu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else {
                MessageBox.Show($"Zadejte ID", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Focus();
            }
        }

        /// <summary>
        /// Vymaže data, která jsou již uložena v databázi
        /// </summary>
        private void vymazData() {
            if (!string.IsNullOrEmpty(textBoxID.Text)) {
                bool IdExistuje = hledejData();
                if (IdExistuje) {
                    if (MessageBox.Show("Opravdu chceš vymazat data z databáze?", "Výstraha", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                        try {
                            connection.Open();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "delete from student where id = '" + textBoxID.Text + "'";
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            zobrazData();
                            vymazTextBox();
                            MessageBox.Show("Vymazání z databáze bylo úspěšné", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        catch (Exception ex) { MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        finally { connection.Close(); }
                    }
                    else {
                        zobrazData();
                        vymazTextBox();
                    }
                }
            }
            else {
                MessageBox.Show($"Zadejte ID", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxID.Focus();
            }
        }

        private void buttonVlozit_Click(object sender, EventArgs e) {
            vlozData();
        }

        private void buttonHledat_Click(object sender, EventArgs e) {
            hledejData();
        }

        private void buttonZobrazit_Click(object sender, EventArgs e) {
            zobrazData();
            vymazTextBox();
        }

        private void buttonVymazat_Click(object sender, EventArgs e) {
            vymazData();
        }

        private void buttonUpravit_Click(object sender, EventArgs e) {
            upravData();
        }
    }
}
