namespace Fishing
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Disk = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Costt = new System.Windows.Forms.Label();
            this.Proz = new System.Windows.Forms.Label();
            this.Op = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Manu = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentLb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.overallLb1 = new System.Windows.Forms.Label();
            this.poisk = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.Poick = new System.Windows.Forms.TextBox();
            this.Dobav = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(827, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(410, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ООО «Рыбалка»";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 134);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Disk);
            this.panel5.Location = new System.Drawing.Point(753, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 1;
            // 
            // Disk
            // 
            this.Disk.AutoSize = true;
            this.Disk.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disk.Location = new System.Drawing.Point(83, 44);
            this.Disk.Name = "Disk";
            this.Disk.Size = new System.Drawing.Size(46, 18);
            this.Disk.TabIndex = 0;
            this.Disk.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Costt);
            this.panel4.Controls.Add(this.Proz);
            this.panel4.Controls.Add(this.Op);
            this.panel4.Controls.Add(this.Cost);
            this.panel4.Controls.Add(this.Manu);
            this.panel4.Controls.Add(this.Opis);
            this.panel4.Location = new System.Drawing.Point(170, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 100);
            this.panel4.TabIndex = 0;
            // 
            // Costt
            // 
            this.Costt.AutoSize = true;
            this.Costt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Costt.Location = new System.Drawing.Point(193, 69);
            this.Costt.Name = "Costt";
            this.Costt.Size = new System.Drawing.Size(41, 17);
            this.Costt.TabIndex = 5;
            this.Costt.Text = "label4";
            // 
            // Proz
            // 
            this.Proz.AutoSize = true;
            this.Proz.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Proz.Location = new System.Drawing.Point(193, 44);
            this.Proz.Name = "Proz";
            this.Proz.Size = new System.Drawing.Size(41, 17);
            this.Proz.TabIndex = 4;
            this.Proz.Text = "label3";
            // 
            // Op
            // 
            this.Op.AutoSize = true;
            this.Op.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Op.Location = new System.Drawing.Point(190, 16);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(41, 17);
            this.Op.TabIndex = 3;
            this.Op.Text = "label2";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost.Location = new System.Drawing.Point(24, 69);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(36, 17);
            this.Cost.TabIndex = 2;
            this.Cost.Text = "Цена";
            // 
            // Manu
            // 
            this.Manu.AutoSize = true;
            this.Manu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manu.Location = new System.Drawing.Point(24, 44);
            this.Manu.Name = "Manu";
            this.Manu.Size = new System.Drawing.Size(99, 17);
            this.Manu.TabIndex = 1;
            this.Manu.Text = "Производитель";
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Opis.Location = new System.Drawing.Point(24, 16);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(108, 17);
            this.Opis.TabIndex = 0;
            this.Opis.Text = "Описание товара";
            // 
            // productsGrid
            // 
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsGrid.Location = new System.Drawing.Point(0, 100);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.Size = new System.Drawing.Size(984, 414);
            this.productsGrid.TabIndex = 3;
            this.productsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellContentClick);
            this.productsGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.productsGrid_RowPrePaint);
            this.productsGrid.SelectionChanged += new System.EventHandler(this.productsGrid_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.currentLb1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.overallLb1);
            this.panel3.Controls.Add(this.poisk);
            this.panel3.Controls.Add(this.Filter);
            this.panel3.Controls.Add(this.Poick);
            this.panel3.Controls.Add(this.Dobav);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 54);
            this.panel3.TabIndex = 4;
            // 
            // currentLb1
            // 
            this.currentLb1.AutoSize = true;
            this.currentLb1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentLb1.Location = new System.Drawing.Point(719, 22);
            this.currentLb1.Name = "currentLb1";
            this.currentLb1.Size = new System.Drawing.Size(11, 17);
            this.currentLb1.TabIndex = 6;
            this.currentLb1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(699, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // overallLb1
            // 
            this.overallLb1.AutoSize = true;
            this.overallLb1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overallLb1.Location = new System.Drawing.Point(674, 17);
            this.overallLb1.Name = "overallLb1";
            this.overallLb1.Size = new System.Drawing.Size(11, 17);
            this.overallLb1.TabIndex = 4;
            this.overallLb1.Text = ".";
            // 
            // poisk
            // 
            this.poisk.AutoSize = true;
            this.poisk.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poisk.Location = new System.Drawing.Point(74, 18);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(46, 17);
            this.poisk.TabIndex = 3;
            this.poisk.Text = "Поиск";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.FormattingEnabled = true;
            this.Filter.Items.AddRange(new object[] {
            "<3",
            ">3<4",
            ">5"});
            this.Filter.Location = new System.Drawing.Point(500, 14);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(121, 25);
            this.Filter.TabIndex = 2;
            this.Filter.SelectedIndexChanged += new System.EventHandler(this.Filter_SelectedIndexChanged);
            // 
            // Poick
            // 
            this.Poick.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Poick.Location = new System.Drawing.Point(136, 15);
            this.Poick.Name = "Poick";
            this.Poick.Size = new System.Drawing.Size(182, 24);
            this.Poick.TabIndex = 1;
            this.Poick.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dobav
            // 
            this.Dobav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Dobav.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dobav.Location = new System.Drawing.Point(850, 17);
            this.Dobav.Name = "Dobav";
            this.Dobav.Size = new System.Drawing.Size(93, 26);
            this.Dobav.TabIndex = 0;
            this.Dobav.Text = "Добавить";
            this.Dobav.UseVisualStyleBackColor = false;
            this.Dobav.Click += new System.EventHandler(this.Dobav_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фильтр";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Disk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Costt;
        private System.Windows.Forms.Label Proz;
        private System.Windows.Forms.Label Op;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Manu;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label poisk;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.TextBox Poick;
        private System.Windows.Forms.Button Dobav;
        private System.Windows.Forms.Label overallLb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentLb1;
        private System.Windows.Forms.Label label3;
    }
}