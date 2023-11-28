using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using KuntoLps2.Authentication.JwtBearer;
using KuntoLps2.Authorization;
using KuntoLps2.Authorization.Users;
using KuntoLps2.Models.TokenAuth;
using KuntoLps2.MultiTenancy;
using Microsoft.AspNetCore.Http;
using KuntoLps2.Dokumen;

namespace KuntoLps2.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UploadController : KuntoLps2ControllerBase
    {
        private readonly LogInManager _logInManager;
        private readonly ITenantCache _tenantCache;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly TokenAuthConfiguration _configuration;
        private readonly IUploadService _upload;

        public UploadController(
            LogInManager logInManager,
            ITenantCache tenantCache,
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            TokenAuthConfiguration configuration, 
            IUploadService upload)
        {
            _logInManager = logInManager;
            _tenantCache = tenantCache;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _configuration = configuration;
            _upload = upload;
        }

        [HttpPost]
        public async Task<IActionResult> FileAsync([FromForm] IFormFile data)
        {
            var result = await _upload.UploadFileAsync("File",data);

            return Ok(result);
        }

    }
}
