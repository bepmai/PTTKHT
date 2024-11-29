namespace lop
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.text_idclass = new System.Windows.Forms.TextBox();
            this.text_numberLea = new System.Windows.Forms.TextBox();
            this.text_nameteacher = new System.Windows.Forms.TextBox();
            this.text_namesub = new System.Windows.Forms.TextBox();
            this.text_nameclass = new System.Windows.Forms.TextBox();
            this.date_create = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_iduser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lop.Properties.Resources.Screenshot_17;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SỐ NGƯỜI HỌC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NGÀY TẠO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "TÊN MÔN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "TÊN GIÁO VIÊN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "TÊN LỚP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 178);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID LỚP";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TÊN LỚP";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SỐ TIẾT";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TÊN GIÁO VIÊN";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TÊN MÔN";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NGÀY TẠO";
            this.Column6.Name = "Column6";
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Xoa.Location = new System.Drawing.Point(601, 247);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(115, 37);
            this.button_Xoa.TabIndex = 8;
            this.button_Xoa.Text = "XÓA";
            this.button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Them.Location = new System.Drawing.Point(62, 251);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(115, 33);
            this.button_Them.TabIndex = 9;
            this.button_Them.Text = "THÊM";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_Sua.Location = new System.Drawing.Point(350, 251);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(115, 33);
            this.button_Sua.TabIndex = 10;
            this.button_Sua.Text = "SỬA";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // text_idclass
            // 
            this.text_idclass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_idclass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.text_idclass.Location = new System.Drawing.Point(169, 56);
            this.text_idclass.Name = "text_idclass";
            this.text_idclass.Size = new System.Drawing.Size(208, 25);
            this.text_idclass.TabIndex = 1;
            // 
            // text_numberLea
            // 
            this.text_numberLea.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_numberLea.Location = new System.Drawing.Point(169, 159);
            this.text_numberLea.Name = "text_numberLea";
            this.text_numberLea.Size = new System.Drawing.Size(208, 25);
            this.text_numberLea.TabIndex = 12;
            // 
            // text_nameteacher
            // 
            this.text_nameteacher.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nameteacher.Location = new System.Drawing.Point(508, 53);
            this.text_nameteacher.Name = "text_nameteacher";
            this.text_nameteacher.Size = new System.Drawing.Size(208, 25);
            this.text_nameteacher.TabIndex = 14;
            // 
            // text_namesub
            // 
            this.text_namesub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_namesub.Location = new System.Drawing.Point(508, 107);
            this.text_namesub.Name = "text_namesub";
            this.text_namesub.Size = new System.Drawing.Size(208, 25);
            this.text_namesub.TabIndex = 15;
            // 
            // text_nameclass
            // 
            this.text_nameclass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nameclass.Location = new System.Drawing.Point(169, 104);
            this.text_nameclass.Name = "text_nameclass";
            this.text_nameclass.Size = new System.Drawing.Size(208, 25);
            this.text_nameclass.TabIndex = 2;
            // 
            // date_create
            // 
            this.date_create.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_create.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_create.Location = new System.Drawing.Point(508, 162);
            this.date_create.Name = "date_create";
            this.date_create.Size = new System.Drawing.Size(208, 25);
            this.date_create.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(521, 39);
            this.label7.TabIndex = 18;
            this.label7.Text = "THÔNG TIN LỚP HỌC";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(62, 290);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 216);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LỚP HỌC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NGƯỜI HỌC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            this.dataGridView2.Location = new System.Drawing.Point(6, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(632, 171);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID NGƯỜI HỌC";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TÊN NGƯỜI HỌC";
            this.Column8.Name = "Column8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(59, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID NGƯỜI HỌC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(392, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "TÊN NGƯỜI HỌC";
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_username.Location = new System.Drawing.Point(509, 213);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(208, 25);
            this.text_username.TabIndex = 22;
            // 
            // text_iduser
            // 
            this.text_iduser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_iduser.Location = new System.Drawing.Point(169, 208);
            this.text_iduser.Name = "text_iduser";
            this.text_iduser.Size = new System.Drawing.Size(208, 25);
            this.text_iduser.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 518);
            this.Controls.Add(this.text_iduser);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_create);
            this.Controls.Add(this.text_nameclass);
            this.Controls.Add(this.text_namesub);
            this.Controls.Add(this.text_nameteacher);
            this.Controls.Add(this.text_numberLea);
            this.Controls.Add(this.text_idclass);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "THÔNG TIN LỚP HỌC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.TextBox text_idclass;
        private System.Windows.Forms.TextBox text_numberLea;
        private System.Windows.Forms.TextBox text_nameteacher;
        private System.Windows.Forms.TextBox text_namesub;
        private System.Windows.Forms.TextBox text_nameclass;
        private System.Windows.Forms.DateTimePicker date_create;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_iduser;
    }
}

