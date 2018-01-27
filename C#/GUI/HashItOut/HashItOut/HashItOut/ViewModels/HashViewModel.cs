using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashItOut.ViewModels
{
    class HashViewModel : INotifyPropertyChanged
    {
        public List<string> SourceFiles
        {
            get { return _sourceFiles; }
            set { _sourceFiles = value; OnPropertyChanged("SourceFiles"); }
        }
        private List<string> _sourceFiles = new List<string>();

        public List<string> Results
        {
            get { return _results; }
            set { _results = value; OnPropertyChanged("Results"); }
        }
        private List<string> _results = new List<string>();

        public bool SHA1Selected
        {
            get { return _sha1; }
            set { _sha1 = value; OnPropertyChanged("SHA1"); }
        }
        private bool _sha1 = true;

        public bool MD5Selected
        {
            get { return _md5; }
            set { _md5 = value; OnPropertyChanged("MD5Selected"); }
        }
        private bool _md5 = true;

        #region Interface Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
