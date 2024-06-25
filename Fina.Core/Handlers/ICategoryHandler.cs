﻿using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(UdateCategoryRequest request);

        Task<Response<Category>> UpdateAsync(UdateCategoryRequest request);

        Task<Response<Category>> DeleteAsync(DeleteCategoryRequest request);

        Task<Response<Category>> GetByIdAsync(GetCategoryByIdRequest request);

        Task<PagedResponse<List<Category>>> GetAllAsync(GetAllCategoriesRequest request);


    }
}
