﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter.Models
{
    class Items
    {
    }
    public class User_ItemList
    {
        public string name { get; set; }
    }

    public class User_ItemMenager
    {

        public static List<User_ItemList> getInstance()
        {
            var lists = new List<User_ItemList> { };
            lists.Add(new User_ItemList { name = "改名卡" });
            lists.Add(new User_ItemList { name = "双倍经验卡" });
            lists.Add(new User_ItemList { name = "提示卡" });
            lists.Add(new User_ItemList { name = "好人卡" });
            lists.Add(new User_ItemList { name = "好人卡" });
            lists.Add(new User_ItemList { name = "好人卡" });
            lists.Add(new User_ItemList { name = "好人卡" });
            lists.Add(new User_ItemList { name = "好人卡" });
            return lists;
        }
    }
    public class Shop_ItemList
    {
        public string name { get; set; }
        public string img { get; set; }
        public int cost { get; set; }
        public string content { get; set; }
    }

    public class Shop_ItemMenager
    {

        public static List<Shop_ItemList> getInstance()
        {
            var lists = new List<Shop_ItemList> { };
            lists.Add(new Shop_ItemList { name = "提示卡" ,cost=100,content="获取一次提示的机会"});
            lists.Add(new Shop_ItemList { name = "双倍经验卡" ,cost=500,content="一段时间内经验值获取量翻倍"});
            lists.Add(new Shop_ItemList { name = "跳关卡" });
            lists.Add(new Shop_ItemList { name = "好人卡" });
            lists.Add(new Shop_ItemList { name = "好人卡" });
            lists.Add(new Shop_ItemList { name = "好人卡" });
            lists.Add(new Shop_ItemList { name = "好人卡" });
            return lists;
        }
    }
}
