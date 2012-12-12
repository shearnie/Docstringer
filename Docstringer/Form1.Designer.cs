namespace Docstringer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtIn = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtVarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbVB = new System.Windows.Forms.RadioButton();
            this.rbCS = new System.Windows.Forms.RadioButton();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtIn);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOut);
            this.splitContainer1.Size = new System.Drawing.Size(984, 761);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtIn
            // 
            this.txtIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIn.Location = new System.Drawing.Point(0, 61);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(492, 700);
            this.txtIn.TabIndex = 1;
            this.txtIn.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.txtVarName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbVB);
            this.panel1.Controls.Add(this.rbCS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(445, 26);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(44, 20);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go >";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtVarName
            // 
            this.txtVarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVarName.Location = new System.Drawing.Point(61, 26);
            this.txtVarName.Name = "txtVarName";
            this.txtVarName.Size = new System.Drawing.Size(378, 20);
            this.txtVarName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "StringBuilder variable name:";
            // 
            // rbVB
            // 
            this.rbVB.AutoSize = true;
            this.rbVB.Location = new System.Drawing.Point(13, 27);
            this.rbVB.Name = "rbVB";
            this.rbVB.Size = new System.Drawing.Size(39, 17);
            this.rbVB.TabIndex = 1;
            this.rbVB.TabStop = true;
            this.rbVB.Text = "VB";
            this.rbVB.UseVisualStyleBackColor = true;
            // 
            // rbCS
            // 
            this.rbCS.AutoSize = true;
            this.rbCS.Checked = true;
            this.rbCS.Location = new System.Drawing.Point(13, 4);
            this.rbCS.Name = "rbCS";
            this.rbCS.Size = new System.Drawing.Size(39, 17);
            this.rbCS.TabIndex = 0;
            this.rbCS.TabStop = true;
            this.rbCS.Text = "C#";
            this.rbCS.UseVisualStyleBackColor = true;
            // 
            // txtOut
            // 
            this.txtOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOut.Location = new System.Drawing.Point(0, 0);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(488, 761);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Docstringer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox txtIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtVarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbVB;
        private System.Windows.Forms.RadioButton rbCS;
        private System.Windows.Forms.RichTextBox txtOut;
    }
}

