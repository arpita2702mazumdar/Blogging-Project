using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BloggingAPI.DTO;
using BloggingAPI.Model;

namespace BloggingAPI.Services.Mapper
{
    public class CommentMapProfile : Profile
    {
        public CommentMapProfile()
        {
            CreateMap<CommentsModel, Comments>()
                .ForMember(d => d.blogId, opt => opt.MapFrom(s => s.blogId))
                .ForMember(d => d.userId, opt => opt.MapFrom(s => s.userId))
                .ForMember(d => d.commentContent, opt => opt.MapFrom(s => s.commentContent))
                ;
        }
    }
}
