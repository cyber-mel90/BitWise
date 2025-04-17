namespace Bitwise_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl = new Label();
            dataGridView1 = new DataGridView();
            button_Convert = new Button();
            textBox_Convert_Value = new TextBox();
            button_Conver_Char = new Button();
            button_Copy_to_Clipboard = new Button();
            button_Convert_Code = new Button();
            button_About = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(832, 51);
            lbl.Margin = new Padding(6, 0, 6, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(97, 43);
            lbl.TabIndex = 0;
            lbl.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 488);
            dataGridView1.Margin = new Padding(6, 5, 6, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1406, 557);
            dataGridView1.TabIndex = 1;
            // 
            // button_Convert
            // 
            button_Convert.Location = new Point(498, 237);
            button_Convert.Margin = new Padding(6, 5, 6, 5);
            button_Convert.Name = "button_Convert";
            button_Convert.Size = new Size(378, 66);
            button_Convert.TabIndex = 3;
            button_Convert.Text = "CONVERT";
            button_Convert.UseVisualStyleBackColor = true;
            button_Convert.Click += button_Convert_Click;
            // 
            // textBox_Convert_Value
            // 
            textBox_Convert_Value.Location = new Point(498, 154);
            textBox_Convert_Value.Margin = new Padding(6, 5, 6, 5);
            textBox_Convert_Value.Multiline = true;
            textBox_Convert_Value.Name = "textBox_Convert_Value";
            textBox_Convert_Value.Size = new Size(785, 59);
            textBox_Convert_Value.TabIndex = 4;
            // 
            // button_Conver_Char
            // 
            button_Conver_Char.Location = new Point(905, 237);
            button_Conver_Char.Margin = new Padding(6, 5, 6, 5);
            button_Conver_Char.Name = "button_Conver_Char";
            button_Conver_Char.Size = new Size(378, 66);
            button_Conver_Char.TabIndex = 5;
            button_Conver_Char.Text = "CONVERT TO CHAR";
            button_Conver_Char.UseVisualStyleBackColor = true;
            button_Conver_Char.Click += button_Conver_Char_Click;
            // 
            // button_Copy_to_Clipboard
            // 
            button_Copy_to_Clipboard.Location = new Point(141, 399);
            button_Copy_to_Clipboard.Margin = new Padding(6, 5, 6, 5);
            button_Copy_to_Clipboard.Name = "button_Copy_to_Clipboard";
            button_Copy_to_Clipboard.Size = new Size(378, 66);
            button_Copy_to_Clipboard.TabIndex = 6;
            button_Copy_to_Clipboard.Text = "COPY TO CLIPBOARD";
            button_Copy_to_Clipboard.UseVisualStyleBackColor = true;
            button_Copy_to_Clipboard.Click += button_Copy_to_Clipboard_Click;
            // 
            // button_Convert_Code
            // 
            button_Convert_Code.Location = new Point(679, 328);
            button_Convert_Code.Margin = new Padding(6, 5, 6, 5);
            button_Convert_Code.Name = "button_Convert_Code";
            button_Convert_Code.Size = new Size(378, 66);
            button_Convert_Code.TabIndex = 7;
            button_Convert_Code.Text = "CONVERT TO CODE";
            button_Convert_Code.UseVisualStyleBackColor = true;
            button_Convert_Code.Click += button_Convert_Code_Click;
            // 
            // button_About
            // 
            button_About.Location = new Point(1097, 399);
            button_About.Margin = new Padding(6, 5, 6, 5);
            button_About.Name = "button_About";
            button_About.Size = new Size(378, 66);
            button_About.TabIndex = 8;
            button_About.Text = "GO TO ABOUT FORM";
            button_About.UseVisualStyleBackColor = true;
            button_About.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1606, 1050);
            Controls.Add(button_About);
            Controls.Add(button_Convert_Code);
            Controls.Add(button_Copy_to_Clipboard);
            Controls.Add(button_Conver_Char);
            Controls.Add(textBox_Convert_Value);
            Controls.Add(button_Convert);
            Controls.Add(dataGridView1);
            Controls.Add(lbl);
            Font = new Font("Segoe UI Variable Display", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "BitWise";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private DataGridView dataGridView1;
        private Button button_Convert;
        private TextBox textBox_Convert_Value;
        private Button button_Conver_Char;
        private Button button_Copy_to_Clipboard;
        private Button button_Convert_Code;
        private Button button_About;
    }
}
