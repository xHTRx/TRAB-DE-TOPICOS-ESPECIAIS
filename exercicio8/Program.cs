/*Cálculo de IMC com Classificação:
Solicite o peso (kg) e altura (m) do usuário, calcule o IMC e informe a classificação:
• Abaixo de 18.5: Abaixo do peso
• 18.5 a 24.9: Peso normal
• 25 a 29.9: Sobrepeso
• 30 ou mais: Obesidade*/

Console.Write("Digite a sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o seu peso: ");
int peso = Convert.ToInt32(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine("\nO seu IMC e: " + imc.ToString("F2"));

if(imc < 18.5){
    Console.WriteLine("\nVoce esta abaixo do peso!");
}
else if(imc < 25){
    Console.WriteLine("\nVoce esta no peso adequado!");
}
else if(imc < 30){
    Console.WriteLine("\nVoce esta em sobrepeso!");
}
else{
    Console.WriteLine("\nVoce esta obeso!");
}