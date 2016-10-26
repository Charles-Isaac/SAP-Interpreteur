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

namespace SAP_Interpreteur
{
    public partial class frmKeyboardPrompt : Form
    {
        public byte Cla { get; set; }
        public frmKeyboardPrompt()
        {
            InitializeComponent();
            this.txtCla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            txtCla.Focus();
        }

        
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnOK_Click(sender, e);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCla.Text))
            {
                byte Temp;
                if (byte.TryParse(txtCla.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out Temp))
                {
                    Cla = Temp;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
