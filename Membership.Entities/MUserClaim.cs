﻿using Microsoft.AspNetCore.Identity;
using SharedMolecules.Entities;

namespace Membership.Entities
{
   public class MUserClaim : IdentityUserClaim<int>, ISMEntity
    {
        #region Properties
        public bool IsValid { get; set; } = true;
        #endregion

        #region Constructors

        #endregion

        #region Methods

        #endregion
    }
}
