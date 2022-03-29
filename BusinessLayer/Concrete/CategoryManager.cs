﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAddBl(Category category)
        {

            _categoryDal.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p=>p.CategoryId==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        




        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category>GetAll()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBl(Category category)
        //{
        //    if (category.CategoryName == "" || category.CategoryName.Length < 3 || category.CategoryDescription == "") 
        //    {

        //    }
        //    else
        //    {
        //        repo.Insert(category);
        //    }
        //}

    }
}
