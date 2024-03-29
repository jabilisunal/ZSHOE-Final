﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Extensions;
using ZSHOE.Domain.Business.BlogPostModule;
using ZSHOE.Domain.Models.DataContexts;
using ZSHOE.Domain.Models.Entities.ViewModels;

namespace ZSHOE.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly ZSHOEDbContext db;
        private readonly IMediator mediator;

        public BlogController(ZSHOEDbContext db, IMediator mediator)
        {
            this.db = db;
            this.mediator = mediator;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(BlogPostGetAllQuery query)
        {
            var response = await mediator.Send(query);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_PostBody", response);
            }
            return View(response);
        }


        [AllowAnonymous]
        [Route("/blog/{slug}")]
        public async Task<IActionResult> Details(BlogPostSingleQuery query)
        {
            var blogPost = await mediator.Send(query);

            var blogPostLikes = await db.BlogPostLikes.Where(bpl => bpl.BlogPostId == blogPost.Id).ToListAsync();

            var vm = new BlogPostItemsViewModel()
            {
                BlogPost = blogPost,
                BlogPostLikes = blogPostLikes
            };

            if (blogPost == null)
            {
                return NotFound();
            }

            return View(vm);
        }

        [HttpPost]
        [Route("/post-comment")]
        public async Task<IActionResult> PostComment(BlogPostCommentCommand command)
        {

            try
            {
                 
                var response = await mediator.Send(command);

                return PartialView("_Comments", response);

            }
            catch (System.Exception ex)
            {

                return Json(new
                {
                    error = true,
                    message = ex.Message
                });

            }

        }

        [HttpPost]
        [Route("/like-unlike-blog-post")]
        public async Task<IActionResult> LikeUnlikeBlogPost(BlogPostLikeUnlikeCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return Json(response);
        }
    }
}