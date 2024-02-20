# Calculadora de Salário

Este é um projeto de uma calculadora de salário desenvolvida em C# usando o Windows Forms. A calculadora permite calcular o salário líquido com base nas horas trabalhadas, horas extras, descontos e faixas salariais.

## Propósito do Projeto

O projeto foi criado com o objetivo de facilitar a organização financeira pessoal, fornecendo uma ferramenta simples e intuitiva para calcular o salário líquido com base em diferentes variáveis.

## Configuração do Ambiente

Certifique-se de ter o seguinte ambiente configurado:

- [.NET Core SDK](https://dotnet.microsoft.com/download) instalado.
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/) ou outro ambiente de desenvolvimento C#

## Como Usar

1. Clone ou faça o download do repositório para a sua máquina.
2. Abra o projeto no Visual Studio ou em seu ambiente de desenvolvimento preferido.
3. Compile e execute o projeto.
4. Insira os valores de salário, horas extras, horas trabalhadas e descontos nos campos correspondentes.
5. Clique no botão "Calcular" para obter o salário líquido.

## Detalhes do Código

O código utiliza o Windows Forms para criar a interface gráfica da calculadora. O método `CalcularButton_Click` é acionado quando o botão de calcular é pressionado. O código converte os valores das `MaskedTextBox` para números, realiza os cálculos e exibe o resultado na `ResultadoTextBox`.


