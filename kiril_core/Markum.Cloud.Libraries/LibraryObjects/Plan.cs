using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markum.Cloud.Libraries.LibraryObjects
{
    [Serializable()]
    public class Plan
    {
        #region Properties

        public int PlanID { get; set; }
        public string PlanName { get; set; }
        public string PlanDescription { get; set; }
        public int ServerID { get; set; }
        public bool IsDynamicService { get; set; }
        public string PlanPriorityID { get; set; }
        public string PlanPriorityGroupID { get; set; }
        public int MarkumUserID { get; set; }
        public string MarkumProductID { get; set; }
        public int SoldPlanID { get; set; }
        public int PlanGroupID { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsResellerPlan { get; set; }
        public bool IsActive { get; set; }
        public int MailServerID { get; set; }
        public int MsSqlServerID { get; set; }
        public int MySqlServerID { get; set; }
        public int ServerPoolRuleID { get; set; }
        public int MailServerPoolRuleID { get; set; }
        public int MsSqlServerPoolRuleID { get; set; }
        public int MySqlServerPoolRuleID { get; set; }
        public bool ResellerDefault { get; set; }
        public int ProductTypeID { get; set; }
        public string ConditionValue { get; set; }
        public string SolusNode { get; set; }
        public int ApiID { get; set; }
        #endregion

        #region Constructors

        public Plan() { }

        public Plan(string PlanName, string PlanDescription, int ServerID, bool IsDynamicService, string PlanPriorityID, string PlanPriorityGroupID, int MarkumUserID, string MarkumProductID, int SoldPlanID, int PlanGroupID, DateTime CreationDate, bool IsResellerPlan, bool IsActive, int MailServerID, int MsSqlServerID, int MySqlServerID, int ServerPoolRuleID, int MailServerPoolRuleID, int MsSqlServerPoolRuleID, int MySqlServerPoolRuleID, bool ResellerDefault, int ProductTypeID)
        {
            this.PlanName = PlanName;
            this.PlanDescription = PlanDescription;
            this.ServerID = ServerID;
            this.IsDynamicService = IsDynamicService;
            this.PlanPriorityID = PlanPriorityID;
            this.PlanPriorityGroupID = PlanPriorityGroupID;
            this.MarkumUserID = MarkumUserID;
            this.MarkumProductID = MarkumProductID;
            this.SoldPlanID = SoldPlanID;
            this.PlanGroupID = PlanGroupID;
            this.CreationDate = CreationDate;
            this.IsResellerPlan = IsResellerPlan;
            this.IsActive = IsActive;
            this.MailServerID = MailServerID;
            this.MsSqlServerID = MsSqlServerID;
            this.MySqlServerID = MySqlServerID;
            this.ServerPoolRuleID = ServerPoolRuleID;
            this.MailServerPoolRuleID = MailServerPoolRuleID;
            this.MsSqlServerPoolRuleID = MsSqlServerPoolRuleID;
            this.MySqlServerPoolRuleID = MySqlServerPoolRuleID;
            this.ResellerDefault = ResellerDefault;
            this.ProductTypeID = ProductTypeID;
        }

        #endregion
    }
}
