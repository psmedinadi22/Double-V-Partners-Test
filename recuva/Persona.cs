using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public string FechaCreacion { get; set; }

        private string numIdentificacionTipo;

        public string GetNumIdentificacionTipo()
        {
            return numIdentificacionTipo;
        }

        public void SetNumIdentificacionTipo(string value)
        {
            numIdentificacionTipo = value;
        }

        private string nombresApellidos;

        public string GetNombresApellidos()
        {
            return nombresApellidos;
        }

        public void SetNombresApellidos(string value)
        {
            nombresApellidos = value;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string NumIdentificacionTipo
        {
            get { return $"{NumeroIdentificacion} - {TipoIdentificacion}"; }
            private set { }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string NombresApellidos
        {
            get { return $"{Nombres} {Apellidos}"; }
            private set { }
        }


    }

    

}
