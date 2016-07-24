namespace Models
{
	#region Using
	using System;
	using UnityEngine;
	#endregion
	public class Coordinates
	{
		public Guid Id { get; set; }
		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }

		public Coordinates()
		{
			this.Id = Guid.NewGuid();
		}

		public Coordinates(float x, float y, float z)
			: this()
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public static explicit operator Vector3(Coordinates coor)
		{
			return new Vector3(coor.X, coor.Y, coor.Z);
		}

		public static explicit operator Coordinates(Vector3 vector)
		{
			return new Coordinates(vector.x, vector.y, vector.z);
		}
	}
}