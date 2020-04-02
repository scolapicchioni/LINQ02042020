using System;
using System.Collections.Generic;
using System.Text;
using LinqBackgroundKnowledge;

namespace ExtensionsNameSpace {
    public delegate bool Checker<TypeOfItemToCheck>(TypeOfItemToCheck car);

    public static class MyExtensions {
        //MyExtensions.Filter(cars,..);
        //cars.Filter(...);
        //public static List<Car> Filter1(this List<Car> cars, Checker<Car> checkCar) {
        //    List<Car> result = new List<Car>();
        //    foreach (Car car in cars) {
        //        if (checkCar(car)) {
        //            result.Add(car);
        //        }
        //    }
        //    return result;
        //}

        //public static List<int> Filter2(this List<int> cars, Checker<int> checkCar) {
        //    List<int> result = new List<int>();
        //    foreach (int item in cars) {
        //        if (checkCar(item)) {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}

        //public static List<string> Filter3(this List<string> cars, Checker<string> checkCar) {
        //    List<string> result = new List<string>();
        //    foreach (string item in cars) {
        //        if (checkCar(item)) {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}

        public static IEnumerable<TypeOfTheItemInTheList> Filter<TypeOfTheItemInTheList>(this IEnumerable<TypeOfTheItemInTheList> list, Checker<TypeOfTheItemInTheList> checkItem) {
            List<TypeOfTheItemInTheList> result = new List<TypeOfTheItemInTheList>();
            foreach (TypeOfTheItemInTheList item in list) {
                if (checkItem(item)) {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
