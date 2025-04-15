namespace Domain.Entities
{
    public class Cliente
    {
        public Cliente(int id, string nome, string sobrenome, string cpfCnpj, string telefone)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            CpfCnpj = cpfCnpj;
            Telefone = telefone;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
    }
}
