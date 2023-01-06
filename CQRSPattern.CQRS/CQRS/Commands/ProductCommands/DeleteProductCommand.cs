using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.CQRS.Commands.ProductCommands
{
    public class DeleteProductCommand
    {
        public int id { get; set; }
        public DeleteProductCommand(int id)
        {
            this.id = id;
        }
    }
}
