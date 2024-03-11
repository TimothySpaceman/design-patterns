namespace lab_1;

public class DrivingCategoryItem
{
    public VehicleCategory VehicleCategory { get; private set; }
    public DateTime DateOfExpiry { get; set; }

    public DrivingCategoryItem(VehicleCategory vehicleCategory, DateTime dateOfExpiry)
    {
        VehicleCategory = vehicleCategory;
        DateOfExpiry = dateOfExpiry;
    }
}