using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
  class Rover
  {

    private int[] _position;
    private int _x = 0, _y = 1;
    private char _orientation;
    private string _movement;

    public Rover( int x, int y, char or, string movement )
    {
      _position = new int[2];
      _position[_x] = x;
      _position[_y] = y;
      _orientation = or;
      _movement = movement;
    }

    public string CalcPosition( int plateauX, int plateauY )
    {
      foreach (char dir in _movement)
      {
        switch (dir)
        {
          case 'M':
            MoveForward();
            break;
          case 'L':
            TurnLeft();
            break;
          case 'R':
            TurnRight();
            break;
        }
      }
      return (_position[_x] < 0 || _position[_x] > plateauX || _position[_y] < 0 || _position[_y] > plateauY)
        ? "Rover is outside the plateu" :
          _position[_x].ToString() + " " + _position[_y].ToString() + " " + _orientation;
    }

    private void MoveForward()
    {
      switch(_orientation)
      {
        case 'N':
          _position[_y]++;
          break;
        case 'S':
          _position[_y]--;
          break;
        case 'W':
          _position[_x]--;
          break;
        case 'E':
          _position[_x]++;
          break;
      }
    }

    private void TurnLeft() 
    {
      switch (_orientation)
      {
        case 'N':
          _orientation = 'W';
          break;
        case 'W':
          _orientation = 'S';
          break;
        case 'S':
          _orientation = 'E';
          break;
        case 'E':
          _orientation = 'N';
          break;
      }
    }

    private void TurnRight()
    {
      {
        switch (_orientation)
        {
          case 'N':
            _orientation = 'E';
            break;
          case 'E':
            _orientation = 'S';
            break;
          case 'S':
            _orientation = 'W';
            break;
          case 'W':
            _orientation = 'N';
            break;
        }
      }
    }
  }
}
