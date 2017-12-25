namespace Routine_Maker
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(63, 35);
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
            this.courseListGrid.Location = new System.Drawing.Point(354, 54);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.RowTemplate.Height = 24;
            this.courseListGrid.Size = new System.Drawing.Size(627, 178);
            this.courseListGrid.TabIndex = 3;
            // 
            // RoutineMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 512);
            this.Controls.Add(this.courseListGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoutineMaker";
            this.Text = "Routine Maker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCourseSelect;
        private System.Windows.Forms.Label courseSelectLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button courseSelectBtn;
        private System.Windows.Forms.DataGridView courseListGrid;
    }
}