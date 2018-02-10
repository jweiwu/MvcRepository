namespace MvcRepository.Models.DbContextFactory
{
    public interface IDbContextFactory
    {
        AppDbContext GetDbContext();
    }
}