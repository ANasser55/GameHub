namespace Games_Hub
{
    partial class loogInForm
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
            this.components = new System.ComponentModel.Container();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.linePanel = new System.Windows.Forms.Panel();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.usernameLoginLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Games_Hub.Database1DataSetTableAdapters.accountsTableAdapter();
            this.tableAdapterManager = new Games_Hub.Database1DataSetTableAdapters.TableAdapterManager();
            this.scoresTableAdapter = new Games_Hub.Database1DataSetTableAdapters.scoresTableAdapter();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginPanel.Controls.Add(this.linePanel);
            this.loginPanel.Controls.Add(this.createAccountLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.usernameText);
            this.loginPanel.Controls.Add(this.passwordLoginLabel);
            this.loginPanel.Controls.Add(this.usernameLoginLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Location = new System.Drawing.Point(217, 96);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(428, 393);
            this.loginPanel.TabIndex = 0;
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.White;
            this.linePanel.Location = new System.Drawing.Point(105, 338);
            this.linePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(215, 2);
            this.linePanel.TabIndex = 4;
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.White;
            this.createAccountLabel.Location = new System.Drawing.Point(129, 350);
            this.createAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(163, 21);
            this.createAccountLabel.TabIndex = 3;
            this.createAccountLabel.Text = "Create new account.";
            this.createAccountLabel.Click += new System.EventHandler(this.createAccountLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(105, 283);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(215, 41);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(105, 234);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(216, 22);
            this.passwordText.TabIndex = 2;
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(105, 149);
            this.usernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(216, 26);
            this.usernameText.TabIndex = 1;
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLoginLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLoginLabel.Location = new System.Drawing.Point(104, 199);
            this.passwordLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(96, 23);
            this.passwordLoginLabel.TabIndex = 0;
            this.passwordLoginLabel.Text = "Password";
            // 
            // usernameLoginLabel
            // 
            this.usernameLoginLabel.AutoSize = true;
            this.usernameLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLoginLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLoginLabel.Location = new System.Drawing.Point(104, 113);
            this.usernameLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLoginLabel.Name = "usernameLoginLabel";
            this.usernameLoginLabel.Size = new System.Drawing.Size(103, 23);
            this.usernameLoginLabel.TabIndex = 0;
            this.usernameLoginLabel.Text = "Username";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(137, 25);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(154, 59);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn2.HeaderText = "userName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountsTableAdapter = this.accountsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.scoresTableAdapter = this.scoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Games_Hub.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // loogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Games_Hub.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 558);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.loogInForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.Label usernameLoginLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Database1DataSetTableAdapters.accountsTableAdapter accountsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.BindingSource scoresBindingSource;
    }
}