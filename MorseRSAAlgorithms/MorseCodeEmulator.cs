using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class MorseCodeEmulator : Form
    {
        static Dictionary<char, string> morseTranslator;
        public MorseCodeEmulator()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            DictionaryLoad();
            EncryptInputForTranslator(encryptInput.Text);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            DecryptInputForTranslator(decryptInput.Text);
        }
        private static void DictionaryLoad() 
        {
            char dot = '.';
            char dash = '-';

            morseTranslator = new Dictionary<char, string>();
            {
                morseTranslator = new Dictionary<char, string>()
                {
                    {'a', string.Concat(dot, dash)},
                    {'b', string.Concat(dash, dot, dot, dot)},
                    {'c', string.Concat(dash, dot, dash, dot)},
                    {'d', string.Concat(dash, dot, dot)},
                    {'e', dot.ToString()},
                    {'f', string.Concat(dot, dot, dash, dot)},
                    {'g', string.Concat(dash, dash, dot)},
                    {'h', string.Concat(dot, dot, dot, dot)},
                    {'i', string.Concat(dot, dot)},
                    {'j', string.Concat(dot, dash, dash, dash)},
                    {'k', string.Concat(dash, dot, dash)},
                    {'l', string.Concat(dot, dash, dot, dot)},
                    {'m', string.Concat(dash, dash)},
                    {'n', string.Concat(dash, dot)},
                    {'o', string.Concat(dash, dash, dash)},
                    {'p', string.Concat(dot, dash, dash, dot)},
                    {'q', string.Concat(dash, dash, dot, dash)},
                    {'r', string.Concat(dot, dash, dot)},
                    {'s', string.Concat(dot, dot, dot)},
                    {'t', string.Concat(dash)},
                    {'u', string.Concat(dot, dot, dash)},
                    {'v', string.Concat(dot, dot, dot, dash)},
                    {'w', string.Concat(dot, dash, dash)},
                    {'x', string.Concat(dash, dot, dot, dash)},
                    {'y', string.Concat(dash, dot, dash, dash)},
                    {'z', string.Concat(dash, dash, dot, dot)},
                    {'0', string.Concat(dash, dash, dash, dash, dash)},
                    {'1', string.Concat(dot, dash, dash, dash, dash)},
                    {'2', string.Concat(dot, dot, dash, dash, dash)},
                    {'3', string.Concat(dot, dot, dot, dash, dash)},
                    {'4', string.Concat(dot, dot, dot, dot, dash)},
                    {'5', string.Concat(dot, dot, dot, dot, dot)},
                    {'6', string.Concat(dash, dot, dot, dot, dot)},
                    {'7', string.Concat(dash, dash, dot, dot, dot)},
                    {'8', string.Concat(dash, dash, dash, dot, dot)},
                    {'9', string.Concat(dash, dash, dash, dash, dot)}
                };
            }
            
        }
        private string EncryptInputForTranslator(string result) 
        {
            string eInput = encryptInput.Text.ToLower();
            result = EncryptionMethod(eInput);
            encryptOutput.Text = result;

            return result;
        }
        private string EncryptionMethod(string eInput) 
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char character in eInput)
            {
                if (morseTranslator.ContainsKey(character))
                {
                    sb.Append(morseTranslator[character] + " ");
                }
                else if (character == ' ')
                {
                    sb.Append("/ ");
                }
                else
                {
                    sb.Append(character + " ");
                }
            }
            return sb.ToString();
        }
        private string DecryptInputForTranslator(string result) 
        {
            string dInput = decryptInput.Text.ToLower();
            result = DecryptionMethod(dInput);
            decryptOutput.Text = result;

            return result;
        }
        private string DecryptionMethod(string dInput) 
        {
            string result = "";
            string[] dArr = dInput.Split(' ');
            string alphabetChars = "abcdefghijklmnopqrstuvwxyz123456789";
            string[] morseChars = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
                                    "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                                    "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----"};

            foreach (string morseChar in dArr) 
            {
                char alphabetChar = ' ';
                int index = Array.IndexOf(morseChars, morseChar);
                if (index >= 0) // character was found
                    alphabetChar = alphabetChars[index];
                result += alphabetChar;
            }
            return result;
        }

        private void encryptImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                encryptImportDialog.ShowDialog();
                encryptInput.Text = File.ReadAllText(encryptImportDialog.FileName);
            }
            catch { }         
        }

        private void decodeImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                decryptImportDialog.ShowDialog();
                decryptInput.Text = File.ReadAllText(decryptImportDialog.FileName);
            }
            catch { }            
        }
    }
}
