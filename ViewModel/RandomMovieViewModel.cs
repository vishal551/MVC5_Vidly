﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Sample.Models;
namespace MVC_Sample.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}