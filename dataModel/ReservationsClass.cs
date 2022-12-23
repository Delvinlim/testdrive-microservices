using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelLayer
{
    public class ReservationsClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int VehicleId { get; set; }
        public VehiclesReservedClass Vehicle { get; set; }
        public bool IsMailSent { get; set; }
    }
    public class VehiclesReservedClass
    {
        [Key]
        public int Vid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
