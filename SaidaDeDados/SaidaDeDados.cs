class SaidaDeDados
{
    static void Main(string[] args)
    {
        int idade = 22;
        double saldo = 1000.0;
        string nome = "Wesley Matheus da Silva Farias";
        // String format
        Console.WriteLine("{0} tem {1} anos de idade e o saldo de {2} na conta", nome, idade, saldo);

        // Interpolação
        Console.WriteLine($"{nome} tem {idade} anos de idade e o saldo de {saldo} na conta");

        // Concatenação
        Console.WriteLine(nome + " tem " + idade + " anos de idade e o saldo de " + saldo + " na conta");
    }
}