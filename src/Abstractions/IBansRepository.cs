using ChatAdmin.Bot.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zs.Bot.Data.Abstractions;

namespace ChatAdmin.Bot.Abstractions
{
    internal interface IBansRepository : IRepository<Ban, int>
    {
        Task<List<Ban>> FindAllTodaysBanWarningsAsync();
    }
}
