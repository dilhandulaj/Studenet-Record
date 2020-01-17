using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Abc_student_system
{
    #region Student
    public class Student
    {
        #region Member Variables
        protected int _sid;
        protected string _name;
        protected string _address;
        protected string _gender;
        protected string _qualification;
        protected string _course;
        protected unknown _dob;
        #endregion
        #region Constructors
        public Student() { }
        public Student(string name, string address, string gender, string qualification, string course, unknown dob)
        {
            this._name=name;
            this._address=address;
            this._gender=gender;
            this._qualification=qualification;
            this._course=course;
            this._dob=dob;
        }
        #endregion
        #region Public Properties
        public virtual int Sid
        {
            get {return _sid;}
            set {_sid=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Address
        {
            get {return _address;}
            set {_address=value;}
        }
        public virtual string Gender
        {
            get {return _gender;}
            set {_gender=value;}
        }
        public virtual string Qualification
        {
            get {return _qualification;}
            set {_qualification=value;}
        }
        public virtual string Course
        {
            get {return _course;}
            set {_course=value;}
        }
        public virtual unknown Dob
        {
            get {return _dob;}
            set {_dob=value;}
        }
        #endregion
    }
    #endregion
}