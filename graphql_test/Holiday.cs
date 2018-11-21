using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphql_test
{
    public class HolidayType : ObjectGraphType<Holiday>
    {
        public HolidayType()
        {
            Field(i => i.Date);
            Field(i => i.Description);
        }
    }

    public class Holiday
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
