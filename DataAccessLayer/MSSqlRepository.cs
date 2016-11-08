using Burse.LinqToMSSql;

namespace DataAccessLayer
{
    public class MSSqlRepository
    {
        public static BurseMSSqlDataContext Repository { get; } = new BurseMSSqlDataContext();

        public MSSqlRepository()
        {
        }
    }
}
