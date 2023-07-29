namespace Project_practice
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtlinks = new System.Windows.Forms.Label();
            this.btnDeleteM = new System.Windows.Forms.Button();
            this.btnUpdateM = new System.Windows.Forms.Button();
            this.btnAddM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnM = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnRemoveMod = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboModules = new System.Windows.Forms.ComboBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.dtpDBO = new System.Windows.Forms.DateTimePicker();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisplayStudents = new System.Windows.Forms.Button();
            this.btnDisplayModules = new System.Windows.Forms.Button();
            this.btnStudMod = new System.Windows.Forms.Button();
            this.btnSearchS = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.txtSearchModule = new System.Windows.Forms.TextBox();
            this.btnSearchM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(42, 65);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(665, 470);
            this.dgvData.TabIndex = 0;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.txtlinks);
            this.groupBox1.Controls.Add(this.btnDeleteM);
            this.groupBox1.Controls.Add(this.btnUpdateM);
            this.groupBox1.Controls.Add(this.btnAddM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtModName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtModCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(783, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module";
            // 
            // txtDescription
            // 
            this.txtDescription.AllowDrop = true;
            this.txtDescription.Location = new System.Drawing.Point(85, 53);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 59);
            this.txtDescription.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.AllowDrop = true;
            this.textBox7.Location = new System.Drawing.Point(287, 53);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(142, 59);
            this.textBox7.TabIndex = 10;
            // 
            // txtlinks
            // 
            this.txtlinks.AllowDrop = true;
            this.txtlinks.AutoSize = true;
            this.txtlinks.Location = new System.Drawing.Point(238, 53);
            this.txtlinks.Name = "txtlinks";
            this.txtlinks.Size = new System.Drawing.Size(35, 13);
            this.txtlinks.TabIndex = 9;
            this.txtlinks.Text = "Links:";
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.Location = new System.Drawing.Point(238, 131);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.Size = new System.Drawing.Size(110, 34);
            this.btnDeleteM.TabIndex = 8;
            this.btnDeleteM.Text = "Delete";
            this.btnDeleteM.UseVisualStyleBackColor = true;
            this.btnDeleteM.Click += new System.EventHandler(this.btnDeleteM_Click);
            // 
            // btnUpdateM
            // 
            this.btnUpdateM.Location = new System.Drawing.Point(122, 131);
            this.btnUpdateM.Name = "btnUpdateM";
            this.btnUpdateM.Size = new System.Drawing.Size(110, 34);
            this.btnUpdateM.TabIndex = 7;
            this.btnUpdateM.Text = "Update";
            this.btnUpdateM.UseVisualStyleBackColor = true;
            this.btnUpdateM.Click += new System.EventHandler(this.btnUpdateM_Click);
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(6, 131);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(110, 34);
            this.btnAddM.TabIndex = 6;
            this.btnAddM.Text = "Add";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description:";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(287, 27);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(142, 20);
            this.txtModName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(85, 27);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(133, 20);
            this.txtModCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module Code:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnM);
            this.groupBox2.Controls.Add(this.btnI);
            this.groupBox2.Controls.Add(this.btnRemoveMod);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboModules);
            this.groupBox2.Controls.Add(this.btnMod);
            this.groupBox2.Controls.Add(this.btnChangeImage);
            this.groupBox2.Controls.Add(this.btnImage);
            this.groupBox2.Controls.Add(this.btnDeleteS);
            this.groupBox2.Controls.Add(this.btnUpdateS);
            this.groupBox2.Controls.Add(this.btnAddS);
            this.groupBox2.Controls.Add(this.dtpDBO);
            this.groupBox2.Controls.Add(this.rbtnFemale);
            this.groupBox2.Controls.Add(this.rbtnMale);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtStdNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(783, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(238, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 134);
            this.listBox1.TabIndex = 32;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(344, 149);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 13);
            this.btnM.TabIndex = 30;
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(238, 149);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 13);
            this.btnI.TabIndex = 29;
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnRemoveMod
            // 
            this.btnRemoveMod.Location = new System.Drawing.Point(287, 220);
            this.btnRemoveMod.Name = "btnRemoveMod";
            this.btnRemoveMod.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveMod.TabIndex = 28;
            this.btnRemoveMod.Text = "Remove Module";
            this.btnRemoveMod.UseVisualStyleBackColor = true;
            this.btnRemoveMod.Click += new System.EventHandler(this.btnRemoveMod_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Modules:";
            // 
            // comboModules
            // 
            this.comboModules.FormattingEnabled = true;
            this.comboModules.Location = new System.Drawing.Point(73, 252);
            this.comboModules.Name = "comboModules";
            this.comboModules.Size = new System.Drawing.Size(200, 21);
            this.comboModules.TabIndex = 25;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(290, 252);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(139, 23);
            this.btnMod.TabIndex = 24;
            this.btnMod.Text = "Add Module";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(290, 127);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(75, 23);
            this.btnChangeImage.TabIndex = 10;
            this.btnChangeImage.Text = "Change";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(248, 42);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(139, 89);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Add Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(255, 281);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(110, 34);
            this.btnDeleteS.TabIndex = 21;
            this.btnDeleteS.Text = "Delete";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(139, 280);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(110, 34);
            this.btnUpdateS.TabIndex = 20;
            this.btnUpdateS.Text = "Update";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnAddS
            // 
            this.btnAddS.Location = new System.Drawing.Point(19, 280);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(110, 34);
            this.btnAddS.TabIndex = 19;
            this.btnAddS.Text = "Add";
            this.btnAddS.UseVisualStyleBackColor = true;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // dtpDBO
            // 
            this.dtpDBO.Location = new System.Drawing.Point(73, 220);
            this.dtpDBO.Name = "dtpDBO";
            this.dtpDBO.Size = new System.Drawing.Size(200, 20);
            this.dtpDBO.TabIndex = 18;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(370, 178);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 17;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(307, 178);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 16;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label9.Location = new System.Drawing.Point(24, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "DBO:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(73, 175);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(145, 20);
            this.txtAddress.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(73, 137);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(73, 99);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(145, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // txtStdNum
            // 
            this.txtStdNum.Enabled = false;
            this.txtStdNum.Location = new System.Drawing.Point(73, 26);
            this.txtStdNum.Name = "txtStdNum";
            this.txtStdNum.Size = new System.Drawing.Size(145, 20);
            this.txtStdNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "std Num:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(238, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 126);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnDisplayStudents
            // 
            this.btnDisplayStudents.Location = new System.Drawing.Point(42, 12);
            this.btnDisplayStudents.Name = "btnDisplayStudents";
            this.btnDisplayStudents.Size = new System.Drawing.Size(207, 47);
            this.btnDisplayStudents.TabIndex = 3;
            this.btnDisplayStudents.Text = "Display Students";
            this.btnDisplayStudents.UseVisualStyleBackColor = true;
            this.btnDisplayStudents.Click += new System.EventHandler(this.btnDisplayStudents_Click);
            // 
            // btnDisplayModules
            // 
            this.btnDisplayModules.Location = new System.Drawing.Point(255, 12);
            this.btnDisplayModules.Name = "btnDisplayModules";
            this.btnDisplayModules.Size = new System.Drawing.Size(227, 47);
            this.btnDisplayModules.TabIndex = 4;
            this.btnDisplayModules.Text = "Display Modules";
            this.btnDisplayModules.UseVisualStyleBackColor = true;
            this.btnDisplayModules.Click += new System.EventHandler(this.btnDisplayModules_Click);
            // 
            // btnStudMod
            // 
            this.btnStudMod.Location = new System.Drawing.Point(488, 12);
            this.btnStudMod.Name = "btnStudMod";
            this.btnStudMod.Size = new System.Drawing.Size(219, 47);
            this.btnStudMod.TabIndex = 5;
            this.btnStudMod.Text = "Display Students and Modules";
            this.btnStudMod.UseVisualStyleBackColor = true;
            this.btnStudMod.Click += new System.EventHandler(this.btnStudMod_Click);
            // 
            // btnSearchS
            // 
            this.btnSearchS.Location = new System.Drawing.Point(203, 552);
            this.btnSearchS.Name = "btnSearchS";
            this.btnSearchS.Size = new System.Drawing.Size(174, 47);
            this.btnSearchS.TabIndex = 6;
            this.btnSearchS.Text = "Search Student";
            this.btnSearchS.UseVisualStyleBackColor = true;
            this.btnSearchS.Click += new System.EventHandler(this.btnSearchS_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudent.Location = new System.Drawing.Point(64, 557);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(133, 31);
            this.txtSearchStudent.TabIndex = 7;
            // 
            // txtSearchModule
            // 
            this.txtSearchModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchModule.Location = new System.Drawing.Point(394, 561);
            this.txtSearchModule.Name = "txtSearchModule";
            this.txtSearchModule.Size = new System.Drawing.Size(133, 31);
            this.txtSearchModule.TabIndex = 9;
            // 
            // btnSearchM
            // 
            this.btnSearchM.Location = new System.Drawing.Point(533, 552);
            this.btnSearchM.Name = "btnSearchM";
            this.btnSearchM.Size = new System.Drawing.Size(174, 47);
            this.btnSearchM.TabIndex = 8;
            this.btnSearchM.Text = "Search Module";
            this.btnSearchM.UseVisualStyleBackColor = true;
            this.btnSearchM.Click += new System.EventHandler(this.btnSearchM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 650);
            this.Controls.Add(this.txtSearchModule);
            this.Controls.Add(this.btnSearchM);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.btnSearchS);
            this.Controls.Add(this.btnStudMod);
            this.Controls.Add(this.btnDisplayModules);
            this.Controls.Add(this.btnDisplayStudents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStdNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisplayStudents;
        private System.Windows.Forms.Button btnDisplayModules;
        private System.Windows.Forms.Button btnStudMod;
        private System.Windows.Forms.Button btnSearchS;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label txtlinks;
        private System.Windows.Forms.Button btnDeleteM;
        private System.Windows.Forms.Button btnUpdateM;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.Button btnAddS;
        private System.Windows.Forms.DateTimePicker dtpDBO;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.TextBox txtSearchModule;
        private System.Windows.Forms.Button btnSearchM;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.ComboBox comboModules;
        private System.Windows.Forms.Button btnRemoveMod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

