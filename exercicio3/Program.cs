/*Cálculo de Fatorial com while
Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
while.*/

int num;
do{
    Console.Write("Digite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());
}while(num <= 0);

int fato = num - 1;

while(fato > 0){
    num *= fato; 
    fato--;
}

Console.WriteLine("O fatorial do numero e: " + num);