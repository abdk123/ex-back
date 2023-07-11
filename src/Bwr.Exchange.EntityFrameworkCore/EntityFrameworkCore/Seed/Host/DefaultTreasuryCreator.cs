using Bwr.Exchange.Settings.Treasuries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bwr.Exchange.EntityFrameworkCore.Seed.Host
{
    public class DefaultTreasuryCreator
    {
        private readonly ExchangeDbContext _context;

        public DefaultTreasuryCreator(ExchangeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            //CreateMainTreasury();
        }

        private void CreateMainTreasury()
        {
            var treasuryExist = _context.Treasuries.Any();
            if (!treasuryExist)
            {
                var treasury = new Treasury();
                treasury.Name = "الصندوق الرئيسي";
                _context.Treasuries.Add(treasury);
                _context.SaveChanges();
            }
            var currencies = _context.Currencies;

            var mainTreasury = _context.Treasuries.FirstOrDefault();
            foreach (var currency in currencies)
            {
                var treasuryBalanceExist = _context.TreasuryBalances.Any(x => x.CurrencyId == currency.Id);
                if (!treasuryBalanceExist)
                {
                    var treasuryBalance = new TreasuryBalance(0, currency.Id, mainTreasury.Id);
                    _context.TreasuryBalances.Add(treasuryBalance);
                }

                _context.SaveChanges();
            }
        }
    }
}
