﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public interface IUniversity
    {
        void WriteAllFaculties();
        void AddFaculty();
        void DeleteFaculty();
        void ChooseFaculty();
    }
}
