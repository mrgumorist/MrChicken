﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mr.Chicken.ServiceReferenceMrChicken {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/IService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfRegisterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DoesWantRecomendationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.EmailAccept[] IEmailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ISConfirmedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelegramIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.UserProducts[] userProductsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfRegister {
            get {
                return this.DateOfRegisterField;
            }
            set {
                if ((this.DateOfRegisterField.Equals(value) != true)) {
                    this.DateOfRegisterField = value;
                    this.RaisePropertyChanged("DateOfRegister");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DoesWantRecomendations {
            get {
                return this.DoesWantRecomendationsField;
            }
            set {
                if ((this.DoesWantRecomendationsField.Equals(value) != true)) {
                    this.DoesWantRecomendationsField = value;
                    this.RaisePropertyChanged("DoesWantRecomendations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.EmailAccept[] IEmails {
            get {
                return this.IEmailsField;
            }
            set {
                if ((object.ReferenceEquals(this.IEmailsField, value) != true)) {
                    this.IEmailsField = value;
                    this.RaisePropertyChanged("IEmails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ISConfirmed {
            get {
                return this.ISConfirmedField;
            }
            set {
                if ((this.ISConfirmedField.Equals(value) != true)) {
                    this.ISConfirmedField = value;
                    this.RaisePropertyChanged("ISConfirmed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TelegramID {
            get {
                return this.TelegramIDField;
            }
            set {
                if ((object.ReferenceEquals(this.TelegramIDField, value) != true)) {
                    this.TelegramIDField = value;
                    this.RaisePropertyChanged("TelegramID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.UserProducts[] userProducts {
            get {
                return this.userProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.userProductsField, value) != true)) {
                    this.userProductsField = value;
                    this.RaisePropertyChanged("userProducts");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmailAccept", Namespace="http://schemas.datacontract.org/2004/07/IService.Entities")]
    [System.SerializableAttribute()]
    public partial class EmailAccept : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.User UserVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VerificationCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.User UserV {
            get {
                return this.UserVField;
            }
            set {
                if ((object.ReferenceEquals(this.UserVField, value) != true)) {
                    this.UserVField = value;
                    this.RaisePropertyChanged("UserV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VerificationCode {
            get {
                return this.VerificationCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.VerificationCodeField, value) != true)) {
                    this.VerificationCodeField = value;
                    this.RaisePropertyChanged("VerificationCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserProducts", Namespace="http://schemas.datacontract.org/2004/07/IService.Entities")]
    [System.SerializableAttribute()]
    public partial class UserProducts : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AddedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Product ProductVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.User UserVField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AddedDate {
            get {
                return this.AddedDateField;
            }
            set {
                if ((this.AddedDateField.Equals(value) != true)) {
                    this.AddedDateField = value;
                    this.RaisePropertyChanged("AddedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Product ProductV {
            get {
                return this.ProductVField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductVField, value) != true)) {
                    this.ProductVField = value;
                    this.RaisePropertyChanged("ProductV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.User UserV {
            get {
                return this.UserVField;
            }
            set {
                if ((object.ReferenceEquals(this.UserVField, value) != true)) {
                    this.UserVField = value;
                    this.RaisePropertyChanged("UserV");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/IService.Entities")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Intermediate[] intermediateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.UserProducts[] userProductsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Intermediate[] intermediate {
            get {
                return this.intermediateField;
            }
            set {
                if ((object.ReferenceEquals(this.intermediateField, value) != true)) {
                    this.intermediateField = value;
                    this.RaisePropertyChanged("intermediate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.UserProducts[] userProducts {
            get {
                return this.userProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.userProductsField, value) != true)) {
                    this.userProductsField = value;
                    this.RaisePropertyChanged("userProducts");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Intermediate", Namespace="http://schemas.datacontract.org/2004/07/IService.Entities")]
    [System.SerializableAttribute()]
    public partial class Intermediate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DishIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Dish DishVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Product ProductVField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DishID {
            get {
                return this.DishIDField;
            }
            set {
                if ((this.DishIDField.Equals(value) != true)) {
                    this.DishIDField = value;
                    this.RaisePropertyChanged("DishID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Dish DishV {
            get {
                return this.DishVField;
            }
            set {
                if ((object.ReferenceEquals(this.DishVField, value) != true)) {
                    this.DishVField = value;
                    this.RaisePropertyChanged("DishV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Product ProductV {
            get {
                return this.ProductVField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductVField, value) != true)) {
                    this.ProductVField = value;
                    this.RaisePropertyChanged("ProductV");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dish", Namespace="http://schemas.datacontract.org/2004/07/IService.Entities")]
    [System.SerializableAttribute()]
    public partial class Dish : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LittleDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReceptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Type TypeVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Intermediate[] intermediateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LittleDescription {
            get {
                return this.LittleDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.LittleDescriptionField, value) != true)) {
                    this.LittleDescriptionField = value;
                    this.RaisePropertyChanged("LittleDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Recept {
            get {
                return this.ReceptField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceptField, value) != true)) {
                    this.ReceptField = value;
                    this.RaisePropertyChanged("Recept");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeID {
            get {
                return this.TypeIDField;
            }
            set {
                if ((this.TypeIDField.Equals(value) != true)) {
                    this.TypeIDField = value;
                    this.RaisePropertyChanged("TypeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Type TypeV {
            get {
                return this.TypeVField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeVField, value) != true)) {
                    this.TypeVField = value;
                    this.RaisePropertyChanged("TypeV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Intermediate[] intermediate {
            get {
                return this.intermediateField;
            }
            set {
                if ((object.ReferenceEquals(this.intermediateField, value) != true)) {
                    this.intermediateField = value;
                    this.RaisePropertyChanged("intermediate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Type", Namespace="http://schemas.datacontract.org/2004/07/IService.Entities")]
    [System.SerializableAttribute()]
    public partial class Type : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Mr.Chicken.ServiceReferenceMrChicken.Dish[] IDishesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Mr.Chicken.ServiceReferenceMrChicken.Dish[] IDishes {
            get {
                return this.IDishesField;
            }
            set {
                if ((object.ReferenceEquals(this.IDishesField, value) != true)) {
                    this.IDishesField = value;
                    this.RaisePropertyChanged("IDishes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMrChicken.IProgrammService")]
    public interface IProgrammService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/Msg", ReplyAction="http://tempuri.org/IProgrammService/MsgResponse")]
        string Msg([System.ServiceModel.MessageParameterAttribute(Name="msg")] string msg1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/Msg", ReplyAction="http://tempuri.org/IProgrammService/MsgResponse")]
        System.Threading.Tasks.Task<string> MsgAsync(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyUser", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyUserResponse")]
        Mr.Chicken.ServiceReferenceMrChicken.User GetEmptyUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/GetEmptyUser", ReplyAction="http://tempuri.org/IProgrammService/GetEmptyUserResponse")]
        System.Threading.Tasks.Task<Mr.Chicken.ServiceReferenceMrChicken.User> GetEmptyUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddUser", ReplyAction="http://tempuri.org/IProgrammService/AddUserResponse")]
        void AddUser(Mr.Chicken.ServiceReferenceMrChicken.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AddUser", ReplyAction="http://tempuri.org/IProgrammService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(Mr.Chicken.ServiceReferenceMrChicken.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/IsEmailUnique", ReplyAction="http://tempuri.org/IProgrammService/IsEmailUniqueResponse")]
        bool IsEmailUnique(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/IsEmailUnique", ReplyAction="http://tempuri.org/IProgrammService/IsEmailUniqueResponse")]
        System.Threading.Tasks.Task<bool> IsEmailUniqueAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AccountId", ReplyAction="http://tempuri.org/IProgrammService/AccountIdResponse")]
        int AccountId(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProgrammService/AccountId", ReplyAction="http://tempuri.org/IProgrammService/AccountIdResponse")]
        System.Threading.Tasks.Task<int> AccountIdAsync(string login, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProgrammServiceChannel : Mr.Chicken.ServiceReferenceMrChicken.IProgrammService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProgrammServiceClient : System.ServiceModel.ClientBase<Mr.Chicken.ServiceReferenceMrChicken.IProgrammService>, Mr.Chicken.ServiceReferenceMrChicken.IProgrammService {
        
        public ProgrammServiceClient() {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgrammServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProgrammServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Msg(string msg1) {
            return base.Channel.Msg(msg1);
        }
        
        public System.Threading.Tasks.Task<string> MsgAsync(string msg) {
            return base.Channel.MsgAsync(msg);
        }
        
        public Mr.Chicken.ServiceReferenceMrChicken.User GetEmptyUser() {
            return base.Channel.GetEmptyUser();
        }
        
        public System.Threading.Tasks.Task<Mr.Chicken.ServiceReferenceMrChicken.User> GetEmptyUserAsync() {
            return base.Channel.GetEmptyUserAsync();
        }
        
        public void AddUser(Mr.Chicken.ServiceReferenceMrChicken.User user) {
            base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(Mr.Chicken.ServiceReferenceMrChicken.User user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public bool IsEmailUnique(string email) {
            return base.Channel.IsEmailUnique(email);
        }
        
        public System.Threading.Tasks.Task<bool> IsEmailUniqueAsync(string email) {
            return base.Channel.IsEmailUniqueAsync(email);
        }
        
        public int AccountId(string login, string password) {
            return base.Channel.AccountId(login, password);
        }
        
        public System.Threading.Tasks.Task<int> AccountIdAsync(string login, string password) {
            return base.Channel.AccountIdAsync(login, password);
        }
    }
}
