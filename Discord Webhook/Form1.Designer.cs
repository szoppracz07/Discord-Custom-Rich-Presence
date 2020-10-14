using System;

namespace Discord_Webhook
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatTextBox3 = new FlatUI.FlatTextBox();
            this.flatTextBox4 = new FlatUI.FlatTextBox();
            this.flatTextBox5 = new FlatUI.FlatTextBox();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton4 = new FlatUI.FlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flatButton3);
            this.panel1.Controls.Add(this.flatButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 39);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discord Custom Rich Presence";
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(445, 4);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(39, 32);
            this.flatButton3.TabIndex = 4;
            this.flatButton3.Text = "_";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.UseCustomColor = false;
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(490, 3);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(39, 32);
            this.flatButton2.TabIndex = 3;
            this.flatButton2.Text = "X";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.UseCustomColor = false;
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Hint = "";
            this.flatTextBox1.Location = new System.Drawing.Point(12, 55);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(144, 29);
            this.flatTextBox1.TabIndex = 3;
            this.flatTextBox1.Text = "State";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Hint = "";
            this.flatTextBox2.Location = new System.Drawing.Point(12, 90);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = false;
            this.flatTextBox2.Size = new System.Drawing.Size(144, 29);
            this.flatTextBox2.TabIndex = 4;
            this.flatTextBox2.Text = "Details";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            // 
            // flatTextBox3
            // 
            this.flatTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox3.FocusOnHover = false;
            this.flatTextBox3.Hint = "";
            this.flatTextBox3.Location = new System.Drawing.Point(162, 55);
            this.flatTextBox3.MaxLength = 32767;
            this.flatTextBox3.Multiline = false;
            this.flatTextBox3.Name = "flatTextBox3";
            this.flatTextBox3.ReadOnly = false;
            this.flatTextBox3.Size = new System.Drawing.Size(217, 29);
            this.flatTextBox3.TabIndex = 5;
            this.flatTextBox3.Text = "App ID";
            this.flatTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox3.UseSystemPasswordChar = false;
            // 
            // flatTextBox4
            // 
            this.flatTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox4.FocusOnHover = false;
            this.flatTextBox4.Hint = "";
            this.flatTextBox4.Location = new System.Drawing.Point(385, 55);
            this.flatTextBox4.MaxLength = 32767;
            this.flatTextBox4.Multiline = false;
            this.flatTextBox4.Name = "flatTextBox4";
            this.flatTextBox4.ReadOnly = false;
            this.flatTextBox4.Size = new System.Drawing.Size(144, 29);
            this.flatTextBox4.TabIndex = 6;
            this.flatTextBox4.Text = "Large Image Key";
            this.flatTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox4.UseSystemPasswordChar = false;
            // 
            // flatTextBox5
            // 
            this.flatTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox5.FocusOnHover = false;
            this.flatTextBox5.Hint = "";
            this.flatTextBox5.Location = new System.Drawing.Point(385, 90);
            this.flatTextBox5.MaxLength = 32767;
            this.flatTextBox5.Multiline = false;
            this.flatTextBox5.Name = "flatTextBox5";
            this.flatTextBox5.ReadOnly = false;
            this.flatTextBox5.Size = new System.Drawing.Size(144, 29);
            this.flatTextBox5.TabIndex = 7;
            this.flatTextBox5.Text = "Small Image Key";
            this.flatTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox5.UseSystemPasswordChar = false;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(162, 90);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 8;
            this.flatButton1.Text = "Update";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.UseCustomColor = false;
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(274, 90);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(106, 32);
            this.flatButton4.TabIndex = 9;
            this.flatButton4.Text = "Initialize";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.UseCustomColor = false;
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(543, 144);
            this.Controls.Add(this.flatButton4);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.flatTextBox5);
            this.Controls.Add(this.flatTextBox4);
            this.Controls.Add(this.flatTextBox3);
            this.Controls.Add(this.flatTextBox2);
            this.Controls.Add(this.flatTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord Webhook";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton2;
        private System.Windows.Forms.Label label2;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatTextBox flatTextBox3;
        private FlatUI.FlatTextBox flatTextBox4;
        private FlatUI.FlatTextBox flatTextBox5;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton4;
    }
}

