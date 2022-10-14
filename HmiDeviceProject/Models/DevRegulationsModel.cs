using System.ComponentModel.DataAnnotations;
namespace HmiDeviceProject.Models;

public class DevRegulationsModel
{
    [Key]
    public int RegId { get; set; }
    public int StaffId { get; set; }
    public int DeviceId { get; set; }
    public string? Task { get; set; }
    public string? SetValue { get; set; }
    public string? Role { get; set; }
    public DateTime TaskDate { get; set; } = DateTime.Now;

}