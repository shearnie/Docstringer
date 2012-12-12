using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Docstringer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (this.txtVarName.Text.Equals("")) return;

            if (this.rbCS.Checked)
            {
                this.RunCS();
            }
            else if (this.rbVB.Checked)
            {
                this.RunVB();
            }
        }

        private void RunVB()
        {
            this.txtOut.Text = "Dim " + this.txtVarName.Text + " As New System.Text.Stringbuilder()\r\n";

            string[] s = this.txtIn.Text.Split("\r\n".ToCharArray());
            if (s == null) return;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (!s[i].Equals(""))
                {
                    this.txtOut.AppendText(this.txtVarName.Text + ".AppendLine(\"" + s[i].Replace("\"", "\"\"") + "\")\r\n");
                }
                else
                {
                    this.txtOut.AppendText(this.txtVarName.Text + ".AppendLine(\"\")\r\n");
                }
            }
        }

        private void RunCS()
        {
            this.txtOut.Text = "var " + this.txtVarName.Text + " = new System.Text.Stringbuilder();\r\n";

            string[] s = this.txtIn.Text.Split("\r\n".ToCharArray());
            if (s == null) return;

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (!s[i].Equals(""))
                {
                    this.txtOut.AppendText(this.txtVarName.Text + ".AppendLine(\"" + s[i].Replace("\"", "\\\"") + "\");\r\n");
                }
                else
                {
                    this.txtOut.AppendText(this.txtVarName.Text + ".AppendLine(\"\");\r\n");
                }
            }
        }
    }
}
