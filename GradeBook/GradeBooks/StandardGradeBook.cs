using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    { 
        //invoke a constructor from BaseGradeBook using base
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
