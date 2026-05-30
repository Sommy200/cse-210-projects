using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateorProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateorProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateorProvince = stateorProvince;
        _country = country;
    }
        // Returns true if the address is in the USA, false otherwise
        public bool IsInUSA()     
    {   
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";


    }
    // Returns formatted New Address
    public string GetFullAddress()
    {
       return $"{_streetAddress}\n{_city}, {_stateorProvince}\n{_country}"; 
    }
}