namespace MinimalApi.Domain.Entities;

public class Administrator
{
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Senha { get; set; } = default!;

        public string Perfil { get; set; } = default!;
}