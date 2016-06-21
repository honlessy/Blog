//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blogentries
    {
        public Blogentries()
        {
            this.Blog_Tags = new HashSet<Blog_Tags>();
            this.Comments = new HashSet<Comments>();
        }
    
        public int blog_id { get; set; }
        public Nullable<int> author_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string allowcomment { get; set; }
        public string markprivate { get; set; }
        public string body { get; set; }
        public Nullable<System.DateTime> datecreated { get; set; }
        public Nullable<System.DateTime> datepublished { get; set; }
        public Nullable<System.DateTime> datemodified { get; set; }
        public string islock { get; set; }
        public Nullable<int> blogtype_id { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual ICollection<Blog_Tags> Blog_Tags { get; set; }
        public virtual Blogtypes Blogtypes { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}