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
