
namespace GUI___WindowsForms
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
            this.listBox_dolgozok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.textBox_Reszleg = new System.Windows.Forms.TextBox();
            this.textBox_Neme = new System.Windows.Forms.TextBox();
            this.numericUpDown_BelepesEve = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ber = new System.Windows.Forms.NumericUpDown();
            this.button_Rogzit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BelepesEve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ber)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_dolgozok
            // 
            this.listBox_dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_dolgozok.FormattingEnabled = true;
            this.listBox_dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_dolgozok.Name = "listBox_dolgozok";
            this.listBox_dolgozok.Size = new System.Drawing.Size(358, 496);
            this.listBox_dolgozok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(446, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(446, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Részleg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(446, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Neme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(446, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Belépés éve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(446, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bér:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(623, 59);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(174, 20);
            this.textBox_Nev.TabIndex = 6;
            // 
            // textBox_Reszleg
            // 
            this.textBox_Reszleg.Location = new System.Drawing.Point(623, 138);
            this.textBox_Reszleg.Name = "textBox_Reszleg";
            this.textBox_Reszleg.Size = new System.Drawing.Size(174, 20);
            this.textBox_Reszleg.TabIndex = 7;
            // 
            // textBox_Neme
            // 
            this.textBox_Neme.Location = new System.Drawing.Point(623, 96);
            this.textBox_Neme.Name = "textBox_Neme";
            this.textBox_Neme.Size = new System.Drawing.Size(174, 20);
            this.textBox_Neme.TabIndex = 8;
            // 
            // numericUpDown_BelepesEve
            // 
            this.numericUpDown_BelepesEve.Location = new System.Drawing.Point(623, 172);
            this.numericUpDown_BelepesEve.Name = "numericUpDown_BelepesEve";
            this.numericUpDown_BelepesEve.Size = new System.Drawing.Size(174, 20);
            this.numericUpDown_BelepesEve.TabIndex = 9;
            this.numericUpDown_BelepesEve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Ber
            // 
            this.numericUpDown_Ber.Location = new System.Drawing.Point(623, 214);
            this.numericUpDown_Ber.Name = "numericUpDown_Ber";
            this.numericUpDown_Ber.Size = new System.Drawing.Size(174, 20);
            this.numericUpDown_Ber.TabIndex = 10;
            this.numericUpDown_Ber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Ber.ThousandsSeparator = true;
            // 
            // button_Rogzit
            // 
            this.button_Rogzit.Location = new System.Drawing.Point(504, 302);
            this.button_Rogzit.Name = "button_Rogzit";
            this.button_Rogzit.Size = new System.Drawing.Size(293, 53);
            this.button_Rogzit.TabIndex = 11;
            this.button_Rogzit.Text = "Rögzítés";
            this.button_Rogzit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(880, 496);
            this.Controls.Add(this.button_Rogzit);
            this.Controls.Add(this.numericUpDown_Ber);
            this.Controls.Add(this.numericUpDown_BelepesEve);
            this.Controls.Add(this.textBox_Neme);
            this.Controls.Add(this.textBox_Reszleg);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_dolgozok);
            this.Name = "Form1";
            this.Text = "Dolgozók felvétele";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BelepesEve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_dolgozok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Reszleg;
        private System.Windows.Forms.TextBox textBox_Neme;
        private System.Windows.Forms.NumericUpDown numericUpDown_BelepesEve;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ber;
        private System.Windows.Forms.Button button_Rogzit;
    }
}

