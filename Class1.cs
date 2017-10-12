using System;
using MySql.Data.MySqlClient;
using Xunit;

namespace XunitLoadAssembly
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            using (new MySqlConnection())
            {
            }
        }
    }
}
