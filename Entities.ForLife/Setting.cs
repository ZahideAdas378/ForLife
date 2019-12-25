using ForLife.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ForLife
{
    public class Setting : IEntity
    {
        public int SettingID { get; set; }
        public byte[] logo{ get; set; }
        public  string Title { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address  { get; set; }
        public string  Email { get; set; }
        public string Facebook { get; set; }
        public string Youtube { get; set; }
        public string Instagram { get; set; }
        public string  GoogleMap { get; set; }
        public string LegalWarning { get; set; }
        public string LawLink { get; set; }
        public string DecreeLink { get; set; }
        public string CircularLink { get; set; }
        public string ReligionDecisionLink { get; set; }
        public string About { get; set; }
        public string Mission { get; set; }
        public string Vision { get; set; }
        public string HomeVideo { get; set; }
        public string VideoDescription { get; set; }
        public string FirstAside { get; set; }
        public string SecondAside { get; set; }
      
      
    }
}
