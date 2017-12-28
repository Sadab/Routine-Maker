﻿namespace Routine_Maker
{
    partial class RoutineMaker
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
            this.comboCourseSelect = new System.Windows.Forms.ComboBox();
            this.courseSelectLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseSelectBtn = new System.Windows.Forms.Button();
            this.courseListGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCourseToListBtn = new System.Windows.Forms.Button();
            this.courseSecLbl = new System.Windows.Forms.Label();
            this.courseTimeLbl = new System.Windows.Forms.Label();
            this.courseDayLbl = new System.Windows.Forms.Label();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addedCourseGrid = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedCourseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCourseSelect
            // 
            this.comboCourseSelect.FormattingEnabled = true;
            this.comboCourseSelect.Items.AddRange(new object[] {
            "Algorithm",
            "Data Structure",
            "Database",
            "Object Oriented Programming",
            "Discrete Math"});
            this.comboCourseSelect.Location = new System.Drawing.Point(31, 80);
            this.comboCourseSelect.Name = "comboCourseSelect";
            this.comboCourseSelect.Size = new System.Drawing.Size(213, 33);
            this.comboCourseSelect.TabIndex = 0;
            this.comboCourseSelect.SelectedIndexChanged += new System.EventHandler(this.comboCourseSelect_SelectedIndexChanged);
            // 
            // courseSelectLbl
            // 
            this.courseSelectLbl.AutoSize = true;
            this.courseSelectLbl.Location = new System.Drawing.Point(66, 43);
            this.courseSelectLbl.Name = "courseSelectLbl";
            this.courseSelectLbl.Size = new System.Drawing.Size(134, 25);
            this.courseSelectLbl.TabIndex = 1;
            this.courseSelectLbl.Text = "Select Course";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseSelectBtn);
            this.groupBox1.Controls.Add(this.comboCourseSelect);
            this.groupBox1.Controls.Add(this.courseSelectLbl);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Select";
            // 
            // courseSelectBtn
            // 
            this.courseSelectBtn.Location = new System.Drawing.Point(71, 133);
            this.courseSelectBtn.Name = "courseSelectBtn";
            this.courseSelectBtn.Size = new System.Drawing.Size(129, 41);
            this.courseSelectBtn.TabIndex = 2;
            this.courseSelectBtn.Text = "Select";
            this.courseSelectBtn.UseVisualStyleBackColor = true;
            this.courseSelectBtn.Click += new System.EventHandler(this.courseSelectBtn_Click);
            // 
            // courseListGrid
            // 
            this.courseListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseListGrid.Location = new System.Drawing.Point(319, 54);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.RowTemplate.Height = 24;
            this.courseListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseListGrid.Size = new System.Drawing.Size(897, 178);
            this.courseListGrid.TabIndex = 3;
            this.courseListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseListGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addCourseToListBtn);
            this.panel1.Controls.Add(this.courseSecLbl);
            this.panel1.Controls.Add(this.courseTimeLbl);
            this.panel1.Controls.Add(this.courseDayLbl);
            this.panel1.Controls.Add(this.courseNameLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 181);
            this.panel1.TabIndex = 4;
            // 
            // addCourseToListBtn
            // 
            this.addCourseToListBtn.Location = new System.Drawing.Point(457, 132);
            this.addCourseToListBtn.Name = "addCourseToListBtn";
            this.addCourseToListBtn.Size = new System.Drawing.Size(127, 38);
            this.addCourseToListBtn.TabIndex = 7;
            this.addCourseToListBtn.Text = "Add";
            this.addCourseToListBtn.UseVisualStyleBackColor = true;
            this.addCourseToListBtn.Click += new System.EventHandler(this.addCourseToListBtn_Click);
            // 
            // courseSecLbl
            // 
            this.courseSecLbl.AutoSize = true;
            this.courseSecLbl.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSecLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.courseSecLbl.Location = new System.Drawing.Point(202, 132);
            this.courseSecLbl.Name = "courseSecLbl";
            this.courseSecLbl.Size = new System.Drawing.Size(81, 25);
            this.courseSecLbl.TabIndex = 6;
            this.courseSecLbl.Text = "Section";
            // 
            // courseTimeLbl
            // 
            this.courseTimeLbl.AutoSize = true;
            this.courseTimeLbl.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTimeLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.courseTimeLbl.Location = new System.Drawing.Point(320, 82);
            this.courseTimeLbl.Name = "courseTimeLbl";
            this.courseTimeLbl.Size = new System.Drawing.Size(62, 25);
            this.courseTimeLbl.TabIndex = 5;
            this.courseTimeLbl.Text = "Time ";
            // 
            // courseDayLbl
            // 
            this.courseDayLbl.AutoSize = true;
            this.courseDayLbl.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDayLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.courseDayLbl.Location = new System.Drawing.Point(202, 82);
            this.courseDayLbl.Name = "courseDayLbl";
            this.courseDayLbl.Size = new System.Drawing.Size(48, 25);
            this.courseDayLbl.TabIndex = 4;
            this.courseDayLbl.Text = "Day";
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.courseNameLbl.Location = new System.Drawing.Point(199, 30);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(66, 25);
            this.courseNameLbl.TabIndex = 3;
            this.courseNameLbl.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course name";
            // 
            // addedCourseGrid
            // 
            this.addedCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addedCourseGrid.Location = new System.Drawing.Point(680, 279);
            this.addedCourseGrid.Name = "addedCourseGrid";
            this.addedCourseGrid.RowTemplate.Height = 24;
            this.addedCourseGrid.Size = new System.Drawing.Size(536, 181);
            this.addedCourseGrid.TabIndex = 5;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(959, 485);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 47);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(37, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(727, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Use Exit Button After Making Your Routine";
            // 
            // RoutineMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addedCourseGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.courseListGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoutineMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Routine Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addedCourseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCourseSelect;
        private System.Windows.Forms.Label courseSelectLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button courseSelectBtn;
        private System.Windows.Forms.DataGridView courseListGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseTimeLbl;
        private System.Windows.Forms.Label courseDayLbl;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.Label courseSecLbl;
        private System.Windows.Forms.Button addCourseToListBtn;
        private System.Windows.Forms.DataGridView addedCourseGrid;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label4;
    }
}