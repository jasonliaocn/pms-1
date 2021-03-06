/***********************************************************
 ** File Name : PmsFlowTemplate.cs
 ** Copyright (C) 2011 Qisda Corporation. All rights reserved.
 **
 ** Creator : AIC01/albee.liu
 ** Create Date : 2011-05-29
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
	public sealed class PmsFlowTemplate
	{
		#region Private Members
		private bool m_IsChanged;
		private bool m_IsDeleted;
		private int m_FlowId; 
		private int m_Stageid; 
		private string m_Typeid; 
		private int m_Order; 
		private string m_Creator; 
		private DateTime m_CreateDate; 		
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public PmsFlowTemplate()
		{
			m_FlowId = 0; 
			m_Stageid = 0; 
			m_Typeid = string.Empty; 
			m_Order = 0; 
			m_Creator = string.Empty; 
			m_CreateDate = new DateTime(); 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public int FlowId
		{
			get { return m_FlowId; }
			set { m_IsChanged |= (m_FlowId != value); m_FlowId = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public int Stageid
		{
			get { return m_Stageid; }
			set { m_IsChanged |= (m_Stageid != value); m_Stageid = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
        public string Typeid
		{
			get { return m_Typeid; }
			set { m_IsChanged |= (m_Typeid != value); m_Typeid = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public int Order
		{
			get { return m_Order; }
			set { m_IsChanged |= (m_Order != value); m_Order = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string Creator
		{
			get { return m_Creator; }
			set { m_IsChanged |= (m_Creator != value); m_Creator = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate
		{
			get { return m_CreateDate; }
			set { m_IsChanged |= (m_CreateDate != value); m_CreateDate = value; }
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
