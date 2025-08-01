using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Car
    {
        #region Attributes
        private int id = default; // 4 bytes
        private string? model = default; // 4 bytes
        private double speed = default; // 8 bytes
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Constructors
        // Empty Parmterless Contructo [Default Constructor]
        // Auto-Genereated by Compiler

        public Car()
        {
            // Empty
        }

        //public Car(int id, string model, double _speed)
        //{
        //    this.id = id;
        //    this.model = model;
        //    speed = _speed;
        //}

        // User Defined Constructor
        public Car(int id, string? model, double speed)
        {
            this.id=id;
            this.model=model;
            this.speed=speed;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Car ID: {Id}, Model: {Model}, Speed: {Speed} km/h";
        }

        #endregion




    }
}
