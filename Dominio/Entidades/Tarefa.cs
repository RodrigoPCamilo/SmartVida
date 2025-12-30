using Dominio.Enums;
using Dominio.ValueObject;

namespace Dominio;

public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public PrioridadeTarefa Prioridade { get; set; }
    public Periodos Periodo { get; set; }
    public StatusTarefa Status { get; set; }
    public int UsuarioId { get; set; }

    public Tarefa(string titulo, string descricao, PrioridadeTarefa prioridade, Periodos periodos, int usuarioId)

    {
        Titulo = titulo;
        Descricao = descricao;
        Prioridade = prioridade;
        Periodo = periodos;
        UsuarioId = usuarioId;
        Status = StatusTarefa.Pendente;
    }
    public void Concluir()
    {
        Status = StatusTarefa.Concluida;
    }
    public void MarcarComoAtrasada()
    {
        Status = StatusTarefa.Atrasada;
    }
    public void AterarPrioridade(PrioridadeTarefa novaPrioridade)
    {
        Prioridade = novaPrioridade;
    }
}
