using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace M7_Exemplo2Ficheirosbinarios
{
    internal class Program
    {
        const string caminho = "nomedoficheiro.dat";
        static void Main(string[] args)
        {
            EscreverFicheiro();
            LerFicheiro();
            Console.ReadKey();
        }
        public static void EscreverFicheiro()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open (caminho,FileMode.Create)))
            {
                bw.Write(1.259F); // preço do produto
                bw.Write("caderno");
                bw.Write(10);
                bw.Write(true);
            }
            
        }
        public static void LerFicheiro()
        {
            float preco;
            string designacao;
            int qtd;
            bool comArgolas;
            if (File.Exists(caminho))
            {
                using (BinaryReader br = new BinaryReader(File.Open(caminho, FileMode.Open)))
                {
                    preco = br.ReadSingle();
                    designacao = br.ReadString();
                    qtd = br.ReadInt32();
                    comArgolas = br.ReadBoolean();
                }
                Console.WriteLine("Preço do produto: " + preco);
                Console.WriteLine("Designação do produto: " + designacao);
                Console.WriteLine("Quantidade em stock: " + qtd);
                Console.WriteLine("Com argolas na capa: " + comArgolas);
            }
        }

    }
}
