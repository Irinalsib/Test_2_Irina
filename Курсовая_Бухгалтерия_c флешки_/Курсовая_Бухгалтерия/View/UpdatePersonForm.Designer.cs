namespace Курсовая_Бухгалтерия.View
{
    partial class UpdatePersonForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelInfoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.UpdatePersonButton = new System.Windows.Forms.Button();
            this.BirthDayLabel = new System.Windows.Forms.Label();
            this.PersonBirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.PersonSalaryTextBox = new System.Windows.Forms.TextBox();
            this.PersonJobPosTextBox = new System.Windows.Forms.TextBox();
            this.PersonSurNameTextBox = new System.Windows.Forms.TextBox();
            this.PersonNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.PanelInfoLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 57);
            this.panel1.TabIndex = 1;
            // 
            // PanelInfoLabel
            // 
            this.PanelInfoLabel.AutoSize = true;
            this.PanelInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelInfoLabel.ForeColor = System.Drawing.Color.Snow;
            this.PanelInfoLabel.Location = new System.Drawing.Point(7, 9);
            this.PanelInfoLabel.Name = "PanelInfoLabel";
            this.PanelInfoLabel.Size = new System.Drawing.Size(345, 29);
            this.PanelInfoLabel.TabIndex = 0;
            this.PanelInfoLabel.Text = "Редактирование сотрудника";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.CloseWindowButton);
            this.panel2.Controls.Add(this.UpdatePersonButton);
            this.panel2.Controls.Add(this.BirthDayLabel);
            this.panel2.Controls.Add(this.PersonBirthDayPicker);
            this.panel2.Controls.Add(this.PersonSalaryTextBox);
            this.panel2.Controls.Add(this.PersonJobPosTextBox);
            this.panel2.Controls.Add(this.PersonSurNameTextBox);
            this.panel2.Controls.Add(this.PersonNameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 393);
            this.panel2.TabIndex = 2;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.AutoSize = true;
            this.CloseWindowButton.BackColor = System.Drawing.Color.Plum;
            this.CloseWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CloseWindowButton.Location = new System.Drawing.Point(73, 239);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(216, 41);
            this.CloseWindowButton.TabIndex = 8;
            this.CloseWindowButton.Text = "Закрыть окно";
            this.CloseWindowButton.UseVisualStyleBackColor = false;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // UpdatePersonButton
            // 
            this.UpdatePersonButton.AutoSize = true;
            this.UpdatePersonButton.BackColor = System.Drawing.Color.Plum;
            this.UpdatePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdatePersonButton.Location = new System.Drawing.Point(73, 192);
            this.UpdatePersonButton.Name = "UpdatePersonButton";
            this.UpdatePersonButton.Size = new System.Drawing.Size(216, 41);
            this.UpdatePersonButton.TabIndex = 7;
            this.UpdatePersonButton.Text = "Изменить сотрудника";
            this.UpdatePersonButton.UseVisualStyleBackColor = false;
            this.UpdatePersonButton.Click += new System.EventHandler(this.UpdatePersonButton_Click);
            // 
            // BirthDayLabel
            // 
            this.BirthDayLabel.AutoSize = true;
            this.BirthDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDayLabel.ForeColor = System.Drawing.Color.Snow;
            this.BirthDayLabel.Location = new System.Drawing.Point(116, 134);
            this.BirthDayLabel.Name = "BirthDayLabel";
            this.BirthDayLabel.Size = new System.Drawing.Size(128, 20);
            this.BirthDayLabel.TabIndex = 5;
            this.BirthDayLabel.Text = "Дата рождения";
            // 
            // PersonBirthDayPicker
            // 
            this.PersonBirthDayPicker.Location = new System.Drawing.Point(12, 157);
            this.PersonBirthDayPicker.Name = "PersonBirthDayPicker";
            this.PersonBirthDayPicker.Size = new System.Drawing.Size(338, 20);
            this.PersonBirthDayPicker.TabIndex = 4;
            // 
            // PersonSalaryTextBox
            // 
            this.PersonSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonSalaryTextBox.Location = new System.Drawing.Point(12, 102);
            this.PersonSalaryTextBox.Multiline = true;
            this.PersonSalaryTextBox.Name = "PersonSalaryTextBox";
            this.PersonSalaryTextBox.Size = new System.Drawing.Size(338, 26);
            this.PersonSalaryTextBox.TabIndex = 3;
            this.PersonSalaryTextBox.Text = "Зарплата сотрудника";
            this.PersonSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PersonSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonSalaryTextBox_KeyPress);
            // 
            // PersonJobPosTextBox
            // 
            this.PersonJobPosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonJobPosTextBox.Location = new System.Drawing.Point(12, 70);
            this.PersonJobPosTextBox.Multiline = true;
            this.PersonJobPosTextBox.Name = "PersonJobPosTextBox";
            this.PersonJobPosTextBox.Size = new System.Drawing.Size(338, 26);
            this.PersonJobPosTextBox.TabIndex = 2;
            this.PersonJobPosTextBox.Text = "Должность сотрудника";
            this.PersonJobPosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonSurNameTextBox
            // 
            this.PersonSurNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonSurNameTextBox.Location = new System.Drawing.Point(12, 38);
            this.PersonSurNameTextBox.Multiline = true;
            this.PersonSurNameTextBox.Name = "PersonSurNameTextBox";
            this.PersonSurNameTextBox.Size = new System.Drawing.Size(338, 26);
            this.PersonSurNameTextBox.TabIndex = 1;
            this.PersonSurNameTextBox.Text = "Фамилия сотрудника";
            this.PersonSurNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PersonNameTextBox
            // 
            this.PersonNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonNameTextBox.Location = new System.Drawing.Point(12, 6);
            this.PersonNameTextBox.Multiline = true;
            this.PersonNameTextBox.Name = "PersonNameTextBox";
            this.PersonNameTextBox.Size = new System.Drawing.Size(338, 26);
            this.PersonNameTextBox.TabIndex = 0;
            this.PersonNameTextBox.Text = "Имя сотрудника";
            this.PersonNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdatePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePersonForm";
            this.Text = "UpdatePersonForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PanelInfoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button UpdatePersonButton;
        private System.Windows.Forms.Label BirthDayLabel;
        private System.Windows.Forms.DateTimePicker PersonBirthDayPicker;
        private System.Windows.Forms.TextBox PersonSalaryTextBox;
        private System.Windows.Forms.TextBox PersonJobPosTextBox;
        private System.Windows.Forms.TextBox PersonSurNameTextBox;
        private System.Windows.Forms.TextBox PersonNameTextBox;
    }
}