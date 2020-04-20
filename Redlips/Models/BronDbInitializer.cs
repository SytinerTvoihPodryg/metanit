using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Redlips.Models
{
    public class BronDbInitializer
    {
        public class BookDbInitializer : DropCreateDatabaseAlways<BronContext>
        {
            protected override void Seed(BronContext db)
            {
                db.Bron.Add(new Bron { NumberID = 4, human = 4, time = 220 });
                db.Bron.Add(new Bron { NumberID = 3, human = 7, time = 180 });
                db.Bron.Add(new Bron { NumberID = 6, human = 2, time = 150 });

                base.Seed(db);
            }
        }
    }
}