using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace reunion_issue_high_cpu
{
    public sealed partial class ListWithItemHeaders : UserControl
    {
        public ListWithItemHeaders()
        {
            this.InitializeComponent();

            Loaded += OnLoaded;
        }

        private ICollectionView _messageView;
        
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var groups = new ObservableCollection<MessageGroup>();

                for (int i = 0; i < 60; i++)
                {
                    var date = DateTimeOffset.Now.AddDays(i).ToString();

                    var group = new MessageGroup(date)
                {
                    new MessageItem { Message = "The quick brown fox jumps over the lazy dog." },
                    new MessageItem { Message = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo." },
                    new MessageItem { Message = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt." },
                    new MessageItem { Message = "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem." },
                    new MessageItem { Message = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?" },
                    new MessageItem { Message = "ABCD EFGH IJKL MNO PQRST UVWX YZab cde fghi jklmno pqrst uvw xyz." }
                };

                    groups.Add(group);
                }

                var viewSource = new CollectionViewSource { IsSourceGrouped = true, Source = groups };
                _messageView = viewSource.View;
                messageList.ItemsSource = _messageView;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
