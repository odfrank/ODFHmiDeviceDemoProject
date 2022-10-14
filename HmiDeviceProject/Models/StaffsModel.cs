using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace HmiDeviceProject.Models;

public class StaffsModel
{
    [Key]
    public int StaffId { get; set; }
    [Required]
    [DisplayName("Staff Name")]
    public string? StaffName { get; set; }
    [Required]
    public string? Role { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

}