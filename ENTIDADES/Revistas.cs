﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ENTIDADES
{
    public partial class Revistas
    {
        public int IdPublicacion { get; set; }
        public int NumArticulos { get; set; }
        public int PagComienzo { get; set; }
        public int PagTerminacion { get; set; }

        public virtual Publicaciones IdPublicacionNavigation { get; set; }
    }
}