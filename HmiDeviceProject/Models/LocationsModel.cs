using System.ComponentModel.DataAnnotations;
namespace HmiDeviceProject.Models;

public class LocationsModel
{
    [Key]
    public int LocationId { get; set; }
    public string? Location { get; set; }
    public string? CurrentTemperature { get; set; }
}