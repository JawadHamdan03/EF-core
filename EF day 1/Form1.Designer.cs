namespace EF_Lec1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Students_GV = new DataGridView();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            ResetButton = new Button();
            IDtextBox = new TextBox();
            NametextBox = new TextBox();
            AgetextBox = new TextBox();
            AddresstextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddStuButton = new Button();
            DepComboBox = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Students_GV).BeginInit();
            SuspendLayout();
            // 
            // Students_GV
            // 
            Students_GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Students_GV.Location = new Point(2, 106);
            Students_GV.Name = "Students_GV";
            Students_GV.RowHeadersWidth = 51;
            Students_GV.Size = new Size(674, 279);
            Students_GV.TabIndex = 0;
            Students_GV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(21, 35);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(189, 27);
            SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(230, 35);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(189, 29);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search by name";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(444, 35);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(189, 29);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(775, 106);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(198, 27);
            IDtextBox.TabIndex = 5;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(775, 148);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(198, 27);
            NametextBox.TabIndex = 6;
            // 
            // AgetextBox
            // 
            AgetextBox.Location = new Point(775, 195);
            AgetextBox.Name = "AgetextBox";
            AgetextBox.Size = new Size(198, 27);
            AgetextBox.TabIndex = 7;
            // 
            // AddresstextBox
            // 
            AddresstextBox.Location = new Point(775, 238);
            AddresstextBox.Name = "AddresstextBox";
            AddresstextBox.Size = new Size(198, 27);
            AddresstextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(702, 115);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(702, 151);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(702, 198);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 11;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(689, 241);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // AddStuButton
            // 
            AddStuButton.Location = new Point(775, 331);
            AddStuButton.Name = "AddStuButton";
            AddStuButton.Size = new Size(198, 29);
            AddStuButton.TabIndex = 13;
            AddStuButton.Text = "ADD Student";
            AddStuButton.UseVisualStyleBackColor = true;
            AddStuButton.Click += AddStuButton_Click;
            // 
            // DepComboBox
            // 
            DepComboBox.FormattingEnabled = true;
            DepComboBox.Location = new Point(775, 281);
            DepComboBox.Name = "DepComboBox";
            DepComboBox.Size = new Size(198, 28);
            DepComboBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(680, 284);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 15;
            label5.Text = "Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 526);
            Controls.Add(label5);
            Controls.Add(DepComboBox);
            Controls.Add(AddStuButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddresstextBox);
            Controls.Add(AgetextBox);
            Controls.Add(NametextBox);
            Controls.Add(IDtextBox);
            Controls.Add(ResetButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(Students_GV);
            Name = "Form1";
            Text = "MyForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Students_GV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Students_GV;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button ResetButton;
        private TextBox IDtextBox;
        private TextBox NametextBox;
        private TextBox AgetextBox;
        private TextBox AddresstextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddStuButton;
        private ComboBox DepComboBox;
        private Label label5;
    }
}
