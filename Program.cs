//using System;

//Console.WriteLine("===CALCULADORA DE TARIFAS");
//Console.WriteLine("");


//Console.WriteLine("Digite o total de minutos no estacionamento: ");
//string totalMinutoStr = Console.ReadLine();
//int.TryParse(totalMinutoStr, out int totalMinutos);

//Console.WriteLine("Digite o valor cobrado por hora: ");
//string valorHoraStr = Console.ReadLine();
//double.TryParse(valorHoraStr, out double valorHora);


//int horasCheias = totalMinutos / 60;
//int minutosRestantes = totalMinutos % 60; 

//Console.WriteLine($"O total de horas e minutos foi de : {horasCheias} {minutosRestantes} minutos ");

//double horasCobrancas = horasCheias;
//if (minutosRestantes > 0) 
//{
//    horasCobrancas++;
//}

//double valorCalculado = horasCobrancas * valorHora;
//Console.WriteLine($"Valor calculado: R$ {valorCalculado:F2}");

//double tetoDiario = 30;

//if(valorCalculado > tetoDiario)
//{
//    Console.WriteLine("O valor calculado é MAIOR que o teto diário.");

//} else if (valorCalculado < tetoDiario)
//{
//    Console.WriteLine("O valor calculado é menor o teto diário.");

//} else
//{
//    Console.WriteLine("O valor calculado é IGUAL ao teto diário.");
//}

//Console.WriteLine("\nPressione qualquer tecla para fechar...");
//Console.ReadKey();




//using System;

//Console.WriteLine("===CALCULADORA DE TARIFAS");
//Console.WriteLine("");


//Console.WriteLine("Digite o total de minutos no estacionamento: ");
//string totalMinutoStr = Console.ReadLine();
//int.TryParse(totalMinutoStr, out int totalMinutos);

//if (totalMinutos < 0)
//{
//    Console.WriteLine("[ERRO] Digite um total de minutos válidos (numero positivo): ");
//}
//else
//{
//    Console.WriteLine($"Total de minutos foi de : {totalMinutos}");

//    int rotativaCurta = 15;
//    int rotativaPadrao = 30;
//    int diaria = 480;

//    if (totalMinutos > diaria)
//    {

//        Console.WriteLine("Diaria");

//    }
//    else if (totalMinutos > rotativaPadrao)
//    {
//        Console.WriteLine("Rotativa padrao");
//    }
//    else
//    {
//        Console.WriteLine("rotativa curta");
//    }

//}

//Console.WriteLine("\nPressione qualquer tecla para fechar...");
//Console.ReadKey();




//using System;

//Console.WriteLine("===CALCULADORA DE TARIFAS");
//Console.WriteLine("");

//int totalMinutos = -1;

//while (totalMinutos < 0)

//{
//    Console.WriteLine("Digite o total de minutos no estacionamento: ");
//    string totalMinutoStr = Console.ReadLine();
//    int.TryParse(totalMinutoStr, out totalMinutos);

//    if (totalMinutos < 0)
//    {
//        Console.WriteLine("\n[ERRO] Valor inválido! Por favor, insira um número inteiro positivo"); 
//    }
//}

//Console.WriteLine($"\nTotal de minutos válido registrado: {totalMinutos}");

//int rotativaCurta = 15;
//int rotativaPadrao = 30;
//int diaria = 480;

//if (totalMinutos > diaria)
//{

//    Console.WriteLine("Diaria");

//}
//else if (totalMinutos > rotativaPadrao)
//{
//    Console.WriteLine("Rotativa padrao");
//}
//else
//{
//    Console.WriteLine("rotativa curta");
//}



//Console.WriteLine("\nPressione qualquer tecla para fechar...");
//Console.ReadKey();

Console.WriteLine("=================================================================================================================");



//using System;

//Console.WriteLine("===CALCULADORA DE TARIFAS");
//Console.WriteLine("");

//int totalMinutos = -1;

//int qtddiaria = 0;
//int qtdrotativaPadrao = 0;
//int qtdrotativaCurta = 0;

//while (totalMinutos != 0)

//{
//    Console.WriteLine("Digite o total de minutos no estacionamento: ");
//    string totalMinutoStr = Console.ReadLine();
//    int.TryParse(totalMinutoStr, out totalMinutos);

//    if (totalMinutos == 0)
//    {
//        Console.WriteLine("\nEncerrando a calculadora...");
//        break;
//    }

//    if (totalMinutos < 0)
//    {
//        Console.WriteLine("\n[ERRO] Valor inválido! Por favor, insira um número inteiro positivo");
//        continue;
//    }


//    Console.WriteLine($"\nTotal de minutos válido registrado: {totalMinutos}");

//    int rotativaCurta = 15;
//    int rotativaPadrao = 30;
//    int diaria = 480;

//    if (totalMinutos > diaria)
//    {

//        Console.WriteLine("Diaria");
//        qtddiaria++;
//    }
//    else if (totalMinutos > rotativaPadrao)
//    {
//        Console.WriteLine("Rotativa padrao");
//        qtdrotativaPadrao++;
//    }
//    else
//    {
//        Console.WriteLine("rotativa curta");
//        qtdrotativaCurta++;
//    }

//}

//Console.WriteLine($"Aquantidade de carros com rotacao curta foi de : {qtdrotativaCurta}");
//Console.WriteLine($"Aquantidade de carros com rotacao padrao foi de : {qtdrotativaPadrao}");
//Console.WriteLine($"Aquantidade de carros com rotacao diaria foi de : {qtddiaria}");



//Console.WriteLine("\nPressione qualquer tecla para fechar...");
//Console.ReadKey();


Console.WriteLine("=================================================================================================================");


//using System;

//Console.WriteLine("===CALCULADORA DE TARIFAS");
//Console.WriteLine("");

//int totalMinutos = -1;

//int qtddiaria = 0;
//int qtdrotativaPadrao = 0;
//int qtdrotativaCurta = 0;

//while (totalMinutos != 0)

//{
//    Console.WriteLine("Digite o total de minutos no estacionamento: ");
//    string totalMinutoStr = Console.ReadLine();
//    int.TryParse(totalMinutoStr, out totalMinutos);

//    if (totalMinutos == 0)
//    {
//        Console.WriteLine("\nEncerrando a calculadora...");
//        break;
//    }

//    if (totalMinutos < 0)
//    {
//        Console.WriteLine("\n[ERRO] Valor inválido! Por favor, insira um número inteiro positivo");
//        continue;
//    }


//    Console.WriteLine($"\nTotal de minutos válido registrado: {totalMinutos}");

//    int rotativaCurta = 15;
//    int rotativaPadrao = 30;
//    int diaria = 480;

//    if (totalMinutos > diaria)
//    {

//        Console.WriteLine("Diaria");
//        qtddiaria++;
//    }
//    else if (totalMinutos > rotativaPadrao)
//    {
//        Console.WriteLine("Rotativa padrao");
//        qtdrotativaPadrao++;
//    }
//    else
//    {
//        Console.WriteLine("rotativa curta");
//        qtdrotativaCurta++;
//    }

//}

//Console.WriteLine($"Aquantidade de carros com rotacao curta foi de : {qtdrotativaCurta}");
//Console.WriteLine($"Aquantidade de carros com rotacao padrao foi de : {qtdrotativaPadrao}");
//Console.WriteLine($"Aquantidade de carros com rotacao diaria foi de : {qtddiaria}");



//Console.WriteLine("\nPressione qualquer tecla para fechar...");
//Console.ReadKey();




//Console.WriteLine("=================================================================================================================");

using System;

int opcao = 0;

do
{
    Console.WriteLine("===MENU ESTACIONAMENTO===");
    Console.WriteLine("1 - Calcular Tarifa");
    Console.WriteLine("2 - Converter Duração em Horas e Minutos");
    Console.WriteLine("3 - Classificar Permanência");
    Console.WriteLine("4 - Sobre");
    Console.WriteLine("5 - Sair ");
    Console.WriteLine("");

    Console.WriteLine("Digite a opcao desejada ou 4 para sair");
    string opcaostr = Console.ReadLine();
    int.TryParse(opcaostr, out opcao);

    switch(opcao) { 

        case 1:
            {
                Console.WriteLine("Calcular Tarifa");
                Console.WriteLine("");

                Console.WriteLine("Digite o total de minutos no estacionamento: ");
                string totalMinutoStr = Console.ReadLine();
                int.TryParse(totalMinutoStr, out int totalMinutos);

                Console.WriteLine("Digite o valor cobrado por hora: ");
                string valorHoraStr = Console.ReadLine();
                double.TryParse(valorHoraStr, out double valorHora);


                int horasCheias = totalMinutos / 60;
                int minutosRestantes = totalMinutos % 60;

                double horasCobrancas = horasCheias;
                if (minutosRestantes > 0)
                {
                    horasCobrancas++;
                }

                double valorCalculado = horasCobrancas * valorHora;
                Console.WriteLine($"Valor calculado: R$ {valorCalculado:F2}");
                break;
            }

        case 2:
            {
                Console.WriteLine("Converter Duração em Horas e Minutos");
                Console.WriteLine("Digite o total de minutos no estacionamento: ");
                string totalMinutoStr = Console.ReadLine();
                int.TryParse(totalMinutoStr, out int totalMinutos);

                int horasCheias = totalMinutos / 60;
                int minutosRestantes = totalMinutos % 60; 

                Console.WriteLine($"O total de horas e minutos foi de : {horasCheias} {minutosRestantes} minutos ");
                break;
            }   

        case 3:
            {
                int rotativaCurta = 15;
                int rotativaPadrao = 30;
                int diaria = 480;

                Console.WriteLine("Digite o total de minutos no estacionamento: ");
                string totalMinutoStr = Console.ReadLine();
                int.TryParse(totalMinutoStr, out int totalMinutos);

                if (totalMinutos < 0)
                {
                    Console.WriteLine("\n[ERRO] Valor inválido! Por favor, insira um número inteiro positivo");
                    
                } else if (totalMinutos > diaria)
                {

                    Console.WriteLine("Diaria");

                }
                else if (totalMinutos > rotativaPadrao)
                {
                    Console.WriteLine("Rotativa padrao");
                }
                else
                {
                    Console.WriteLine("rotativa curta");
                }
                break;
            }   
       

        case 4:
            {
                
                Console.WriteLine("--- SOBRE O SISTEMA ---");
                Console.WriteLine($"Versão do .NET em uso: {Environment.Version}");
                Console.WriteLine("Explicação de multiplataforma:");
                Console.WriteLine("Este programa funciona em diferentes sistemas operacionais (como Windows, Linux e macOS)");
                Console.WriteLine("porque o .NET é uma plataforma multiplataforma. O código C# é compilado para uma linguagem");
                Console.WriteLine("intermediária (IL) que o ambiente de execução (.NET Runtime) de cada sistema entende e executa.");
                break;
                
            }

        case 5:

            Console.WriteLine("\nEncerrando o sistema de estacionamento...");
            break;


        default:
            Console.WriteLine("\n[ERRO] Opção inválida! Por favor, escolha um número de 1 a 4.");
            break;

    }


 } while (opcao != 5) ;

 Console.WriteLine("\nPressione qualquer tecla para fechar...");
 Console.ReadKey();



