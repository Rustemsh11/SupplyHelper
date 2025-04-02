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
            this.addNewPropButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newPropNameTextBox = new System.Windows.Forms.TextBox();
            this.newPropValueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AllSemRadioButton = new System.Windows.Forms.RadioButton();
            this.CurrentSemRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.semPropGrid.RowHeadersWidth = 51;
            this.semPropGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.semPropGrid.Size = new System.Drawing.Size(240, 150);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "\\/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "/\\";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(560, 313);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 19);
            this.button5.TabIndex = 10;
            this.button5.Text = "Отправить запрос";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addNewPropButton
            // 
            this.addNewPropButton.Location = new System.Drawing.Point(126, 102);
            this.addNewPropButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addNewPropButton.Name = "addNewPropButton";
            this.addNewPropButton.Size = new System.Drawing.Size(100, 19);
            this.addNewPropButton.TabIndex = 11;
            this.addNewPropButton.Text = "Добавить";
            this.addNewPropButton.UseVisualStyleBackColor = true;
            this.addNewPropButton.Click += new System.EventHandler(this.addNewPropButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentSemRadioButton);
            this.groupBox1.Controls.Add(this.AllSemRadioButton);
            this.groupBox1.Controls.Add(this.newPropValueTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.newPropNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addNewPropButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(240, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление свойствами";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Свойство";
            // 
            // newPropNameTextBox
            // 
            this.newPropNameTextBox.Location = new System.Drawing.Point(8, 55);
            this.newPropNameTextBox.Name = "newPropNameTextBox";
            this.newPropNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPropNameTextBox.TabIndex = 13;
            // 
            // newPropValueTextBox
            // 
            this.newPropValueTextBox.Location = new System.Drawing.Point(126, 55);
            this.newPropValueTextBox.Name = "newPropValueTextBox";
            this.newPropValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.newPropValueTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Значение";
            // 
            // AllSemRadioButton
            // 
            this.AllSemRadioButton.AutoSize = true;
            this.AllSemRadioButton.Location = new System.Drawing.Point(8, 81);
            this.AllSemRadioButton.Name = "AllSemRadioButton";
            this.AllSemRadioButton.Size = new System.Drawing.Size(72, 17);
            this.AllSemRadioButton.TabIndex = 13;
            this.AllSemRadioButton.TabStop = true;
            this.AllSemRadioButton.Text = "Для всех";
            this.AllSemRadioButton.UseVisualStyleBackColor = true;
            // 
            // CurrentSemRadioButton
            // 
            this.CurrentSemRadioButton.AutoSize = true;
            this.CurrentSemRadioButton.Location = new System.Drawing.Point(8, 104);
            this.CurrentSemRadioButton.Name = "CurrentSemRadioButton";
            this.CurrentSemRadioButton.Size = new System.Drawing.Size(92, 17);
            this.CurrentSemRadioButton.TabIndex = 16;
            this.CurrentSemRadioButton.TabStop = true;
            this.CurrentSemRadioButton.Text = "Для текущей";
            this.CurrentSemRadioButton.UseVisualStyleBackColor = true;
            // 
            // PropertyMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "PropertyMapForm";
            this.Text = "PropertyMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button addNewPropButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newPropValueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPropNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton CurrentSemRadioButton;
        private System.Windows.Forms.RadioButton AllSemRadioButton;
    }
}