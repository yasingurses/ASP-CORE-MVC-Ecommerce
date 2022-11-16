using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TagManager : ITagService
    {
        ITagDal tagDal;
        public TagManager(ITagDal tagDal)
        {
            this.tagDal = tagDal;
        }

        public int AddTag(Tag tag)
        {
            return tagDal.Add(tag);
        }

        public int DeleteTag(Tag tag)
        {
            return tagDal.Delete(tag);
        }

        public List<Tag> GetAllTag()
        {
            return tagDal.GetAll();
        }

        public Tag GetTagByID(int id)
        {
            return tagDal.getByID(id);
        }

        public int UpdateTag(Tag tag)
        {
            return tagDal.Update(tag);
        }
    }
}
