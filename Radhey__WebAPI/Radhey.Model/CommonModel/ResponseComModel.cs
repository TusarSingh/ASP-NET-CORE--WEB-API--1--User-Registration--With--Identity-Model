﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Radhey.Model.CommonModel
{
    public class ResponseComModel
    {
#nullable disable
        //public ResponseComModel()
        //{
        //    this.StatusCode = (int)HttpStatusCode.OK;
        //}

        public int StatusCode { get; set; }

        public bool IsSuccess { get; set; }

        public string StatusMessage { get; set; }

        

    }


    public class ResponseComModel<T> : ResponseComModel
    {
        public T Data { get; set; }

        public T ValidationError { get; set; }


        //public object ValidationError { get; set; }

        public string Token { get; set; }

    }


}
