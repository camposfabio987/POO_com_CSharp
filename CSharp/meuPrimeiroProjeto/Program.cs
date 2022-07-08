using System;

namespace meuPrimeiroProjeto 
{
class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta_do_Fabio = new ContaCorrente ("Fábio Henrique", 89777, 820, 50000);
            ContaCorrente conta_do_Renatin = new ContaCorrente ("Renatin do Celta", 89777, 123, 5);
            ContaCorrente conta_da_Barbara = new ContaCorrente ("Bárbara", 89777, 965, 100);

            bool sacar_conta1 = conta_do_Fabio.Sacar(100);
            bool sacar_conta2 = conta_do_Renatin.Sacar(100);
            bool sacar_conta3 = conta_da_Barbara.Sacar(100);

            bool depositar_conta1 = conta_do_Fabio.Depositar(200);

            Console.WriteLine("A conta é do(a): " + conta_do_Fabio.Titular + ", A agência é: " + conta_do_Fabio.Agencia +
            ", O número da conta é: " + conta_do_Fabio.Numero + ", O saldo da conta é: " + conta_do_Fabio.Saldo);   

            Console.WriteLine("A conta é do(a): " + conta_do_Renatin.Titular + ", A agência é: " + conta_do_Renatin.Agencia +
            ", O número da conta é: " + conta_do_Renatin.Numero + ", O saldo da conta é: " + conta_do_Renatin.Saldo);

            Console.WriteLine("A conta é do(a): " + conta_da_Barbara.Titular + ", A agência é: " + conta_da_Barbara.Agencia +
            ", O número da conta é: " + conta_da_Barbara.Numero + ", O saldo da conta é: " + conta_da_Barbara.Saldo);
           
        }
    }
}
