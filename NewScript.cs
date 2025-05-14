using Godot;
using System;

public partial class NewScript : Node
{
  public override void _Ready()
	{
		int rows = 10; // Number of rows
		int cols = 10; // Number of columns

		int[,] matrix = new int[rows, cols];

		// Populate the matrix with multiplication table values
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				matrix[i, j] = (i + 1) * (j + 1);
			}
		}

		// Print the multiplication table
		for (int i = 0; i < rows; i++)
		{
			string rowOutput = "";
			for (int j = 0; j < cols; j++)
			{
				rowOutput += $"{matrix[i, j],4}";
			}
			GD.Print(rowOutput); // Print each row to Godot's Output window
		}
	}
}
