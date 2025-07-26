
namespace Games_Hub
{
    partial class wordGuess2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordGuess2));
            this.Enterbutton1 = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.Showlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Scorelabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trylabel3 = new System.Windows.Forms.Label();
            this.highScorelabel = new System.Windows.Forms.Label();
            this.HighScorelabel4 = new System.Windows.Forms.Label();
            this.Retrybutton1 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TrypictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.database1DataSet = new Games_Hub.Database1DataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Games_Hub.Database1DataSetTableAdapters.accountsTableAdapter();
            this.tableAdapterManager = new Games_Hub.Database1DataSetTableAdapters.TableAdapterManager();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresTableAdapter = new Games_Hub.Database1DataSetTableAdapters.scoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrypictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Enterbutton1
            // 
            this.Enterbutton1.BackColor = System.Drawing.Color.SpringGreen;
            this.Enterbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enterbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbutton1.Location = new System.Drawing.Point(102, 370);
            this.Enterbutton1.Name = "Enterbutton1";
            this.Enterbutton1.Size = new System.Drawing.Size(117, 48);
            this.Enterbutton1.TabIndex = 0;
            this.Enterbutton1.Text = "Enter";
            this.Enterbutton1.UseVisualStyleBackColor = false;
            this.Enterbutton1.Click += new System.EventHandler(this.Enterbutton1_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nextbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbutton.Location = new System.Drawing.Point(675, 379);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(106, 48);
            this.Nextbutton.TabIndex = 1;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = false;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AnswerTextBox.Location = new System.Drawing.Point(76, 326);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(170, 31);
            this.AnswerTextBox.TabIndex = 3;
            this.AnswerTextBox.Text = "Guess The Word";
            this.AnswerTextBox.Click += new System.EventHandler(this.TextBoxClick);
            // 
            // Showlabel
            // 
            this.Showlabel.AutoSize = true;
            this.Showlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Showlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showlabel.ForeColor = System.Drawing.SystemColors.Window;
            this.Showlabel.Location = new System.Drawing.Point(134, 297);
            this.Showlabel.Name = "Showlabel";
            this.Showlabel.Size = new System.Drawing.Size(0, 25);
            this.Showlabel.TabIndex = 4;
            this.Showlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score : ";
            // 
            // Scorelabel2
            // 
            this.Scorelabel2.AutoSize = true;
            this.Scorelabel2.BackColor = System.Drawing.Color.Maroon;
            this.Scorelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.Scorelabel2.Location = new System.Drawing.Point(80, 20);
            this.Scorelabel2.Name = "Scorelabel2";
            this.Scorelabel2.Size = new System.Drawing.Size(0, 24);
            this.Scorelabel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tries left :";
            // 
            // trylabel3
            // 
            this.trylabel3.AutoSize = true;
            this.trylabel3.BackColor = System.Drawing.Color.Maroon;
            this.trylabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trylabel3.ForeColor = System.Drawing.SystemColors.Window;
            this.trylabel3.Location = new System.Drawing.Point(127, 98);
            this.trylabel3.Name = "trylabel3";
            this.trylabel3.Size = new System.Drawing.Size(0, 24);
            this.trylabel3.TabIndex = 8;
            // 
            // highScorelabel
            // 
            this.highScorelabel.AutoSize = true;
            this.highScorelabel.BackColor = System.Drawing.Color.Maroon;
            this.highScorelabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScorelabel.ForeColor = System.Drawing.SystemColors.Window;
            this.highScorelabel.Location = new System.Drawing.Point(0, 189);
            this.highScorelabel.Name = "highScorelabel";
            this.highScorelabel.Size = new System.Drawing.Size(133, 23);
            this.highScorelabel.TabIndex = 9;
            this.highScorelabel.Text = "High Score :";
            // 
            // HighScorelabel4
            // 
            this.HighScorelabel4.AutoSize = true;
            this.HighScorelabel4.BackColor = System.Drawing.Color.Maroon;
            this.HighScorelabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScorelabel4.ForeColor = System.Drawing.SystemColors.Window;
            this.HighScorelabel4.Location = new System.Drawing.Point(130, 189);
            this.HighScorelabel4.Name = "HighScorelabel4";
            this.HighScorelabel4.Size = new System.Drawing.Size(0, 24);
            this.HighScorelabel4.TabIndex = 10;
            // 
            // Retrybutton1
            // 
            this.Retrybutton1.BackColor = System.Drawing.Color.Crimson;
            this.Retrybutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Retrybutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrybutton1.Location = new System.Drawing.Point(134, 379);
            this.Retrybutton1.Name = "Retrybutton1";
            this.Retrybutton1.Size = new System.Drawing.Size(117, 48);
            this.Retrybutton1.TabIndex = 11;
            this.Retrybutton1.Text = "Retry";
            this.Retrybutton1.UseVisualStyleBackColor = false;
            this.Retrybutton1.Click += new System.EventHandler(this.Retrybutton1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(10, 379);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(117, 48);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // TrypictureBox3
            // 
            this.TrypictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("TrypictureBox3.Image")));
            this.TrypictureBox3.Location = new System.Drawing.Point(0, 4);
            this.TrypictureBox3.Name = "TrypictureBox3";
            this.TrypictureBox3.Size = new System.Drawing.Size(322, 266);
            this.TrypictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TrypictureBox3.TabIndex = 14;
            this.TrypictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(322, 267);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(266, 455);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-1, 14);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 41);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-1, 89);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(181, 41);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-2, 182);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(182, 41);
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.TrypictureBox3);
            this.groupBox1.Controls.Add(this.Enterbutton1);
            this.groupBox1.Controls.Add(this.Showlabel);
            this.groupBox1.Controls.Add(this.AnswerTextBox);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(313, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(322, 431);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(-1, 279);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(267, 41);
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Maroon;
            this.GameOverLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.GameOverLabel.Location = new System.Drawing.Point(52, 284);
            this.GameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(160, 30);
            this.GameOverLabel.TabIndex = 22;
            this.GameOverLabel.Text = "Game Over !";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "accounts";
            this.accountsBindingSource.DataSource = this.database1DataSet;
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
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "scores";
            this.scoresBindingSource.DataSource = this.database1DataSet;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // wordGuess2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(793, 438);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.trylabel3);
            this.Controls.Add(this.highScorelabel);
            this.Controls.Add(this.Scorelabel2);
            this.Controls.Add(this.HighScorelabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Retrybutton1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wordGuess2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrypictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enterbutton1;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label Showlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Scorelabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trylabel3;
        private System.Windows.Forms.Label highScorelabel;
        private System.Windows.Forms.Label HighScorelabel4;
        private System.Windows.Forms.Button Retrybutton1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox TrypictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label GameOverLabel;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Database1DataSetTableAdapters.accountsTableAdapter accountsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.BindingSource scoresBindingSource;
    }
}