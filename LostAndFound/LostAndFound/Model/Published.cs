using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    [Serializable]
    public partial class Published
    {
        public Published()
        { }

        public Published(int FoundPropertyId)
        {
            this._foundpropertyid = FoundPropertyId;

        }
        //public Published(int AreaID, string AreaName)
        //{
        //    this._areaid = AreaID;
        //    this._areaname = AreaName;

        //}

        public Published(int v1, string v2, string v3, string v4, string v5)
        {
            this._foundpropertyid = v1;
            this. _foundpropertyname =v2;
            this._founddate = v3;
            this._foundpart = v4;
            this._userid = v5;
        }
        #region Model
        private int _foundpropertyid;
        private string _foundpropertyname;
        private string _userid;
        private string _foundpart;
        private string _founddate;
        


        /// <summary>
        /// 
        /// </summary>
        public int FoundPropertyId
        {
            set { _foundpropertyid = value; }
            get { return _foundpropertyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string FoundPropertyName
        {
            set { _foundpropertyname = value; }
            get { return _foundpropertyname; }
        }
    
        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }

        public string FoundDate
        {
            set { _founddate = value; }
            get { return _founddate; }
        }

        public string FoundPart
        {
            set { _foundpart = value; }
            get { return _foundpart; }
        }
   
        #endregion Model

    }
}
