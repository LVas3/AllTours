
namespace AllTours
{
    partial class Feedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.NameTourcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxFBack = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Feedbackbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваше ФИО";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Location = new System.Drawing.Point(335, 63);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(125, 27);
            this.textBoxNameUser.TabIndex = 1;
            // 
            // NameTourcomboBox
            // 
            this.NameTourcomboBox.FormattingEnabled = true;
            this.NameTourcomboBox.Location = new System.Drawing.Point(194, 130);
            this.NameTourcomboBox.Name = "NameTourcomboBox";
            this.NameTourcomboBox.Size = new System.Drawing.Size(266, 28);
            this.NameTourcomboBox.TabIndex = 2;
            this.NameTourcomboBox.SelectedIndexChanged += new System.EventHandler(this.NameTourcomboBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название вашего тура";
            // 
            // richTextBoxFBack
            // 
            this.richTextBoxFBack.Location = new System.Drawing.Point(235, 230);
            this.richTextBoxFBack.Name = "richTextBoxFBack";
            this.richTextBoxFBack.Size = new System.Drawing.Size(316, 135);
            this.richTextBoxFBack.TabIndex = 4;
            this.richTextBoxFBack.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Напишите подробно о впечатлениях тура (до 255 символов)";
            // 
            // Feedbackbutton
            // 
            this.Feedbackbutton.Location = new System.Drawing.Point(307, 390);
            this.Feedbackbutton.Name = "Feedbackbutton";
            this.Feedbackbutton.Size = new System.Drawing.Size(183, 48);
            this.Feedbackbutton.TabIndex = 6;
            this.Feedbackbutton.Text = "Отправить отзыв";
            this.Feedbackbutton.UseVisualStyleBackColor = true;
            this.Feedbackbutton.Click += new System.EventHandler(this.Feedbackbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оценка вашего тура";
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Location = new System.Drawing.Point(503, 130);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(100, 28);
            this.comboBoxRating.TabIndex = 7;
            this.comboBoxRating.SelectedIndexChanged += new System.EventHandler(this.comboBoxRating_SelectedIndexChanged);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.Feedbackbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxFBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTourcomboBox);
            this.Controls.Add(this.textBoxNameUser);
            this.Controls.Add(this.label1);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.ComboBox NameTourcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxFBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Feedbackbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRating;
    }
}