//Inspired by: https://en.wikipedia.org/wiki/Little_man_computer
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace SAP_Interpreteur
{
    public partial class frmInterpreteur : Form
    {
        byte oldIndex;
        byte Index;
        byte Acc;
        bool Z;
        bool N;

        public frmInterpreteur()
        {
            InitializeComponent();
            Index = 0;
            Acc = 0;
            Z = true;
            N = false;
        }

        private void Interpreteur_Load(object sender, EventArgs e)
        {
            GridCode.RowCount = 64;
            GridCode.Columns["Mem1"].DefaultCellStyle.BackColor = Color.Gray;
            GridCode.Columns["Mem2"].DefaultCellStyle.BackColor = Color.Gray;
            GridCode.Columns["Mem3"].DefaultCellStyle.BackColor = Color.Gray;
            GridCode.Columns["Mem4"].DefaultCellStyle.BackColor = Color.Gray;
            for (int i = 0; i < 256; i++)
            {
                GridCode.Rows[i % 64].Cells[i / 64 * 2].Value = i.ToString("X2");
                GridCode.Rows[i % 64].Cells[i / 64 * 2 + 1].Value = "00";
            }
        }

        private void GridCode_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            byte Temp;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
            }
            else
            {
                if (!byte.TryParse(e.FormattedValue.ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out Temp))
                {
                    e.Cancel = true;
                }
            }
        }

        private void GridCode_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {

                e.Value = e.Value.ToString().ToUpper().PadLeft(2, '0');
                e.FormattingApplied = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool Arret = Execution();
            Index++;
            lblCO.Text = "CO: " + Index.ToString();
            lblAcc.Text = "Acc: " + Acc.ToString("X2");
            lblZ.Text = "Z: " + (Z ? "1" : "0");
            lblN.Text = "N: " + (N ? "1" : "0");
            while (cbPauseLoop.Checked && !Arret)
            {
                Arret = Execution();
                Index++;
                lblCO.Text = "CO: " + Index.ToString();
                lblZ.Text = "Z: " + (Z ? "1" : "0");
                lblN.Text = "N: " + (N ? "1" : "0");
                //System.Threading.Thread.Sleep(500);
            }
            if (Arret)
            {
                btnRun.Text = "Executer";
            }
            else
            {
                btnRun.Text = "Suivant";
            }

        }

        private bool Execution()
        {
            //MessageBox.Show(GridCode.Rows[Index % 64].Cells[Index / 64 * 2 + 1].Value.ToString());
            GridCode.Rows[(oldIndex) % 64].Cells[(oldIndex + 1) / 64 * 2 + 1].Style.BackColor = Color.White;
            GridCode.Rows[(oldIndex) % 64].Cells[(oldIndex + 1) / 64 * 2].Style.BackColor = Color.Gray;
            GridCode.Rows[(Index) % 64].Cells[(Index + 1) / 64 * 2 + 1].Style.BackColor = Color.Red;
            GridCode.Rows[(Index) % 64].Cells[(Index + 1) / 64 * 2].Style.BackColor = Color.Red;
            GridCode.FirstDisplayedScrollingRowIndex = Index % 64;
            oldIndex = Index;
            switch (Convert.ToByte(GridCode.Rows[Index % 64].Cells[Index / 64 * 2 + 1].Value.ToString(), 16))
            {
                case 1:
                    Acc = GetKeyboard();
                    break;
                case 2:
                    //==Array[Array[i + 1]] = Acc;
                    GridCode.Rows[(Convert.ToByte(GridCode.Rows[(Index + 1) % 64].Cells[(Index + 1) / 64 * 2 + 1].Value.ToString(), 16)) % 64]
                        .Cells[(Convert.ToByte(GridCode.Rows[(Index + 1) % 64].Cells[(Index + 1) / 64 * 2 + 1]
                        .Value.ToString(), 16)) / 64 * 2 + 1].Value = Acc;
                    Index++;
                    break;
                case 3:
                    //==Acc = Array[Array[i + 1]];
                    Acc = Convert.ToByte(GridCode.Rows[(Convert.ToByte(GridCode.Rows[(Index + 1) % 64].Cells[(Index + 1) / 64 * 2 + 1].Value.ToString(), 16)) % 64]
                        .Cells[(Convert.ToByte(GridCode.Rows[(Index + 1) % 64].Cells[(Index + 1) / 64 * 2 + 1]
                        .Value.ToString(), 16)) / 64 * 2 + 1].Value.ToString(), 16);
                    Index++;
                    break;
                case 4:
                    //==Acc = -Acc;
                    Acc = (byte)(0 - Acc);

                    if (Acc >= 0x80)
                        N = true;
                    else
                        N = false;

                    if (Acc == 0)
                        Z = true;
                    else
                        Z = false;

                    break;
                case 5:
                    //==Acc += Array[Array[i + 1]];
                    Acc += Convert.ToByte(GridCode.Rows[(Convert.ToByte(GridCode.Rows[(Index + 1) % 64]
                        .Cells[(Index + 1) / 64 * 2 + 1].Value.ToString(), 16)) % 64]
                        .Cells[(Convert.ToByte(GridCode.Rows[(Index + 1) % 64]
                        .Cells[(Index + 1) / 64 * 2 + 1]
                        .Value.ToString(), 16)) / 64 * 2 + 1].Value.ToString(), 16);

                    if (Acc >= 0x80)
                        N = true;
                    else
                        N = false;

                    if (Acc == 0)
                        Z = true;
                    else
                        Z = false;
                    Index++;
                    break;
                case 6:
                    if (Z)
                    {
                        //if (i == Array[i + 2])
                        if (Index == Convert.ToByte(GridCode.Rows[(Index + 2) % 64].Cells[(Index + 2) / 64 * 2 + 1].Value.ToString(), 16))
                        {
                            MessageBox.Show("Vous devez vraiment aimer ce label!  " + Index, "Label", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Index = 255;
                            return true;
                        }
                        //i = Array[i + 2] - 1;
                        Index = Convert.ToByte(GridCode.Rows[(Index + 2) % 64].Cells[(Index + 2) / 64 * 2 + 1].Value.ToString(), 16);
                        Index--;

                    }
                    else
                    {
                        if (N)
                        {
                            //if (i == Array[i + 1])
                            if (Index == Convert.ToByte(GridCode.Rows[(Index + 1) % 64].Cells[(Index + 1) / 64 * 2 + 1].Value.ToString(), 16))
                            {
                                MessageBox.Show("Vous devez vraiment aimer ce label!  " + Index, "Label", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Index = 255;
                                return true;
                            }
                            //i = Array[i + 1] - 1;
                            Index = Convert.ToByte(GridCode.Rows[(Index + 1) % 64].Cells[(Index + 1) / 64 * 2 + 1].Value.ToString(), 16);
                            Index--;
                        }
                        else
                        {
                            //i = i + 2;
                            Index += 2;
                        }
                    }
                    break;
                case 7:
                    lblAff.Text += Acc.ToString("X2") + ", ";
                    //MessageBox.Show(Acc.ToString("X"));
                    break;
                case 8:
                    Index = 255;
                    MessageBox.Show("Terminé");
                    return true;
                default:
                    MessageBox.Show("CE MESSAGE NE DEVRAIS PAS SE PRODUIRE", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Index = 255;
                    return true;
            }
            return false;
        }
        private byte GetKeyboard()
        {
            using (frmKeyboardPrompt form = new frmKeyboardPrompt())
            {

                if (form.ShowDialog() == DialogResult.OK)
                {
                    return form.Cla;
                }
            }
            return 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 256; i++)
            {
                GridCode.Rows[i % 64].Cells[i / 64 * 2 + 1].Value = "00";
            }
            lblCO.Text = "CO: 0";
            Index = 0;
            GridCode.Rows[(oldIndex) % 64].Cells[(oldIndex + 1) / 64 * 2 + 1].Style.BackColor = Color.White;
            GridCode.Rows[(oldIndex) % 64].Cells[(oldIndex + 1) / 64 * 2].Style.BackColor = Color.Gray;
            lblAcc.Text = "Acc: ";
            lblAff.Text = "Aff: ";
            lblN.Text = "N: ";
            lblZ.Text = "Z: ";
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SAP file| *.sap";
            saveFileDialog1.Title = "Save a SAP file";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                string[] Temp = new string[256];
                for (int i = 0; i < 256; i++)
                {
                    Temp[i] = GridCode.Rows[i % 64].Cells[i / 64 * 2 + 1].Value.ToString();
                }
                File.WriteAllLines(saveFileDialog1.FileName, Temp, Encoding.UTF8);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SAP file| *.sap";
            openFileDialog1.Title = "open SAP file";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                string[] Temp = File.ReadAllLines(openFileDialog1.FileName);
                if (Temp.Length != 256)
                {
                    MessageBox.Show("File doesn't have the right number of lines");
                    return;
                }
                byte BTemp;
                for (int i = 0; i < 256; i++)
                {
                    if (byte.TryParse(Temp[i].ToString(), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out BTemp))
                    {
                        GridCode.Rows[i % 64].Cells[i / 64 * 2 + 1].Value = Temp[i];
                    }
                }
            }
        }
    }
}
