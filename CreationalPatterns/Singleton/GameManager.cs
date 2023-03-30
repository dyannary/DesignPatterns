using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class GameManager
    {
        private static GameManager _gameManager;

        private static readonly object _syncLock = new object();
        public string menu { get; set; }    
        private GameManager() { }

        public static GameManager GetGameManager()
        {
            if(_gameManager == null)
            {
                lock(_syncLock)
                {
                    if(_gameManager == null )
                    {
                        _gameManager = new GameManager();
                    }
                }
            }
            return _gameManager;
        }

        public void OpenMenu() 
        {
            Console.WriteLine("MENU");
        }

        public void StartGame()
        {
            Console.WriteLine("Waiting...");
        }
    }
}
