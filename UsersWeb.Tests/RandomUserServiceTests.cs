using UsersWeb.Services;
using Xunit;

namespace UsersWeb.Tests;

public class RandomUserServiceTests
{
    [Fact]
    public void GenerateUsers_CountMatches()
    {
        var service = new RandomUserService();
        var users = service.GenerateUsers(5);
        Assert.Equal(5, users.Count);
    }

    [Fact]
    public void GenerateUsers_UniqueIds()
    {
        var service = new RandomUserService();
        var users = service.GenerateUsers(10);
        Assert.Equal(users.Count, users.Select(u => u.Id).Distinct().Count());
    }

    [Fact]
    public void GenerateUsers_NonNegativeCount()
    {
        var service = new RandomUserService();
        Assert.Throws<ArgumentOutOfRangeException>(() => service.GenerateUsers(-1));
    }
}
