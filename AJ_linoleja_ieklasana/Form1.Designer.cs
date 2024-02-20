namespace AJ_linoleja_ieklasana
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
            this.l_cena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_platums = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.platums = new System.Windows.Forms.NumericUpDown();
            this.garums = new System.Windows.Forms.NumericUpDown();
            this.aprekinat = new System.Windows.Forms.Button();
            this.izvadit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.platums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garums)).BeginInit();
            this.SuspendLayout();
            // 
            // l_cena
            // 
            this.l_cena.Location = new System.Drawing.Point(178, 48);
            this.l_cena.Name = "l_cena";
            this.l_cena.Size = new System.Drawing.Size(72, 20);
            this.l_cena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linoleja cena EUR/m2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linoleja rulļa platums:";
            // 
            // l_platums
            // 
            this.l_platums.Location = new System.Drawing.Point(178, 93);
            this.l_platums.Name = "l_platums";
            this.l_platums.Size = new System.Drawing.Size(72, 20);
            this.l_platums.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telpas platums:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telpas garums:";
            // 
            // platums
            // 
            this.platums.Location = new System.Drawing.Point(178, 138);
            this.platums.Name = "platums";
            this.platums.Size = new System.Drawing.Size(72, 20);
            this.platums.TabIndex = 6;
            // 
            // garums
            // 
            this.garums.Location = new System.Drawing.Point(178, 178);
            this.garums.Name = "garums";
            this.garums.Size = new System.Drawing.Size(72, 20);
            this.garums.TabIndex = 7;
            // 
            // aprekinat
            // 
            this.aprekinat.Location = new System.Drawing.Point(38, 236);
            this.aprekinat.Name = "aprekinat";
            this.aprekinat.Size = new System.Drawing.Size(115, 23);
            this.aprekinat.TabIndex = 8;
            this.aprekinat.Text = "Aprēķināt izmaksas";
            this.aprekinat.UseVisualStyleBackColor = true;
            // 
            // izvadit
            // 
            this.izvadit.Location = new System.Drawing.Point(178, 236);
            this.izvadit.Name = "izvadit";
            this.izvadit.Size = new System.Drawing.Size(100, 20);
            this.izvadit.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izvadit);
            this.Controls.Add(this.aprekinat);
            this.Controls.Add(this.garums);
            this.Controls.Add(this.platums);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_platums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_cena);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.platums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox l_cena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox l_platums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown platums;
        private System.Windows.Forms.NumericUpDown garums;
        private System.Windows.Forms.Button aprekinat;
        private System.Windows.Forms.TextBox izvadit;
    }
}

