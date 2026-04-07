using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Auth.Exceptions
{
        public class EmailOrPasswordShouldNotBeInvalidException : BaseExceptions
        {
            public EmailOrPasswordShouldNotBeInvalidException() : base("kullanıcı adı veya şifre yanlıştır  ") { }
        }
    
}
