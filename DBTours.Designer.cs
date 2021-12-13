
namespace AllTours
{
    partial class DBTours
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
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRetrieve = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DayNightTxt = new System.Windows.Forms.TextBox();
            this.daylabel = new System.Windows.Forms.Label();
            this.DateTourTxt = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.TournameTxt = new System.Windows.Forms.TextBox();
            this.LabelTourName = new System.Windows.Forms.Label();
            this.TypeTourTxt = new System.Windows.Forms.TextBox();
            this.labelTypeTour = new System.Windows.Forms.Label();
            this.ChildTxt = new System.Windows.Forms.TextBox();
            this.labelchild = new System.Windows.Forms.Label();
            this.OldTxt = new System.Windows.Forms.TextBox();
            this.labelold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(46, 485);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(94, 29);
            this.Clearbutton.TabIndex = 31;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(628, 485);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(94, 29);
            this.Updatebutton.TabIndex = 30;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(480, 485);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRetrieve
            // 
            this.buttonRetrieve.Location = new System.Drawing.Point(339, 485);
            this.buttonRetrieve.Name = "buttonRetrieve";
            this.buttonRetrieve.Size = new System.Drawing.Size(94, 29);
            this.buttonRetrieve.TabIndex = 18;
            this.buttonRetrieve.Text = "Retrieve";
            this.buttonRetrieve.UseVisualStyleBackColor = true;
            this.buttonRetrieve.Click += new System.EventHandler(this.buttonRetrieve_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(192, 485);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(94, 29);
            this.Addbutton.TabIndex = 17;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(664, 356);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DayNightTxt
            // 
            this.DayNightTxt.Location = new System.Drawing.Point(931, 267);
            this.DayNightTxt.Name = "DayNightTxt";
            this.DayNightTxt.Size = new System.Drawing.Size(125, 27);
            this.DayNightTxt.TabIndex = 39;
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.Location = new System.Drawing.Point(931, 224);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(92, 20);
            this.daylabel.TabIndex = 38;
            this.daylabel.Text = "Дней ночей";
            // 
            // DateTourTxt
            // 
            this.DateTourTxt.Location = new System.Drawing.Point(764, 267);
            this.DateTourTxt.Name = "DateTourTxt";
            this.DateTourTxt.Size = new System.Drawing.Size(125, 27);
            this.DateTourTxt.TabIndex = 37;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(764, 224);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(102, 20);
            this.labelDate.TabIndex = 36;
            this.labelDate.Text = "Дата поездки";
            // 
            // TournameTxt
            // 
            this.TournameTxt.Location = new System.Drawing.Point(931, 156);
            this.TournameTxt.Name = "TournameTxt";
            this.TournameTxt.Size = new System.Drawing.Size(125, 27);
            this.TournameTxt.TabIndex = 35;
            this.TournameTxt.TextChanged += new System.EventHandler(this.TournameTxt_TextChanged);
            // 
            // LabelTourName
            // 
            this.LabelTourName.AutoSize = true;
            this.LabelTourName.Location = new System.Drawing.Point(931, 115);
            this.LabelTourName.Name = "LabelTourName";
            this.LabelTourName.Size = new System.Drawing.Size(111, 20);
            this.LabelTourName.TabIndex = 34;
            this.LabelTourName.Text = "Название тура";
            // 
            // TypeTourTxt
            // 
            this.TypeTourTxt.Location = new System.Drawing.Point(764, 158);
            this.TypeTourTxt.Name = "TypeTourTxt";
            this.TypeTourTxt.Size = new System.Drawing.Size(125, 27);
            this.TypeTourTxt.TabIndex = 33;
            // 
            // labelTypeTour
            // 
            this.labelTypeTour.AutoSize = true;
            this.labelTypeTour.Location = new System.Drawing.Point(764, 115);
            this.labelTypeTour.Name = "labelTypeTour";
            this.labelTypeTour.Size = new System.Drawing.Size(69, 20);
            this.labelTypeTour.TabIndex = 32;
            this.labelTypeTour.Text = "Тип тура";
            // 
            // ChildTxt
            // 
            this.ChildTxt.Location = new System.Drawing.Point(931, 377);
            this.ChildTxt.Name = "ChildTxt";
            this.ChildTxt.Size = new System.Drawing.Size(133, 27);
            this.ChildTxt.TabIndex = 43;
            // 
            // labelchild
            // 
            this.labelchild.AutoSize = true;
            this.labelchild.Location = new System.Drawing.Point(931, 334);
            this.labelchild.Name = "labelchild";
            this.labelchild.Size = new System.Drawing.Size(133, 20);
            this.labelchild.TabIndex = 42;
            this.labelchild.Text = "Количество детей";
            // 
            // OldTxt
            // 
            this.OldTxt.Location = new System.Drawing.Point(764, 377);
            this.OldTxt.Name = "OldTxt";
            this.OldTxt.Size = new System.Drawing.Size(160, 27);
            this.OldTxt.TabIndex = 41;
            // 
            // labelold
            // 
            this.labelold.AutoSize = true;
            this.labelold.Location = new System.Drawing.Point(764, 334);
            this.labelold.Name = "labelold";
            this.labelold.Size = new System.Drawing.Size(160, 20);
            this.labelold.TabIndex = 40;
            this.labelold.Text = "Количество взрослых";
            // 
            // DBTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 530);
            this.Controls.Add(this.ChildTxt);
            this.Controls.Add(this.labelchild);
            this.Controls.Add(this.OldTxt);
            this.Controls.Add(this.labelold);
            this.Controls.Add(this.DayNightTxt);
            this.Controls.Add(this.daylabel);
            this.Controls.Add(this.DateTourTxt);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.TournameTxt);
            this.Controls.Add(this.LabelTourName);
            this.Controls.Add(this.TypeTourTxt);
            this.Controls.Add(this.labelTypeTour);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRetrieve);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBTours";
            this.Text = "DBTours";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRetrieve;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DayNightTxt;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.TextBox DateTourTxt;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox TournameTxt;
        private System.Windows.Forms.Label LabelTourName;
        private System.Windows.Forms.TextBox TypeTourTxt;
        private System.Windows.Forms.Label labelTypeTour;
        private System.Windows.Forms.TextBox ChildTxt;
        private System.Windows.Forms.Label labelchild;
        private System.Windows.Forms.TextBox OldTxt;
        private System.Windows.Forms.Label labelold;
    }
}