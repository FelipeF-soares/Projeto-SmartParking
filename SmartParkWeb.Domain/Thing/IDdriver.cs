using SmartParkWeb.Domain.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.Domain.Thing;

public class IDdriver
{
    [Required]
    public int Id { get; set; }
    [Required]
    [DisplayName("Número da CNH")]
    public string RegisterNumber { get; set; }
    [Required]
    [DisplayName("Validade")]
    public DateTime Validity { get; set; }
    [Required]
    [DisplayName("Categoria")]
    public string Category { get; set; }
    public int? MilitaryId { get; set; }
    public virtual Military Military { get; set; }
}
