using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SampleCoreApp.Domain
{
    public class SamuraiDbContextFactory : IDbContextFactory<SamuraiContext>
    {
        private readonly string _connString =
                    "Server=ALIENBONMK2\\SQLEXPRESS;Database=SampleCoreApp;Persist Security Info=True;User ID=sa;Password=QZMoyqkeahg6R;MultipleActiveResultSets=True";

        public SamuraiContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<SamuraiContext>();
            builder.UseSqlServer(_connString);
            return new SamuraiContext(builder.Options);
        }
    }
}