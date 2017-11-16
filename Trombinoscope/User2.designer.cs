﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trombinoscope
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="labo")]
	public partial class User2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    #endregion
		
		public User2DataContext() : 
				base(global::Trombinoscope.Properties.Settings.Default.trombinoscopeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public User2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public User2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public User2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public User2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllFromUserId")]
		public ISingleResult<GetAllFromUserIdResult> GetAllFromUserId([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userid);
			return ((ISingleResult<GetAllFromUserIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetListOfUsers")]
		public ISingleResult<GetListOfUsersResult> GetListOfUsers()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetListOfUsersResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetAllFromUserIdResult:INotifyPropertyChanged
	{
		
		private int _UserId;
		
		private string _Nom;
		
		private string _Prenom;
		
		private string _Email;
		
		private string _tel;
		
		private string _Rue;
		
		private string _codePostal;
		
		private string _Ville;
		
		private System.Data.Linq.Binary _Photo;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String property) {
            if (PropertyChanged != null) {
                PropertyChanged( this, new PropertyChangedEventArgs( property ) );
            }
        }

        public GetAllFromUserIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
                    OnPropertyChanged( "UserId" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this._Nom = value;
                    OnPropertyChanged( "Nom" );

                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this._Prenom = value;
                    OnPropertyChanged( "Prenom" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
                    OnPropertyChanged( "Email" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tel", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string tel
		{
			get
			{
				return this._tel;
			}
			set
			{
				if ((this._tel != value))
				{
					this._tel = value;
                    OnPropertyChanged( "tel" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rue", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Rue
		{
			get
			{
				return this._Rue;
			}
			set
			{
				if ((this._Rue != value))
				{
					this._Rue = value;
                    OnPropertyChanged( "Rue" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codePostal", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string codePostal
		{
			get
			{
				return this._codePostal;
			}
			set
			{
				if ((this._codePostal != value))
				{
					this._codePostal = value;
                    OnPropertyChanged( "codePostal" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ville", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ville
		{
			get
			{
				return this._Ville;
			}
			set
			{
				if ((this._Ville != value))
				{
					this._Ville = value;
                    OnPropertyChanged( "Ville" );
                }
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image")]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this._Photo = value;
                    OnPropertyChanged( "Photo" );
                }
			}
		}
	}
	
	public partial class GetListOfUsersResult
	{
		
		private int _UserId;
		
		private string _Nom;
		
		private string _Prenom;
		
		public GetListOfUsersResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this._UserId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this._Nom = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this._Prenom = value;
				}
			}
		}
	}
}
#pragma warning restore 1591