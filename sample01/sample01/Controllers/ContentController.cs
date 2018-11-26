using Microsoft.AspNetCore.Mvc;
using sample01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample01.Controllers
{
    /// <summary>
    /// 2108.11.23
    /// LeiZhang
    /// content控制器
    /// </summary>
    public class ContentController : Controller
    {
        ///<summary>
        ///首页显示
        ///</summary>
        ///<returns></returns>

        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(new Content { Id = i, Title = $"{i}的标题", Contents = $"{i}的内容", Status = 1, Add_Time = DateTime.Now.AddDays(-i) });
            }
            return View(new ContentViewModel { Contentes = contents });
        }

    }
}
