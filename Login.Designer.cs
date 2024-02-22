namespace Tap.az
{
    partial class Login
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
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(293, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 357);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            maskedTextBox1.Location = new Point(80, 157);
            maskedTextBox1.Mask = "(000) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(348, 48);
            maskedTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 90);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 17;
            label1.Text = "Kabinetə giriş";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(165, 195, 252);
            button1.ForeColor = Color.White;
            button1.Location = new Point(80, 236);
            button1.Name = "button1";
            button1.Size = new Size(348, 60);
            button1.TabIndex = 16;
            button1.Text = "SMS-kod gondərilsin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 717);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
    }
}