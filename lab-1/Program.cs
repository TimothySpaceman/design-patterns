using lab_1;

var personalInfo = new PersonalInfo(
    "Timothy",
    "Yuriyovych",
    "Rehenel",
    Sex.Male,
    new DateTime(2004,12,15)
    );

var passport = new Passport(
    personalInfo,
    "☺",
    new DateTime(2054,6,30),
    "123456789",
    "UP",
    1001
);

var drivingLicense = new DrivingLicense(personalInfo, "☺", "DL", 100234);
drivingLicense.AddCategory(VehicleCategory.B, new DateTime(2034,6,30));
drivingLicense.AddCategory(VehicleCategory.C1, new DateTime(2034,6,30));
drivingLicense.AddCategory(VehicleCategory.C, new DateTime(2034,6,30));

var militaryId = new MilitaryID(personalInfo, "☺", "MI", 12345, EnrollAbility.PartiallyAble);

var notDiia = new NotDiia();
notDiia.AddDocument(passport);
notDiia.AddDocument(drivingLicense);
notDiia.AddDocument(militaryId);

notDiia.ShowDocument();
notDiia.ShowInfo();
notDiia.HideInfo();
notDiia.GenerateQR();
var doc = notDiia.CurrentDocument as Passport;
doc?.CopyRNTRC();
notDiia.HideDocument();

notDiia.NextDocument();
Console.WriteLine();

notDiia.ShowDocument();
notDiia.ShowInfo();
notDiia.HideInfo();
notDiia.GenerateQR();
notDiia.HideDocument();

notDiia.NextDocument();
Console.WriteLine();

notDiia.ShowDocument();
notDiia.ShowInfo();
notDiia.HideInfo();
notDiia.GenerateQR();
notDiia.HideDocument();

notDiia.CurrentIndex = 0;
Console.WriteLine($"\nPosition {notDiia.CurrentIndex + 1}: ");
notDiia.ShowDocument();

notDiia.CurrentIndex = 1;
Console.WriteLine($"\nPosition {notDiia.CurrentIndex + 1}: ");
notDiia.ShowDocument();

notDiia.CurrentIndex = 0;
notDiia.ShiftRight();
Console.WriteLine("\nCalling ShiftRight()");

notDiia.CurrentIndex = 0;
Console.WriteLine($"\nPosition {notDiia.CurrentIndex + 1}: ");
notDiia.ShowDocument();

notDiia.CurrentIndex = 1;
Console.WriteLine($"\nPosition {notDiia.CurrentIndex + 1}: ");
notDiia.ShowDocument();

Console.ReadLine();