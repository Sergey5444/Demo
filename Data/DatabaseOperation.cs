using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Data;

namespace Demo
{
    class DatabaseOperation
    {
        public static class DatabaseOperations
        {

            private static bd7Entities Entities;


            public static void InitializeEntities()
            {

                if (Entities is null)
                {
                    Entities = new bd7Entities();
                }

            }
        }
    }
}
