using UsersWeb.Models;

namespace UsersWeb.Services;

public class RandomUserService
{
    private static readonly string[] Nombres = new[]
    {
        "Luis","Ana","Carlos","María","Jorge","Lucía","Pedro","Sofía","Miguel","Paula"
    };

    private static readonly string[] Dominios = new[]
    {
        "example.com","mail.com","test.org","dev.net"
    };

    private readonly Random _random = new();

    public List<User> GenerateUsers(int count)
    {
        if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
        var list = new List<User>(count);
        for (int i = 0; i < count; i++)
        {
            var nombre = Nombres[_random.Next(Nombres.Length)];
            var dominio = Dominios[_random.Next(Dominios.Length)];
            var email = $"{nombre.ToLower()}{_random.Next(100,999)}@{dominio}";
            list.Add(new User
            {
                Id = i + 1,
                Nombre = nombre,
                Email = email
            });
        }
        return list;
    }
}
