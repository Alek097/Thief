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
		public virtual ICollection<NPC> People { get; set; }
		//Kingdom
		public Coordinates Coordinates { get; set; }
		public Coordinates Rotation { get; set; }

		public House()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
