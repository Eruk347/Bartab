using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bartab.Interface
{
    public interface IConnectionInformationService
    {
        string ConnectionString { get; }
    }
}
