namespace Tugas3._2
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
            label3 = new Label();
            txtNama = new TextBox();
            lstPekerjaan = new ListBox();
            cmbPendidikan = new ComboBox();
            txtPesan1 = new TextBox();
            txtPesan2 = new TextBox();
            txtPesan3 = new TextBox();
            btnOk = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 70);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 0;
            label3.Text = "Pekerjaan";
            label3.Click += label3_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(75, 12);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(321, 23);
            txtNama.TabIndex = 1;
            // 
            // lstPekerjaan
            // 
            lstPekerjaan.FormattingEnabled = true;
            lstPekerjaan.ItemHeight = 15;
            lstPekerjaan.Items.AddRange(new object[] { "Pedagang", "PNS", "Dosen", "Swasta", "ABRI", "Mahasiswa" });
            lstPekerjaan.Location = new Point(75, 70);
            lstPekerjaan.Name = "lstPekerjaan";
            lstPekerjaan.Size = new Size(321, 169);
            lstPekerjaan.TabIndex = 3;
            lstPekerjaan.SelectedIndexChanged += lstPekerjaan_SelectedIndexChanged;
            // 
            // cmbPendidikan
            // 
            cmbPendidikan.FormattingEnabled = true;
            cmbPendidikan.Items.AddRange(new object[] { "SD", "SMP", "SMA", "Diploma", "Sarjana", "Pascasarjana" });
            cmbPendidikan.Location = new Point(75, 41);
            cmbPendidikan.Name = "cmbPendidikan";
            cmbPendidikan.Size = new Size(321, 23);
            cmbPendidikan.TabIndex = 4;
            // 
            // txtPesan1
            // 
            txtPesan1.Enabled = false;
            txtPesan1.Location = new Point(12, 252);
            txtPesan1.Name = "txtPesan1";
            txtPesan1.Size = new Size(384, 23);
            txtPesan1.TabIndex = 5;
            // 
            // txtPesan2
            // 
            txtPesan2.Enabled = false;
            txtPesan2.Location = new Point(12, 281);
            txtPesan2.Name = "txtPesan2";
            txtPesan2.Size = new Size(384, 23);
            txtPesan2.TabIndex = 5;
            // 
            // txtPesan3
            // 
            txtPesan3.Enabled = false;
            txtPesan3.Location = new Point(12, 310);
            txtPesan3.Name = "txtPesan3";
            txtPesan3.Size = new Size(384, 23);
            txtPesan3.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 339);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(384, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 41);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "Pendidikan";
            label1.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 13);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 0;
            label2.Text = "Nama";
            label2.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 366);
            Controls.Add(btnOk);
            Controls.Add(txtPesan3);
            Controls.Add(txtPesan2);
            Controls.Add(txtPesan1);
            Controls.Add(cmbPendidikan);
            Controls.Add(lstPekerjaan);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Tugas 3.2 Muhammad Yudha Maputra";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtNama;
        private ListBox lstPekerjaan;
        private ComboBox cmbPendidikan;
        private TextBox txtPesan1;
        private TextBox txtPesan2;
        private TextBox txtPesan3;
        private Button btnOk;
        private Label label1;
        private Label label2;
    }
}