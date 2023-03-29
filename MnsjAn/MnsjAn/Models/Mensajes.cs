using System;
using System.Collections.Generic;
using System.Text;

namespace MnsjAn.Models
{
  public  class Mensajes
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public int tipo_id { get; set; }
        public int usuario_id { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
