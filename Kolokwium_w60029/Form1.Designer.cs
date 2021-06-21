
namespace Kolokwium_w60029
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lCel = new System.Windows.Forms.Label();
            this.lFah = new System.Windows.Forms.Label();
            this.lKel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bResult = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź wartość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skala Celsjusza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Skala Fahrenheita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(295, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skala Kelvina";
            // 
            // lCel
            // 
            this.lCel.AutoSize = true;
            this.lCel.Location = new System.Drawing.Point(21, 218);
            this.lCel.Name = "lCel";
            this.lCel.Size = new System.Drawing.Size(32, 15);
            this.lCel.TabIndex = 4;
            this.lCel.Text = "Error";
            // 
            // lFah
            // 
            this.lFah.AutoSize = true;
            this.lFah.Location = new System.Drawing.Point(144, 218);
            this.lFah.Name = "lFah";
            this.lFah.Size = new System.Drawing.Size(32, 15);
            this.lFah.TabIndex = 5;
            this.lFah.Text = "Error";
            // 
            // lKel
            // 
            this.lKel.AutoSize = true;
            this.lKel.Location = new System.Drawing.Point(295, 218);
            this.lKel.Name = "lKel";
            this.lKel.Size = new System.Drawing.Size(32, 15);
            this.lKel.TabIndex = 6;
            this.lKel.Text = "Error";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 23);
            this.textBox1.TabIndex = 7;
            // 
            // bResult
            // 
            this.bResult.Location = new System.Drawing.Point(173, 112);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(75, 23);
            this.bResult.TabIndex = 8;
            this.bResult.Text = "Oblicz";
            this.bResult.UseVisualStyleBackColor = true;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Skala Celsjusza",
            "Skala Fahrenheita",
            "Skala Kelvina"});
            this.comboBox1.Location = new System.Drawing.Point(295, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Wybierz skale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 260);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lKel);
            this.Controls.Add(this.lFah);
            this.Controls.Add(this.lCel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature-Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lCel;
        private System.Windows.Forms.Label lFah;
        private System.Windows.Forms.Label lKel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

