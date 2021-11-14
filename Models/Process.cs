using System.Collections.Generic;

namespace QMSystem.Models
{
    public class Process
    {
        public int Id { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        IEnumerable<ProcessPurpose> Purposes { get; set; }
        public Process()
        {
            Purposes = new List<ProcessPurpose>();
        }
    }
}
