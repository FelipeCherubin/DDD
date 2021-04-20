using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=DbCurso;Uid=root;Pwd=123mudar;";
            var optionsBuider = new DbContextOptionsBuilder<MyContext>();
            optionsBuider.UseMySql(connectionString, new MySqlServerVersion(new System.Version(8, 0, 23)),
            mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend)
            );
            return new MyContext(optionsBuider.Options);
        }
    }
}
