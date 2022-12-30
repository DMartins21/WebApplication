﻿using System.Collections.Generic;
using System.Linq;
using WebApplication.Data;
using WebApplication.Models;
namespace WebApplication.Services
{
    public class SellerService
    {
        private readonly WebApplicationContext _context;

        public SellerService(WebApplicationContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
