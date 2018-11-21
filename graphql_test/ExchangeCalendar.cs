using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphql_test
{
    public class ExchangeCalendarType : ObjectGraphType<ExchangeCalendar>
    {
        private readonly DataStore _store;

        public ExchangeCalendarType(DataStore store)
        {
            Field(i => i.TradingHolidays).Resolve(ctx =>
            {
                var exchangeCode = ctx.GetArgument<string>("exchangeCode");
                var year = ctx.GetArgument<int>("year");

                return _store.GetHolidays(exchangeCode, year, "trading");
            });
            Field(i => i.SettlementHolidays).Resolve(ctx =>
            {
                var exchangeCode = ctx.GetArgument<string>("exchangeCode");
                var year = ctx.GetArgument<int>("year");

                return _store.GetHolidays(exchangeCode, year, "settlement");
            });
            _store = store;
        }
    }

    public class ExchangeCalendar
    {
        public List<Holiday> TradingHolidays { get; set; }

        public List<Holiday> SettlementHolidays { get; set; }
    }
}
