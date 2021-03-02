using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers.Data
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
