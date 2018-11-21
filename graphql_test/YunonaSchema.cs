using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphql_test
{
    public class YunonaSchema : Schema
    {
        public YunonaSchema(CalendarQuery query)
        {
            Query = query;
        }
    }
}
