namespace Games_Hub
{
    partial class tRex
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.running = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTm = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.database1DataSet = new Games_Hub.Database1DataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Games_Hub.Database1DataSetTableAdapters.accountsTableAdapter();
            this.tableAdapterManager = new Games_Hub.Database1DataSetTableAdapters.TableAdapterManager();
            this.scoresTableAdapter = new Games_Hub.Database1DataSetTableAdapters.scoresTableAdapter();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highscorelabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.running)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Games_Hub.Properties.Resources.obstacle_1;
            this.pictureBox1.Location = new System.Drawing.Point(484, 466);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "obstacle";
            // 
            // running
            // 
            this.running.Image = global::Games_Hub.Properties.Resources.running;
            this.running.Location = new System.Drawing.Point(191, 455);
            this.running.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.running.Name = "running";
            this.running.Size = new System.Drawing.Size(60, 62);
            this.running.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.running.TabIndex = 0;
            this.running.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(-31, 517);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1223, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(16, 11);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(89, 33);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "score: ";
            // 
            // gameTm
            // 
            this.gameTm.Enabled = true;
            this.gameTm.Interval = 20;
            this.gameTm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Games_Hub.Properties.Resources.obstacle_2;
            this.pictureBox5.Location = new System.Drawing.Point(1044, 466);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "obstacle";
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
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "scores";
            this.scoresBindingSource.DataSource = this.database1DataSet;
            // 
            // highscorelabel1
            // 
            this.highscorelabel1.AutoSize = true;
            this.highscorelabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscorelabel1.Location = new System.Drawing.Point(16, 62);
            this.highscorelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highscorelabel1.Name = "highscorelabel1";
            this.highscorelabel1.Size = new System.Drawing.Size(145, 33);
            this.highscorelabel1.TabIndex = 1;
            this.highscorelabel1.Text = "high Score: ";
            // 
            // tRex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 571);
            this.Controls.Add(this.highscorelabel1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.running);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tRex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "obstacle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tRex_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tRex_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tRex_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.running)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox running;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTm;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Database1DataSetTableAdapters.accountsTableAdapter accountsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private System.Windows.Forms.Label highscorelabel1;
    }
}

