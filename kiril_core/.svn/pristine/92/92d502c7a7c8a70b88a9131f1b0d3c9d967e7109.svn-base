using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Libraries.LibraryObjects
{
    [Serializable()]
    public class PanelUser
    {
        #region Properties

        public int PanelUserID { get; set; }
        public string PanelUsername { get; set; }
        public string PanelUserPassword { get; set; }
        public string PanelUserEmail { get; set; }
        public bool IsReseller { get; set; }
        public int MarkumUserID { get; set; }
        public int ServerID { get; set; }
        public int PanelUserParentID { get; set; }
        public int RealUserID { get; set; }
        public string RealUsername { get; set; }
        public string RealOwnerUsername { get; set; }
        public int PanelUserStatusID { get; set; }
        public string PanelUserStatusDescription { get; set; }
        public bool IsMarkumUser { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Constructors

        public PanelUser() { }

        public PanelUser(string PanelUsername, string PanelUserPassword, string PanelUserEmail, bool IsReseller, int MarkumUserID, int ServerID, int PanelUserParentID, int RealUserID, string RealUsername, string RealOwnerUsername, int PanelUserStatusID, string PanelUserStatusDescription, DateTime CreationDate, bool IsActive)
        {
            this.PanelUsername = PanelUsername;
            this.PanelUserPassword = PanelUserPassword;
            this.PanelUserEmail = PanelUserEmail;
            this.IsReseller = IsReseller;
            this.MarkumUserID = MarkumUserID;
            this.ServerID = ServerID;
            this.PanelUserParentID = PanelUserParentID;
            this.RealUserID = RealUserID;
            this.RealUsername = RealUsername;
            this.RealOwnerUsername = RealOwnerUsername;
            this.PanelUserStatusID = PanelUserStatusID;
            this.PanelUserStatusDescription = PanelUserStatusDescription;
            this.CreationDate = CreationDate;
            this.IsActive = IsActive;
        }

        #endregion

        public override string ToString()
        {
            return PanelUsername;
        }
    }
}
