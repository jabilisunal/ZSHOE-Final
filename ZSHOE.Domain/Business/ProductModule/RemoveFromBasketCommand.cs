﻿using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.DataContexts;
using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Business.ProductModule
{
    public class RemoveFromBasketCommand : IRequest<JsonResponse>
    {
        public int ProductId { get; set; }

        public class RemoveFromBasketCommandHandler : IRequestHandler<RemoveFromBasketCommand, JsonResponse>
        {
            private readonly ZSHOEDbContext db;
            private readonly IActionContextAccessor ctx;

            public RemoveFromBasketCommandHandler(ZSHOEDbContext db, IActionContextAccessor ctx)
            {
                this.db = db;
                this.ctx = ctx;
            }


            public async Task<JsonResponse> Handle(RemoveFromBasketCommand request, CancellationToken cancellationToken)
            {
                var userId = ctx.GetCurrentUserId();

                var basketItem = await db.Basket.FirstOrDefaultAsync(b => b.ProductId == request.ProductId
                                            && b.UserId == userId, cancellationToken);

                if (basketItem == null)
                {
                    return new JsonResponse
                    {
                        Error = true,
                        Message = "Product does not exist in your basket"
                    };
                }

                db.Basket.Remove(basketItem);
                await db.SaveChangesAsync(cancellationToken);

                var info = await (from b in db.Basket
                                  join p in db.Products on b.ProductId equals p.Id
                                  where b.UserId == userId
                                  select new
                                  {
                                      b.UserId,
                                      SubTotal = p.Price * b.Quantity
                                  })
                                .GroupBy(g => g.UserId)
                                .Select(g => new
                                {
                                    Total = g.Sum(m => m.SubTotal),
                                    Count = g.Count()
                                })
                                .FirstOrDefaultAsync(cancellationToken);

                return new JsonResponse
                {
                    Error = false,
                    Message = "Product was deleted from the basket",
                    Value = info
                };
            }
        }
    }
}