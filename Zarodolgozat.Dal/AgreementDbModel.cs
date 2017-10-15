using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class AgreementDbModel
    {
        [Key]
        public int Id { get; set; }
        public UserDbModel User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Key]
        public ClientDbModel Client { get; set; }
    }
}
