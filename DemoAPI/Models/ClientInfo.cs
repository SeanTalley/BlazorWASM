public class ClientInfo
{
    private static Random random = new Random();
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; } = $"972-{random.Next(100,999)}-{random.Next(1000,9999)}";
    public string? Address { get; set; } = $"{random.Next(1,1000)} Real Street Rd.";
    public string? City { get; set; } = "Frisco";
    public string? State { get; set; } = "TX";
    public string? Zip { get; set; } = "75034";
    //public DateTime Created { get; set; } = DateTime.Now;
    //public DateTime LastUpdated { get; set; } = DateTime.Now;
}
public class DataAdapterHelper {
    public List<ClientInfo> Items { get; set; } = new();
    public int Count { get { return Items.Count; } }
}