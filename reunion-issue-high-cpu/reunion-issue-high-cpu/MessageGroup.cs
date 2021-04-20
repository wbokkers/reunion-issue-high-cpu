using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reunion_issue_high_cpu
{
    public class MessageGroup : ObservableCollection<MessageItem>
    {
        public MessageGroup(string groupDate)
        {
            GroupDate = groupDate;
        }

        public string GroupDate { get; }
    }


}
