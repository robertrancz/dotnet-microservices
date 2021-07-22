﻿using Shopping.Aggregator.Models;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasketAsync(string userName);
    }
}
