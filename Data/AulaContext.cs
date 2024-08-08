using Microsoft.EntityFrameworkCore;
namespace ExercicioGitHubMarqueto.Data
{
    public class AulaContext : DbContext
    {
        public AulaContext(DbContextOptions<AulaContext> options) : base(options) 
        {
        }
    }
}
