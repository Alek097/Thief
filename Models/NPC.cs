namespace Models
{
	#region Using
	using System;
	#endregion
	public class NPC
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Job Job { get; set; }
		public virtual King King { get; set; }
		public virtual House House { get; set; }

		public NPC()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
