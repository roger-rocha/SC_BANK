using System;
    public class ContaCorrente
    {
      public string titular;
      public int agencia;
      public int conta;
      public double saldo;

    public bool Sacar(double valor)
     {
       if(this.saldo < valor)
         {
           return false;
         }
         
         this.saldo -= valor;      
            return true;  
     }
       
     public void Depositar(double valor)
     {
       this.saldo += valor;
     }  

     public bool Transferir(double valor, ContaCorrente contaDestino)
     {
       if(this.saldo < valor)
       {
         return false;
       }

       this.saldo -= valor;
       contaDestino.Depositar(valor);
       return true;
     }   






    }   
   
   