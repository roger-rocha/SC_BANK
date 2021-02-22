using System;




namespace SC_BANK
{
     public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaRoger = new ContaCorrente();
            contaRoger.titular = "ROGER ROCHA";
            contaRoger.saldo = 1000;
            contaRoger.agencia = 101;
            contaRoger.conta = 837213;
            
            Console.WriteLine();
            Console.WriteLine(" O nome do titular é: " + contaRoger.titular);
            Console.WriteLine();
            Console.WriteLine(" A quantia em dinheiro desta conta é: " + contaRoger.saldo);

            
            
            contaRoger.Sacar(273);
            Console.WriteLine(contaRoger.saldo);

            

            contaRoger.Depositar(200);
            Console.WriteLine(contaRoger.saldo);
             
            ContaCorrente contaRogerio = new ContaCorrente();
            contaRogerio.titular = "ROGERIO ROCHA";
            contaRogerio.saldo = 2000;
            contaRogerio.agencia = 101;
            contaRogerio.conta = 832090;

            Console.WriteLine();

            Console.WriteLine(contaRogerio.titular);
            Console.WriteLine(contaRogerio.agencia);
            Console.WriteLine(contaRogerio.saldo);
            Console.WriteLine(contaRogerio.conta);

            contaRoger.Transferir(100, contaRogerio);

            Console.WriteLine(contaRoger.saldo);
            Console.WriteLine(contaRogerio.saldo);
             

            Console.ReadLine();

           
        }
    }
}
