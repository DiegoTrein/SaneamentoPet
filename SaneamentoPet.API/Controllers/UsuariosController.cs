/* using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly string _connectionString;

    public UsuariosController(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] UsuariosController user) // Certifique-se de usar o modelo Usuario
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            var command = new MySqlCommand("SELECT * FROM account WHERE usuario = @usuario AND senha = @senha", connection);
            command.Parameters.AddWithValue("@usuario", user.Usuario); // Use 'Usuario' com 'U' maiúsculo
            command.Parameters.AddWithValue("@senha", user.Senha); // Use 'Senha' com 'S' maiúsculo

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return Ok(new { Message = "Login bem-sucedido!" });
                }
                else
                {
                    return Unauthorized(new { Message = "Credenciais inválidas." });
                }
            }
        }
    }
} */