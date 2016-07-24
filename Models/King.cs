namespace Models
{
	#region Using
	using System;
	using System.Collections.Generic;
	#endregion
	public class King
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public virtual ICollection<NPC> Slaves { get; set; }
		public King()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
