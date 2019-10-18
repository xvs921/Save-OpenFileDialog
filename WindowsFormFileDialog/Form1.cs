using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    File.WriteAllLines(fileName, listSzovegek.Items.Cast<string>().ToArray());

                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült a kiírás.");
                }

            };

            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);
                    listSzovegek.Items.Clear();
                    foreach (var item in sorok)
                    {
                        listSzovegek.Items.Add(item);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba! Nem sikerült betöltés.");
                }
            };
        }

        private void tbBeir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listSzovegek.Items.Add(tbBeir.Text);
                tbBeir.Text = "";
            }
        }

        private void btnMent_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
