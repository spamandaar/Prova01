using System;
using System.Windows.Forms;

namespace PROVA01
{
    public partial class FrmCalc : Form
    {

        double numero1;
        double numero2;
        string total;
        public FrmCalc()
        {
            InitializeComponent();
           
        }

        private void Somar(object sender, EventArgs e)
        {            
                total = (numero1 + numero2).ToString();
                txtTot.Text = total;
        }

        private void Subtrair(object sender, EventArgs e)
        {

                total = (numero1 - numero2).ToString();
                txtTot.Text = total;
        }

        private void Multiplicar(object sender, EventArgs e)
        {        
                total = (numero1 * numero2).ToString();
                txtTot.Text = total;
        }

        private void Dividir(object sender, EventArgs e)
        {
            if (numero2 != 0) //validação para não dividir número por zero
            {
               
                total = (numero1 / numero2).ToString();
                txtTot.Text = total;
            }
            else
            {
                txtTot.Text = "Não é possivel dividir um número por zero"; 
            }

        }

        private void ZerarNum1(object sender, EventArgs e) //limpa o campo 
        {
            txtNum1.Text = "";
            numero1 = 0;
        }

        private void ZerarNum2(object sender, EventArgs e) //limpa o campo
        {
            txtNum2.Text = "";
            numero2 = 0;
        }

        private void valida_numeros(object sender, System.ComponentModel.CancelEventArgs e) //efetua validação para não ser digitado texto nos campos de número
        {

            if (!String.IsNullOrEmpty(txtNum1.Text))
            {
                try
                {
                    numero1 = double.Parse(txtNum1.Text); //converte texto para número
                    numero1 = double.Parse(txtNum1.Text);
                }
                catch (Exception)
                {
                    txtNum1.Text = "";
                    MessageBox.Show("Informe um numero no primeiro campo ");
                }

            }
            
            if (!String.IsNullOrEmpty(txtNum2.Text))
            {
                try
                {
                    numero2 = double.Parse(txtNum2.Text);
                    numero2 = double.Parse(txtNum2.Text);
                }
                catch (Exception)
                {
                    txtNum2.Text = "";
                    MessageBox.Show("Informe um numero no segundo campo ");
                }

            }
          

        }

        private void btnSoma_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
 }
