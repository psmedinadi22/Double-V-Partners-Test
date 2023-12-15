using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace APICORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly DBtestContext _context;

        public PersonasController(DBtestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Persona> Get() => _context.Personas.ToList();



        [HttpPost]
            public ActionResult AgregarPersona(string nombres, string apellidos, string numIdentificacion, string email, string tipoIdentificacion, string nombresApellidos)
            {
                string connectionString = "Server=DESKTOP-O0UKSD6;Database=DBtest;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO [DBtest].[dbo].[Personas] " +
                                   "(Nombres, Apellidos, NumeroIdentificacion, Email, TipoIdentificacion, NombresApellidos, FechaCreacion, NumIdentificacionTipo) " +
                                   "VALUES (@Nombres, @Apellidos, @NumeroIdentificacion, @Email, @TipoIdentificacion, @NombresApellidos, GETDATE(), @NumIdentificacionTipo)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombres", nombres);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@NumeroIdentificacion", numIdentificacion);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@TipoIdentificacion", tipoIdentificacion);
                    command.Parameters.AddWithValue("@NombresApellidos", nombresApellidos);
                    command.Parameters.AddWithValue("@NumIdentificacionTipo", numIdentificacion + tipoIdentificacion); 

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return Content("Persona agregada correctamente");
                    }
                    catch (Exception ex)
                    {
                        return Content("Error al agregar persona: " + ex.Message);
                    }
                }
            }


            [HttpGet("{id}")]
        public IActionResult GetPersona(int id)
        {
            var persona = _context.Personas.FirstOrDefault(p => p.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }

       
    }

}
