using System.ComponentModel.DataAnnotations;
namespace HmiDeviceProject.Models;

public class DevicesModel
{
    [Key]
    public int DeviceId { get; set; }

    [Required]
    public string? Location { get; set; }

    [Required]
    public string? Status { get; set; }

    public int SetTemperature { get; set; }

    public string? AssignedStaff { get; set; }

    public DateTime MaintenanceDate { get; set; } = DateTime.Now;

}