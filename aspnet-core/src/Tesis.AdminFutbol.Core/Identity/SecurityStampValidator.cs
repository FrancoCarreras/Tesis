﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Tesis.AdminFutbol.Authorization.Roles;
using Tesis.AdminFutbol.Authorization.Users;
using Tesis.AdminFutbol.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace Tesis.AdminFutbol.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
