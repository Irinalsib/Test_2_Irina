namespace Курсовая_Бухгалтерия.View
{
    partial class RegisterForm
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
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.ControlInfoLabel = new System.Windows.Forms.Label();
            this.CreateExcelReportButton = new System.Windows.Forms.Button();
            this.CreateReportButton = new System.Windows.Forms.Button();
            this.DataViewButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryDateLabel = new System.Windows.Forms.Label();
            this.SalaryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmployeesCountLabel = new System.Windows.Forms.Label();
            this.RegisterDataGrid = new System.Windows.Forms.DataGridView();
            this.CreateRegisterButton = new System.Windows.Forms.Button();
            this.BestWorkerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BestWorkerLabel = new System.Windows.Forms.Label();
            this.BonusSalaryTextBox = new System.Windows.Forms.TextBox();
            this.ControlsPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.Indigo;
            this.ControlsPanel.Controls.Add(this.ControlInfoLabel);
            this.ControlsPanel.Controls.Add(this.CreateExcelReportButton);
            this.ControlsPanel.Controls.Add(this.CreateReportButton);
            this.ControlsPanel.Controls.Add(this.DataViewButton);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(225, 519);
            this.ControlsPanel.TabIndex = 1;
            // 
            // ControlInfoLabel
            // 
            this.ControlInfoLabel.AutoSize = true;
            this.ControlInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlInfoLabel.ForeColor = System.Drawing.Color.Snow;
            this.ControlInfoLabel.Location = new System.Drawing.Point(3, 9);
            this.ControlInfoLabel.Name = "ControlInfoLabel";
            this.ControlInfoLabel.Size = new System.Drawing.Size(175, 37);
            this.ControlInfoLabel.TabIndex = 9;
            this.ControlInfoLabel.Text = "Ведомость";
            // 
            // CreateExcelReportButton
            // 
            this.CreateExcelReportButton.AutoSize = true;
            this.CreateExcelReportButton.BackColor = System.Drawing.Color.Plum;
            this.CreateExcelReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateExcelReportButton.Location = new System.Drawing.Point(3, 143);
            this.CreateExcelReportButton.Name = "CreateExcelReportButton";
            this.CreateExcelReportButton.Size = new System.Drawing.Size(216, 41);
            this.CreateExcelReportButton.TabIndex = 7;
            this.CreateExcelReportButton.Text = "Создать отчёт в excel";
            this.CreateExcelReportButton.UseVisualStyleBackColor = false;
            this.CreateExcelReportButton.Click += new System.EventHandler(this.CreateExcelReportButton_Click);
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.AutoSize = true;
            this.CreateReportButton.BackColor = System.Drawing.Color.Plum;
            this.CreateReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateReportButton.Location = new System.Drawing.Point(3, 96);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.Size = new System.Drawing.Size(216, 41);
            this.CreateReportButton.TabIndex = 6;
            this.CreateReportButton.Text = "Создать отчёт в .txt";
            this.CreateReportButton.UseVisualStyleBackColor = false;
            this.CreateReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // DataViewButton
            // 
            this.DataViewButton.AutoSize = true;
            this.DataViewButton.BackColor = System.Drawing.Color.Plum;
            this.DataViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DataViewButton.Location = new System.Drawing.Point(3, 49);
            this.DataViewButton.Name = "DataViewButton";
            this.DataViewButton.Size = new System.Drawing.Size(216, 41);
            this.DataViewButton.TabIndex = 5;
            this.DataViewButton.Text = "Вернуться в бухгалтерию";
            this.DataViewButton.UseVisualStyleBackColor = false;
            this.DataViewButton.Click += new System.EventHandler(this.DataViewButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.DarkOrchid;
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.SalaryDateLabel);
            this.ContentPanel.Controls.Add(this.SalaryDatePicker);
            this.ContentPanel.Controls.Add(this.EmployeesCountLabel);
            this.ContentPanel.Controls.Add(this.RegisterDataGrid);
            this.ContentPanel.Controls.Add(this.CreateRegisterButton);
            this.ContentPanel.Controls.Add(this.BestWorkerRichTextBox);
            this.ContentPanel.Controls.Add(this.BestWorkerLabel);
            this.ContentPanel.Controls.Add(this.BonusSalaryTextBox);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(225, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(596, 519);
            this.ContentPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Среднее значения оклада:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // SalaryDateLabel
            // 
            this.SalaryDateLabel.AutoSize = true;
            this.SalaryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryDateLabel.ForeColor = System.Drawing.Color.Snow;
            this.SalaryDateLabel.Location = new System.Drawing.Point(15, 73);
            this.SalaryDateLabel.Name = "SalaryDateLabel";
            this.SalaryDateLabel.Size = new System.Drawing.Size(110, 17);
            this.SalaryDateLabel.TabIndex = 14;
            this.SalaryDateLabel.Text = "Дата зарплаты";
            // 
            // SalaryDatePicker
            // 
            this.SalaryDatePicker.Location = new System.Drawing.Point(18, 96);
            this.SalaryDatePicker.Name = "SalaryDatePicker";
            this.SalaryDatePicker.Size = new System.Drawing.Size(200, 20);
            this.SalaryDatePicker.TabIndex = 13;
            // 
            // EmployeesCountLabel
            // 
            this.EmployeesCountLabel.AutoSize = true;
            this.EmployeesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeesCountLabel.ForeColor = System.Drawing.Color.Snow;
            this.EmployeesCountLabel.Location = new System.Drawing.Point(6, 177);
            this.EmployeesCountLabel.Name = "EmployeesCountLabel";
            this.EmployeesCountLabel.Size = new System.Drawing.Size(181, 17);
            this.EmployeesCountLabel.TabIndex = 12;
            this.EmployeesCountLabel.Text = "Количество сотрудников: ";
            // 
            // RegisterDataGrid
            // 
            this.RegisterDataGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.RegisterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisterDataGrid.Location = new System.Drawing.Point(6, 197);
            this.RegisterDataGrid.Name = "RegisterDataGrid";
            this.RegisterDataGrid.Size = new System.Drawing.Size(578, 319);
            this.RegisterDataGrid.TabIndex = 11;
            // 
            // CreateRegisterButton
            // 
            this.CreateRegisterButton.AutoSize = true;
            this.CreateRegisterButton.BackColor = System.Drawing.Color.Plum;
            this.CreateRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateRegisterButton.Location = new System.Drawing.Point(18, 122);
            this.CreateRegisterButton.Name = "CreateRegisterButton";
            this.CreateRegisterButton.Size = new System.Drawing.Size(162, 30);
            this.CreateRegisterButton.TabIndex = 10;
            this.CreateRegisterButton.Text = "Создать ведомость";
            this.CreateRegisterButton.UseVisualStyleBackColor = false;
            this.CreateRegisterButton.Click += new System.EventHandler(this.CreateRegisterButton_Click);
            // 
            // BestWorkerRichTextBox
            // 
            this.BestWorkerRichTextBox.Location = new System.Drawing.Point(400, 54);
            this.BestWorkerRichTextBox.Name = "BestWorkerRichTextBox";
            this.BestWorkerRichTextBox.Size = new System.Drawing.Size(184, 137);
            this.BestWorkerRichTextBox.TabIndex = 3;
            this.BestWorkerRichTextBox.Text = "";
            // 
            // BestWorkerLabel
            // 
            this.BestWorkerLabel.AutoSize = true;
            this.BestWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestWorkerLabel.ForeColor = System.Drawing.Color.Snow;
            this.BestWorkerLabel.Location = new System.Drawing.Point(372, 29);
            this.BestWorkerLabel.Name = "BestWorkerLabel";
            this.BestWorkerLabel.Size = new System.Drawing.Size(212, 17);
            this.BestWorkerLabel.TabIndex = 2;
            this.BestWorkerLabel.Text = "Сотрудник с большим окладом";
            // 
            // BonusSalaryTextBox
            // 
            this.BonusSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BonusSalaryTextBox.Location = new System.Drawing.Point(18, 37);
            this.BonusSalaryTextBox.Multiline = true;
            this.BonusSalaryTextBox.Name = "BonusSalaryTextBox";
            this.BonusSalaryTextBox.Size = new System.Drawing.Size(184, 30);
            this.BonusSalaryTextBox.TabIndex = 0;
            this.BonusSalaryTextBox.Text = "Размер премии";
            this.BonusSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BonusSalaryTextBox.Click += new System.EventHandler(this.BonusSalaryTextBox_Click);
            this.BonusSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BonusSalaryTextBox_KeyPress);
            this.BonusSalaryTextBox.Leave += new System.EventHandler(this.BonusSalaryTextBox_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 519);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ControlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Label ControlInfoLabel;
        private System.Windows.Forms.Button CreateExcelReportButton;
        private System.Windows.Forms.Button CreateReportButton;
        private System.Windows.Forms.Button DataViewButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TextBox BonusSalaryTextBox;
        private System.Windows.Forms.RichTextBox BestWorkerRichTextBox;
        private System.Windows.Forms.Label BestWorkerLabel;
        private System.Windows.Forms.DataGridView RegisterDataGrid;
        private System.Windows.Forms.Button CreateRegisterButton;
        private System.Windows.Forms.Label EmployeesCountLabel;
        private System.Windows.Forms.DateTimePicker SalaryDatePicker;
        private System.Windows.Forms.Label SalaryDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}