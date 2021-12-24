namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Gender { get; set; }
    public int Age {get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}