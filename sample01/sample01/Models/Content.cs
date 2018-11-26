using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample01.Models
{
    /// <summary>
    /// 2018.11.23
    /// LeiZhang
    /// 内容实体类
    /// </summary>
    public class Content
    {
        ///<summary>
        ///主键
        ///</summary>
        private int id;
        public int Id { get => id; set => id = value; }
        ///<summary>
        ///标题
        /// </summary>
        private string title;
        public string Title { get => title; set => title = value; }
        ///<summary>
        ///内容
        ///</summary>
        private string contents;
        public string Contents { get => contents; set => contents = value; }

        ///<summary>
        ///状态  1正常  0删除
        ///</summary>
        private int status;
        public int Status { get => status; set => status = value; }

        ///<summary>
        ///创建时间
        ///</summary>
        private DateTime add_Time;
        public DateTime Add_Time { get => add_Time; set => add_Time = value; }

        ///<summary>
        ///修改时间
        ///</summary>
        private DateTime modify_Time;
        public DateTime Modify_Time { get => modify_Time; set => modify_Time = value; }


    }
}
