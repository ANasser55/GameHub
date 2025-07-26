namespace Games_Hub
{
    partial class signUpForm
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
            this.signInPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailSignUp = new System.Windows.Forms.TextBox();
            this.passwordSignUp = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameSignUp = new System.Windows.Forms.TextBox();
            this.passwordSignInLabel = new System.Windows.Forms.Label();
            this.usernamesSignInLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Games_Hub.Database1DataSetTableAdapters.accountsTableAdapter();
            this.tableAdapterManager = new Games_Hub.Database1DataSetTableAdapters.TableAdapterManager();
            this.scoresTableAdapter = new Games_Hub.Database1DataSetTableAdapters.scoresTableAdapter();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signInPanel
            // 
            this.signInPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signInPanel.Controls.Add(this.loginButton);
            this.signInPanel.Controls.Add(this.emailSignUp);
            this.signInPanel.Controls.Add(this.passwordSignUp);
            this.signInPanel.Controls.Add(this.emailLabel);
            this.signInPanel.Controls.Add(this.usernameSignUp);
            this.signInPanel.Controls.Add(this.passwordSignInLabel);
            this.signInPanel.Controls.Add(this.usernamesSignInLabel);
            this.signInPanel.Controls.Add(this.loginLabel);
            this.signInPanel.Location = new System.Drawing.Point(220, 69);
            this.signInPanel.Margin = new System.Windows.Forms.Padding(4);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(417, 417);
            this.signInPanel.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(100, 346);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(215, 41);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Sign up";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailSignUp
            // 
            this.emailSignUp.Location = new System.Drawing.Point(100, 303);
            this.emailSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.emailSignUp.Name = "emailSignUp";
            this.emailSignUp.Size = new System.Drawing.Size(216, 22);
            this.emailSignUp.TabIndex = 3;
            // 
            // passwordSignUp
            // 
            this.passwordSignUp.Location = new System.Drawing.Point(100, 220);
            this.passwordSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.passwordSignUp.Name = "passwordSignUp";
            this.passwordSignUp.PasswordChar = '*';
            this.passwordSignUp.Size = new System.Drawing.Size(216, 22);
            this.passwordSignUp.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(99, 268);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(69, 23);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-Mail";
            // 
            // usernameSignUp
            // 
            this.usernameSignUp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameSignUp.Location = new System.Drawing.Point(100, 135);
            this.usernameSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.usernameSignUp.Name = "usernameSignUp";
            this.usernameSignUp.Size = new System.Drawing.Size(216, 26);
            this.usernameSignUp.TabIndex = 1;
            // 
            // passwordSignInLabel
            // 
            this.passwordSignInLabel.AutoSize = true;
            this.passwordSignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordSignInLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSignInLabel.ForeColor = System.Drawing.Color.White;
            this.passwordSignInLabel.Location = new System.Drawing.Point(99, 186);
            this.passwordSignInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordSignInLabel.Name = "passwordSignInLabel";
            this.passwordSignInLabel.Size = new System.Drawing.Size(100, 23);
            this.passwordSignInLabel.TabIndex = 0;
            this.passwordSignInLabel.Text = "Password";
            // 
            // usernamesSignInLabel
            // 
            this.usernamesSignInLabel.AutoSize = true;
            this.usernamesSignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamesSignInLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamesSignInLabel.ForeColor = System.Drawing.Color.White;
            this.usernamesSignInLabel.Location = new System.Drawing.Point(99, 100);
            this.usernamesSignInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamesSignInLabel.Name = "usernamesSignInLabel";
            this.usernamesSignInLabel.Size = new System.Drawing.Size(108, 23);
            this.usernamesSignInLabel.TabIndex = 0;
            this.usernamesSignInLabel.Text = "Username";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(100, 25);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(203, 59);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Sign up";
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
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Games_Hub.Properties.Resources.game_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 558);
            this.Controls.Add(this.signInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "signUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signInForm";
            this.Load += new System.EventHandler(this.signInForm_Load);
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signInPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox emailSignUp;
        private System.Windows.Forms.TextBox passwordSignUp;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox usernameSignUp;
        private System.Windows.Forms.Label passwordSignInLabel;
        private System.Windows.Forms.Label usernamesSignInLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Database1DataSetTableAdapters.accountsTableAdapter accountsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.BindingSource scoresBindingSource;
    }
}