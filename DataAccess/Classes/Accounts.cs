﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Classes
{
	public class Accounts
	{
		public List<DangNhap> GetAccounts()
		{
			return DangNhap.GetAllAccounts();
		}
	}
}