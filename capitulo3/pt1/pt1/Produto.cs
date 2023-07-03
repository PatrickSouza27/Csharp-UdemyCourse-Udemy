﻿using System.Globalization;
namespace pt1
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }
        
        public Produto(string nome, double preco, int qtd) 
        {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;  
  
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }

   

        
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}