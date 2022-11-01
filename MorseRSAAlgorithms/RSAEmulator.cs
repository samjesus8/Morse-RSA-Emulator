using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class RSAEmulator : Form
    {
        public RSAEmulator()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string[] publicKey = publicKeyBox.Text.Split(',');
            string input = encodeInput.Text; //Plaintext
            char[] inputChar = input.ToCharArray(); //Converting into a char array to read

            int n = int.Parse(publicKey[0]); //The modulus
            int eEncode = int.Parse(publicKey[1]); //Value of e
            int[] asciiValues = new int[inputChar.Length]; //Array to store encrypted values
            for (int i = 0; i < inputChar.Length; i++) 
            {
                int ascii = (int)inputChar[i];
                int temp = (int)Math.Pow(ascii, eEncode); //Performing m^e mod n

                asciiValues[i] = temp % n;

                if (asciiValues[i] < 0)
                {
                    asciiValues[i] = asciiValues[i] / -1; //IF C comes out as negative, will change to positive as ASCII error will produce if its negative
                    encodeOutput.Text = ((char)asciiValues[i]).ToString();
                }
                else 
                {
                    encodeOutput.Text = ((char)asciiValues[i]).ToString();
                }
            }                       
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string[] privateKey = privateKeyBox.Text.Split(',');
            string cInput = decodeInput.Text;
            char[] inputChar = cInput.ToCharArray();

            int n = int.Parse(privateKey[0]); //Modulus
            int d = int.Parse(privateKey[1]); //Value of d
            int c = (int)inputChar[0];

            int temp = (int)Math.Pow(c, d);
            int m = temp % n;

            decodeOutput.Text = ((char)m).ToString();
        }

        private void keyCreateButton_Click(object sender, EventArgs e)
        {
            KeyCreate();
        }

        //ALL METHODS FOR ACCESS KEYS

        private void KeyCreate() 
        {
            //Process
            Random random = new Random(); //Creating the random generator
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int p = primeNumbers[random.Next(primeNumbers.Length)];
            int q = primeNumbers[random.Next(primeNumbers.Length)];

            int n = p * q; //The Modulus
            int totientForN = (p - 1) * (q - 1); //Totient function

            List<int> coprimes = new List<int>(); //Creating list for co-primes
            int count = 2; //Must be 2 as that is the first prime number
            while (count > 1 && count < totientForN) 
            {
                if (coPrimes(totientForN, count) == true) //Finding the co-primes between 1 & totientForN
                {
                    coprimes.Add(count);
                    count++;
                }
                else
                {
                    count++;
                }
            }
            int e = coprimes[0]; //e - The Public Key
            int totativesCalculate = totativeListLength(n);

            int d = 1;
            while (d > 0) 
            {
                int dCalculate = (d * e) % totativesCalculate; //Finding the value of D, our private key
                if (dCalculate == 1)
                {
                    dCalculate = d;
                    break;
                }
                else 
                {
                    d++;
                }
            }

            //Output
            publicKeyBox.Text = n.ToString() + "," + e.ToString(); //Outputting final values to the text boxes
            privateKeyBox.Text = n.ToString() + "," + d.ToString();
        }
        static int GCD(int a, int b) 
        {
            //GCD - Greatest common divisor for finding co-primes

                if (a == 0 || b == 0) 
                {
                return 0;
                }
                if (a == b) 
                {
                return a;
                }
                if (a > b) 
                {
                    return GCD(a - b, b);
                }
                return GCD(a,b - a);               
        }
        static bool coPrimes(int a, int b) 
        {
            if (GCD(a, b) == 1) //Goes through all the possible values and finds a pair equal to 1
            {
                return true;
            }
            return false;
        }
        static int totativeListLength(int n) 
        {
            List<int> totatives = new List<int>();
            int i = 0;

            while (i < n) 
            {
                if (GCD(n, i) == 1) 
                {
                    totatives.Add(i);
                }
                i++;
            }
            return totatives.Count;
        }
    }
}
