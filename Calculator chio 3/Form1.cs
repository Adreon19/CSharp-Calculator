using System.Linq.Expressions;

namespace Calculator_chio_3
{
    public partial class Form1 : Form
    {
        private static decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        private static double ConverttoRadian(double radian)
        {
            
            radian = (Math.PI / 180) * radian;
            return radian;
        }
        private static double ConverttoDegrees(double degrees)
        {
            
            degrees = (180 / Math.PI) * degrees;
            return degrees;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TxtBox.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains(",")) {
                TxtBox.Text += ",";
            }
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
                valueFirst = int.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "+";  
        }
        private void sinBtn_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(TxtBox.Text);
            sin = Math.Sin(sin);
            TxtBox.Text = Convert.ToString(sin);
           
 
        }
        private void DevideBtn_Click(object sender, EventArgs e)
        {
                valueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "/";
           
        }  

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            double a;   

            a = Convert.ToDouble(TxtBox.Text) / Convert.ToDouble(100);

            TxtBox.Text = Convert.ToString(a);
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    break;
                case "/":
                    try
                    {
                        valueSecond = int.Parse(TxtBox.Text);
                        Result = valueFirst / valueSecond;
                        TxtBox.Text = Result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        TxtBox.Text = "Invalid value";
                    }
                    break;
            }
        } 

        private void cosBtn_BindingContextChanged(object sender, EventArgs e)
        {

        }

        

        private void cosBtn_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(TxtBox.Text);
            cos = Math.Cos(cos);
            TxtBox.Text = Convert.ToString(cos);
        }

        private void cosBtn_Click_1(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(TxtBox.Text);
            cos = Math.Cos(cos);
            TxtBox.Text = Convert.ToString(cos);
        }

        private void TanBtn_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(TxtBox.Text);
            tan = Math.Tan(tan);
            TxtBox.Text = Convert.ToString(tan);
        }

        private void Radian_CheckedChanged(object sender, EventArgs e)
        {
            if (Radian.Checked) 
            {
                double hasilradian;
               hasilradian = ConverttoRadian(double.Parse(TxtBox.Text));
                TxtBox.Text = hasilradian.ToString();
            }
        }

        private void Degrees_CheckedChanged(object sender, EventArgs e)
        { 
           if(Degrees.Checked)
            {
                double hasildegrees;
                hasildegrees = ConverttoDegrees(double.Parse(TxtBox.Text));
                TxtBox.Text =hasildegrees.ToString();
            }
        }
    }
}