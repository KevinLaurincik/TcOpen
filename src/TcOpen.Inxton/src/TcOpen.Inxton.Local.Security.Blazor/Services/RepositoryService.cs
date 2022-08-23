﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcOpen.Inxton.Data;
using TcOpen.Inxton.Local.Security.Blazor.Users;

namespace TcOpen.Inxton.Local.Security.Blazor.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly IRepository<UserData>  _userRepository;
        private readonly BlazorRoleGroupManager _roleGroupManager;
        private bool _disposed;
        public RepositoryService(IRepository<UserData> userRepository, BlazorRoleGroupManager roleGroupManager)
        {
            _userRepository = userRepository;
            _roleGroupManager = roleGroupManager;
        }
        public IRepository<UserData> UserRepository
        {
            get
            {
                return _userRepository;
            }
        }

        public BlazorRoleGroupManager RoleGroupManager
        {
            get
            {
                return _roleGroupManager;
            }
        }

        public void Dispose()
        {
            _disposed = true;
        }
    }
}
