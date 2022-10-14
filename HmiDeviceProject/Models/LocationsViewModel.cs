using System.ComponentModel.DataAnnotations;

namespace HmiDeviceProject.Models;

public class LocationsViewModel
{
    [Key]
    public int Id { get; set; }
    public string? Location { get; set; }
    public string? CurrentTemperature { get; set; }
}