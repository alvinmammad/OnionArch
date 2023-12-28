using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Domain.Common
{
    public class EntityBase
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
