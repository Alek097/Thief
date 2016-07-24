namespace Models
{
	#region Using
	using System;
	using System.Collections.Generic;
	#endregion
	public class Kingdom
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public virtual King King { get; set; }
		public virtual ICollection<House> Houses { get; set; }
		public virtual ICollection<Road> Roads { get; set; }
		public virtual ICollection<Shelter> Shelters { get; set; }
		public virtual ICollection<Resource> Resources { get; set; }
		public Kingdom()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
