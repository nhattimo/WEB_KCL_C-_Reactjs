using AutoMapper;
using KCL_Web.Server.Dtos.Post;
using KCL_Web.Server.Dtos.PostCategory;
using KCL_Web.Server.Dtos.Product;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    //Tạo mapper tự động
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {/*
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Region, AddingRegionDto>().ReverseMap();
            CreateMap<Region, UpdatingRegionDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
            CreateMap<Walk, AddingWalkDto>().ReverseMap();
            CreateMap<Walk, UpdatingWalkDto>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();*/
            CreateMap<ProductCatogory,ProductCategoryDto>().ReverseMap();
            CreateMap<ProductCatogory, AddingProductCategory>().ReverseMap();
            CreateMap<ProductCatogory,UpdatingProductCategory>().ReverseMap();
            CreateMap<Product, AddingProduct>().ReverseMap();
            CreateMap<Product, UpdatedProduct>().ReverseMap();
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<PostingCategory,AddingPostCategory>().ReverseMap();
            CreateMap<PostingCategory,UpdatedPostCategory>().ReverseMap();
            CreateMap<PostingCategory,PostingCategoryDto>().ReverseMap();
            CreateMap<Post,AddingPost>().ReverseMap();
            CreateMap<Post,UpdatedPost>().ReverseMap();
            CreateMap<Post, PostDto>().ReverseMap();
        }
    }
}
