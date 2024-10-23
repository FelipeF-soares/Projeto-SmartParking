using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.Domain.People;

public class Person
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Nome Completo")]
    public string Name { get; set; }
    [Required]
    [DisplayName("RG")]
    public string IdentificationDocument { get; set; }
    [Required]
    [DisplayName("Contato")]
    public string CellPhone { get; set; }
    [Required]
    [DisplayName("E-mail")]
    public string Email { get; set; }
}
