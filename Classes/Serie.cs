using System;

namespace Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }        
        private string Titulo { get; set; }
        private string Sinopse { get; set; }
        private int Ano { get; set; }
        private Classificacao Classificacao { get; set; }

        //private int ConteudosSensiveis ConteudosSensiveis { get; set; }
        private bool Excluido { get; set; }

        //Métodos
        public Serie(int id, Genero genero, string titulo, string sinopse, int ano, Classificacao classificacao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Ano = ano;
            this.Classificacao = classificacao;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " +this.Genero + Environment.NewLine;
            retorno += "Título: " +this.Titulo + Environment.NewLine;
            retorno += "Descrição: " +this.Sinopse + Environment.NewLine;
            retorno += "Classificação: " +this.Classificacao + Environment.NewLine;
            retorno += "Ano de Início: " +this.Ano;
            retorno += "Excluído: " +this.Excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
