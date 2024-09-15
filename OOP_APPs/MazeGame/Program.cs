using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    internal class Program
    {
        static void Main(string[] args) {

            Maze maze = new Maze(40,20);// construct new maze
            while (true) // run 
            {
                maze.DrawMaze();
                maze.MovePlayer();
            }
        }
    }
}
