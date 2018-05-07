namespace Bungie
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Responses;

    public interface IDService
    {
        Task<GetAdvisorsV2Response> GetAdvisorsv2(bool? definitions = null);
    }
}
