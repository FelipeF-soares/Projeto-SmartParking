using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartParkWeb.Domain.People;

namespace SmartParkWeb.Domain.Thing;

public class Vehicle
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Marca")]
    public string Make { get; set; }
    [Required]
    [DisplayName("Modelo")]
    public string Model { get; set; }
    [Required]
    [DisplayName("Placa")]
    public string LicensePlate { get; set; }
    [Required]
    [DisplayName("Tipo")]
    public string Type { get; set; }
    [Required]
    [DisplayName("Numero Do Cartão")]
    public string CardNumber { get; set; }
    public int MilitaryId { get; set; }
    public virtual Military Military { get; set; }
}
