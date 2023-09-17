using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id=1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99m,
            ReleaseDate = new DateTime(1991, 2,1)
        },
        new Game()
        {
            Id=2,
            Name = "Final Fantasy XIV",
            Genre = "Roleplaying",
            Price = 59.99m,
            ReleaseDate = new DateTime(2010, 9,30)
        },
        new Game()
        {
            Id=3,
            Name = "FIFA 23",
            Genre = "Sports",
            Price = 69.99m,
            ReleaseDate = new DateTime(2022, 9,27)
        },
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(g => g.Id) + 1;
        games.Add(game);
    }
}