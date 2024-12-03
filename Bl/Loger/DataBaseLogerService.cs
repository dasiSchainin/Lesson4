using lesson3.Dl;

using lesson3.Model;

namespace lesson3.Bl.Loger
{
    public class DataBaseLogerService : ILoggerService
    {
        private readonly TaskDbContext _context;
        public DataBaseLogerService(TaskDbContext context)
        {
            _context = context;
        }
        public void Log(string message)
        {
            Logger1 logger = new Logger1();
            logger.log = message;
            //logger.Id = 1;
            _context.Logger1.Add(logger);
            _context.SaveChanges();
        }
    }
}
