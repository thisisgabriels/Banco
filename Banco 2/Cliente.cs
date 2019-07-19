namespace Banco.Contas
{
    public class Cliente
    {
        public string Nome { get; set; } //Classe do atributo nome;

        public Cliente()
        {
        }

        public Cliente(string N)
        {
            this.Nome = N;
        }
    
    }
}