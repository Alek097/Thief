namespace Models
{
	#region Using
	using System;
	using Types;
	#endregion
	public class Resource
	{
		public Guid Id { get; set; }
		public ResourceType ResourceType { get; set; }
		public virtual Coordinates Coordinates { get; set; }
		public virtual Kingdom Kingdom { get; set; }
		public Resource()
		{
			this.Id = Guid.NewGuid();
		}
	}
}
