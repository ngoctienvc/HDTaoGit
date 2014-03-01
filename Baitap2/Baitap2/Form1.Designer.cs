namespace Baitap2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGiaTri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMang = new System.Windows.Forms.ComboBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonGhifile = new System.Windows.Forms.Button();
            this.buttonDocfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gia tri";
            // 
            // textBoxGiaTri
            // 
            this.textBoxGiaTri.Location = new System.Drawing.Point(87, 22);
            this.textBoxGiaTri.Name = "textBoxGiaTri";
            this.textBoxGiaTri.Size = new System.Drawing.Size(89, 20);
            this.textBoxGiaTri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mang";
            // 
            // comboBoxMang
            // 
            this.comboBoxMang.FormattingEnabled = true;
            this.comboBoxMang.Location = new System.Drawing.Point(288, 22);
            this.comboBoxMang.Name = "comboBoxMang";
            this.comboBoxMang.Size = new System.Drawing.Size(131, 21);
            this.comboBoxMang.TabIndex = 3;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(39, 75);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(62, 24);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Them";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(107, 75);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(69, 25);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xoa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(183, 75);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(68, 25);
            this.buttonSua.TabIndex = 6;
            this.buttonSua.Text = "Sua";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonGhifile
            // 
            this.buttonGhifile.Location = new System.Drawing.Point(257, 74);
            this.buttonGhifile.Name = "buttonGhifile";
            this.buttonGhifile.Size = new System.Drawing.Size(69, 26);
            this.buttonGhifile.TabIndex = 7;
            this.buttonGhifile.Text = "Ghifile";
            this.buttonGhifile.UseVisualStyleBackColor = true;
            this.buttonGhifile.Click += new System.EventHandler(this.buttonGhifile_Click);
            // 
            // buttonDocfile
            // 
            this.buttonDocfile.Location = new System.Drawing.Point(332, 74);
            this.buttonDocfile.Name = "buttonDocfile";
            this.buttonDocfile.Size = new System.Drawing.Size(74, 25);
            this.buttonDocfile.TabIndex = 8;
            this.buttonDocfile.Text = "Doc file";
            this.buttonDocfile.UseVisualStyleBackColor = true;
            this.buttonDocfile.Click += new System.EventHandler(this.buttonDocfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 134);
            this.Controls.Add(this.buttonDocfile);
            this.Controls.Add(this.buttonGhifile);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.comboBoxMang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGiaTri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mang phan so";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGiaTri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMang;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonGhifile;
        private System.Windows.Forms.Button buttonDocfile;
    }
}

