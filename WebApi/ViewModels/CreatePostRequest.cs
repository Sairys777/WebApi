using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.ViewModels
{
    public class CreatePostRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
