﻿using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Services
{
    class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository

        public IEnumerable<Account> GetAccounts()
        {

        }
    }
}
