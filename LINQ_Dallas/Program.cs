using LINQ_Dallas;

class Program
{
    static void Main(string[] args)
    {
        // assigns games to all the string bellow
        Game[] games = new Game[]
        {
            new Game("Minecraft", 'E', "Action-Adventure"),
            new Game("CS:GO", 'M', "FPS"),
            new Game("Elden Ring", 'M', "Action-Adventure"),
            new Game("Valorant", 'T', "FPS"),
            new Game("Halo 3", 'M', "Action FPS"),
            new Game("Zombcube", 'E', "FPS Survival"),
            new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
            new Game("Paddle Balls", 'E', "Arcade Casual"),
            new Game("Rocket League", 'E', "Action Racing"),
            new Game("Fifa 22", 'E', "Sport"),
        };

        //creats a var for games with a title longer then 9 chareters then selects them
        var shortGames = from game in games
                         where game.Title.Length < 9
                         select $"Game Title: {game.Title.ToUpper()}";
        //for each one it prints it to the console
        foreach ( var game in shortGames )
        {
            Console.WriteLine(game);
        }
        //creats a var for thr game minecraft and selcts it title ESRB and Genre and then prints it to the console
        var mineCraft = games.Where(game => game.Title == "Minecraft")
                        .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

        Console.WriteLine(mineCraft.FirstOrDefault());

        //creates a var for games with a raiting of T and finds them and selects all games with a T rating
        var tRated = from game in games
                     where game.Esrb == 'T'
                     select game.Title;
        //prints out the follwoingand then foreach of them it prints out the title
        Console.WriteLine("T Rated Games:");
        foreach ( var game in tRated)
        {
            Console.WriteLine(game);
        }

        //creates a var for E rated games and action games to selcet the game title
        var eRatedAction = from game in games
                           where game.Esrb == 'E' && game.Genre.Contains("Action")
                           select game.Title;

        //prints the following and then for each prints out the title
        Console.WriteLine("E Rated Action Games:");
        foreach (var game in eRatedAction)
        {
            Console.WriteLine(game);
        }
    }
}