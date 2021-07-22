using System;
using System.Text;
using System.Collections.Generic;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
       public AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
