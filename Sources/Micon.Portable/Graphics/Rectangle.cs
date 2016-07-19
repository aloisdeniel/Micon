﻿namespace Micon.Portable.Graphics
{
    /// <summary>
    /// A rectangle.
    /// </summary>
	public class Rectangle
	{
        public Rectangle()
        {

        }

		public Rectangle(int x, int y, int width, int height)
		{
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
		}

		public int X { get; set; }

		public int Y { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }
	}
}

