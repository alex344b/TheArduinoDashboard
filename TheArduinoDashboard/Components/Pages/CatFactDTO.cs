namespace TheArduinoDashboard.Components.Pages;

public class CatFactDTO
{
    public DateTime dateAdded { get; set; }
    public string fact { get; set; }
    public int likes { get; set; }
    public int dislikes { get; set; }
}

public class Pages
{
    public List<CatFactDTO> data { get; set; }
    public int page { get; set; }
    public int pagesize { get; set; }
    public int toatlCount { get; set; }
    public int totalPages { get; set; }
}