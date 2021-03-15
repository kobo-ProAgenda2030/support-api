﻿using Support.API.Services.Models;
using Support.API.Services.Models.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Support.API.Services.Services
{
    public interface IKoboUserService
    {
        IEnumerable<KoboUserDetail> GetAll();
        
        bool UpdateKoboUser(KoboUserRequest request);

        IEnumerable<OrganizationSimple> GetOrganizationsByKoboUsername(string username);
        Task<int> GetKoboUserIdForKoboUsername(string username);
        IEnumerable<string> GetRolesByKoboUsername(string username);

        Task<List<UserAsset>> GetAssetsForCurrentUser(string userName);

        Task<int> GetKoboUserIdForKoboUsername(string username);
    }
}