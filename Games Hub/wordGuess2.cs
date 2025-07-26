using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Games_Hub
{

    public partial class wordGuess2 : Form
    {
        int score = 0, TryCount = 3, id = 0;

        string ans, WordToFind;
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            menuform menu1 = new menuform();
            menu1.Show();
        }

        private void Retrybutton1_Click(object sender, EventArgs e)
        {
            score = 0;
            TryCount = 3;
            Enterbutton1.Visible = true;
            AnswerTextBox.Clear();
            Form2_Load(this, null);
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            Enterbutton1.Visible = true;
            AnswerTextBox.Clear();
            Form2_Load(this, null);
        }


        private void Enterbutton1_Click(object sender, EventArgs e)
        {
            ans = AnswerTextBox.Text;
            if (TryCount != 0)
            {
                if (ans == WordToFind)
                {

                    highScorelabel.Text = "high Score : " + scoresTableAdapter.GetWordScore(id);
                    MessageBox.Show("Correct");
                    score++;
                    TryCount = 3;
                    Scorelabel2.Text = score.ToString();
                    trylabel3.Text = TryCount.ToString();
                    Nextbutton.Visible = true;
                    Enterbutton1.Visible = false;
                }
                else
                {
                    TryCount--;
                    MessageBox.Show("Wrong, Try again!");
                    trylabel3.Text = TryCount.ToString();
                    Showlabel.Text = "";
                        for (int k = 0; k < WordToFind.Length; k++)
                        {
                            if (k == 0)
                                Showlabel.Text += WordToFind[k];
                            else
                            {
                                if (k % 2 == 1)
                                    Showlabel.Text += WordToFind[k];
                                else
                                    Showlabel.Text += "-";
                            }
                        }
                    if (TryCount == 3)
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        TrypictureBox3.Visible = false;
                    }
                    else if (TryCount == 2)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        TrypictureBox3.Visible = false;
                    }
                    else if (TryCount == 1)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox4.Visible = true;
                    }
                    else
                    {
                        if (scoresTableAdapter.GetFlappyScore(id) < score)
                        {
                            highScorelabel.Text = "high Score :" + score.ToString();
                        }
                        if (scoresTableAdapter.GetWordScore(id) == null)
                        {
                            scoresTableAdapter.InsertQueryScores(id, 0, 0, score, 0);
                        }
                        else if (score > scoresTableAdapter.GetWordScore(id))
                        {
                            scoresTableAdapter.UpdateQueryWordScore(score, id);
                        }
                        highScorelabel.Text = "high Score : " + scoresTableAdapter.GetWordScore(id);
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        TrypictureBox3.Visible = true;
                        pictureBox4.Visible = false;
                        GameOverLabel.Visible = true;
                        MessageBox.Show("Game Over! \n The Word is: "+ WordToFind);
                        Nextbutton.Visible = false;
                        Enterbutton1.Visible = false;
                        Retrybutton1.Visible = true;
                    }
                }
            }
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        public wordGuess2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.database1DataSet.scores);
            // TODO: This line of code loads data into the 'database1DataSet.accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.database1DataSet.accounts);
            id = (int)accountsTableAdapter.GetID(loogInForm.UserName);
            highScorelabel.Text = "high Score : " + scoresTableAdapter.GetWordScore(id);
            int ChooseWord = 0, i = 1;
            GameOverLabel.Visible = false;
            Nextbutton.Visible = false;
            Retrybutton1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            TrypictureBox3.Visible = false;
            pictureBox4.Visible = false;
            Scorelabel2.Text = score.ToString();
            trylabel3.Text = TryCount.ToString();
            Random rand = new Random();
            StreamReader inputFile;
            ChooseWord = rand.Next(0, 3000);

            inputFile = File.OpenText("Word.txt");
            try
            {
                while (inputFile.ReadLine() != null)
                {
                    if (ChooseWord == i)
                    {
                        WordToFind = inputFile.ReadLine();
                        break;
                    }
                    i++;
                }
                inputFile.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
            Showlabel.Text = "";
            for(int k = 0; k < WordToFind.Length; k++)
            {
                if (k % 3 == 0)
                    Showlabel.Text += WordToFind[k];
                else
                {
                    Showlabel.Text += "-";
                }
            }
        }
        private void TextBoxClick(object sender, EventArgs e)
        {
            AnswerTextBox.ForeColor = Color.Black;
            AnswerTextBox.Clear();
        }
    }
}
