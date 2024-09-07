using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelimsTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        Random rand;
        string[] words =
        {
        "computer",
        "science",
        "sti",
        "information",
        "dasmarinas",
        "second",
        "visual",
        "studio"
        };

        string word;
        int word_order;

        public void load_word()
        {
            if (word_order < words.Length)
            {

                word = words[word_order].ToUpper();
                int word_length = word.Length;
                StringBuilder maskedWord = new StringBuilder(word_length);
                int mask = word_length / 2;
                ArrayList letter_mask = new ArrayList();

                for (int i = 0; i < mask; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rand.Next(word_length);
                        if (!letter_mask.Contains(rand_num))
                        {
                            letter_mask.Add(rand_num);
                            can_loop = false;

                        }
                    } while (can_loop);
                }

                for (int i = 0; i < word_length; i++)
                {
                    if (letter_mask.Contains(i))
                    {
                        maskedWord.Append("?");
                    }
                    else
                    {
                        maskedWord.Append(word[i]);
                    }
                }

                random_word.Text = maskedWord.ToString();

            }
            else
            {
                refresh_words();
                load_word();
            }
        }
        public void refresh_words()
        {
            words = words.OrderBy(x => rand.Next()).ToArray();
            word_order = 0;
        }

        private void tb_guess_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();

            refresh_words();
            load_word();
        }

        private void tb_guess_Click_1(object sender, EventArgs e)
        {
            if (Guess_box.Text.Equals("Play again"))
            {
                word_order++;
                load_word();
                Guess_box.Text = "Guess";
                wrong_guessed_list.Items.Clear();
            }

            if (!answer_box.Text.Equals(""))
            {
                if (answer_box.Text.ToUpper().Equals(word))
                {
                    random_word.Text = word;
                    Guess_box.Text = "Play again";

                    MessageBox.Show("Correct guess");
                }
                else
                {
                    wrong_guessed_list.Items.Add(answer_box.Text);

                    MessageBox.Show("Wrong guess");
                }
                answer_box.Text = " ";
            }
        }
    }
}