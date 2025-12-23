namespace Asp.NetDevelopHelper
{
    partial class DPAPI_Tool
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
            inputTxtbox = new RichTextBox();
            outputTxtbox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            encBtn = new Button();
            reverseBtn = new Button();
            SuspendLayout();
            // 
            // inputTxtbox
            // 
            inputTxtbox.Location = new Point(12, 77);
            inputTxtbox.Name = "inputTxtbox";
            inputTxtbox.Size = new Size(776, 149);
            inputTxtbox.TabIndex = 0;
            inputTxtbox.Text = "";
            // 
            // outputTxtbox
            // 
            outputTxtbox.Location = new Point(12, 289);
            outputTxtbox.Name = "outputTxtbox";
            outputTxtbox.Size = new Size(776, 149);
            outputTxtbox.TabIndex = 1;
            outputTxtbox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 266);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "خروجی";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 54);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "ورودی";
            // 
            // encBtn
            // 
            encBtn.Location = new Point(694, 12);
            encBtn.Name = "encBtn";
            encBtn.Size = new Size(94, 29);
            encBtn.TabIndex = 4;
            encBtn.Text = "تبدیل";
            encBtn.UseVisualStyleBackColor = true;
            encBtn.Click += encBtn_Click;
            // 
            // reverseBtn
            // 
            reverseBtn.Location = new Point(12, 12);
            reverseBtn.Name = "reverseBtn";
            reverseBtn.Size = new Size(94, 29);
            reverseBtn.TabIndex = 5;
            reverseBtn.Text = "برگردان";
            reverseBtn.UseVisualStyleBackColor = true;
            reverseBtn.Click += reverseBtn_Click;
            // 
            // DPAPI_Tool
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reverseBtn);
            Controls.Add(encBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputTxtbox);
            Controls.Add(inputTxtbox);
            Name = "DPAPI_Tool";
            Text = "DPAPI_Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputTxtbox;
        private RichTextBox outputTxtbox;
        private Label label1;
        private Label label2;
        private Button encBtn;
        private Button reverseBtn;
    }
}