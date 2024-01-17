namespace CRUD
{
    partial class StudentInfo
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSaveStudent = new Button();
            label5 = new Label();
            textBoxSection = new TextBox();
            label4 = new Label();
            textBoxClass = new TextBox();
            label3 = new Label();
            textBoxReg = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(160, 113, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 104);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 0;
            label1.Text = "AddStudent";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSaveStudent);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxSection);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxClass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxReg);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(12, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 531);
            panel2.TabIndex = 1;
            // 
            // btnSaveStudent
            // 
            btnSaveStudent.BackColor = Color.FromArgb(116, 113, 255);
            btnSaveStudent.FlatStyle = FlatStyle.Flat;
            btnSaveStudent.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveStudent.ForeColor = Color.White;
            btnSaveStudent.Location = new Point(187, 327);
            btnSaveStudent.Name = "btnSaveStudent";
            btnSaveStudent.Size = new Size(139, 33);
            btnSaveStudent.TabIndex = 0;
            btnSaveStudent.Text = "Save";
            btnSaveStudent.UseVisualStyleBackColor = false;
            btnSaveStudent.Click += btnSaveStudent_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 258);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Stream:";
            // 
            // textBoxSection
            // 
            textBoxSection.BorderStyle = BorderStyle.FixedSingle;
            textBoxSection.Location = new Point(124, 276);
            textBoxSection.Name = "textBoxSection";
            textBoxSection.Size = new Size(290, 23);
            textBoxSection.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 201);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Class:";
            // 
            // textBoxClass
            // 
            textBoxClass.BorderStyle = BorderStyle.FixedSingle;
            textBoxClass.Location = new Point(124, 219);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.Size = new Size(290, 23);
            textBoxClass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 148);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Reg:";
            label3.Click += label3_Click;
            // 
            // textBoxReg
            // 
            textBoxReg.BorderStyle = BorderStyle.FixedSingle;
            textBoxReg.Location = new Point(124, 166);
            textBoxReg.Name = "textBoxReg";
            textBoxReg.Size = new Size(290, 23);
            textBoxReg.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 104);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(124, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(290, 23);
            textBoxName.TabIndex = 1;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "StudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxName;
        private Label label2;
        private Label label4;
        private TextBox textBoxClass;
        private Label label3;
        private TextBox textBoxReg;
        private Label label5;
        private TextBox textBoxSection;
        private Button btnSaveStudent;
    }
}