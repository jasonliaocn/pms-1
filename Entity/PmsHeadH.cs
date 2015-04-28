/***********************************************************
 ** File Name : PmsHeadH.cs
 ** Copyright (C) 2013 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/Ename.Wang
 ** Create Date : 2013-02-07
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
    public sealed class PmsHeadH
    {
        #region Private Members
        private bool m_IsChanged;
        private bool m_IsDeleted;
        private string m_PmsId;
        private int m_Seq;
        private string m_CrId;
        private string m_CrIdNew;
        private string m_System;
        private string m_SystemNew;
        private string m_Type;
        private string m_TypeNew;
        private DateTime m_DueDate;
        private DateTime m_DueDateNew;
        private string m_Pm;
        private string m_PmNew;
        private string m_Sd;
        private string m_SdNew;
        private string m_Se;
        private string m_SeNew;
        private string m_Qa;
        private string m_QaNew;
        private string m_ReasonType;
        private string m_Reason;
        private DateTime m_Maintaindate;
        private string m_Maintainuser;

        private string m_Description;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public PmsHeadH()
        {
            m_PmsId = string.Empty;
            m_Seq = 0;
            m_CrId = string.Empty;
            m_CrIdNew = string.Empty;
            m_System = string.Empty;
            m_SystemNew = string.Empty;
            m_Type = string.Empty;
            m_TypeNew = string.Empty;
            m_DueDate = new DateTime();
            m_DueDateNew = new DateTime();
            m_Pm = string.Empty;
            m_PmNew = string.Empty;
            m_Sd = string.Empty;
            m_SdNew = string.Empty;
            m_Se = string.Empty;
            m_SeNew = string.Empty;
            m_Qa = string.Empty;
            m_QaNew = string.Empty;
            m_ReasonType = string.Empty;
            m_Reason = string.Empty;
            m_Maintaindate = new DateTime();
            m_Maintainuser = string.Empty;
            m_Description = string.Empty;
        }
        #endregion // End of Default ( Empty ) Class Constuctor

        #region Public Properties

        /// <summary>
        /// 
        /// </summary>		
        public string PmsId
        {
            get { return m_PmsId; }
            set
            {
                if (value != string.Empty && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for PmsId", value, value.ToString());

                m_IsChanged |= (m_PmsId != value); m_PmsId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public int Seq
        {
            get { return m_Seq; }
            set { m_IsChanged |= (m_Seq != value); m_Seq = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CrId
        {
            get { return m_CrId; }
            set
            {
                if (value != string.Empty && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for CrId", value, value.ToString());

                m_IsChanged |= (m_CrId != value); m_CrId = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string CrIdNew
        {
            get { return m_CrIdNew; }
            set
            {
                if (value != string.Empty && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for CrIdNew", value, value.ToString());

                m_IsChanged |= (m_CrIdNew != value); m_CrIdNew = value;
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
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for System", value, value.ToString());

                m_IsChanged |= (m_System != value); m_System = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string SystemNew
        {
            get { return m_SystemNew; }
            set
            {
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for SystemNew", value, value.ToString());

                m_IsChanged |= (m_SystemNew != value); m_SystemNew = value;
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
                if (value != string.Empty && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for Type", value, value.ToString());

                m_IsChanged |= (m_Type != value); m_Type = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string TypeNew
        {
            get { return m_TypeNew; }
            set
            {
                if (value != string.Empty && value.Length > 20)
                    throw new ArgumentOutOfRangeException("Invalid value for TypeNew", value, value.ToString());

                m_IsChanged |= (m_TypeNew != value); m_TypeNew = value;
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
        public DateTime DueDateNew
        {
            get { return m_DueDateNew; }
            set { m_IsChanged |= (m_DueDateNew != value); m_DueDateNew = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Pm
        {
            get { return m_Pm; }
            set
            {
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Pm", value, value.ToString());

                m_IsChanged |= (m_Pm != value); m_Pm = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string PmNew
        {
            get { return m_PmNew; }
            set
            {
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for PmNew", value, value.ToString());

                m_IsChanged |= (m_PmNew != value); m_PmNew = value;
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
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Sd", value, value.ToString());

                m_IsChanged |= (m_Sd != value); m_Sd = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string SdNew
        {
            get { return m_SdNew; }
            set
            {
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for SdNew", value, value.ToString());

                m_IsChanged |= (m_SdNew != value); m_SdNew = value;
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
                if (value != string.Empty && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for Se", value, value.ToString());

                m_IsChanged |= (m_Se != value); m_Se = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string SeNew
        {
            get { return m_SeNew; }
            set
            {
                if (value != string.Empty && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for SeNew", value, value.ToString());

                m_IsChanged |= (m_SeNew != value); m_SeNew = value;
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
                if (value != string.Empty && value.Length > 200)
                    throw new ArgumentOutOfRangeException("Invalid value for Qa", value, value.ToString());

                m_IsChanged |= (m_Qa != value); m_Qa = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string QaNew
        {
            get { return m_QaNew; }
            set
            {
                if (value != string.Empty && value.Length > 200)
                    throw new ArgumentOutOfRangeException("Invalid value for QaNew", value, value.ToString());

                m_IsChanged |= (m_QaNew != value); m_QaNew = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string ReasonType
        {
            get { return m_ReasonType; }
            set
            {
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for ReasonType", value, value.ToString());

                m_IsChanged |= (m_ReasonType != value); m_ReasonType = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Reason
        {
            get { return m_Reason; }
            set
            {
                if (value != string.Empty && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for Reason", value, value.ToString());

                m_IsChanged |= (m_Reason != value); m_Reason = value;
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
                if (value != string.Empty && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Maintainuser", value, value.ToString());

                m_IsChanged |= (m_Maintainuser != value); m_Maintainuser = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Description
        {
            get { return m_Description; }
            set { m_Description = value; }
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