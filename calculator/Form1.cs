using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculadora : Form
    {
        private Rectangle num0Rectangulo;
        private Rectangle num1Rectangulo;
        private Rectangle num2Rectangulo;
        private Rectangle num3Rectangulo;
        private Rectangle num4Rectangulo;
        private Rectangle num5Rectangulo;
        private Rectangle num6Rectangulo;
        private Rectangle num7Rectangulo;
        private Rectangle num8Rectangulo;
        private Rectangle num9Rectangulo;
        private Rectangle btnDividirRectangulo;
        private Rectangle btnIgualRectangulo;
        private Rectangle btnRestarRectangulo;
        private Rectangle btnSumarRectangulo;
        private Rectangle btnMultiplicarRectangulo;
        private Rectangle btnPuntoRectangulo;
        private Rectangle btnLimpiarRectangulo;
        private Rectangle btnBorrarRectangulo;
        private Size originalFormSize;
        private Rectangle displayLabel;

        public calculadora()
        {
            InitializeComponent();
        }
        private void calculadora_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            num0Rectangulo = new Rectangle(num0.Location.X, num0.Location.Y, num0.Width, num0.Height);
            num1Rectangulo = new Rectangle(num1.Location.X, num1.Location.Y, num1.Width, num1.Height);
            num2Rectangulo = new Rectangle(num2.Location.X, num2.Location.Y, num2.Width, num2.Height);
            num3Rectangulo = new Rectangle(num3.Location.X, num3.Location.Y, num3.Width, num3.Height);
            num4Rectangulo = new Rectangle(num4.Location.X, num4.Location.Y, num4.Width, num4.Height);
            num5Rectangulo = new Rectangle(num5.Location.X, num5.Location.Y, num5.Width, num5.Height);
            num6Rectangulo = new Rectangle(num6.Location.X, num6.Location.Y, num6.Width, num6.Height);
            num7Rectangulo = new Rectangle(num7.Location.X, num7.Location.Y, num7.Width, num7.Height);
            num8Rectangulo = new Rectangle(num8.Location.X, num8.Location.Y, num8.Width, num8.Height);
            num9Rectangulo = new Rectangle(num9.Location.X, num9.Location.Y, num9.Width, num9.Height);
            btnDividirRectangulo = new Rectangle(btnDividir.Location.X, btnDividir.Location.Y, btnDividir.Width, btnDividir.Height);
            btnIgualRectangulo = new Rectangle(btnIgual.Location.X, btnIgual.Location.Y, btnIgual.Width, btnIgual.Height);
            btnLimpiarRectangulo = new Rectangle(btnLimpiar.Location.X, btnLimpiar.Location.Y, btnLimpiar.Width, btnLimpiar.Height);
            btnMultiplicarRectangulo = new Rectangle(btnMultiplicar.Location.X, btnMultiplicar.Location.Y, btnMultiplicar.Width, btnMultiplicar.Height);
            btnPuntoRectangulo = new Rectangle(btnPunto.Location.X, btnPunto.Location.Y, btnPunto.Width, btnPunto.Height);
            btnRestarRectangulo = new Rectangle(btnResta.Location.X, btnResta.Location.Y, btnResta.Width, btnResta.Height);
            btnSumarRectangulo = new Rectangle(btnSuma.Location.X, btnSuma.Location.Y, btnSuma.Width, btnSuma.Height);
            btnBorrarRectangulo = new Rectangle(btnBorrar.Location.X, btnBorrar.Location.Y, btnBorrar.Width, btnBorrar.Height);
            displayLabel = new Rectangle(lblDisplayCalculator.Location.X, lblDisplayCalculator.Location.Y, lblDisplayCalculator.Width, lblDisplayCalculator.Height);
        }
        
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }
        private void calculadora_Resize(object sender, EventArgs e)
        {
            resizeControl(num0Rectangulo, num0);
            resizeControl(num1Rectangulo, num1);
            resizeControl(num2Rectangulo, num2);
            resizeControl(num3Rectangulo, num3);
            resizeControl(num4Rectangulo, num4);
            resizeControl(num5Rectangulo, num5);
            resizeControl(num6Rectangulo, num6);
            resizeControl(num7Rectangulo, num7);
            resizeControl(num8Rectangulo, num8);
            resizeControl(num9Rectangulo, num9);
            resizeControl(btnDividirRectangulo, btnDividir);
            resizeControl(btnBorrarRectangulo, btnBorrar);
            resizeControl(btnLimpiarRectangulo, btnLimpiar);
            resizeControl(btnPuntoRectangulo, btnPunto);
            resizeControl(btnIgualRectangulo, btnIgual);
            resizeControl(btnMultiplicarRectangulo, btnMultiplicar);
            resizeControl(btnSumarRectangulo, btnSuma);
            resizeControl(btnRestarRectangulo, btnResta);
            resizeControl(displayLabel, lblDisplayCalculator);
        }
        float primerNum, segundoNum, resultado;
        char operacion;
        bool dec = false;
        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in lblDisplayCalculator.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    lblDisplayCalculator.Text = lblDisplayCalculator.Text + ".";
                }
                dec = false;
            }
            else
            {
                if ((lblDisplayCalculator.Text.Equals("0") == true && lblDisplayCalculator.Text != null))
                {
                    lblDisplayCalculator.Text = numPressed.ToString();
                }
                else if (lblDisplayCalculator.Text.Equals("-0") == true)
                {
                    lblDisplayCalculator.Text = "-" + numPressed.ToString();
                }
                else
                {
                    lblDisplayCalculator.Text = lblDisplayCalculator.Text + numPressed.ToString();
                }
            }
        }
        private void num0_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void num1_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblDisplayCalculator.Text = "0";
            primerNum = 0;
            segundoNum = 0;
            resultado = 0;
            operacion = '\0';
            dec = false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resultado = 0;
            if (lblDisplayCalculator.Text.Equals("0") == false)
            {
                switch (operacion)
                {
                    case '+':
                        segundoNum = float.Parse(lblDisplayCalculator.Text);
                        resultado = primerNum + segundoNum;
                        break;
                    case '-':
                        segundoNum = float.Parse(lblDisplayCalculator.Text);
                        resultado = primerNum - segundoNum;
                        break;
                    case '/':
                        segundoNum = float.Parse(lblDisplayCalculator.Text);
                        resultado = primerNum / segundoNum;
                        break;
                    case '*':
                        segundoNum = float.Parse(lblDisplayCalculator.Text);
                        resultado = primerNum * segundoNum;
                        break;
                    default:
                        break;
                }
            }
            lblDisplayCalculator.Text = resultado.ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            primerNum = float.Parse(lblDisplayCalculator.Text);
            operacion = '+';
            resultado = resultado + primerNum;
            lblDisplayCalculator.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            primerNum = float.Parse(lblDisplayCalculator.Text);
            operacion = '-';
            lblDisplayCalculator.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            primerNum = float.Parse(lblDisplayCalculator.Text);
            operacion = '*';
            lblDisplayCalculator.Text = "";
        }

        private void calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    num1.PerformClick();
                    break;
                case Keys.D1:
                    num1.PerformClick();
                    break;
                case Keys.NumPad2:
                    num2.PerformClick();
                    break;
                case Keys.D2:
                    num2.PerformClick();
                    break;
                case Keys.NumPad3:
                    num3.PerformClick();
                    break;
                case Keys.D3:
                    num3.PerformClick();
                    break;
                case Keys.NumPad4:
                    num4.PerformClick();
                    break;
                case Keys.D4:
                    num4.PerformClick();
                    break;
                case Keys.NumPad5:
                    num5.PerformClick();
                    break;
                case Keys.D5:
                    num5.PerformClick();
                    break;
                case Keys.NumPad6:
                    num6.PerformClick();
                    break;
                case Keys.D6:
                    num6.PerformClick();
                    break;
                case Keys.NumPad7:
                    num7.PerformClick();
                    break;
                case Keys.D7:
                    num7.PerformClick();
                    break;
                case Keys.NumPad8:
                    num8.PerformClick();
                    break;
                case Keys.D8:
                    num8.PerformClick();
                    break;
                case Keys.NumPad9:
                    num9.PerformClick();
                    break;
                case Keys.D9:
                    num9.PerformClick();
                    break;
                case Keys.Divide:
                    btnDividir.PerformClick();
                    break;
                case Keys.Subtract:
                    btnResta.PerformClick();
                    break;
                case Keys.Add:
                    btnSuma.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiplicar.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void calculadora_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnIgual.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            primerNum = float.Parse(lblDisplayCalculator.Text);
            operacion = '/';
            lblDisplayCalculator.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int numCantidad = lblDisplayCalculator.Text.Length;
            if (numCantidad > 1)
            {
                lblDisplayCalculator.Text = lblDisplayCalculator.Text.Substring(0, numCantidad - 1);
            }
            else
            {
                lblDisplayCalculator.Text = "0";
            }
        }
    }
}
