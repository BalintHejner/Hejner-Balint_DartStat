using Hejner_Balint_DartStat.Datamodels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hejner_Balint_DartStat.Viewmodels
{
    public class TopListViewModel
    {
		private ObservableCollection<ToplistDatamodel> toplist;

		    public ObservableCollection<ToplistDatamodel> ToplistCollection
		    {
			    get { return toplist; }
			    set { toplist = value; }
		    }

        public TopListViewModel()
        {
            toplist = new ObservableCollection<ToplistDatamodel>();
            this.GenerateRows();
        }

        public void GenerateRows()
        {
            toplist.Add(new ToplistDatamodel { });
        }
    }
}
