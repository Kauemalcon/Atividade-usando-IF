using System;

namespace Aula04
{
    class Program
    {

        //Faça um algoritmo que solicite a digitação do nome de uma pessoa.
        //Caso o nome desta pessoa seja "Maria", então solicite que seja digitado o seu
        //sobrenome.
        //Caso o seu sobrenome seja "Silva", então solicite a digitação
        //do ano de seu nascimento.
        //Se o ano de nascimento for superior a 2021, escreva a frase "Você ainda não nasceu", se o ano for ímpar ou 1986 ou
        //1988, escreva "Você nasceu em um ano legal"
        //Se o ano for par e maior ou igual 1970 e menor que 1982, escreva "Que legal! Esse ano em que você
        //nasceu é show!".
        //Se o ano de nascimento não compreender nenhuma das I
        //regras anteriores, escreva "Você nasceu!".
        //Se caso o sobrenome não for "Silva", solicite a digitação da idade da pessoa, se a idade for par, escreva
        //"Sua idade não é ímpar", caso contrário escreva "Sua idade não é par".
        //Caso o nome da pessoa não seja "Maria", então solicite a digitação da sua
        //altura (pode ser fracionário) e a digitação do seu peso(pode ser fracionário)
        //e calcule o sei IMC(Índice de massa corpórea) (Faça um método que
        //receba como parâmetro a altura e peso da pessoa e utilize a seguinte
        //fórmula para calcular o IMC = Peso/ (Altura* Altura).
        //Caso o IMC esteja abaixo de 18,5 Escreva "Magreza".
        //Caso o IMC esteja igual ou maior 18,5 e abaixo de 24,9, escreva "Normal".
        //Caso o IMC esteja igual ou maior a 24,9 e abaixo de 30, escreva "Sobrepeso". Caso o IMC esteja acima de 30, escreva "Obesidade"


        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();


            if (nome == "Maria")

            {
                Console.WriteLine("Digite o seu sobrenome");
                Console.ReadLine();
                string sobrenome = Console.ReadLine();

                if (sobrenome == "Silva")

                {
                    Console.WriteLine("Digite sua data de nascimento");
                    string nascimento = Console.ReadLine();
                    int ano = int.Parse(nascimento);

                    if (ano > 2021)
                    {
                        Console.WriteLine("Você ainda não nasceu");
                    }

                    else if (ano % 2 != 0 || ano == 1986 || ano == 1988)
                    {
                        Console.WriteLine("Você nasceu em um ano legal!");
                    }

                    else if (ano % 2 == 0 && ano >= 1970 && ano < 1982)
                    {
                        Console.WriteLine("Que legal! Esse ano em que você nasceu é show!");
                    }

                    else
                    {
                        Console.WriteLine("Você já nasceu!");
                    }
                }


                else
                {
                    Console.WriteLine("Digite sua idade");

                    Console.ReadLine();
                    string numero = Console.ReadLine();
                    int idade = int.Parse(numero);

                    if (idade % 2 == 0)
                    {
                        Console.WriteLine("Sua idade não é ímpar");
                    }

                    else
                    {
                        Console.WriteLine("Sua idade é ímpar");
                    }
                }
            }

            else
            {
                Console.WriteLine("Digite seu  altura");
                decimal altura = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu peso");
                decimal peso = decimal.Parse(Console.ReadLine());
                CalcularIMC(altura, peso);

            }
        }

          static void CalcularIMC(decimal altura, decimal peso)
            {
                decimal imc= peso / (altura * altura);

                if (imc < 18.5m)
                {
                    Console.WriteLine("Magreza");
                }

                else if (imc >= 18.5m && imc < 24.9m) 
                {
                    Console.WriteLine("Normal");
                }

                else if (imc >= 24.9m && imc < 30m) 
                {
                    Console.WriteLine("Sobrepeso");
                }

                else
                {
                    Console.WriteLine("Obesidade");
                }

            }
        

    }
}



                
              