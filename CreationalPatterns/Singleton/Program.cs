namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameLoggerMenu = GameManager.GetGameManager();

            var gameLoggerStartGame = GameManager.GetGameManager();

            //gameLogger.OpenMenu();
            //gameLogger.StartGame();

            Task.Run(() => gameLoggerMenu.OpenMenu());

            Task.Run(() => gameLoggerStartGame.StartGame());
        }
    }
}