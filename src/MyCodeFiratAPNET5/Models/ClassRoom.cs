using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyCodeFiratAPNET5.Models
{
    /// <summary>
    /// 教室
    /// </summary>
    public class ClassRoom
    {
        /// <summary>
        /// 流水號
        /// </summary>
        [Key]
        public int id { get; set; }
        /// <summary>
        /// 教室編號
        /// </summary>
        [Required]
        [StringLength(10)]
        public string ClassRoomId { get; set; }
        /// <summary>
        /// 教室名稱
        /// </summary>
        [Required]
        [StringLength(200)]
        public string ClassRoomName { get; set; }
        /// <summary>
        /// 教室樓層
        /// </summary>
        [Required]
        public virtual int ClassFloor { get; set; }
        /// <summary>
        /// 人數
        /// </summary>
        [Required]
        public int NumOfPeoples { get; set; }
        /// <summary>
        /// 參考的大樓流水號
        /// </summary>
        [Required]
        public int BuildingId { get; set; }
    }
}