﻿namespace Loja.Testes.ConsoleApp.Model
{
    public class Compra
    {
        public int Id { get; internal set; }
        public int Quantidade { get; internal set; }
        public double Preco { get; internal set; }
        public int ProdutoId { get; internal set; }
        public Produto Produto { get; internal set; }
    }
}
