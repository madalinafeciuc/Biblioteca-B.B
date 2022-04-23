
namespace Gestiune_librarie
{
    partial class Imprumut
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ales1_rdbtn = new System.Windows.Forms.RadioButton();
            this.ales2_rdbtn = new System.Windows.Forms.RadioButton();
            this.ales3_rdbtn = new System.Windows.Forms.RadioButton();
            this.imprumut_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.poza3 = new System.Windows.Forms.PictureBox();
            this.poza2 = new System.Windows.Forms.PictureBox();
            this.poza1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.poza3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fictiune",
            "Carti pentru copii",
            "Psihologie",
            "Business",
            "Istorie",
            "Biografii"});
            this.comboBox1.Location = new System.Drawing.Point(242, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alegeti categoria cartii:";
            // 
            // ales1_rdbtn
            // 
            this.ales1_rdbtn.AutoSize = true;
            this.ales1_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ales1_rdbtn.Location = new System.Drawing.Point(112, 567);
            this.ales1_rdbtn.Name = "ales1_rdbtn";
            this.ales1_rdbtn.Size = new System.Drawing.Size(78, 28);
            this.ales1_rdbtn.TabIndex = 5;
            this.ales1_rdbtn.TabStop = true;
            this.ales1_rdbtn.Text = "Alege";
            this.ales1_rdbtn.UseVisualStyleBackColor = true;
            // 
            // ales2_rdbtn
            // 
            this.ales2_rdbtn.AutoSize = true;
            this.ales2_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ales2_rdbtn.Location = new System.Drawing.Point(365, 567);
            this.ales2_rdbtn.Name = "ales2_rdbtn";
            this.ales2_rdbtn.Size = new System.Drawing.Size(78, 28);
            this.ales2_rdbtn.TabIndex = 5;
            this.ales2_rdbtn.TabStop = true;
            this.ales2_rdbtn.Text = "Alege";
            this.ales2_rdbtn.UseVisualStyleBackColor = true;
            // 
            // ales3_rdbtn
            // 
            this.ales3_rdbtn.AutoSize = true;
            this.ales3_rdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ales3_rdbtn.Location = new System.Drawing.Point(590, 567);
            this.ales3_rdbtn.Name = "ales3_rdbtn";
            this.ales3_rdbtn.Size = new System.Drawing.Size(78, 28);
            this.ales3_rdbtn.TabIndex = 5;
            this.ales3_rdbtn.TabStop = true;
            this.ales3_rdbtn.Text = "Alege";
            this.ales3_rdbtn.UseVisualStyleBackColor = true;
            // 
            // imprumut_btn
            // 
            this.imprumut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprumut_btn.Location = new System.Drawing.Point(592, 629);
            this.imprumut_btn.Name = "imprumut_btn";
            this.imprumut_btn.Size = new System.Drawing.Size(154, 40);
            this.imprumut_btn.TabIndex = 6;
            this.imprumut_btn.Text = "Imprumuta";
            this.imprumut_btn.UseVisualStyleBackColor = true;
            this.imprumut_btn.Click += new System.EventHandler(this.imprumut_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 629);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 40);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Inapoi";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // poza3
            // 
            this.poza3.Image = global::Gestiune_librarie.Properties.Resources.question;
            this.poza3.Location = new System.Drawing.Point(535, 302);
            this.poza3.Name = "poza3";
            this.poza3.Size = new System.Drawing.Size(222, 234);
            this.poza3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poza3.TabIndex = 3;
            this.poza3.TabStop = false;
            // 
            // poza2
            // 
            this.poza2.Image = global::Gestiune_librarie.Properties.Resources.question;
            this.poza2.Location = new System.Drawing.Point(289, 302);
            this.poza2.Name = "poza2";
            this.poza2.Size = new System.Drawing.Size(214, 234);
            this.poza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poza2.TabIndex = 3;
            this.poza2.TabStop = false;
            // 
            // poza1
            // 
            this.poza1.Image = global::Gestiune_librarie.Properties.Resources.question;
            this.poza1.Location = new System.Drawing.Point(28, 302);
            this.poza1.Name = "poza1";
            this.poza1.Size = new System.Drawing.Size(219, 234);
            this.poza1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poza1.TabIndex = 3;
            this.poza1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestiune_librarie.Properties.Resources.logo_bibi2;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Imprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(793, 691);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.imprumut_btn);
            this.Controls.Add(this.ales3_rdbtn);
            this.Controls.Add(this.ales2_rdbtn);
            this.Controls.Add(this.ales1_rdbtn);
            this.Controls.Add(this.poza3);
            this.Controls.Add(this.poza2);
            this.Controls.Add(this.poza1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Imprumut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Magazin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poza3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox poza1;
        private System.Windows.Forms.PictureBox poza2;
        private System.Windows.Forms.PictureBox poza3;
        private System.Windows.Forms.RadioButton ales1_rdbtn;
        private System.Windows.Forms.RadioButton ales2_rdbtn;
        private System.Windows.Forms.RadioButton ales3_rdbtn;
        private System.Windows.Forms.Button imprumut_btn;
        private System.Windows.Forms.Button back_btn;
    }
}