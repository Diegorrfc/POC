using System;
using Trigre.Entity;
using Trigre.Repository.Interfaces;

namespace Trigre.Repository
{
    public class BotRepository
    {
        public BotRepository : Repository<Bot>, IBotRepository
        {
        }
    }
}
