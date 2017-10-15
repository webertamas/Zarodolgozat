using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class DailyLogDbModel
    {
        [Key]
        public int Id { get; set; }
        public AgreementDbModel Agreement { get; set; }
        public bool Use { get; set; }
    }
}
