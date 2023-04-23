using System.Collections.Generic;

namespace PLEXRenamer
{
    public class Season
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public int Number { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
