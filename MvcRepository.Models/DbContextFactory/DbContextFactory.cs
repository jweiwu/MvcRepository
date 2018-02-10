namespace MvcRepository.Models.DbContextFactory
{
    public class DbContextFactory : IDbContextFactory
    {
        private AppDbContext _dbContext;

        private AppDbContext dbContext
        {
            get
            {
                if (this._dbContext == null)
                {
                    this._dbContext = new AppDbContext();
                }
                return _dbContext;
            }
        }
        
        public AppDbContext GetDbContext()
        {
            return this.dbContext;
        }
    }
}