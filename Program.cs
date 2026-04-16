using Eventix_Project.Data;

using (var context = new EventixContext())
{
	foreach (var item in context.Users)
	{
        Console.WriteLine(item.Id);
	}
}