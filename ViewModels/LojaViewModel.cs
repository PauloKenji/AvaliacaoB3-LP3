namespace Avaliacao3b_LP3.ViewModels;

public class LojaViewModel{
    public int Id { get; set; }
    public int Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Categoria { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int id, int piso, string nome, string descricao, string categoria, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Categoria = categoria;
        Email = email;
    }
}