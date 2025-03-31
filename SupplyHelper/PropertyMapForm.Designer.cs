namespace SupplyHelper
{
    partial class PropertyMapForm
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
            this.choosenPropsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.semPropGrid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.neededPropList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // choosenPropsList
            // 
            this.choosenPropsList.FormattingEnabled = true;
            this.choosenPropsList.ItemHeight = 16;
            this.choosenPropsList.Location = new System.Drawing.Point(403, 59);
            this.choosenPropsList.Margin = new System.Windows.Forms.Padding(4);
            this.choosenPropsList.Name = "choosenPropsList";
            this.choosenPropsList.Size = new System.Drawing.Size(269, 180);
            this.choosenPropsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Свойства семейства";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // semPropGrid
            // 
            this.semPropGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semPropGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Value});
            this.semPropGrid.Location = new System.Drawing.Point(16, 59);
            this.semPropGrid.Margin = new System.Windows.Forms.Padding(4);
            this.semPropGrid.Name = "semPropGrid";
            this.semPropGrid.RowHeadersWidth = 51;
            this.semPropGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.semPropGrid.Size = new System.Drawing.Size(320, 185);
            this.semPropGrid.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 140;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Значение";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Свойства для запроса";
            // 
            // neededPropList
            // 
            this.neededPropList.FormattingEnabled = true;
            this.neededPropList.ItemHeight = 16;
            this.neededPropList.Location = new System.Drawing.Point(767, 59);
            this.neededPropList.Margin = new System.Windows.Forms.Padding(4);
            this.neededPropList.Name = "neededPropList";
            this.neededPropList.Size = new System.Drawing.Size(269, 180);
            this.neededPropList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(779, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Необходимые свойства для запроса";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(614, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "\\/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "/\\";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(747, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Отправить запрос";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PropertyMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.neededPropList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semPropGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosenPropsList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "PropertyMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox choosenPropsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView semPropGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox neededPropList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}