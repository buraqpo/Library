﻿using System;
using System.Collections.Generic;
using Library.Model;

namespace Library.Web.Models
{
    public interface IReserveViewModel
    {
        int ReserveId { get; set; }
        string Isbn { get; set; }
        string BookTitle { get; set; }
        List<AuthorViewModel> Authors { get; set; }
        BookStatus ReserveState { get; set; }
        DateTime ReserveDate { get; set; }
        DateTime ReturnDate { get; set; }
        string UserEmail { get; set; }
        DateTime? UserReturnedDate { get; set; }
    }
}