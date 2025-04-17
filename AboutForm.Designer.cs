namespace Bitwise_app
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            label_description = new Label();
            button_Go_Maın = new Button();
            pnl_About = new Panel();
            pnl_About.SuspendLayout();
            SuspendLayout();
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(6, 21);
            label_description.Margin = new Padding(6, 0, 6, 0);
            label_description.Name = "label_description";
            label_description.Size = new Size(127, 53);
            label_description.TabIndex = 4;
            label_description.Text = "label5";
            // 
            // button_Go_Maın
            // 
            button_Go_Maın.Location = new Point(1236, 828);
            button_Go_Maın.Margin = new Padding(6);
            button_Go_Maın.Name = "button_Go_Maın";
            button_Go_Maın.Size = new Size(462, 81);
            button_Go_Maın.TabIndex = 5;
            button_Go_Maın.Text = "GO TO MAIN FORM";
            button_Go_Maın.UseVisualStyleBackColor = true;
            button_Go_Maın.Click += button1_Click;
            // 
            // pnl_About
            // 
            pnl_About.AutoScroll = true;
            pnl_About.AutoSize = true;
            pnl_About.BackgroundImage = (Image)resources.GetObject("pnl_About.BackgroundImage");
            pnl_About.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_About.Controls.Add(label_description);
            pnl_About.Controls.Add(button_Go_Maın);
            pnl_About.Dock = DockStyle.Fill;
            pnl_About.Location = new Point(0, 0);
            pnl_About.Margin = new Padding(6);
            pnl_About.Name = "pnl_About";
            pnl_About.Size = new Size(1760, 954);
            pnl_About.TabIndex = 6;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(22F, 53F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1760, 954);
            Controls.Add(pnl_About);
            Font = new Font("Segoe UI Variable Display", 20F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "AboutForm";
            Opacity = 0.8D;
            Text = "AboutForm";
            Load += AboutForm_Load;
            pnl_About.ResumeLayout(false);
            pnl_About.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_description;
        private Button button_Go_Maın;
        private Panel pnl_About;
    }
}