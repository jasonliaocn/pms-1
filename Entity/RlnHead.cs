/***********************************************************
 ** File Name : RlnHead.cs
 ** Copyright (C) 2010 BenQ Corporation. All rights reserved.
 **
 ** Creator : AIC0/Albee
 ** Create Date : 2011-06-10
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
	public sealed class RlnHead
	{
		#region Private Members
		private bool m_IsChanged;
		private bool m_IsDeleted;
		private string m_RlnId; 
		private string m_ProjectId; 
		private string m_CrId; 
		private string m_ApplySite; 
		private string m_ProjectName; 
		private string m_ProjectUrl; 
		private string m_Creator; 
		private string m_Pm; 
		private string m_Sd; 
		private string m_Se; 
		private string m_Qa; 
		private string m_ProjectType; 
		private string m_DueDate; 
		private DateTime m_ReleaseDate; 
		private string m_ProjectStatus; 
		private string m_Impact; 
		private string m_Content; 
		private string m_Contacter; 
		private string m_RlnStatus; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public RlnHead()
		{
			m_RlnId = null; 
			m_ProjectId = null; 
			m_CrId = null; 
			m_ApplySite = null; 
			m_ProjectName = null; 
			m_ProjectUrl = null; 
			m_Creator = null; 
			m_Pm = null; 
			m_Sd = null; 
			m_Se = null; 
			m_Qa = null; 
			m_ProjectType = null; 
			m_DueDate = null; 
			m_ReleaseDate = new DateTime(); 
			m_ProjectStatus = null; 
			m_Impact = null; 
			m_Content = null; 
			m_Contacter = null; 
			m_RlnStatus = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public string RlnId
		{
			get { return m_RlnId; }
			set	
			{
				if( value!= null && value.Length > 12)
					throw new ArgumentOutOfRangeException("Invalid value for RlnId", value, value.ToString());
				
				m_IsChanged |= (m_RlnId != value); m_RlnId = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ProjectId
		{
			get { return m_ProjectId; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for ProjectId", value, value.ToString());
				
				m_IsChanged |= (m_ProjectId != value); m_ProjectId = value;
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
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for CrId", value, value.ToString());
				
				m_IsChanged |= (m_CrId != value); m_CrId = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ApplySite
		{
			get { return m_ApplySite; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for ApplySite", value, value.ToString());
				
				m_IsChanged |= (m_ApplySite != value); m_ApplySite = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ProjectName
		{
			get { return m_ProjectName; }
			set	
			{
				if( value!= null && value.Length > 200)
					throw new ArgumentOutOfRangeException("Invalid value for ProjectName", value, value.ToString());
				
				m_IsChanged |= (m_ProjectName != value); m_ProjectName = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ProjectUrl
		{
			get { return m_ProjectUrl; }
			set	
			{
				if( value!= null && value.Length > 500)
					throw new ArgumentOutOfRangeException("Invalid value for ProjectUrl", value, value.ToString());
				
				m_IsChanged |= (m_ProjectUrl != value); m_ProjectUrl = value;
			}
		}
			
		/// <summary>
		/// 
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
		/// 
		/// </summary>		
		public string Pm
		{
			get { return m_Pm; }
			set	
			{
				if( value!= null && value.Length > 100)
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
				if( value!= null && value.Length > 100)
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
				if( value!= null && value.Length > 100)
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
				if( value!= null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Qa", value, value.ToString());
				
				m_IsChanged |= (m_Qa != value); m_Qa = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string ProjectType
		{
			get { return m_ProjectType; }
			set	
			{
				if( value!= null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for ProjectType", value, value.ToString());
				
				m_IsChanged |= (m_ProjectType != value); m_ProjectType = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string DueDate
		{
			get { return m_DueDate; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for DueDate", value, value.ToString());
				
				m_IsChanged |= (m_DueDate != value); m_DueDate = value;
			}
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
		public string ProjectStatus
		{
			get { return m_ProjectStatus; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for ProjectStatus", value, value.ToString());
				
				m_IsChanged |= (m_ProjectStatus != value); m_ProjectStatus = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Impact
		{
			get { return m_Impact; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Impact", value, value.ToString());
				
				m_IsChanged |= (m_Impact != value); m_Impact = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Content
		{
			get { return m_Content; }
			set	
			{
				if( value!= null && value.Length > 1073741823)
					throw new ArgumentOutOfRangeException("Invalid value for Content", value, value.ToString());
				
				m_IsChanged |= (m_Content != value); m_Content = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Contacter
		{
			get { return m_Contacter; }
			set	
			{
				if( value!= null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Contacter", value, value.ToString());
				
				m_IsChanged |= (m_Contacter != value); m_Contacter = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string RlnStatus
		{
			get { return m_RlnStatus; }
			set	
			{
				if( value!= null && value.Length > 10)
					throw new ArgumentOutOfRangeException("Invalid value for RlnStatus", value, value.ToString());
				
				m_IsChanged |= (m_RlnStatus != value); m_RlnStatus = value;
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
