namespace Models
{
	#region Using
	using System;
	using System.Collections.Generic;
	#endregion
	public class House
	{
		public Guid Id { get; set; }
		public int ModelType { get; set; }
		public int Level { get; set; }
		public virtual ICollection<NPC> People { get; set; }
		public virtual Kingdom Kingdom { get; set; }
		public virtual Coordinates Coordinates { get; set; }
		public virtual Coordinates Rotation { get; set; }

		public House()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
