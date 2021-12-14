namespace CadastroSeries
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido {get; set;}



        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
           this.Id = id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descricao = descricao;
           this.Ano = ano;
           this.Excluido = false;
        }

        public override string ToString()
        {
            //retorno do objeto Serie
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine; 
            retorno += "Descricao: " + this.Genero + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;

        }

        public string RetornarTitulo()
        {
            return this.Titulo;
        }

        public int RetornarId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}