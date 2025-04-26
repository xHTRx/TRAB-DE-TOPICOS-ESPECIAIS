/* Validador de Senhas Fortes:
Peça ao usuário que digite uma senha e verifique se ela atende aos seguintes critérios:
• Mínimo de 8 caracteres
• Pelo menos uma letra maiúscula
• Pelo menos um número
• Pelo menos um caractere especial (ex: !, @, #)*/

Console.Write("Digite uma senha: ");
String senha = Console.ReadLine();

bool tamanho_bom = false;
bool temMaiuscula = false;
bool temNumero = false;
bool temEspecial = false;
string especiais = "!@#$%&*";

for(int i = 0; i < senha.Length; i++){
    char c = senha[i];

    if(senha.Length >= 8){
        tamanho_bom = true;
    }

    if (c >= 'A' && c <= 'Z'){ 
        temMaiuscula = true;
    }

    if (c >= '0' && c <= '9'){
        temNumero = true;
    }

    if (especiais.Contains(c)){
        temEspecial = true;
    }
}

if (tamanho_bom && temMaiuscula && temNumero && temEspecial){
    Console.Write("Senha forte!");
}
else{
    Console.WriteLine("Senha fraca. Digite Novamente!");
    if(!tamanho_bom){
        Console.WriteLine("A senha deve conter 8 digitos.");
    }

    if(!temMaiuscula){
        Console.WriteLine("A senha deve conter pelo menos uma letra maiuscula.");
    }

    if(!temNumero){
        Console.WriteLine("A senha deve conter pelo menos um numero.");
    }

    if(!temEspecial){
        Console.WriteLine("A senha deve conter pelo menos um caractere especial.");
    }
}