/***********************************************************
 ** File Name : WscUserRole.cs
 ** Copyright (C) 2013 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/Justin.Meng
 ** Create Date : 2013-12-28
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
	public sealed class WscUserRole
	{
		#region Private Members
		private bool m_IsChanged;
		private bool m_IsDeleted;
		private string m_RoleId; 
		private string m_LoginName; 
		private string m_SysId; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public WscUserRole()
		{
			m_RoleId = null; 
			m_LoginName = null; 
			m_SysId = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public string RoleId
		{
			get { return m_RoleId; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for RoleId", value, value.ToString());
				
				m_IsChanged |= (m_RoleId != value); m_RoleId = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string LoginName
		{
			get { return m_LoginName; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for LoginName", value, value.ToString());
				
				m_IsChanged |= (m_LoginName != value); m_LoginName = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string SysId
		{
			get { return m_SysId; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for SysId", value, value.ToString());
				
				m_IsChanged |= (m_SysId != value); m_SysId = value;
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