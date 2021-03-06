﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Template.ServiceClient
{
    public class CustomIdentity : IIdentity
    {
        private readonly string _authenticationType;
        private readonly bool _isAuthenticated;
        private readonly string _name;

        public CustomIdentity(string authenticationType, bool isAuthenticated, string name)
        {
            _authenticationType = authenticationType;
            _isAuthenticated = isAuthenticated;
            _name = name;
        }

        public DateTime? LastPasswordChange { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsLockedOut { get; set; }
        public List<string> Roles { get; set; }
        public string UserRoleType { get; set; }
        public int? UserRoleTypeId { get; set; }
        public int? UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public bool RememberMe { get; set; }
        public bool IsActive { get; set; }

        public string AuthenticationType
        {
            get { return _authenticationType; }
        }

        public bool IsAuthenticated
        {
            get { return _isAuthenticated; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
