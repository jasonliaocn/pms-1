/***********************************************************
 ** File Name : ItarmUser.cs
 ** Copyright (C) 2011 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/Kite.Zhang
 ** Create Date : 2011-08-08
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
	public sealed class ItarmUser
	{
		#region Private Members
		private bool m_IsChanged;
		private bool m_IsDeleted;
		private string m_EmpNo; 
		private string m_EmpId; 
		private string m_Account; 
		private string m_Domain; 
		private string m_ChineseName; 
		private string m_EnglishName; 
		private string m_Email; 
		private string m_Extension; 
		private string m_Department; 
		private string m_Site; 
		private string m_Active; 
		private DateTime m_Updatedate; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public ItarmUser()
		{
			m_EmpNo = null; 
			m_EmpId = null; 
			m_Account = null; 
			m_Domain = null; 
			m_ChineseName = null; 
			m_EnglishName = null; 
			m_Email = null; 
			m_Extension = null; 
			m_Department = null; 
			m_Site = null; 
			m_Active = null; 
			m_Updatedate = new DateTime(); 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public string EmpNo
		{
			get { return m_EmpNo; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for EmpNo", value, value.ToString());
				
				m_IsChanged |= (m_EmpNo != value); m_EmpNo = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string EmpId
		{
			get { return m_EmpId; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for EmpId", value, value.ToString());
				
				m_IsChanged |= (m_EmpId != value); m_EmpId = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Account
		{
			get { return m_Account; }
			set	
			{
				if( value!= null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Account", value, value.ToString());
				
				m_IsChanged |= (m_Account != value); m_Account = value;
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
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Domain", value, value.ToString());
				
				m_IsChanged |= (m_Domain != value); m_Domain = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ChineseName
		{
			get { return m_ChineseName; }
			set	
			{
				if( value!= null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for ChineseName", value, value.ToString());
				
				m_IsChanged |= (m_ChineseName != value); m_ChineseName = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string EnglishName
		{
			get { return m_EnglishName; }
			set	
			{
				if( value!= null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for EnglishName", value, value.ToString());
				
				m_IsChanged |= (m_EnglishName != value); m_EnglishName = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Email
		{
			get { return m_Email; }
			set	
			{
				if( value!= null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Email", value, value.ToString());
				
				m_IsChanged |= (m_Email != value); m_Email = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Extension
		{
			get { return m_Extension; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Extension", value, value.ToString());
				
				m_IsChanged |= (m_Extension != value); m_Extension = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Department
		{
			get { return m_Department; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Department", value, value.ToString());
				
				m_IsChanged |= (m_Department != value); m_Department = value;
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
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Site", value, value.ToString());
				
				m_IsChanged |= (m_Site != value); m_Site = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Active
		{
			get { return m_Active; }
			set	
			{
				if( value!= null && value.Length > 4)
					throw new ArgumentOutOfRangeException("Invalid value for Active", value, value.ToString());
				
				m_IsChanged |= (m_Active != value); m_Active = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime Updatedate
		{
			get { return m_Updatedate; }
			set { m_IsChanged |= (m_Updatedate != value); m_Updatedate = value; }
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
