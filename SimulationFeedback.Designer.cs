
namespace AllTours
{
    partial class SimulationFeedback
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStops = new System.Windows.Forms.Button();
            this.buttonStarts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во новых отзывов:";
            // 
            // buttonStops
            // 
            this.buttonStops.Location = new System.Drawing.Point(176, 271);
            this.buttonStops.Name = "buttonStops";
            this.buttonStops.Size = new System.Drawing.Size(94, 29);
            this.buttonStops.TabIndex = 5;
            this.buttonStops.Text = "Stop";
            this.buttonStops.UseVisualStyleBackColor = true;
            this.buttonStops.Click += new System.EventHandler(this.buttonStops_Click);
            // 
            // buttonStarts
            // 
            this.buttonStarts.Location = new System.Drawing.Point(176, 218);
            this.buttonStarts.Name = "buttonStarts";
            this.buttonStarts.Size = new System.Drawing.Size(94, 29);
            this.buttonStarts.TabIndex = 4;
            this.buttonStarts.Text = "Start";
            this.buttonStarts.UseVisualStyleBackColor = true;
            this.buttonStarts.Click += new System.EventHandler(this.buttonStarts_Click);
            // 
            // SimulationFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStops);
            this.Controls.Add(this.buttonStarts);
            this.Name = "SimulationFeedback";
            this.Text = "SimulationFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStops;
        private System.Windows.Forms.Button buttonStarts;
    }
}