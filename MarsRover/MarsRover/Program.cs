using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
  class Program
  {
    static void Main( string[] args )
    {
      int plateauX, plateauY;
      int roverX, roverY;
      char roverOr;
      List<Rover> roverList = new List<Rover>();
      string line = "-1";
      while (line != "" && line != null) 
      {
        line = Console.ReadLine(); //Read plateau dimension
        string[] plateau = line.Split( ' ' );
        plateauX = Int32.Parse( plateau[0] );
        plateauY = Int32.Parse( plateau[1] );
        line = Console.ReadLine();
        while (line != "" && line != null) //Read information and orientation of each rover
        {
          string[] roverLine = line.Split( ' ' );
          roverX = Int32.Parse( roverLine[0] );
          roverY = Int32.Parse( roverLine[1] );
          roverOr = Char.Parse( roverLine[2] );
          line = Console.ReadLine();
          string movement = line;
          roverList.Add( new Rover( roverX, roverY, roverOr, movement ) );
          line = Console.ReadLine();
        }

        foreach (Rover rover in roverList) //After reading all the info, calc the new position of each rover
        {
          Console.WriteLine( rover.CalcPosition( plateauX, plateauY ) );
        }

        Console.WriteLine( "==========" );
        Console.ReadLine(); //Pause
      }
    }
  }
}
