﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services.BASE;

namespace Blog.Core.Services
{
    public class TopicDetailServices: BaseServices<TopicDetail>, ITopicDetailServices
    {
        ITopicDetailRepository dal;
        public TopicDetailServices(ITopicDetailRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
}