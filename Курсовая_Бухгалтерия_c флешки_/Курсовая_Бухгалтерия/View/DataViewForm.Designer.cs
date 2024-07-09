namespace Курсовая_Бухгалтерия
{
    partial class DataViewForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.OpenRegistryButton = new System.Windows.Forms.Button();
            this.ControlInfoLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.RegistryGridView = new System.Windows.Forms.DataGridView();
            this.ControlsPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.Indigo;
            this.ControlsPanel.Controls.Add(this.OpenRegistryButton);
            this.ControlsPanel.Controls.Add(this.ControlInfoLabel);
            this.ControlsPanel.Controls.Add(this.DeleteButton);
            this.ControlsPanel.Controls.Add(this.UpdateButton);
            this.ControlsPanel.Controls.Add(this.CreateButton);
            this.ControlsPanel.Controls.Add(this.MainMenuButton);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(225, 515);
            this.ControlsPanel.TabIndex = 0;
            // 
            // OpenRegistryButton
            // 
            this.OpenRegistryButton.AutoSize = true;
            this.OpenRegistryButton.BackColor = System.Drawing.Color.Violet;
            this.OpenRegistryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OpenRegistryButton.Location = new System.Drawing.Point(4, 237);
            this.OpenRegistryButton.Name = "OpenRegistryButton";
            this.OpenRegistryButton.Size = new System.Drawing.Size(216, 41);
            this.OpenRegistryButton.TabIndex = 10;
            this.OpenRegistryButton.Text = "Открыть ведомость";
            this.OpenRegistryButton.UseVisualStyleBackColor = false;
            this.OpenRegistryButton.Click += new System.EventHandler(this.OpenRegistryButton_Click);
            // 
            // ControlInfoLabel
            // 
            this.ControlInfoLabel.AutoSize = true;
            this.ControlInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlInfoLabel.ForeColor = System.Drawing.Color.Snow;
            this.ControlInfoLabel.Location = new System.Drawing.Point(3, 9);
            this.ControlInfoLabel.Name = "ControlInfoLabel";
            this.ControlInfoLabel.Size = new System.Drawing.Size(184, 37);
            this.ControlInfoLabel.TabIndex = 9;
            this.ControlInfoLabel.Text = "Управление";
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Plum;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteButton.Location = new System.Drawing.Point(3, 190);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(216, 41);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить сотрудника";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.Color.Plum;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateButton.Location = new System.Drawing.Point(3, 143);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(216, 41);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Редактировать сотрудника";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.BackColor = System.Drawing.Color.Plum;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateButton.Location = new System.Drawing.Point(3, 96);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(216, 41);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Создать сотрудника";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.AutoSize = true;
            this.MainMenuButton.BackColor = System.Drawing.Color.Plum;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuButton.Location = new System.Drawing.Point(3, 49);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(216, 41);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Главное меню";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click_1);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.DarkOrchid;
            this.ContentPanel.Controls.Add(this.RegistryGridView);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(225, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(592, 515);
            this.ContentPanel.TabIndex = 1;
            // 
            // RegistryGridView
            // 
            this.RegistryGridView.AllowUserToAddRows = false;
            this.RegistryGridView.AllowUserToDeleteRows = false;
            this.RegistryGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.RegistryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistryGridView.Location = new System.Drawing.Point(6, 9);
            this.RegistryGridView.Name = "RegistryGridView";
            this.RegistryGridView.ReadOnly = true;
            this.RegistryGridView.Size = new System.Drawing.Size(574, 494);
            this.RegistryGridView.TabIndex = 0;
            this.RegistryGridView.SelectionChanged += new System.EventHandler(this.RegistryGridView_SelectionChanged);
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(817, 515);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ControlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataViewForm";
            this.Text = "Расчет итоговых значений";
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegistryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label ControlInfoLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.DataGridView RegistryGridView;
        private System.Windows.Forms.Button OpenRegistryButton;
    }
}

