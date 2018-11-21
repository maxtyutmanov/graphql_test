using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphql_test
{
    public class CalendarQuery : ObjectGraphType
    {
        private readonly DataStore _store;

        public CalendarQuery(DataStore store)
        {
            _store = store;

            Field<ExchangeCalendarType>(
                "exchangeCalendar",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType>() { Name = "exchangeCode" },
                    new QueryArgument<IntGraphType>() { Name = "year" }),
                resolve: ctx =>
                {
                    return new ExchangeCalendar();
                });
        }
    }
}
