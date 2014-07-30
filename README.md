Battleship Puzzle
=================

Context
-------
This problem is based on the battleship game. The battleship ground is a 10x10 grid.

A fleet is composed of a carrier (5 holes), battleship (4 holes), 1 destroyer (3 holes), 1 submarine (3 holes) and 1 small assault chip.

A user places his fleet on the grid which remains fixed during the life of the game.

Reference: [http://en.wikipedia.org/wiki/Battleship_(puzzle)](http://en.wikipedia.org/wiki/Battleship_(puzzle) "Battleship Puzzle on Wikipedia")
 
Goal
----
We need an API, which given a coordinate within the grid, tells the caller whether the game is over (complete fleet is destroyed), whether it was a miss or whether one of the boats was hit and if so, whether the boat sank (all holes have been hit). 

Notes
-----
- API outline

		enum Result
		{
			Miss,
			Hit,
			ShipSank,
			GameOver
			// errors: invalid coordinates, game over
		}
	
		class BattleshipPuzzle
		{
			public Result ShootAt(int x, int y);
		}
	
- common sense methods

		class BattleshipPuzzle
		{
			public void NewGame();
		}

- design notes:
	- how do we store the board?
	- algorithms:
		- determine if a ship was hit
		- determine if all ships are sunk
	- extra feature: generate board

Representing the board
---
Building and representing a board is an interesting problem in itself. It might worth creating a separate class for it.

Tentative interface:

	public class Board
	{
		public AddShip(Point origin, Ship ship);
		public Ship ShipAt(int x, int y);
		public bool AreAllShipsSunk();
	}

	public class Ship
	{
		public Ship(Size size, Orientation orientation);
		public void Hit(Point location);
		public bool IsSunk();
	}

