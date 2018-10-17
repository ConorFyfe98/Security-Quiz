using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Security
{
    public partial class Main : Form
    {
        String Answer = "";
       public static String FailMessage = "";
        int QuestionID = 1;
        public Main()
        {
            InitializeComponent();
            loadQuestions();
     
        }



        public void questionCount()
        {
            string stmt = "SELECT COUNT(*) FROM Questions";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Security\Security\SecurityDB.mdf; Integrated Security = True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            
            if(QuestionID > count)
            {
                gameOver();
            }

        }

       

        public  String loadQuestions()
        {
            //String Answer="";
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Security\Security\SecurityDB.mdf; Integrated Security = True");
            conn.Open();

           

                String sqlSelectQuery = ("Select * from Questions Where QuestionID ="+QuestionID);
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    questionLabel.Text = (dr["Question"].ToString());
                    optAButton.Text = (dr["optA"].ToString());
                    optBButton.Text = (dr["optB"].ToString());
                    Answer = (dr["Answer"].ToString());
                    


                }
            return Answer;
        }

        public String loadNextQuestion()
        {
            //String Answer="";
            QuestionID = QuestionID + 1;
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Security\Security\SecurityDB.mdf; Integrated Security = True");
            conn.Open();



            String sqlSelectQuery = ("Select * from Questions Where QuestionID ="+QuestionID);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                questionLabel.Text = (dr["Question"].ToString());
                optAButton.Text = (dr["optA"].ToString());
                optBButton.Text = (dr["optB"].ToString());
                Answer = (dr["Answer"].ToString());
            }
            return Answer;
        }

        public void decreaseRepuatation()
        {
            if(reputationBar.Value >= 2){
                reputationBar.Value = reputationBar.Value - 2;
            }else if(reputationBar.Value == 1)
            {
                reputationBar.Value = reputationBar.Value - 1;
            }

            if(reputationBar.Value == 0)
            { 
                FailMessage = "You were fired! You're reputation became too low.";
                gameOver();
            }

        }
        public void increaseRepuatation()
        {
            if (reputationBar.Value <= 5)
            {
                reputationBar.Value = reputationBar.Value + 1;
            }
            else
            {
                reputationBar.Value = reputationBar.Value;
            }

        }

        public void increaseThreat()
        {
            threatBar.Value = threatBar.Value  + 1;
            if(threatBar.Value >=2)
            {
                FailMessage = "You were fired! You let the threat become too high.";
                gameOver();
            }
        }

        public void gameOver()
        {
            this.Hide();
            GameOver gm = new GameOver();
            gm.Show();

        }

        private void optAButton_Click(object sender, EventArgs e)
        {
            if (optAButton.Text == Answer){
                MessageBox.Show("Correct");
                loadNextQuestion();
                increaseRepuatation();
                questionCount();
            }
            else
            {
                MessageBox.Show("Wrong");
                loadNextQuestion();
                decreaseRepuatation();
                increaseThreat();
                questionCount();
            }
        }

        private void optBButton_Click(object sender, EventArgs e)
        {
            if (optBButton.Text == Answer)
            {
                MessageBox.Show("Correct");
                loadNextQuestion();
                increaseRepuatation();
                questionCount();
            }
            else
            {
                MessageBox.Show("Wrong");
                loadNextQuestion();
                decreaseRepuatation();
                increaseThreat();
                questionCount();
            }
        }

        private void threatBar_Click(object sender, EventArgs e)
        {

        }
    }
}
