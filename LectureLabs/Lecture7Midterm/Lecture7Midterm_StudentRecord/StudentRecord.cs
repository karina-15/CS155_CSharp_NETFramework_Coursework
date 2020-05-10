using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Midterm_StudentRecord
{
    class StudentRecord
    {
        private int[] quizzes;
        private int midterm;
        private int final;

        /**
         * Constructor
         */
        public StudentRecord(int[] quizzes, int midterm, int final)
        {
            this.quizzes = new int[3];
            for (int i = 0; i < quizzes.Length; i++)
            {
                this.quizzes[i] = quizzes[i];
            }
            this.midterm = midterm;
            this.final = final;
        }

        /**
         * OverallGrade()
         */
        public double OverallGrade()
        {
            double scoreQuizzes = 0.0;

            for (int i = 0; i < quizzes.Length; i++)
            {
                scoreQuizzes += quizzes[i];
            }
            scoreQuizzes = (scoreQuizzes / 30) * 0.25;
            double scoreMidterm = (GetMidterm() / 100.0) * 0.35;
            double scoreFinal = (GetFinal() / 100.0) * 0.40;
            double totalScores = (scoreQuizzes + scoreMidterm + scoreFinal) * 100;
            return totalScores;
        }

        /**
         * GetQuizzes()
         */
        public int[] GetQuizzes()
        {
            int[] quizArr = new int[quizzes.Length];
            for (int i = 0; i < quizzes.Length; i++)
            {
                quizArr[i] = quizzes[i];
            }
            return quizArr;
        }

        /**
         * SetQuizzes(int[] quizzes)
         */
        public void SetQuizzes(int[] quizzes)
        {
            for (int i = 0; i < quizzes.Length; i++)
            {
                this.quizzes[i] = quizzes[i];
            }
        }

        /**
         * GetMidterm()
         */
        public int GetMidterm()
        {
            return midterm;
        }

        /**
         * SetMidterm(int midterm)
         */
        public void SetMidterm(int midterm)
        {
            this.midterm = midterm;
        }

        /**
         * GetFinal()
         */
        public int GetFinal()
        {
            return final;
        }

        /**
         * SetFinal(int final)
         */
        public void SetFinal(int final)
        {
            this.final = final;
        }

        public char LetterGrade()
        {
            if (OverallGrade() >= 90)
            {
                return 'A';
            }
            else if (OverallGrade() >= 80)
            {
                return 'B';
            }
            else if (OverallGrade() >= 70)
            {
                return 'C';
            }
            else if (OverallGrade() >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        /**
         * Equals()
         */
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            StudentRecord s = (StudentRecord)obj;
            return quizzes.Equals(s.quizzes) && midterm.Equals(s.midterm) && final.Equals(s.final);
        }

        /**
         * ToString()
         */
        public override string ToString()
        {
            return String.Format("Overall score: {0:F2}%\nLetter Grade: {1}", OverallGrade(), LetterGrade());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
