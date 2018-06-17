using System;
using NBitcoin;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Key chave = new Key();
            PubKey chavePublica = chave.PubKey;
            var hashChavePublica = chavePublica.Hash;
            var mainNetEndereco = chavePublica.GetAddress(Network.Main);
            var testNetEndereco = chavePublica.GetAddress(Network.TestNet);

            Console.WriteLine("WIF da chave privada na Main:" + chave.GetWif(Network.Main));
            Console.WriteLine("WIF da chave privada na TestNet:" + chave.GetWif(Network.TestNet));
            Console.WriteLine("Chave pública:" + chavePublica);
            Console.WriteLine("Hash da chave pública:" + hashChavePublica);
            Console.WriteLine("Endereço da carteira na rede Main:" + mainNetEndereco);
            Console.WriteLine("Endereço da carteira na rede de Teste:" + testNetEndereco);

            Console.Beep();
            int i = Console.Read();
        }
    }
}
