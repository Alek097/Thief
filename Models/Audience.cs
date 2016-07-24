namespace Models
{
	#region Using
	using System;
	using Types;
	#endregion
	public class Audience
	{
		public Guid Id { get; set; }
		public AudienceType AudienceType { get; set; }
		public virtual NPC Slave { get; set; }
		public virtual King King { get; set; }

		public Audience()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
