using Microsoft.EntityFrameworkCore;

namespace MrPizza.Repository
{
    public class OrderDbContext : IOrderDbContext, DbContext
    {
    }
}