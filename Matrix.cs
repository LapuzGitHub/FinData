using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinDataForm
{
	class Matrix
	{
		private int rows, columns;
		public int Rows { get { return rows; } }
		public int Columns { get { return columns; } }

		private double[][] matrixData;
		public Matrix(int rows, int columns)
		{
			this.rows = rows;
			this.columns = columns;

			matrixData = new double[rows][];
			for (int i = 0; i < rows; i++)
			{
				matrixData[i] = new double[columns];
			}
		}
		public Matrix(double[] md)
		{
			rows = md.Length;
			columns = 1;

			matrixData = new double[rows][];
			for (int i = 0; i < rows; i++)
			{
				matrixData[i] = new double[] { md[i] };
			}
		}
		public Matrix(double[][] md)
		{
			rows = md.Length;
			columns = md[0].Length;

			matrixData = new double[rows][];
			for (int i = 0; i < rows; i++)
			{
				if(md[i].Length != columns) throw new IndexOutOfRangeException();

				matrixData[i] = new double[columns];
				for (int j = 0; j < columns; j++)
				{
					matrixData[i][j] = md[i][j];
				}
			}
		}
		public double Get(int row, int column = 0)
		{
			if (row < 0 || row >= rows || column < 0 || column >= columns) throw new IndexOutOfRangeException();
			return matrixData[row][column];
		}
		public void Set(double value, int row, int column = 0)
		{
			if (row < 0 || row >= rows || column < 0 || column >= columns) throw new IndexOutOfRangeException();
			matrixData[row][column] = value;
		}
		public Matrix Transpose()
		{
			Matrix resultMatrix = new Matrix(columns, rows);
			for (int i = 0; i < columns; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					resultMatrix.Set(Get(j, i), i, j);
				}
			}

			return resultMatrix;
		}
		public Matrix Product(Matrix other)
		{
			return new Matrix(MatrixCore.MatrixProduct(matrixData, other.matrixData));
		}
		public Matrix Inverse()
		{
			return new Matrix(MatrixCore.MatrixInverse(matrixData));
		}
	}
}
