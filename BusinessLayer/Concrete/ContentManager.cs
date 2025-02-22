﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager: IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAddBl(Content heading)
        {

            _contentDal.Insert(heading);

        }

        public void ContentDelete(Content heading)
        {
            _contentDal.Delete(heading);
        }

        public void ContentUpdate(Content heading)
        {
            _contentDal.Update(heading);
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(p => p.ContentId == id);
        }

        public List<Content> GetList(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return _contentDal.List();
            }
            return _contentDal.List(x=>x.ContentText.Contains(p));
        }

        public List<Content> GetListByWriter(int id)
        {
            return _contentDal.List(x => x.WriterId == id);
        }

        public List<Content> GetListHeadingId(int Id)
        {
            return _contentDal.List(x => x.HeadingId == Id);
        }
    }
}
