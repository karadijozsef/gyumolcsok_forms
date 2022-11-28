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

namespace gyumolcsok_forms
{
    public partial class Form_Nyito : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;

        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void Form_Nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                //-- terv szerint
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //-- váratlan hiba!
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!!");
                Environment.Exit(0);

            }
            finally
            {
                //-- Hiba és terv szerinti esetén is lefut
                conn.Close();
            }

            
        }

        private void gyumolcs_update()
        {
            listBox_gyumolcs.Items.Clear();
            cmd.CommandText = "SELECT `id`, `nev`, `egysegar`, `mennyiseg` FROM `gyumolcs` WHERE 1;";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    gyumolcsok uj = new gyumolcsok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetInt32("egysegar"), dr.GetInt32("mennyiseg"));
                    listBox_gyumolcs.Items.Add(uj);

                }

            }
            conn.Close();
        }

        private void újGyümölcsHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nincsenek_adatok())
            {
                return;
            }
            cmd.CommandText = "INSERT INTO `gyumolcs` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @egysegar, @mennyiseg)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDown_egysegar.Value);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown_mennyiseg.Value);
            conn.Open();
            try
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBox_id.Text = "";
                    textBox_nev.Text = "";
                    numericUpDown_egysegar.Text = "";
                    numericUpDown_egysegar.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!");

            }
            conn.Close();



        }
        private bool nincsenek_adatok()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adjon meg egy gyümölcs nevet!");
                textBox_nev.Focus();
                return true;
            }
            if (numericUpDown_mennyiseg.Value > 1000)
            {
                MessageBox.Show("Érvénytelen mennyiség!!!");
                numericUpDown_mennyiseg.Value = 1000;
                numericUpDown_mennyiseg.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(numericUpDown_egysegar.Text))
            {
                MessageBox.Show("Nem adott meg egyséárat!!");
                numericUpDown_egysegar.Focus();
                return true;
            }
            return false;
        }

        private void gyümölcsMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_gyumolcs.SelectedIndex < 0)
            {
                return;
            }
            //--  A felhasználó kijeleöl egy elemet a listából
            gyumolcsok kivalasztott_gyumolcs = (gyumolcsok)listBox_gyumolcs.SelectedItem;
            cmd.CommandText = "UPDATE `gyumolcs` SET `nev` = @nev, `egysegar` = @egysegar, `mennyiseg`= @mennyiseg WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text.ToString());
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDown_egysegar.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDown_mennyiseg.Value);
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Módosítás sikeres volt!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                numericUpDown_egysegar.Text = "";
                numericUpDown_mennyiseg.Text = "";
                
            }
            else
            {

                MessageBox.Show("Az adatok módosítása sikertelen volt!");

            }
            if (conn.State == ConnectionState.Open)
            {

                conn.Close();

            }
        }

        private void gyümölcsTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_gyumolcs.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `gyumolcs` WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                numericUpDown_egysegar.Value = 0;
                numericUpDown_egysegar.Value = 0;
                
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void listBox_gyumolcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_gyumolcs.SelectedIndex < 0)
            {
                return;
            }
            // --A felhasználó kijelöl egy elemet a listában.
            gyumolcsok kivalasztottgyumolcs = (gyumolcsok)listBox_gyumolcs.SelectedItem;
            textBox_id.Text = kivalasztottgyumolcs.Id.ToString();
            textBox_nev.Text = kivalasztottgyumolcs.Nev;
            numericUpDown_egysegar.Text = kivalasztottgyumolcs.Egysegar.ToString();
            numericUpDown_mennyiseg.Text = kivalasztottgyumolcs.Mennyiseg.ToString();
        }
    }
}
