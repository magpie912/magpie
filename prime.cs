using System; 

class Prime {
    public static bool isPrime(long value)
    {
	value = value > 0 ? value : -value;

	if (value < 4  || value == 5 || value == 7) {
	    return value != 0;
	} else if (value % 2 == 0) {
	    return false;
	}

	for (int dividend = 3; dividend <= Math.Sqrt(value); dividend+=2) {            
	    if (value % dividend == 0) {
		return false;
	    }
	}
    
	return true;
    }
}
