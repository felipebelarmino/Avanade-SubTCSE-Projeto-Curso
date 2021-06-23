namespace Projeto_Curso_full_stack.Domain.Aggregates
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
