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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addNewPropButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sharedObjectNames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentSemRadioButton = new System.Windows.Forms.RadioButton();
            this.AllSemRadioButton = new System.Windows.Forms.RadioButton();
            this.newPropValueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPropNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.neededPropGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neededPropGrid)).BeginInit();
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
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "<=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "\\/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Отправить запрос";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // addNewPropButton
            // 
            this.addNewPropButton.Location = new System.Drawing.Point(168, 188);
            this.addNewPropButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewPropButton.Name = "addNewPropButton";
            this.addNewPropButton.Size = new System.Drawing.Size(133, 23);
            this.addNewPropButton.TabIndex = 11;
            this.addNewPropButton.Text = "Добавить";
            this.addNewPropButton.UseVisualStyleBackColor = true;
            this.addNewPropButton.Click += new System.EventHandler(this.addNewPropButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sharedObjectNames);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CurrentSemRadioButton);
            this.groupBox1.Controls.Add(this.AllSemRadioButton);
            this.groupBox1.Controls.Add(this.newPropValueTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.newPropNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addNewPropButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(320, 218);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление свойствами";
            // 
            // sharedObjectNames
            // 
            this.sharedObjectNames.FormattingEnabled = true;
            this.sharedObjectNames.Location = new System.Drawing.Point(7, 44);
            this.sharedObjectNames.Margin = new System.Windows.Forms.Padding(4);
            this.sharedObjectNames.Name = "sharedObjectNames";
            this.sharedObjectNames.Size = new System.Drawing.Size(160, 24);
            this.sharedObjectNames.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Группа ФОП";
            // 
            // CurrentSemRadioButton
            // 
            this.CurrentSemRadioButton.AutoSize = true;
            this.CurrentSemRadioButton.Location = new System.Drawing.Point(11, 154);
            this.CurrentSemRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentSemRadioButton.Name = "CurrentSemRadioButton";
            this.CurrentSemRadioButton.Size = new System.Drawing.Size(110, 20);
            this.CurrentSemRadioButton.TabIndex = 16;
            this.CurrentSemRadioButton.TabStop = true;
            this.CurrentSemRadioButton.Text = "Для текущей";
            this.CurrentSemRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllSemRadioButton
            // 
            this.AllSemRadioButton.AutoSize = true;
            this.AllSemRadioButton.Location = new System.Drawing.Point(11, 126);
            this.AllSemRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllSemRadioButton.Name = "AllSemRadioButton";
            this.AllSemRadioButton.Size = new System.Drawing.Size(84, 20);
            this.AllSemRadioButton.TabIndex = 13;
            this.AllSemRadioButton.TabStop = true;
            this.AllSemRadioButton.Text = "Для всех";
            this.AllSemRadioButton.UseVisualStyleBackColor = true;
            // 
            // newPropValueTextBox
            // 
            this.newPropValueTextBox.Location = new System.Drawing.Point(169, 94);
            this.newPropValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPropValueTextBox.Name = "newPropValueTextBox";
            this.newPropValueTextBox.Size = new System.Drawing.Size(132, 22);
            this.newPropValueTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Значение";
            // 
            // newPropNameTextBox
            // 
            this.newPropNameTextBox.Location = new System.Drawing.Point(11, 94);
            this.newPropNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPropNameTextBox.Name = "newPropNameTextBox";
            this.newPropNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.newPropNameTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Свойство";
            // 
            // neededPropGrid
            // 
            this.neededPropGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.neededPropGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.neededPropGrid.Location = new System.Drawing.Point(734, 59);
            this.neededPropGrid.Margin = new System.Windows.Forms.Padding(4);
            this.neededPropGrid.Name = "neededPropGrid";
            this.neededPropGrid.RowHeadersWidth = 51;
            this.neededPropGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.neededPropGrid.Size = new System.Drawing.Size(320, 185);
            this.neededPropGrid.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PropertyMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.neededPropGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semPropGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosenPropsList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "PropertyMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.semPropGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neededPropGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox choosenPropsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView semPropGrid;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sharedObjectNames;
        private System.Windows.Forms.DataGridView neededPropGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}