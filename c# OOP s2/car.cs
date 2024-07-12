using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_s2
{
    internal class car
    {
		private int id;
		private string model;
		private double speed;

		public car(int _id, string _model , double _speed) 
		{
			id = _id;
			model = _model;
			speed = _speed;

		}
		public car (int _id , string _model) : this(_id , _model , 180)
        { 
			//id = _id;
			//model = _model;
			//speed = 180; 
		}
        public car(int _id) : this(_id , "honda"  , 320)
        {
            //id = _id;
            //model = "bmw";
            //speed = 320;
        }


        public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int ID
		{
			get { return id; }
			set { id = value; }
		}
        public override string ToString()
        {
            return $"ID : {id}\n MODEL : {model}\n SPEED : {speed}";
        }

    }
}
