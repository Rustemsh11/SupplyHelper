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
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // choosenPropsList
            // 
            this.choosenPropsList.FormattingEnabled = true;
            this.choosenPropsList.Location = new System.Drawing.Point(302, 48);
            this.choosenPropsList.Name = "choosenPropsList";
            this.choosenPropsList.Size = new System.Drawing.Size(203, 147);
            this.choosenPropsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
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
            this.semPropGrid.Location = new System.Drawing.Point(12, 48);
            this.semPropGrid.Name = "semPropGrid";
            this.semPropGrid.Size = new System.Drawing.Size(240, 150);
            this.semPropGrid.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Свойства для запроса";
            // 
            // neededPropList
            // 
            this.neededPropList.FormattingEnabled = true;
            this.neededPropList.Location = new System.Drawing.Point(575, 48);
            this.neededPropList.Name = "neededPropList";
            this.neededPropList.Size = new System.Drawing.Size(203, 147);
            this.neededPropList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Необходимые свойства для запроса";
            // 
            // PropertyMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.neededPropList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semPropGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosenPropsList);
            this.Name = "PropertyMapForm";
            this.Text = "PropertyMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox choosenPropsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView semPropGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox neededPropList;
        private System.Windows.Forms.Label label3;
    }
}