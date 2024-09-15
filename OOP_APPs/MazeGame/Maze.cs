using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    internal class Maze
    {
        int _Width { get; set; }
        int _Height { get; set; }
        private Player _Player; 
        private IMazeObject[,] _MazeObjectArray;


        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            _MazeObjectArray = new IMazeObject[width, height];
            _Player = new Player() { 
              X=1,
              Y=1,
            };
           
        }

        public void MovePlayer() { 
           var userInput =  Console.ReadKey();
           var key = userInput.Key;//inumeration
            switch (key) {

                case ConsoleKey.UpArrow:
                    UpdatePlayer(0,-1);
                    break;

                case ConsoleKey.DownArrow:
                    UpdatePlayer(0,1);

                    break;

                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1,0);

                    break;

                case ConsoleKey.RightArrow:
                    UpdatePlayer(1,0);

                    break;
            }
        }
        private void UpdatePlayer(int dx, int dy) { 
               var newX = _Player.X + dx;
               var newY = _Player.Y + dy;  
               // setting X to new x and Y to new y
               if(newX < _Width && newX >= 0  && newY < _Height && newY >= 0 && _MazeObjectArray[newX, newY].ISolid == false)
            {
                _Player.X = newX;
                _Player.Y = newY;
                DrawMaze();
            }
                
        

        }

        public void DrawMaze() { 
            Console.Clear(); ;
            for(int y =0; y < _Height; y++)
            {
                for(int x = 0; x < _Width; x++)
                {
                    if(x==39 && y == 19)
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].Icon);


                    }
                   else if (x == 0 || y == 0 || x == _Width - 1 || y == _Height - 1)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if (x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);

                    }
                    else if (x % 3 == 0 && y % 3 == 0) {

                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);


                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {

                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);


                    }
                    else
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].Icon);

                    }
                }

                Console.WriteLine();
            }
          
        
        }
    }
}