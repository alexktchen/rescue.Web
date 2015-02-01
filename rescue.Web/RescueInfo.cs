using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rescue.Web
{
    /// <summary>
    /// 求救資訊
    /// </summary>
    public class RescueInfo
    {
        public int id { get; set; }
        // X座標 
        public string xaddr { get; set; }
        // Y座標 
        public string yaddr { get; set; }
        // 求救時間
        public DateTime rescuetime { get; set; }
        // 圖片URL
        public string photoUrl { get; set; }
        // 影片URL
        public string videoUrl { get; set; }
    }

    public class HelpInfo
    {
        public int id { get; set; }
        // 救援點名稱
        public string name { get; set; }
        // X座標
        public string xaddr { get; set; }
        // y座標
        public string yaddr { get; set; }
        // 電話
        public string tel { get; set; }
        // 網站
        public string website { get; set; }

    }
}