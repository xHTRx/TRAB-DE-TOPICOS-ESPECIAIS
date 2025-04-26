/*Conversor de Temperaturas com Menu
Crie um menu com as opções:
1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Sair
Use switch e while para manter o menu ativo até o usuário sair.*/

int opcao;

do{

    Console.WriteLine("\n1 - Celsius para Fahrenheit\n2 - Fahrenheit para Celsius\n3 - Sair");
    Console.Write("Digite o numero da opcao desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao > 3 || opcao < 1){
        Console.WriteLine("Digite uma opcao valida!");
    }
    else{
        switch(opcao){
            case 1:
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine("A temperatura em fahrenheit e: " + fahrenheit);
            break;
            case 2:
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double Fahrenheit = Convert.ToDouble(Console.ReadLine());

                double Celsius = (Fahrenheit - 32) / 1.8;
                Console.WriteLine("A temperatura em celsius e: " + Celsius);
            break;
            case 3:
                Console.WriteLine("-----Saindo-----");
            break;
        }
    }

}while(opcao != 3);