/***********************************************************
 ** File Name : SdpDetail.cs
 ** Copyright (C) 2013 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/Ename.Wang
 ** Create Date : 2013-12-25
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
    public sealed class SdpDetail
    {
        #region Private Members
        private bool m_IsChanged;
        private bool m_IsDeleted;
        private int m_Serial;
        private string m_Serials;
        private string m_Pmsid;
        private int m_Taskno;
        private string m_TaskName;
        private double m_Refcost;
        private double m_Plancost;
        private double m_Actualcost;
        private DateTime m_Planstartday;
        private DateTime m_Planendday;
        private DateTime m_Actualstartday;
        private DateTime m_Actualendday;
        private int m_PretaskNo;
        private string m_Role;
        private string m_Resource;
        private string m_Remark;
        private string m_Phase;
        private string m_Iseditable;
        private string m_Deleteflag;
        private DateTime m_Createdate;
        private string m_Createuser;
        private DateTime m_Maintaindate;
        private string m_Maintainuser;
        private double m_Completedpercent;
        private int m_AuditStatus;
        private int m_TaskStatus;
        private int m_FunctionType;
        private int m_OperationType;
        private int m_TaskType;
        private int m_TaskComplexity;
        private int m_ProgramLanguage;
        private string m_Auditor;
        private string m_ScheduleRemark;
        private string m_ExecuteRemark;
        private string m_AuditStatusDesc;
        private string m_TaskStatusDesc;
        private string m_Type;
        private string m_FunctionTypeDesc;
        private string m_OperationTypeDesc;
        private string m_TaskTypeDesc;
        private string m_TaskComplexityDesc;
        private string m_ProgramLanguageDesc;
        private string m_AuditorAgent;
        private string m_CrId;
        private double m_LastRefcost;
        private double m_LastPlancost;
        private DateTime m_LastPlanstartday;
        private DateTime m_LastPlanendday;
        #endregion

        #region Default ( Empty ) Class Constuctor
        /// <summary>
        /// default constructor
        /// </summary>
        public SdpDetail()
        {
            m_Serial = 0;
            m_Serials = "";
            m_Pmsid = null;
            m_Taskno = 0;
            m_TaskName = null;
            m_Refcost = 0;
            m_Plancost = 0;
            m_Actualcost = 0;
            m_Planstartday = new DateTime();
            m_Planendday = new DateTime();
            m_Actualstartday = new DateTime();
            m_Actualendday = new DateTime();
            m_PretaskNo = 0;
            m_Role = null;
            m_Resource = null;
            m_Remark = null;
            m_Phase = null;
            m_Iseditable = null;
            m_Deleteflag = null;
            m_Createdate = new DateTime();
            m_Createuser = null;
            m_Maintaindate = new DateTime();
            m_Maintainuser = null;
            m_Completedpercent = 0;
            m_AuditStatus = 0;
            m_TaskStatus = 0;
            m_FunctionType = 0;
            m_OperationType = 0;
            m_TaskType = 0;
            m_TaskComplexity = 0;
            m_ProgramLanguage = 0;
            m_Auditor = null;
            m_AuditorAgent = null;
            m_CrId = null;
            m_ScheduleRemark = null;
            m_ExecuteRemark = null;
            m_FunctionTypeDesc = "";
            m_OperationTypeDesc = "";
            m_TaskTypeDesc = "";
            m_TaskComplexityDesc = "";
            m_ProgramLanguageDesc = "";
            m_LastRefcost = 0;
            m_LastPlancost = 0;
            m_LastPlanstartday = new DateTime();
            m_LastPlanendday = new DateTime();
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
        public string Serials
        {
            get { return m_Serials; }
            set { m_IsChanged |= (m_Serials != value); m_Serials = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Pmsid
        {
            get { return m_Pmsid; }
            set
            {
                if (value != null && value.Length > 15)
                    throw new ArgumentOutOfRangeException("Invalid value for Pmsid", value, value.ToString());

                m_IsChanged |= (m_Pmsid != value); m_Pmsid = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public int Taskno
        {
            get { return m_Taskno; }
            set { m_IsChanged |= (m_Taskno != value); m_Taskno = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string TaskName
        {
            get { return m_TaskName; }
            set
            {
                if (value != null && value.Length > 300)
                    throw new ArgumentOutOfRangeException("Invalid value for TaskName", value, value.ToString());

                m_IsChanged |= (m_TaskName != value); m_TaskName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public double Refcost
        {
            get { return m_Refcost; }
            set { m_IsChanged |= (m_Refcost != value); m_Refcost = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public double Plancost
        {
            get { return m_Plancost; }
            set { m_IsChanged |= (m_Plancost != value); m_Plancost = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public double Actualcost
        {
            get { return m_Actualcost; }
            set { m_IsChanged |= (m_Actualcost != value); m_Actualcost = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime Planstartday
        {
            get { return m_Planstartday; }
            set { m_IsChanged |= (m_Planstartday != value); m_Planstartday = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime Planendday
        {
            get { return m_Planendday; }
            set { m_IsChanged |= (m_Planendday != value); m_Planendday = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime Actualstartday
        {
            get { return m_Actualstartday; }
            set { m_IsChanged |= (m_Actualstartday != value); m_Actualstartday = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime Actualendday
        {
            get { return m_Actualendday; }
            set { m_IsChanged |= (m_Actualendday != value); m_Actualendday = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public int PretaskNo
        {
            get { return m_PretaskNo; }
            set { m_IsChanged |= (m_PretaskNo != value); m_PretaskNo = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Role
        {
            get { return m_Role; }
            set
            {
                if (value != null && value.Length > 40)
                    throw new ArgumentOutOfRangeException("Invalid value for Role", value, value.ToString());

                m_IsChanged |= (m_Role != value); m_Role = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Resource
        {
            get { return m_Resource; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Resource", value, value.ToString());

                m_IsChanged |= (m_Resource != value); m_Resource = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Remark
        {
            get { return m_Remark; }
            set
            {
                if (value != null && value.Length > 600)
                    throw new ArgumentOutOfRangeException("Invalid value for Remark", value, value.ToString());

                m_IsChanged |= (m_Remark != value); m_Remark = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Phase
        {
            get { return m_Phase; }
            set
            {
                if (value != null && value.Length > 40)
                    throw new ArgumentOutOfRangeException("Invalid value for Phase", value, value.ToString());

                m_IsChanged |= (m_Phase != value); m_Phase = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Iseditable
        {
            get { return m_Iseditable; }
            set
            {
                if (value != null && value.Length > 2)
                    throw new ArgumentOutOfRangeException("Invalid value for Iseditable", value, value.ToString());

                m_IsChanged |= (m_Iseditable != value); m_Iseditable = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public string Deleteflag
        {
            get { return m_Deleteflag; }
            set
            {
                if (value != null && value.Length > 2)
                    throw new ArgumentOutOfRangeException("Invalid value for Deleteflag", value, value.ToString());

                m_IsChanged |= (m_Deleteflag != value); m_Deleteflag = value;
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
                if (value != null && value.Length > 100)
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
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for Maintainuser", value, value.ToString());

                m_IsChanged |= (m_Maintainuser != value); m_Maintainuser = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>		
        public double Completedpercent
        {
            get { return m_Completedpercent; }
            set { m_IsChanged |= (m_Completedpercent != value); m_Completedpercent = value; }
        }

        /// <summary>
        /// 审核状态
        /// </summary>		
        public int AuditStatus
        {
            get { return m_AuditStatus; }
            set { m_IsChanged |= (m_AuditStatus != value); m_AuditStatus = value; }
        }

        /// <summary>
        /// 任务状态
        /// </summary>		
        public int TaskStatus
        {
            get { return m_TaskStatus; }
            set { m_IsChanged |= (m_TaskStatus != value); m_TaskStatus = value; }
        }

        /// <summary>
        /// 功能分类
        /// </summary>		
        public int FunctionType
        {
            get { return m_FunctionType; }
            set { m_IsChanged |= (m_FunctionType != value); m_FunctionType = value; }
        }

        /// <summary>
        /// 作业方式
        /// </summary>		
        public int OperationType
        {
            get { return m_OperationType; }
            set { m_IsChanged |= (m_OperationType != value); m_OperationType = value; }
        }

        /// <summary>
        /// 任务类型
        /// </summary>		
        public int TaskType
        {
            get { return m_TaskType; }
            set { m_IsChanged |= (m_TaskType != value); m_TaskType = value; }
        }

        /// <summary>
        /// 任务复杂度
        /// </summary>		
        public int TaskComplexity
        {
            get { return m_TaskComplexity; }
            set { m_IsChanged |= (m_TaskComplexity != value); m_TaskComplexity = value; }
        }

        /// <summary>
        /// 编程语言
        /// </summary>		
        public int ProgramLanguage
        {
            get { return m_ProgramLanguage; }
            set { m_IsChanged |= (m_ProgramLanguage != value); m_ProgramLanguage = value; }
        }

        /// <summary>
        /// 审核人
        /// </summary>		
        public string Auditor
        {
            get { return m_Auditor; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for Auditor", value, value.ToString());

                m_IsChanged |= (m_Auditor != value); m_Auditor = value;
            }
        }

        /// <summary>
        /// 审核人代理
        /// </summary>		
        public string AuditorAgent
        {
            get { return m_AuditorAgent; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for AuditorAgent", value, value.ToString());

                m_IsChanged |= (m_AuditorAgent != value); m_AuditorAgent = value;
            }
        }

        /// <summary>
        /// 当前PMSID对应的CrId
        /// </summary>		
        public string CrId
        {
            get { return m_CrId; }
            set
            {
                if (value != null && value.Length > 50)
                    throw new ArgumentOutOfRangeException("Invalid value for CrId", value, value.ToString());

                m_IsChanged |= (m_CrId != value); m_CrId = value;
            }
        }


        /// <summary>
        /// 任务计划说明
        /// </summary>		
        public string ScheduleRemark
        {
            get { return m_ScheduleRemark; }
            set
            {
                if (value != null && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for ScheduleRemark", value, value.ToString());

                m_IsChanged |= (m_ScheduleRemark != value); m_ScheduleRemark = value;
            }
        }

        /// <summary>
        /// 执行计划说明
        /// </summary>		
        public string ExecuteRemark
        {
            get { return m_ExecuteRemark; }
            set
            {
                if (value != null && value.Length > 500)
                    throw new ArgumentOutOfRangeException("Invalid value for ExecuteRemark", value, value.ToString());

                m_IsChanged |= (m_ExecuteRemark != value); m_ExecuteRemark = value;
            }
        }

        /// <summary>
        /// 审核状态说明
        /// </summary>		
        public string AuditStatusDesc
        {
            get { return m_AuditStatusDesc; }
            set { m_IsChanged |= (m_AuditStatusDesc != value); m_AuditStatusDesc = value; }
        }

        /// <summary>
        /// 任务状态说明
        /// </summary>		
        public string TaskStatusDesc
        {
            get { return m_TaskStatusDesc; }
            set { m_IsChanged |= (m_TaskStatusDesc != value); m_TaskStatusDesc = value; }
        }

        /// <summary>
        /// 项目类型
        /// </summary>
        public string Type
        {
            get { return m_Type; }
            set { m_IsChanged |= (m_Type != value); m_Type = value; }
        }

        /// <summary>
        /// 功能分类说明
        /// </summary>		
        public string FunctionTypeDesc
        {
            get { return m_FunctionTypeDesc; }
            set { m_IsChanged |= (m_FunctionTypeDesc != value); m_FunctionTypeDesc = value; }
        }

        /// <summary>
        /// 作业方式说明
        /// </summary>		
        public string OperationTypeDesc
        {
            get { return m_OperationTypeDesc; }
            set { m_IsChanged |= (m_OperationTypeDesc != value); m_OperationTypeDesc = value; }
        }

        /// <summary>
        /// 任务类型说明
        /// </summary>		
        public string TaskTypeDesc
        {
            get { return m_TaskTypeDesc; }
            set { m_IsChanged |= (m_TaskTypeDesc != value); m_TaskTypeDesc = value; }
        }

        /// <summary>
        /// 任务复杂度说明
        /// </summary>		
        public string TaskComplexityDesc
        {
            get { return m_TaskComplexityDesc; }
            set { m_IsChanged |= (m_TaskComplexityDesc != value); m_TaskComplexityDesc = value; }
        }

        /// <summary>
        /// 编程语言说明
        /// </summary>		
        public string ProgramLanguageDesc
        {
            get { return m_ProgramLanguageDesc; }
            set { m_IsChanged |= (m_ProgramLanguageDesc != value); m_ProgramLanguageDesc = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public double LastRefcost
        {
            get { return m_LastRefcost; }
            set { m_IsChanged |= (m_LastRefcost != value); m_LastRefcost = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public double LastPlancost
        {
            get { return m_LastPlancost; }
            set { m_IsChanged |= (m_LastPlancost != value); m_LastPlancost = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime LastPlanstartday
        {
            get { return m_LastPlanstartday; }
            set { m_IsChanged |= (m_LastPlanstartday != value); m_LastPlanstartday = value; }
        }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime LastPlanendday
        {
            get { return m_LastPlanendday; }
            set { m_IsChanged |= (m_LastPlanendday != value); m_LastPlanendday = value; }
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
