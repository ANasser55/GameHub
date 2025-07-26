namespace Games_Hub
{
    partial class Flappy_Bird
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.database1DataSet = new Games_Hub.Database1DataSet();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new Games_Hub.Database1DataSetTableAdapters.accountsTableAdapter();
            this.tableAdapterManager = new Games_Hub.Database1DataSetTableAdapters.TableAdapterManager();
            this.scoresTableAdapter = new Games_Hub.Database1DataSetTableAdapters.scoresTableAdapter();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highscorelabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::Games_Hub.Properties.Resources.Bird;
            this.flappyBird.Location = new System.Drawing.Point(179, 186);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(4);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(61, 44);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.Image = global::Games_Hub.Properties.Resources.Pipe_UP;
            this.pipeBottom2.Location = new System.Drawing.Point(623, 363);
            this.pipeBottom2.Margin = new System.Windows.Forms.Padding(4);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(77, 208);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom2.TabIndex = 1;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Image = global::Games_Hub.Properties.Resources.Pipe_Down;
            this.pipeTop2.Location = new System.Drawing.Point(623, -33);
            this.pipeTop2.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(77, 242);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop2.TabIndex = 2;
            this.pipeTop2.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Games_Hub.Properties.Resources.Pipe_Down;
            this.pipeTop.Location = new System.Drawing.Point(52, -33);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(4);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(77, 188);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Games_Hub.Properties.Resources.Ground;
            this.ground.Location = new System.Drawing.Point(-17, 497);
            this.ground.Margin = new System.Windows.Forms.Padding(4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(852, 122);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::Games_Hub.Properties.Resources.Pipe_UP;
            this.pipeBottom.Location = new System.Drawing.Point(52, 304);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(77, 239);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(16, 527);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(99, 29);
            this.scoreText.TabIndex = 3;
            this.scoreText.Text = "score: 0";
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
            this.highscorelabel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.highscorelabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscorelabel1.Location = new System.Drawing.Point(16, 571);
            this.highscorelabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highscorelabel1.Name = "highscorelabel1";
            this.highscorelabel1.Size = new System.Drawing.Size(161, 29);
            this.highscorelabel1.TabIndex = 3;
            this.highscorelabel1.Text = "high Score : 0";
            // 
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Games_Hub.Properties.Resources.flappyBirdBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 615);
            this.Controls.Add(this.highscorelabel1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.flappyBird);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Flappy_Bird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Flappy_Bird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Flappy_Bird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Flappy_Bird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private Database1DataSetTableAdapters.accountsTableAdapter accountsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private System.Windows.Forms.Label highscorelabel1;
    }
}

