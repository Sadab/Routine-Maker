namespace Routine_Maker
{
    partial class MainWindow
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
            this.courseNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secTB = new System.Windows.Forms.TextBox();
            this.createCouseBtn = new System.Windows.Forms.Button();
            this.courseList = new System.Windows.Forms.DataGridView();
            this.loadCourseBtn = new System.Windows.Forms.Button();
            this.EditCourseIdTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editCourse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delCourseBrn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.delCourseTB = new System.Windows.Forms.TextBox();
            this.clearDBbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseNameTB
            // 
            this.courseNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.courseNameTB.Location = new System.Drawing.Point(168, 52);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.Size = new System.Drawing.Size(168, 22);
            this.courseNameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name";
            // 
            // secTB
            // 
            this.secTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.secTB.Location = new System.Drawing.Point(142, 220);
            this.secTB.Name = "secTB";
            this.secTB.Size = new System.Drawing.Size(168, 22);
            this.secTB.TabIndex = 5;
            // 
            // createCouseBtn
            // 
            this.createCouseBtn.Location = new System.Drawing.Point(141, 263);
            this.createCouseBtn.Name = "createCouseBtn";
            this.createCouseBtn.Size = new System.Drawing.Size(168, 44);
            this.createCouseBtn.TabIndex = 6;
            this.createCouseBtn.Text = "Create Course";
            this.createCouseBtn.UseVisualStyleBackColor = true;
            this.createCouseBtn.Click += new System.EventHandler(this.createCouseBtn_Click);
            // 
            // courseList
            // 
            this.courseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseList.Location = new System.Drawing.Point(22, 42);
            this.courseList.Name = "courseList";
            this.courseList.RowTemplate.Height = 24;
            this.courseList.Size = new System.Drawing.Size(734, 265);
            this.courseList.TabIndex = 7;
            // 
            // loadCourseBtn
            // 
            this.loadCourseBtn.Location = new System.Drawing.Point(293, 324);
            this.loadCourseBtn.Name = "loadCourseBtn";
            this.loadCourseBtn.Size = new System.Drawing.Size(173, 50);
            this.loadCourseBtn.TabIndex = 9;
            this.loadCourseBtn.Text = "Load Courses";
            this.loadCourseBtn.UseVisualStyleBackColor = true;
            this.loadCourseBtn.Click += new System.EventHandler(this.loadCourseBtn_Click);
            // 
            // EditCourseIdTB
            // 
            this.EditCourseIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.EditCourseIdTB.Location = new System.Drawing.Point(142, 40);
            this.EditCourseIdTB.Name = "EditCourseIdTB";
            this.EditCourseIdTB.Size = new System.Drawing.Size(167, 22);
            this.EditCourseIdTB.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.secTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.createCouseBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.courseNameTB);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 329);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Section";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboTime);
            this.groupBox5.Controls.Add(this.comboDay);
            this.groupBox5.Location = new System.Drawing.Point(25, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 84);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Course Time";
            // 
            // comboTime
            // 
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Items.AddRange(new object[] {
            "9:00-11:00 A.M",
            "11:00-1:00 A.M",
            "1:00-3:00 P.M",
            "3:00-5:00 P.M"});
            this.comboTime.Location = new System.Drawing.Point(164, 33);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(147, 29);
            this.comboTime.TabIndex = 12;
            this.comboTime.SelectedIndexChanged += new System.EventHandler(this.comboTime_SelectedIndexChanged);
            // 
            // comboDay
            // 
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Items.AddRange(new object[] {
            "SUN-TUES",
            "MON-WED"});
            this.comboDay.Location = new System.Drawing.Point(23, 33);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(121, 29);
            this.comboDay.TabIndex = 11;
            this.comboDay.SelectedIndexChanged += new System.EventHandler(this.comboDay_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editCourse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EditCourseIdTB);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(28, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Course";
            // 
            // editCourse
            // 
            this.editCourse.Location = new System.Drawing.Point(142, 91);
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(168, 48);
            this.editCourse.TabIndex = 12;
            this.editCourse.Text = "Update Course";
            this.editCourse.UseVisualStyleBackColor = true;
            this.editCourse.Click += new System.EventHandler(this.editCourse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loadCourseBtn);
            this.groupBox3.Controls.Add(this.courseList);
            this.groupBox3.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(483, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 385);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Course List";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.delCourseBrn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.delCourseTB);
            this.groupBox4.Font = new System.Drawing.Font("Adobe Gothic Std B", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(483, 436);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 154);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Course";
            // 
            // delCourseBrn
            // 
            this.delCourseBrn.Location = new System.Drawing.Point(347, 91);
            this.delCourseBrn.Name = "delCourseBrn";
            this.delCourseBrn.Size = new System.Drawing.Size(139, 48);
            this.delCourseBrn.TabIndex = 13;
            this.delCourseBrn.Text = "Delete Course";
            this.delCourseBrn.UseVisualStyleBackColor = true;
            this.delCourseBrn.Click += new System.EventHandler(this.delCourseBrn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Course ID";
            // 
            // delCourseTB
            // 
            this.delCourseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.delCourseTB.Location = new System.Drawing.Point(264, 40);
            this.delCourseTB.Name = "delCourseTB";
            this.delCourseTB.Size = new System.Drawing.Size(290, 22);
            this.delCourseTB.TabIndex = 0;
            // 
            // clearDBbtn
            // 
            this.clearDBbtn.Location = new System.Drawing.Point(28, 387);
            this.clearDBbtn.Name = "clearDBbtn";
            this.clearDBbtn.Size = new System.Drawing.Size(127, 24);
            this.clearDBbtn.TabIndex = 15;
            this.clearDBbtn.Text = "Clear DB";
            this.clearDBbtn.UseVisualStyleBackColor = true;
            this.clearDBbtn.Click += new System.EventHandler(this.clearDBbtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 611);
            this.Controls.Add(this.clearDBbtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.courseList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox courseNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secTB;
        private System.Windows.Forms.Button createCouseBtn;
        private System.Windows.Forms.DataGridView courseList;
        private System.Windows.Forms.Button loadCourseBtn;
        private System.Windows.Forms.TextBox EditCourseIdTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editCourse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button delCourseBrn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delCourseTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.Button clearDBbtn;
    }
}