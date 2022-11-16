using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITagService
    {
        int AddTag(Tag tag);
        int UpdateTag(Tag tag);
        int DeleteTag(Tag tag);
        List<Tag> GetAllTag();
        Tag GetTagByID(int id);
    }
}
