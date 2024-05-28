using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    public class ViewModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Theme { get; set; }
        public string Body { get; set; }
        private ObservableCollection<string> attachments;
        public IEnumerable<string> Attachments => attachments;
        public ViewModel(string from)
        {
            From = from;  
            attachments = new ObservableCollection<string>();
        }
        public void AddAttach(string at)
        {
           attachments.Add(at);
        }

    }
}
