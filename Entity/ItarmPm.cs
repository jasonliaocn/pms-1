/***********************************************************
 ** File Name : ItarmPm.cs
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
	public sealed class ItarmPm
	{
		#region Private Members
		private bool m_IsChanged;
		private bool m_IsDeleted;
		private int m_SystemId; 
		private string m_PmNo; 
		private int m_Sequence;

        private string m_EnglishName; 
		#endregion
		
		#region Default ( Empty ) Class Constuctor
		/// <summary>
		/// default constructor
		/// </summary>
		public ItarmPm()
		{
			m_SystemId = 0; 
			m_PmNo = null; 
			m_Sequence = 0;

            m_EnglishName = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor
		
		#region Public Properties
			
		/// <summary>
		/// 
		/// </summary>		
		public int SystemId
		{
			get { return m_SystemId; }
			set { m_IsChanged |= (m_SystemId != value); m_SystemId = value; }
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public string PmNo
		{
			get { return m_PmNo; }
			set	
			{
				if( value!= null && value.Length > 30)
					throw new ArgumentOutOfRangeException("Invalid value for PmNo", value, value.ToString());
				
				m_IsChanged |= (m_PmNo != value); m_PmNo = value;
			}
		}
			
		/// <summary>
		/// 
		/// </summary>		
		public int Sequence
		{
			get { return m_Sequence; }
			set { m_IsChanged |= (m_Sequence != value); m_Sequence = value; }
		}






        /// <summary>
        /// 
        /// </summary>		
        public string EnglishName
        {
            get { return m_EnglishName; }
            set
            {
                if (value != null && value.Length > 100)
                    throw new ArgumentOutOfRangeException("Invalid value for EnglishName", value, value.ToString());

                m_IsChanged |= (m_EnglishName != value); m_EnglishName = value;
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
