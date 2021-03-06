/***********************************************************
 ** File Name : PmsProjectCommitmentHitRate.cs
 ** Copyright (C) 2013 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/Ename.Wang
 ** Create Date : 2013-03-25
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
    public sealed class PmsProjectCommitmentHitRate
    {
        #region Private Members
        private bool m_IsChanged;
        private bool m_IsDeleted;
        private int m_Serial;
        private string m_Month;
        private string m_Week;
        private string m_UserDept;
        private string m_PmsId;
        private string m_CrId;
        private string m_CrName;
        private string m_Type;
        private string m_System;
        private string m_Domain;
        private string m_Priority;
        private string m_Site;
        private DateTime m_DueDate;
        private DateTime m_ReleaseDate;
        private string m_Pm;
        private string m_Sd;
        private string m_Se;
        private string m_Qa;
        private string m_Status;
        private string m_Rerver1;
        private string m_Rerver2;
        private string m_Rerver3;
        private string m_Rerver4;
        private string m_Rerver5;
        private DateTime m_Createdate;
        private string m_Createuser;
        private DateTime m_Maintaindate;
        private string m_Maintainuser;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public PmsProjectCommitmentHitRate()
        {
            m_Serial = 0;
            m_Month = string.Empty;
            m_Week = string.Empty;
            m_UserDept = string.Empty;
            m_PmsId = string.Empty;
            m_CrId = string.Empty;
            m_CrName = string.Empty;
            m_Type = string.Empty;
            m_System = string.Empty;
            m_Domain = string.Empty;
            m_Priority = string.Empty;
            m_Site = string.Empty;
            m_DueDate = new DateTime();
            m_ReleaseDate = new DateTime();
            m_Pm = string.Empty;
            m_Sd = string.Empty;
            m_Se = string.Empty;
            m_Qa = string.Empty;
            m_Status = string.Empty;
            m_Rerver1 = string.Empty;
            m_Rerver2 = string.Empty;
            m_Rerver3 = string.Empty;
            m_Rerver4 = string.Empty;
            m_Rerver5 = string.Empty;
            m_Createdate = new DateTime();
            m_Createuser = string.Empty;
            m_Maintaindate = new DateTime();
            m_Maintainuser = string.Empty;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		
        public int Serial
        {
            get { return m_Serial; }
            set { m_IsChanged |= (m_Serial != value); m_Serial = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Month
        {
            get { return m_Month; }
            set
            {
                if (value != null && value.Length > 10)
                    throw new ArgumentOutOfRangeException("Invalid value for Month", value, value.ToString());

                m_IsChanged |= (m_Month != value); m_Month = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Week
        {
            get { return m_Week; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for Week", value, value.ToString());

                m_IsChanged |= (m_Week != value); m_Week = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string UserDept
        {
            get { return m_UserDept; }
            set
            {
                if (value != null && value.Length > 10)
                    throw new ArgumentOutOfRangeException("Invalid value for UserDept", value, value.ToString());

                m_IsChanged |= (m_UserDept != value); m_UserDept = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string PmsId
        {
            get { return m_PmsId; }
            set
            {
                if (value != null && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for PmsId", value, value.ToString());

                m_IsChanged |= (m_PmsId != value); m_PmsId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CrId
        {
            get { return m_CrId; }
            set
            {
                if (value != null && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for CrId", value, value.ToString());

                m_IsChanged |= (m_CrId != value); m_CrId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CrName
        {
            get { return m_CrName; }
            set
            {
                if (value != null && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for CrName", value, value.ToString());

                m_IsChanged |= (m_CrName != value); m_CrName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Type
        {
            get { return m_Type; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for Type", value, value.ToString());

                m_IsChanged |= (m_Type != value); m_Type = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string System
        {
            get { return m_System; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for System", value, value.ToString());

                m_IsChanged |= (m_System != value); m_System = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Domain
        {
            get { return m_Domain; }
            set
            {
                if (value != null && value.Length > 30)
                    throw new ArgumentOutOfRangeException("Invalid value for Domain", value, value.ToString());

                m_IsChanged |= (m_Domain != value); m_Domain = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Priority
        {
            get { return m_Priority; }
            set
            {
                if (value != null && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for Priority", value, value.ToString());

                m_IsChanged |= (m_Priority != value); m_Priority = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Site
        {
            get { return m_Site; }
            set
            {
                if (value != null && value.Length > 10)
                    throw new ArgumentOutOfRangeException("Invalid value for Site", value, value.ToString());

                m_IsChanged |= (m_Site != value); m_Site = value;
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
        /// 
        /// </summary>		
        public DateTime ReleaseDate
        {
            get { return m_ReleaseDate; }
            set { m_IsChanged |= (m_ReleaseDate != value); m_ReleaseDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Pm
        {
            get { return m_Pm; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Pm", value, value.ToString());

                m_IsChanged |= (m_Pm != value); m_Pm = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Sd
        {
            get { return m_Sd; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Sd", value, value.ToString());

                m_IsChanged |= (m_Sd != value); m_Sd = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Se
        {
            get { return m_Se; }
            set
            {
                if (value != null && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for Se", value, value.ToString());

                m_IsChanged |= (m_Se != value); m_Se = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Qa
        {
            get { return m_Qa; }
            set
            {
                if (value != null && value.Length > 200)
                    throw new ArgumentOutOfRangeException("Invalid value for Qa", value, value.ToString());

                m_IsChanged |= (m_Qa != value); m_Qa = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Status
        {
            get { return m_Status; }
            set
            {
                if (value != null && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for Status", value, value.ToString());

                m_IsChanged |= (m_Status != value); m_Status = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Rerver1
        {
            get { return m_Rerver1; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Rerver1", value, value.ToString());

                m_IsChanged |= (m_Rerver1 != value); m_Rerver1 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Rerver2
        {
            get { return m_Rerver2; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Rerver2", value, value.ToString());

                m_IsChanged |= (m_Rerver2 != value); m_Rerver2 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Rerver3
        {
            get { return m_Rerver3; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Rerver3", value, value.ToString());

                m_IsChanged |= (m_Rerver3 != value); m_Rerver3 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Rerver4
        {
            get { return m_Rerver4; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Rerver4", value, value.ToString());

                m_IsChanged |= (m_Rerver4 != value); m_Rerver4 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Rerver5
        {
            get { return m_Rerver5; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Rerver5", value, value.ToString());

                m_IsChanged |= (m_Rerver5 != value); m_Rerver5 = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime Createdate
        {
            get { return m_Createdate; }
            set { m_IsChanged |= (m_Createdate != value); m_Createdate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Createuser
        {
            get { return m_Createuser; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for Createuser", value, value.ToString());

                m_IsChanged |= (m_Createuser != value); m_Createuser = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime Maintaindate
        {
            get { return m_Maintaindate; }
            set { m_IsChanged |= (m_Maintaindate != value); m_Maintaindate = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Maintainuser
        {
            get { return m_Maintainuser; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for Maintainuser", value, value.ToString());

                m_IsChanged |= (m_Maintainuser != value); m_Maintainuser = value;
            }
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
