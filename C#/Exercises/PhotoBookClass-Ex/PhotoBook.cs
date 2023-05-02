﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass_Ex
{
    internal class PhotoBook
    {
        private int numPages;
        public int GetNumberOfPages()
        {
            return numPages;
        }
        public PhotoBook() 
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
    }
}
