namespace XMLSerializer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PasangerCountBox = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.RejestrationNumberBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.ReadFromFillButton = new System.Windows.Forms.Button();
            this.SaveToFillButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistratioinNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassangerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PasangerCountBox);
            this.groupBox1.Controls.Add(this.ColorBox);
            this.groupBox1.Controls.Add(this.YearBox);
            this.groupBox1.Controls.Add(this.BrandBox);
            this.groupBox1.Controls.Add(this.RejestrationNumberBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie samochodu:";
            // 
            // PasangerCountBox
            // 
            this.PasangerCountBox.Location = new System.Drawing.Point(189, 201);
            this.PasangerCountBox.Name = "PasangerCountBox";
            this.PasangerCountBox.Size = new System.Drawing.Size(280, 22);
            this.PasangerCountBox.TabIndex = 10;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(189, 156);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(280, 22);
            this.ColorBox.TabIndex = 9;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(189, 114);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(280, 22);
            this.YearBox.TabIndex = 8;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(189, 70);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(280, 22);
            this.BrandBox.TabIndex = 7;
            // 
            // RejestrationNumberBox
            // 
            this.RejestrationNumberBox.Location = new System.Drawing.Point(189, 32);
            this.RejestrationNumberBox.Name = "RejestrationNumberBox";
            this.RejestrationNumberBox.Size = new System.Drawing.Size(280, 22);
            this.RejestrationNumberBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(238, 326);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(153, 42);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Liczba pasażerów:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kolor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok Produkcji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr rejestracyjny:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeserializeButton);
            this.groupBox2.Controls.Add(this.SerializeButton);
            this.groupBox2.Controls.Add(this.ReadFromFillButton);
            this.groupBox2.Controls.Add(this.SaveToFillButton);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Location = new System.Drawing.Point(666, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zapis i odczyt:";
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.Location = new System.Drawing.Point(6, 265);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(584, 42);
            this.DeserializeButton.TabIndex = 10;
            this.DeserializeButton.Text = "Deserializuj";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Location = new System.Drawing.Point(6, 206);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(584, 42);
            this.SerializeButton.TabIndex = 9;
            this.SerializeButton.Text = "Serializuj";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // ReadFromFillButton
            // 
            this.ReadFromFillButton.Location = new System.Drawing.Point(6, 148);
            this.ReadFromFillButton.Name = "ReadFromFillButton";
            this.ReadFromFillButton.Size = new System.Drawing.Size(584, 42);
            this.ReadFromFillButton.TabIndex = 8;
            this.ReadFromFillButton.Text = "Odczytaj z pliku";
            this.ReadFromFillButton.UseVisualStyleBackColor = true;
            this.ReadFromFillButton.Click += new System.EventHandler(this.ReadFromFillButton_Click);
            // 
            // SaveToFillButton
            // 
            this.SaveToFillButton.Location = new System.Drawing.Point(6, 94);
            this.SaveToFillButton.Name = "SaveToFillButton";
            this.SaveToFillButton.Size = new System.Drawing.Size(584, 42);
            this.SaveToFillButton.TabIndex = 7;
            this.SaveToFillButton.Text = "Zapisz do pliku";
            this.SaveToFillButton.UseVisualStyleBackColor = true;
            this.SaveToFillButton.Click += new System.EventHandler(this.SaveToFillButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(6, 37);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(584, 42);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Wyczyść listę";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistratioinNumber,
            this.Brand,
            this.ProductionYear,
            this.Color,
            this.PassangerCount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 459);
            this.dataGridView1.TabIndex = 2;
            // 
            // RegistratioinNumber
            // 
            this.RegistratioinNumber.HeaderText = "Numer rejestracyjny";
            this.RegistratioinNumber.MinimumWidth = 6;
            this.RegistratioinNumber.Name = "RegistratioinNumber";
            this.RegistratioinNumber.Width = 125;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Marka";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.Width = 125;
            // 
            // ProductionYear
            // 
            this.ProductionYear.HeaderText = "Rok produkcji";
            this.ProductionYear.MinimumWidth = 6;
            this.ProductionYear.Name = "ProductionYear";
            this.ProductionYear.Width = 125;
            // 
            // Color
            // 
            this.Color.HeaderText = "Kolor";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 125;
            // 
            // PassangerCount
            // 
            this.PassangerCount.HeaderText = "Ilość pasażerów";
            this.PassangerCount.MinimumWidth = 6;
            this.PassangerCount.Name = "PassangerCount";
            this.PassangerCount.Width = 125;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 900);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PasangerCountBox;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox RejestrationNumberBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button ReadFromFillButton;
        private System.Windows.Forms.Button SaveToFillButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistratioinNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassangerCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

