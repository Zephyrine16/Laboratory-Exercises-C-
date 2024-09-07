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
        // Constructor
        public Form1()
        {
            InitializeComponent(); // Initialise form components.
            rand = new Random(); // Instantiate random object for random number generation.
        }

        Random rand; // Random number generator.
        string[] words = // Array of words to be guessed.
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

        string word; // Current word to be guessed.
        int word_order; // Index of the curent word in the array

        // Method to load a new word.
        public void load_word()
        {
            if (word_order < words.Length)
            {

                // Capitalise the word.
                word = words[word_order].ToUpper();
                int word_length = word.Length;
                StringBuilder maskedWord = new StringBuilder(word_length); // Build the masked word.
                int mask = word_length / 2; // Number of leters to mask.
                ArrayList letter_mask = new ArrayList(); // To store indices of masked letters.

                // Randomly select indices to mask
                for (int i = 0; i < mask; i++)
                {
                    bool can_loop = true;
                    do
                    {
                        int rand_num = rand.Next(word_length); // Generate random index.
                        if (!letter_mask.Contains(rand_num)) // Ensure index is not already in use.
                        {
                            letter_mask.Add(rand_num); // Add index to mask list.
                            can_loop = false;

                        }
                    } while (can_loop);
                }

                // Build the masked word.
                for (int i = 0; i < word_length; i++)
                {
                    if (letter_mask.Contains(i))
                    {
                        maskedWord.Append("?"); // If index is in mask list, add "?".
                    }
                    else
                    {
                        maskedWord.Append(word[i]); // Otherwise add the actual letter.
                    }
                }

                random_word.Text = maskedWord.ToString(); // Display the masked word.

            }
            else
            {
                refresh_words(); // Shuffle words array
                load_word(); // Load a new word.
            }
        }

        // Method to shuffle words and reset word order.
        public void refresh_words()
        {
            words = words.OrderBy(x => rand.Next()).ToArray(); // Shuffle words array.
            word_order = 0; // Reset word order.
        }

        private void tb_guess_Click(object sender, EventArgs e)
        {

        }

        // Method for form load.
        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random(); // Reinitialise random number generator.

            refresh_words(); // Shuffle words and reset.
            load_word(); // Load the first word.
        }

        private void tb_guess_Click_1(object sender, EventArgs e)
        {
            if (Guess_box.Text.Equals("Play again"))
            {
                word_order++; // Move to the next word.
                load_word(); // Load the new word.
                Guess_box.Text = "Guess"; // Change button text back to "Guess".
                wrong_guessed_list.Items.Clear(); // Clear previous guesses.
            }

            if (!answer_box.Text.Equals(""))
            {
                if (answer_box.Text.ToUpper().Equals(word))
                {
                    random_word.Text = word; // Reveal the correct word.
                    Guess_box.Text = "Play again"; // Change button text to "Play again".

                    MessageBox.Show("Correct guess"); // Correct guess.
                }
                else
                {
                    wrong_guessed_list.Items.Add(answer_box.Text); // Add wrong guess to the list.

                    MessageBox.Show("Wrong guess"); // Wrong guess.
                }
                answer_box.Text = " "; // Erase the answer box.
            }
        }
    }
}
