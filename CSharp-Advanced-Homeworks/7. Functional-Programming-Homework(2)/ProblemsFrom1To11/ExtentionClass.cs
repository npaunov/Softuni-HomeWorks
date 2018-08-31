using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class ExtentionClass
{
    public static List<Student> ExtentionCount(this IList<Student> marks)
    {
        var result =
            from s in marks
            where (s.Marks.Count(x => x == 2) == 2)
            select s;
        return result.ToList();
    }

}

