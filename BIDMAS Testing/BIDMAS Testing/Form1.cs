using System.CodeDom.Compiler;
using System.Globalization;
using System.Text.Json.Serialization;

namespace BIDMAS_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int symbolPriority(string temp)
         {
            if (temp == "+")
                return 1;
            if(temp == "-")
                return 1;
            if (temp == "/")
                return 2;
            if (temp == "*")
                return 2;
            else
            return 0;
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string temp = "";
            string varA = "";
            string varB = "";
            string varC = "";
            int count = 0;
            
            if (textBox1.Text != "")
            {

                string text = textBox1.Text;
                int length = textBox1.Text.Length;
                for (int i = 0; i <= textBox1.Text.Length - 1; i++)    
                {
                    if (temp == "+" || temp == "-" || temp == "*" || temp == "/")
                    {
                        if (count == 0)
                        {
                            string symbol1 = temp;
                            int symbol1loc = i;
                            int symbol1pri = symbolPriority(temp);
                            for (int loop = 0; loop < i; loop++)
                            {
                                varA += textBox1.Text[loop].ToString();
                            }
                            count++;
                        }
                        tb2.Text = varA;
                        if (count == 1)
                        {
                            string symbol2 = temp;
                            int symbol2loc = i;
                            int symbol2pri = symbolPriority(temp);
                            for (loop2 = loop2 + 1; loop2 <= textBox1.Text.Length - 1; loop2++)
                            {
                                varB += textBox1.Text[loop2].ToString();
                            }
                            count++;
                        }
                        tb3.Text = varB;
                        if (count == 2)
                        {
                            string symbol3 = temp;
                            int symbol3loc = i;
                            int symbol3pri = symbolPriority(temp);
                            for (loop3 = loop3 + 1; loop3 <= textBox1.Text.Length - 1; loop3++)
                            {
                                varC += textBox1.Text[loop3].ToString();
                            }
                            count++;
                        }
                        tb4.Text = varC;
                    }
                    else if (temp == "")
                        i = textBox1.TextLength - 1;
                 

                    
                    

                }
            }

        }
    }
}