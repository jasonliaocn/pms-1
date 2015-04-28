/***********************************************************
 ** File Name : PmsSdpAudit.cs
 ** Copyright (C) 2014 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/ITO.Abel.Li
 ** Create Date : 2014-02-16
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
	public sealed class PmsSdpAudit
	{
		#region Private Members
		private bool m_IsChanged;
		private bool m_IsDeleted;
		private string m_Pmsid; 
		private float m_SdpVersion; 
		private string m_Auditor; 
		private string m_AuditResult; 
		private string m_AuditComment; 
		private DateTime m_CreateDate; 
		private string m_Creator; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public PmsSdpAudit()
		{
			m_Pmsid = null; 
			m_SdpVersion = 0; 
			m_Auditor = null; 
			m_AuditResult = null; 
			m_AuditComment = null; 
			m_CreateDate = new DateTime(); 
			m_Creator = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// PMS ID
		/// </summary>		
		public string Pmsid
		{
			get { return m_Pmsid; }
			set	
			{
				if( value!= null && value.Length > 15)
					throw new ArgumentOutOfRangeException("Invalid value for Pmsid", value, value.ToString());
				
				m_IsChanged |= (m_Pmsid != value); m_Pmsid = value;
			}
		}
			
		/// <summary>
		/// SDP的版本
		/// </summary>		
		public float SdpVersion
		{
			get { return m_SdpVersion; }
			set { m_IsChanged |= (m_SdpVersion != value); m_SdpVersion = value; }
		}
			
		/// <summary>
		/// 审核人
		/// </summary>		
		public string Auditor
		{
			get { return m_Auditor; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Auditor", value, value.ToString());
				
				m_IsChanged |= (m_Auditor != value); m_Auditor = value;
			}
		}
			
		/// <summary>
		/// Approve/Reject
		/// </summary>		
		public string AuditResult
		{
			get { return m_AuditResult; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for AuditResult", value, value.ToString());
				
				m_IsChanged |= (m_AuditResult != value); m_AuditResult = value;
			}
		}
			
		/// <summary>
		/// 审核意见
		/// </summary>		
		public string AuditComment
		{
			get { return m_AuditComment; }
			set	
			{
				if( value!= null && value.Length > 500)
					throw new ArgumentOutOfRangeException("Invalid value for AuditComment", value, value.ToString());
				
				m_IsChanged |= (m_AuditComment != value); m_AuditComment = value;
			}
		}
			
		/// <summary>
		/// 创建时间
		/// </summary>		
		public DateTime CreateDate
		{
			get { return m_CreateDate; }
			set { m_IsChanged |= (m_CreateDate != value); m_CreateDate = value; }
		}
			
		/// <summary>
		/// 创建人
		/// </summary>		
		public string Creator
		{
			get { return m_Creator; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Creator", value, value.ToString());
				
				m_IsChanged |= (m_Creator != value); m_Creator = value;
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
