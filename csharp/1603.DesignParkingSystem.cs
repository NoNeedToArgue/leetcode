// Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.

// Implement the ParkingSystem class:

// ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class. The number of slots for each parking space are given as part of the constructor.
// bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot. carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively. A car can only park in a parking space of its carType. If there is no space available, return false, else park the car in that size space and return true.

public class ParkingSystem {

    int _big;
    int _medium;
    int _small;

    public ParkingSystem(int big, int medium, int small) {

        _big = big;
        _medium = medium;
        _small = small;
    }
    
    public bool AddCar(int carType) {

        switch (carType)
        {
            case 1:
                if (_big > 0)
                {
                    _big--;
                    return true;
                }
                break;
            case 2:
                if (_medium > 0)
                {
                    _medium--;
                    return true;
                }
                break;
            case 3:
                if (_small > 0)
                {
                    _small--;
                    return true;
                }
                break;
        }

        return false;        
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */