namespace BaiTapThucHanhTuan2
{
    partial class Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Form));
            this.bt_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.datetime_birthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_GiaoVien = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.bt_all = new System.Windows.Forms.Button();
            this.bt_find = new System.Windows.Forms.Button();
            this.link_exit = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaoVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Add.Location = new System.Drawing.Point(24, 306);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(121, 41);
            this.bt_Add.TabIndex = 4;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "BirthDay:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(24, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(332, 27);
            this.txt_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(26, 139);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(332, 27);
            this.txt_address.TabIndex = 6;
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Crimson;
            this.bt_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_delete.Location = new System.Drawing.Point(165, 306);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(111, 41);
            this.bt_delete.TabIndex = 15;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.DarkMagenta;
            this.bt_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_edit.Location = new System.Drawing.Point(299, 306);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(104, 41);
            this.bt_edit.TabIndex = 16;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(24, 193);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(332, 27);
            this.txt_id.TabIndex = 7;
            // 
            // datetime_birthday
            // 
            this.datetime_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_birthday.Location = new System.Drawing.Point(24, 247);
            this.datetime_birthday.Name = "datetime_birthday";
            this.datetime_birthday.Size = new System.Drawing.Size(332, 27);
            this.datetime_birthday.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(13, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data:";
            // 
            // dataGridView_GiaoVien
            // 
            this.dataGridView_GiaoVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GiaoVien.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_GiaoVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView_GiaoVien.Location = new System.Drawing.Point(12, 117);
            this.dataGridView_GiaoVien.Name = "dataGridView_GiaoVien";
            this.dataGridView_GiaoVien.RowHeadersWidth = 51;
            this.dataGridView_GiaoVien.RowTemplate.Height = 29;
            this.dataGridView_GiaoVien.Size = new System.Drawing.Size(484, 393);
            this.dataGridView_GiaoVien.TabIndex = 5;
            this.dataGridView_GiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SinhVien_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(40, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 83);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Stencil", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(293, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao Vien";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_find);
            this.panel3.Controls.Add(this.bt_all);
            this.panel3.Controls.Add(this.bt_find);
            this.panel3.Controls.Add(this.link_exit);
            this.panel3.Controls.Add(this.bt_Add);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_address);
            this.panel3.Controls.Add(this.bt_delete);
            this.panel3.Controls.Add(this.bt_edit);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.datetime_birthday);
            this.panel3.Location = new System.Drawing.Point(502, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 393);
            this.panel3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(198, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Find by ID:";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(198, 31);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(176, 27);
            this.txt_find.TabIndex = 20;
            // 
            // bt_all
            // 
            this.bt_all.BackColor = System.Drawing.Color.SlateGray;
            this.bt_all.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_all.Location = new System.Drawing.Point(3, 3);
            this.bt_all.Name = "bt_all";
            this.bt_all.Size = new System.Drawing.Size(42, 33);
            this.bt_all.TabIndex = 19;
            this.bt_all.Text = "All";
            this.bt_all.UseVisualStyleBackColor = false;
            this.bt_all.Click += new System.EventHandler(this.bt_all_Click);
            // 
            // bt_find
            // 
            this.bt_find.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_find.BackgroundImage")));
            this.bt_find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_find.Location = new System.Drawing.Point(380, 18);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(56, 52);
            this.bt_find.TabIndex = 1;
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // link_exit
            // 
            this.link_exit.AutoSize = true;
            this.link_exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_exit.LinkColor = System.Drawing.Color.Red;
            this.link_exit.Location = new System.Drawing.Point(390, 355);
            this.link_exit.Name = "link_exit";
            this.link_exit.Size = new System.Drawing.Size(39, 25);
            this.link_exit.TabIndex = 18;
            this.link_exit.TabStop = true;
            this.link_exit.Text = "Exit";
            this.link_exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_exit_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView_GiaoVien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 513);
            this.panel1.TabIndex = 2;
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Teacher_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GiaoVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_Add;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txt_name;
        private Label label3;
        private TextBox txt_address;
        private Button bt_delete;
        private Button bt_edit;
        private TextBox txt_id;
        private DateTimePicker datetime_birthday;
        private Label label6;
        private DataGridView dataGridView_GiaoVien;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel1;
        private LinkLabel link_exit;
        private Button bt_find;
        private Button bt_all;
        private Label label7;
        private TextBox txt_find;
    }
}