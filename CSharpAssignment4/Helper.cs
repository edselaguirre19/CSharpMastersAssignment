using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignment4
{
    public static class Helper
    {
        public static bool ValidateName(string name) => (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) ? false : true;
        
    }
}
