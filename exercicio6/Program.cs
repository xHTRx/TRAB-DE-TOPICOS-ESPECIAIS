/*Cadastro Simples de Produtos:
Crie uma classe Produto com propriedades Nome, Preço e Quantidade. Permita ao
usuário cadastrar 3 produtos e depois liste todos com o valor total em estoque (Preço *
Quantidade).*/

class Program{
    static void Main(string[] args){

        int qtde = 3;
        Produto[] produtos = new Produto[qtde];

        for(int i = 0; i < qtde; i++){
            Console.Write("\nDigite o nome do produto " + (i+1) + ": ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preco do produto "+ (i+1) + ": ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade do produto " + (i+1) + ": ");
            int qtd = Convert.ToInt32(Console.ReadLine());

            produtos[i] = new Produto(nome, preco, qtd);
        }

        Console.WriteLine("\nProdutos cadastrados:\n");

        foreach (Produto produto in produtos){
            produto.Exibir_produtos();
            Console.WriteLine();
        }
    } 
}

class Produto{
    public string Nome{get; set;}
    public double Preco{get; set;}
    public int Qtd{get; set;}

    public Produto(string nome, double preco, int qtd){
        Nome = nome;
        Preco = preco;
        Qtd = qtd;    
    }

    public double Total_estoque(){
        return Preco * Qtd;
    }

    public void Exibir_produtos(){
        Console.Write("\nNome do produto: " + Nome);
        Console.Write("\nPreco do produto: " + Preco);
        Console.Write("\nQuantidade do produto: " + Qtd);
        Console.Write("\nTotal no estoque: " + Total_estoque());
    }
}
