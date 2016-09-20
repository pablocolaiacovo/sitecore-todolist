using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreTodo.Models
{
    [SitecoreType(AutoMap = true, TemplateId = "{C66EFAE3-7678-495A-B3D3-E3EBBB19B886}")]
    public class Todo
    {
        [SitecoreField("Text")]
        public virtual string Text { get; set; }
        [SitecoreField("Done")]
        public virtual bool Done { get; set; }
    }
}