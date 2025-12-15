namespace Vue_Marketeo_WebAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 权限等级
        /// </summary>
        public UserRole Role { get; set; }
    }

    public enum UserRole 
    {
        Admin,     //超级管理员
        Manager,        //管理员
        User,           //普通用户
    }
}
