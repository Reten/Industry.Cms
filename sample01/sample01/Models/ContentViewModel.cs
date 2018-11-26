using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample01.Models
{
    /// <summary>
    /// 2018.11.23
    /// LeiZhang
    /// Content视图模式
    /// </summary>
    public class ContentViewModel
    {
        ///<summary>
        ///内容列表
        ///</summary>

        private List<Content> contentes;
        public List<Content> Contentes { get => contentes; set => contentes = value; }
    }
}
