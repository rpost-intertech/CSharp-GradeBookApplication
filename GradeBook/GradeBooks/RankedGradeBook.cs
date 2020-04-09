using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name): base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            
            if(Students.Count < 5)
                throw new InvalidOperationException();

            if (averageGrade >= 80)
                return 'A';
            else if (60 > averageGrade && averageGrade < 80)
                return 'B';
            else if (40 > averageGrade && averageGrade < 60)
                return 'C';
            else if (20 > averageGrade && averageGrade < 40)
                return 'D';
            else
                return 'F';
        }
    }
}
