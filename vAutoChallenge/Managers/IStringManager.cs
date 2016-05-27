using System.Collections.Generic;
using vAutoChallenge.Models;

namespace vAutoChallenge.Managers
{
    interface IStringManager
    {
        List<StringItems> StringModifier(string input);
    }
}
