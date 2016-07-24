namespace Models
{
	#region Using
	using System;
	#endregion
	public class Road
	{
		public Guid Id { get; set; }
		public int Level { get; set; }
		public virtual Coordinates Coordinates { get; set; }
		public virtual Kingdom Kingdom { get; set; }
		public Road()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
