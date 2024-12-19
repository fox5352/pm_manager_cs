using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pm_manager
{
    public struct DataViewStruct {
        public bool IsLive { get; set; }
        public string ImagePath { get; set; }
        public string HeaderText { get; set; }
        public string ContentText { get; set; }
    }

    public sealed class DataViewHook
    {
        private static readonly Lazy<DataViewHook> _instace = new Lazy<DataViewHook>(()=>new DataViewHook());

        public static DataViewHook Instance = _instace.Value;

        private DataViewStruct data;

        private DataViewHook()
        {
            this.data = new DataViewStruct();
        }

        public bool toggle_isLive()
        {
            this.data.IsLive = !this.data.IsLive;
            return this.data.IsLive;
        }

        public bool get_isLive()
        {
            return this.data.IsLive;
        }
    }
}
