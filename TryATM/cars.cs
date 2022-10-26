using System;
using System.Collections.Generic;
using System.Linq;
namespace TryATM
{
    public class car
    {
        public int carid { get; set; }
        string brand;
        string model;
        string color;
        string engine;
        string transmission;
        string brandmodel;
        public double carPrice { get; set; }

        public car(int carid, string brand, string model, string color, string engine, string transmission, string brandmodel, double carPrice)
        {
            this.carid = carid;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.engine = engine;
            this.transmission = transmission;
            this.brandmodel = brand + model;
            this.carPrice = carPrice;
        }
        public string GetBrand()
        {
            return brand;
        }
        public string GetModel()
        {
            return model;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetEngine()
        {
            return engine;
        }
        public string GetTransmission()
        {
            return transmission;
        }
        public string GetBrandModel(string newBrandmodel)
        {
            return newBrandmodel;
        }
        public void SetBrand(string newBrand)
        {
            brand = newBrand;
        }
        public void SetModel(string newModel)
        {
            model = newModel;
        }
        public void SetColor(string newcolor = "green")
        {
            color = newcolor;
        }
        public void SetEngine(string newEngine = "disel")
        {
            engine = newEngine;
        }
        public void SetTransmission(string newTransmission = "manual")
        {
            transmission = newTransmission;
        }
        public string SetBranModel(string newBrandModel)
        {
            string model = this.model;
            string brand = this.brand;
            newBrandModel = brand + model;
            brandmodel = newBrandModel;
            return newBrandModel;
        }
        public static double Load(int carid)
        {
      

            List<car> cars = new List<car>();
            cars.Add(new car(1, "BMW", "525", "red", "petrol", "manual", "BMW525", 200.00));
            cars.Add(new car(2, "BMW", "525", "red", "petrol", "auto", "", 250.00));
            cars.Add(new car(3, "BMW", "325", "green", "disel", "manual", "", 350.00));
            cars.Add(new car(4, "BMW", "530", "yellow", "disel", "auto", "", 450.00));
            cars.Add(new car(5, "Citroen", "C5", "red", "petrol", "manual", "", 55.20));
            cars.Add(new car(6, "BMW", "C5", "white", "petrol", "auto", "", 250.00));
            cars.Add(new car(7, "Volvo", "XC90", "red", "petrol", "auto", "", 550.00));
            car currentcar;
            currentcar = cars.FirstOrDefault(x => x.carid == carid);
            double currentCarPrice;

            return currentCarPrice = currentcar.carPrice;
        }




        //string brand = 7onsole.ReadLine();
        //string model = 7onsole.ReadLine();
    }
}