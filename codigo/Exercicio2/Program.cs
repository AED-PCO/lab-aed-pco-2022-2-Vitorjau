namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int cont = 0;
            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numero; i++){
                if(numero %i == 0){
                    cont++;
                }
            }
            if(cont == 2){
                Console.WriteLine("Numero é primo!");
            }else{
                Console.WriteLine("Numero não é primo!");
            }

        
        }
    }
}