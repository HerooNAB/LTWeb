﻿using NgoAnBinh_Lab456.DTOs;
using NgoAnBinh_Lab456.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;

namespace Ngo.Controllers
{

    public class FollowingsController : ApiController
    {
       
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
            {
                var following = new Following
                {
                    FollowerId = userId,
                    FolloweeId = followingDto.FolloweeId,
                };

                _dbContext.Followings.Attach(following);
                _dbContext.Followings.Remove(following);
                _dbContext.SaveChanges();
                return Ok();
            }
            else {
                var following = new Following 
                { 
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId,              
                };

                _dbContext.Followings.Add(following);
                _dbContext.SaveChanges();               
                return Ok();
            }      
        }       
    }
}
