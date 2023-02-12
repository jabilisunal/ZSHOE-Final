﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;
using ZSHOE.Domain.Models.DataContexts;

namespace ZSHOE.Domain.Business.BlogPostModule
{
    public class BlogPostCommentRemoveCommand : IRequest<BlogPostComment>
    {
        public int Id { get; set; }

        public class BlogPostCommentRemoveCommandHandler : IRequestHandler<BlogPostCommentRemoveCommand, BlogPostComment>
        {
            private readonly ZSHOEDbContext db;

            public BlogPostCommentRemoveCommandHandler(ZSHOEDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPostComment> Handle(BlogPostCommentRemoveCommand request, CancellationToken cancellationToken)
            {
                var data = db.BlogPostComments.FirstOrDefault(m => m.Id == request.Id && m.DeletedDate == null);

                if (data == null)
                {
                    return null;
                }

                data.DeletedDate = DateTime.UtcNow.AddHours(4);

                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}
