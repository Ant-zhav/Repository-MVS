using Xunit;
using Microsoft.EntityFrameworkCore;
using Complex742.Data;
using Complex742.Models.Equipments;
using Npgsql.BackendMessages;

namespace Complex742Tests
{
    public class DBTests
    {
        
        private readonly Complex742Context _context;
        public DBTests(Complex742Context context)
        {
            _context = context;
        }

        [Fact]

        public void ConnectionString()
        {

        }
    }
}