using System.Collections.ObjectModel;

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
