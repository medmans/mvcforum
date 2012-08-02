﻿using System;
using System.Collections.Generic;

namespace MVCForum.Domain.DomainModel
{
    public class Post : Entity
    {
        public Guid Id { get; set; }
        public string PostContent { get; set; }
        public DateTime DateCreated { get; set; }
        public int VoteCount { get; set; }
        public DateTime DateEdited { get; set; }
        public bool IsSolution { get; set; }
        public bool IsTopicStarter { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual MembershipUser User { get; set; }
        public virtual IList<Vote> Votes { get; set; }
    }
}