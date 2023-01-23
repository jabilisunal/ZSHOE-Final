﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class AboutTeam:BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string Slug { get; set; }
        public string TwitterLink { get; set; }
    }
}