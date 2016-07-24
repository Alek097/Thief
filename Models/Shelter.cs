namespace Models
{
	#region Using
	using System;
	#endregion
	public class Shelter
	{
		public Guid Id { get; set; }
		public int ModelType { get; set; }
		public Coordinates Coordinates { get; set; }
		public Kingdom Kingdom { get; set; }
		public Shelter()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
