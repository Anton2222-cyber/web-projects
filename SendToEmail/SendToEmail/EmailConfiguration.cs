using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendToEmail
{
    public class EmailConfiguration
    {
        //Хто відправляє листа
        public string From { set; get; } = "antonlashch@ukr.net";

        //адреса smptp сервера
        public string SmptpServer { set; get; } = "smtp.ukr.net";

        //порт smptp сервера
        public int Port { set; get; } = 2525;
        //ім'я користувача для авторизації
        public string UserName { set; get; } = "antonlashch@ukr.net";

        //пароль який видав сервер
        public string Password { set; get; } = "jlHXHHu9kte8gmZs";
    }
}
