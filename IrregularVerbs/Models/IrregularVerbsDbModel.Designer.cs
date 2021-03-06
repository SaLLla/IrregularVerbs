﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace IrregularVerbs.Models
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class IrregularVerbsDbEntities : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект IrregularVerbsDbEntities, используя строку соединения из раздела "IrregularVerbsDbEntities" файла конфигурации приложения.
        /// </summary>
        public IrregularVerbsDbEntities() : base("name=IrregularVerbsDbEntities", "IrregularVerbsDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта IrregularVerbsDbEntities.
        /// </summary>
        public IrregularVerbsDbEntities(string connectionString) : base(connectionString, "IrregularVerbsDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта IrregularVerbsDbEntities.
        /// </summary>
        public IrregularVerbsDbEntities(EntityConnection connection) : base(connection, "IrregularVerbsDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<IrregularVerb> IrregularVerbs
        {
            get
            {
                if ((_IrregularVerbs == null))
                {
                    _IrregularVerbs = base.CreateObjectSet<IrregularVerb>("IrregularVerbs");
                }
                return _IrregularVerbs;
            }
        }
        private ObjectSet<IrregularVerb> _IrregularVerbs;

        #endregion

        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet IrregularVerbs. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToIrregularVerbs(IrregularVerb irregularVerb)
        {
            base.AddObject("IrregularVerbs", irregularVerb);
        }

        #endregion

    }

    #endregion

    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IrregularVerbsDbModel", Name="IrregularVerb")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class IrregularVerb : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта IrregularVerb.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="presentSimple">Исходное значение свойства PresentSimple.</param>
        /// <param name="pastSimple">Исходное значение свойства PastSimple.</param>
        /// <param name="pastParticiple">Исходное значение свойства PastParticiple.</param>
        /// <param name="translate">Исходное значение свойства Translate.</param>
        /// <param name="lessonNumber">Исходное значение свойства LessonNumber.</param>
        public static IrregularVerb CreateIrregularVerb(global::System.Int32 id, global::System.String presentSimple, global::System.String pastSimple, global::System.String pastParticiple, global::System.String translate, global::System.Int32 lessonNumber)
        {
            IrregularVerb irregularVerb = new IrregularVerb();
            irregularVerb.Id = id;
            irregularVerb.PresentSimple = presentSimple;
            irregularVerb.PastSimple = pastSimple;
            irregularVerb.PastParticiple = pastParticiple;
            irregularVerb.Translate = translate;
            irregularVerb.LessonNumber = lessonNumber;
            return irregularVerb;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PresentSimple
        {
            get
            {
                return _PresentSimple;
            }
            set
            {
                OnPresentSimpleChanging(value);
                ReportPropertyChanging("PresentSimple");
                _PresentSimple = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PresentSimple");
                OnPresentSimpleChanged();
            }
        }
        private global::System.String _PresentSimple;
        partial void OnPresentSimpleChanging(global::System.String value);
        partial void OnPresentSimpleChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PastSimple
        {
            get
            {
                return _PastSimple;
            }
            set
            {
                OnPastSimpleChanging(value);
                ReportPropertyChanging("PastSimple");
                _PastSimple = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PastSimple");
                OnPastSimpleChanged();
            }
        }
        private global::System.String _PastSimple;
        partial void OnPastSimpleChanging(global::System.String value);
        partial void OnPastSimpleChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PastParticiple
        {
            get
            {
                return _PastParticiple;
            }
            set
            {
                OnPastParticipleChanging(value);
                ReportPropertyChanging("PastParticiple");
                _PastParticiple = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PastParticiple");
                OnPastParticipleChanged();
            }
        }
        private global::System.String _PastParticiple;
        partial void OnPastParticipleChanging(global::System.String value);
        partial void OnPastParticipleChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Translate
        {
            get
            {
                return _Translate;
            }
            set
            {
                OnTranslateChanging(value);
                ReportPropertyChanging("Translate");
                _Translate = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Translate");
                OnTranslateChanged();
            }
        }
        private global::System.String _Translate;
        partial void OnTranslateChanging(global::System.String value);
        partial void OnTranslateChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 LessonNumber
        {
            get
            {
                return _LessonNumber;
            }
            set
            {
                OnLessonNumberChanging(value);
                ReportPropertyChanging("LessonNumber");
                _LessonNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LessonNumber");
                OnLessonNumberChanged();
            }
        }
        private global::System.Int32 _LessonNumber;
        partial void OnLessonNumberChanging(global::System.Int32 value);
        partial void OnLessonNumberChanged();

        #endregion

    
    }

    #endregion

    
}
