using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGB
{
    public interface IStudents
    {
        void AddStudents(Student student);

        List<Student> getStudents { get; }

        Student getStudent { get; }

        int indexStudent { set; }
    }
}
