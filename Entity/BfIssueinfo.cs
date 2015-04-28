/***********************************************************
 ** File Name : BfIssueinfo.cs
 ** Copyright (C) 2011 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/Kite.Zhang
 ** Create Date : 2011-08-26
 ** Modifier :
 ** Modify Date :
 **
 ** Description:
 **
 ***********************************************************/
using System;

namespace Qisda.PMS.Entity
{
    /// <summary>
    ///	Generated by MyGeneration using the IBatis Object Mapping template
    /// </summary>
    [Serializable]
    public sealed class BfIssueinfo
    {
        #region Private Members
        private bool m_IsChanged;
        private bool m_IsDeleted;
        private int m_Issueid;
        private short m_Projectid;
        private string m_ProjectName;
        private int m_Moduleid;
        private string m_ModulePath;
        private string m_IssueTitle;
        private int m_IssueSeverity;
        private int m_IssuePriority;
        private string m_IssueType;
        private string m_Issueos;
        private string m_IssueBrowser;
        private string m_IssueMachine;
        private string m_HowFound;
        private string m_ReproSteps;
        private string m_IssueStatus;
        private string m_IssueSubStatus;
        private string m_Linkid;
        private string m_Caseid;
        private string m_Duplicateid;
        private string m_MailTo;
        private string m_OpenedBy;
        private DateTime m_OpenedDate;
        private string m_OpenedBuild;
        private string m_AssignedTo;
        private DateTime m_AssignedDate;
        private string m_ResolvedBy;
        private string m_Resolution;
        private string m_ResolvedBuild;
        private DateTime m_ResolvedDate;
        private string m_ClosedBy;
        private DateTime m_ClosedDate;
        private string m_LastEditedBy;
        private DateTime m_LastEditedDate;
        private string m_ModifiedBy;
        private string m_IssueKeyword;
        private int m_Resultid;
        private string m_CustomField1;
        private string m_CustomField2;
        private string m_CustomField3;
        private string m_IsDroped;
        private string m_DutyBy;
        private string m_Cause;
        private string m_CauseAnalyze;
        private string m_Strategy;
        private DateTime m_DueDate;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public BfIssueinfo()
        {
            m_Issueid = 0;
            m_Projectid = 0;
            m_ProjectName = null;
            m_Moduleid = 0;
            m_ModulePath = null;
            m_IssueTitle = null;
            m_IssueSeverity = new byte();
            m_IssuePriority = new byte();
            m_IssueType = null;
            m_Issueos = null;
            m_IssueBrowser = null;
            m_IssueMachine = null;
            m_HowFound = null;
            m_ReproSteps = null;
            m_IssueStatus = null;
            m_IssueSubStatus = null;
            m_Linkid = null;
            m_Caseid = null;
            m_Duplicateid = null;
            m_MailTo = null;
            m_OpenedBy = null;
            m_OpenedDate = new DateTime();
            m_OpenedBuild = null;
            m_AssignedTo = null;
            m_AssignedDate = new DateTime();
            m_ResolvedBy = null;
            m_Resolution = null;
            m_ResolvedBuild = null;
            m_ResolvedDate = new DateTime();
            m_ClosedBy = null;
            m_ClosedDate = new DateTime();
            m_LastEditedBy = null;
            m_LastEditedDate = new DateTime();
            m_ModifiedBy = null;
            m_IssueKeyword = null;
            m_Resultid = 0;
            m_CustomField1 = null;
            m_CustomField2 = null;
            m_CustomField3 = null;
            m_IsDroped = null;
            m_DutyBy = null;
            m_Cause = null;
            m_CauseAnalyze = null;
            m_Strategy = null;
            m_DueDate = new DateTime();
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		
        public int Issueid
        {
            get { return m_Issueid; }
            set { m_IsChanged |= (m_Issueid != value); m_Issueid = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public short Projectid
        {
            get { return m_Projectid; }
            set { m_IsChanged |= (m_Projectid != value); m_Projectid = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ProjectName
        {
            get { return m_ProjectName; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for ProjectName", value, value.ToString());

                m_IsChanged |= (m_ProjectName != value); m_ProjectName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public int Moduleid
        {
            get { return m_Moduleid; }
            set { m_IsChanged |= (m_Moduleid != value); m_Moduleid = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ModulePath
        {
            get { return m_ModulePath; }
            set
            {
                if (value != null && value.Length > 240)
                    throw new ArgumentOutOfRangeException("Invalid value for ModulePath", value, value.ToString());

                m_IsChanged |= (m_ModulePath != value); m_ModulePath = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueTitle
        {
            get { return m_IssueTitle; }
            set
            {
                if (value != null && value.Length > 150)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueTitle", value, value.ToString());

                m_IsChanged |= (m_IssueTitle != value); m_IssueTitle = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public int IssueSeverity
        {
            get { return m_IssueSeverity; }
            set
            {
                m_IsChanged |= (m_IssueSeverity != value); m_IssueSeverity = value;
            }

        }

        /// <summary>
        /// 
        /// </summary>		
        public int IssuePriority
        {
            get { return m_IssuePriority; }
            set
            {
                m_IsChanged |= (m_IssuePriority != value); m_IssuePriority = value;
            }

        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueType
        {
            get { return m_IssueType; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueType", value, value.ToString());

                m_IsChanged |= (m_IssueType != value); m_IssueType = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Issueos
        {
            get { return m_Issueos; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Issueos", value, value.ToString());

                m_IsChanged |= (m_Issueos != value); m_Issueos = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueBrowser
        {
            get { return m_IssueBrowser; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueBrowser", value, value.ToString());

                m_IsChanged |= (m_IssueBrowser != value); m_IssueBrowser = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueMachine
        {
            get { return m_IssueMachine; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueMachine", value, value.ToString());

                m_IsChanged |= (m_IssueMachine != value); m_IssueMachine = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string HowFound
        {
            get { return m_HowFound; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for HowFound", value, value.ToString());

                m_IsChanged |= (m_HowFound != value); m_HowFound = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ReproSteps
        {
            get { return m_ReproSteps; }
            set
            {

                m_IsChanged |= (m_ReproSteps != value); m_ReproSteps = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueStatus
        {
            get { return m_IssueStatus; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueStatus", value, value.ToString());

                m_IsChanged |= (m_IssueStatus != value); m_IssueStatus = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueSubStatus
        {
            get { return m_IssueSubStatus; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueSubStatus", value, value.ToString());

                m_IsChanged |= (m_IssueSubStatus != value); m_IssueSubStatus = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Linkid
        {
            get { return m_Linkid; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for Linkid", value, value.ToString());

                m_IsChanged |= (m_Linkid != value); m_Linkid = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Caseid
        {
            get { return m_Caseid; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for Caseid", value, value.ToString());

                m_IsChanged |= (m_Caseid != value); m_Caseid = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Duplicateid
        {
            get { return m_Duplicateid; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for Duplicateid", value, value.ToString());

                m_IsChanged |= (m_Duplicateid != value); m_Duplicateid = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string MailTo
        {
            get { return m_MailTo; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for MailTo", value, value.ToString());

                m_IsChanged |= (m_MailTo != value); m_MailTo = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string OpenedBy
        {
            get { return m_OpenedBy; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for OpenedBy", value, value.ToString());

                m_IsChanged |= (m_OpenedBy != value); m_OpenedBy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime OpenedDate
        {
            get { return m_OpenedDate; }
            set { m_IsChanged |= (m_OpenedDate != value); m_OpenedDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string OpenedBuild
        {
            get { return m_OpenedBuild; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for OpenedBuild", value, value.ToString());

                m_IsChanged |= (m_OpenedBuild != value); m_OpenedBuild = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string AssignedTo
        {
            get { return m_AssignedTo; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for AssignedTo", value, value.ToString());

                m_IsChanged |= (m_AssignedTo != value); m_AssignedTo = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime AssignedDate
        {
            get { return m_AssignedDate; }
            set { m_IsChanged |= (m_AssignedDate != value); m_AssignedDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ResolvedBy
        {
            get { return m_ResolvedBy; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for ResolvedBy", value, value.ToString());

                m_IsChanged |= (m_ResolvedBy != value); m_ResolvedBy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Resolution
        {
            get { return m_Resolution; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for Resolution", value, value.ToString());

                m_IsChanged |= (m_Resolution != value); m_Resolution = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ResolvedBuild
        {
            get { return m_ResolvedBuild; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for ResolvedBuild", value, value.ToString());

                m_IsChanged |= (m_ResolvedBuild != value); m_ResolvedBuild = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime ResolvedDate
        {
            get { return m_ResolvedDate; }
            set { m_IsChanged |= (m_ResolvedDate != value); m_ResolvedDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ClosedBy
        {
            get { return m_ClosedBy; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for ClosedBy", value, value.ToString());

                m_IsChanged |= (m_ClosedBy != value); m_ClosedBy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime ClosedDate
        {
            get { return m_ClosedDate; }
            set { m_IsChanged |= (m_ClosedDate != value); m_ClosedDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string LastEditedBy
        {
            get { return m_LastEditedBy; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for LastEditedBy", value, value.ToString());

                m_IsChanged |= (m_LastEditedBy != value); m_LastEditedBy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime LastEditedDate
        {
            get { return m_LastEditedDate; }
            set { m_IsChanged |= (m_LastEditedDate != value); m_LastEditedDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ModifiedBy
        {
            get { return m_ModifiedBy; }
            set
            {

                m_IsChanged |= (m_ModifiedBy != value); m_ModifiedBy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IssueKeyword
        {
            get { return m_IssueKeyword; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for IssueKeyword", value, value.ToString());

                m_IsChanged |= (m_IssueKeyword != value); m_IssueKeyword = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public int Resultid
        {
            get { return m_Resultid; }
            set { m_IsChanged |= (m_Resultid != value); m_Resultid = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CustomField1
        {
            get { return m_CustomField1; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for CustomField1", value, value.ToString());

                m_IsChanged |= (m_CustomField1 != value); m_CustomField1 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CustomField2
        {
            get { return m_CustomField2; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for CustomField2", value, value.ToString());

                m_IsChanged |= (m_CustomField2 != value); m_CustomField2 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CustomField3
        {
            get { return m_CustomField3; }
            set
            {
                if (value != null && value.Length > 255)
                    throw new ArgumentOutOfRangeException("Invalid value for CustomField3", value, value.ToString());

                m_IsChanged |= (m_CustomField3 != value); m_CustomField3 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string IsDroped
        {
            get { return m_IsDroped; }
            set
            {
                m_IsChanged |= (m_IsDroped != value); m_IsDroped = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string DutyBy
        {
            get { return m_DutyBy; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for DutyBy", value, value.ToString());

                m_IsChanged |= (m_DutyBy != value); m_DutyBy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Cause
        {
            get { return m_Cause; }
            set
            {
                m_IsChanged |= (m_Cause != value); m_Cause = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CauseAnalyze
        {
            get { return m_CauseAnalyze; }
            set
            {


                m_IsChanged |= (m_CauseAnalyze != value); m_CauseAnalyze = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Strategy
        {
            get { return m_Strategy; }
            set
            {


                m_IsChanged |= (m_Strategy != value); m_Strategy = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime DueDate
        {
            get { return m_DueDate; }
            set { m_IsChanged |= (m_DueDate != value); m_DueDate = value; }
        }

        /// <summary>
        /// Returns whether or not the object has changed it's values.
        /// </summary>
        public bool IsChanged
        {
            get { return m_IsChanged; }
        }

        /// <summary>
        /// Returns whether or not the object has changed it's values.
        /// </summary>
        public bool IsDeleted
        {
            get { return m_IsDeleted; }
        }

        #endregion


        #region Public Functions

        /// <summary>
        /// mark the item as deleted
        /// </summary>
        public void MarkAsDeleted()
        {
            m_IsDeleted = true;
            m_IsChanged = true;
        }

        #endregion


    }
}
