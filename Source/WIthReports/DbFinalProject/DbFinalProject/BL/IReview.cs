using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public interface IReview
    {
        bool UpdateReview(int stars, string description);
    }
}
