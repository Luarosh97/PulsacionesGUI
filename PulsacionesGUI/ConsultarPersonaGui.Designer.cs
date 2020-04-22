namespace PulsacionesGUI
{
    partial class ConsultarPersonaGui
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
            this.TipoConsultaCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Totalinscritostxt = new System.Windows.Forms.TextBox();
            this.TotalMujerestxt = new System.Windows.Forms.TextBox();
            this.TotalHombrestxt = new System.Windows.Forms.TextBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoConsultaCmb
            // 
            this.TipoConsultaCmb.FormattingEnabled = true;
            this.TipoConsultaCmb.Items.AddRange(new object[] {
            "Todos",
            "Masculino",
            "Femenino"});
            this.TipoConsultaCmb.Location = new System.Drawing.Point(107, 34);
            this.TipoConsultaCmb.Name = "TipoConsultaCmb";
            this.TipoConsultaCmb.Size = new System.Drawing.Size(125, 21);
            this.TipoConsultaCmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Inscritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Mujeres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Hombres";
            // 
            // Totalinscritostxt
            // 
            this.Totalinscritostxt.Location = new System.Drawing.Point(107, 332);
            this.Totalinscritostxt.Name = "Totalinscritostxt";
            this.Totalinscritostxt.Size = new System.Drawing.Size(100, 20);
            this.Totalinscritostxt.TabIndex = 6;
            // 
            // TotalMujerestxt
            // 
            this.TotalMujerestxt.Location = new System.Drawing.Point(273, 332);
            this.TotalMujerestxt.Name = "TotalMujerestxt";
            this.TotalMujerestxt.Size = new System.Drawing.Size(100, 20);
            this.TotalMujerestxt.TabIndex = 7;
            // 
            // TotalHombrestxt
            // 
            this.TotalHombrestxt.Location = new System.Drawing.Point(443, 332);
            this.TotalHombrestxt.Name = "TotalHombrestxt";
            this.TotalHombrestxt.Size = new System.Drawing.Size(100, 20);
            this.TotalHombrestxt.TabIndex = 8;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(404, 22);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(94, 43);
            this.BtnConsulta.TabIndex = 10;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 223);
            this.dataGridView1.TabIndex = 11;
            // 
            // ConsultarPersonaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 378);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.TotalHombrestxt);
            this.Controls.Add(this.TotalMujerestxt);
            this.Controls.Add(this.Totalinscritostxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoConsultaCmb);
            this.Name = "ConsultarPersonaGui";
            this.Text = "ConsultarPersonaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TipoConsultaCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Totalinscritostxt;
        private System.Windows.Forms.TextBox TotalMujerestxt;
        private System.Windows.Forms.TextBox TotalHombrestxt;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}