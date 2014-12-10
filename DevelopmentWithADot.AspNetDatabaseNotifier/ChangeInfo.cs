
namespace DevelopmentWithADot.AspNetDatabaseNotifier
{
	public enum ChangeInfo
	{
		AlreadyChanged = -2,
		Unknown = -1,
		Truncate = 0,
		Insert = 1,
		Update = 2,
		Delete = 3,
		Drop = 4,
		Alter = 5,
		Restart = 6,
		Error = 7,
		Query = 8,
		Invalid = 9,
		Options = 10,
		Isolation = 11,
		Expired = 12,
		Resource = 13,
		PreviousFire = 14,
		TemplateLimit = 15,
		Merge = 16,
	}
}
