using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CalculadoraSalário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CalcularButton_Click(object sender, EventArgs e)
        {
           
            CultureInfo culture = CultureInfo.InvariantCulture;
            string var_salario = SalarioMTextBox.Text.Replace(",", ".").ToString();
            double SalarioHora = Convert.ToDouble(var_salario, culture);


            string var_extras = HorasExtrasMTextBox.Text.Replace(",", ".").ToString();
            double HorasExtras = Convert.ToDouble(var_extras,culture );
            double ValorHorasExtras = 0;

            string var_trabalhadas = HorasTrabMTextBox.Text.Replace(",",".").ToString();
            double HorasTrabalhadas = Convert.ToDouble(var_trabalhadas, culture);


            string var_descontos = DescontosMTextBox.Text.Replace(",", ".").ToString();
            double Descontos = Convert.ToDouble(var_descontos, culture);



            Debug.WriteLine($"SalarioHora: {SalarioHora}");
            Debug.WriteLine($"HorasExtras: {HorasExtras}");
            Debug.WriteLine($"HorasTrabalhadas: {HorasTrabalhadas}");
            Debug.WriteLine($"Descontos: {Descontos}"); 
            
            double SalarioBruto = SalarioHora * HorasTrabalhadas;
            double SalarioLiquido = 0;

            Debug.WriteLine($"SalarioBruto: {SalarioBruto}");


            if (SalarioBruto <= 1412.00)
            {
                ValorHorasExtras = (SalarioHora * 1.5) * HorasExtras;
                double INSS = SalarioBruto * 7.5 / 100;

                SalarioLiquido = SalarioBruto + ValorHorasExtras - INSS - Descontos;
                ResultadoTextBox.Text = $"O seu Salário Líquido é igual a: {SalarioLiquido:C}";

            }
            else if (SalarioBruto > 1412.00 && SalarioBruto <= 2666.68)
            {
                ValorHorasExtras = (SalarioHora * 1.5) * HorasExtras;
                double INSS = SalarioBruto * 9 / 100;

                SalarioLiquido = SalarioBruto + ValorHorasExtras - INSS - Descontos;
                ResultadoTextBox.Text = $"O seu Salário Líquido é igual a: {SalarioLiquido:C}";

            }
            else if (SalarioBruto > 2666.68 && SalarioBruto <= 4000.04)
            {
                ValorHorasExtras = (SalarioHora * 1.5) * HorasExtras;
                double INSS = SalarioBruto * 12 / 100;

                SalarioLiquido = SalarioBruto + ValorHorasExtras - INSS - Descontos;
                ResultadoTextBox.Text = $"O seu Salário Líquido é igual a: {SalarioLiquido:C}";

            }
            else if (SalarioBruto > 4000.04 && SalarioBruto <= 7786.02)
            {
                ValorHorasExtras = (SalarioHora * 1.5) * HorasExtras;
                double INSS = SalarioBruto * 14 / 100;

                SalarioLiquido = SalarioBruto + ValorHorasExtras - INSS - Descontos;
                ResultadoTextBox.Text = $"O seu Salário Líquido é igual a: {SalarioLiquido:C}";
            }
            else if (SalarioBruto > 7786.02)
            {
                ValorHorasExtras = (SalarioHora * 1.5) * HorasExtras;
                double INSS = SalarioBruto * 14 / 100;

                SalarioLiquido = SalarioBruto + ValorHorasExtras - INSS - Descontos;
                ResultadoTextBox.Text = $"O seu Salário Líquido é igual a: {SalarioLiquido:C}";
            }
            

        }

 
    }
}
    

