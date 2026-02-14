using DVLD_Shared;
using DVLDdataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DVLDBussinessLayer
{
    public class DVLD_BL
    {
        public class People
        {
            public static bool is_unique_nationalNo_but_personal(string nationalNumebr, int personID) => DVLD_DAL.People.is_unique_NationalityNo_but_personal(nationalNumebr, personID);
            public static bool is_unique_naitonalNo(string nationalNumber) => DVLD_DAL.People.is_unique_NationaltyNo(nationalNumber);

            public static DataTable get_all_people() => DVLD_DAL.People.get_all_people();

            public static bool delete_person(int personID) => DVLD_DAL.People.delete_person(personID);

            public static DVLDShared.stPerson get_person_data_for_edit(int personID) => DVLD_DAL.People.get_person_data(personID);

            public static DVLDShared.stPerson get_person_data_for_edit(string nationalNo) => DVLD_DAL.People.get_person_data(nationalNo);

            public static int add_new_person(DVLDShared.stPerson person)
            {
                if (string.IsNullOrWhiteSpace(person.NationalNo) || is_unique_naitonalNo(person.NationalNo) || string.IsNullOrWhiteSpace(person.FirstName) ||
                    string.IsNullOrWhiteSpace(person.SecondName) || string.IsNullOrWhiteSpace(person.LastName) ||
                       string.IsNullOrWhiteSpace(person.Address) || string.IsNullOrWhiteSpace(person.Phone))
                {
                    return -1;
                }

                return DVLD_DAL.People.save_new_person(person);
            }

            public static bool update_new_person(DVLDShared.stPerson person)
            {
                if (string.IsNullOrWhiteSpace(person.NationalNo) || is_unique_nationalNo_but_personal(person.NationalNo,person.personID) || string.IsNullOrWhiteSpace(person.FirstName) ||
                    string.IsNullOrWhiteSpace(person.SecondName) || string.IsNullOrWhiteSpace(person.LastName) ||
                       string.IsNullOrWhiteSpace(person.Address) || string.IsNullOrWhiteSpace(person.Phone))
                {
                    return false;
                }

                person.ThirdName = string.IsNullOrWhiteSpace(person.ThirdName) ? null : person.ThirdName;
                person.Email = string.IsNullOrWhiteSpace(person.Email) ? null : person.Email; ;
                person.ImagePath = string.IsNullOrWhiteSpace(person.ImagePath) ? null : person.ImagePath;

                return DVLD_DAL.People.update_person(person);
            }

            public static List<string> get_all_nationlityID_for_user_adding() => DVLD_DAL.People.get_all_nationalityNo_for_user_adding();

            public static int get_personID_by_NationaltyNO(string nationaltyNo) => DVLD_DAL.People.get_person_id_by_nationalityNo(nationaltyNo);

            public static List<string> get_all_nationlityID()=>DVLD_DAL.People.get_all_nationalityNo();

            public static List<int> get_all_personID() => DVLD_DAL.People.get_all_personID();

            public static List<int> get_all_personID_for_user_adding() => DVLD_DAL.People.get_all_personID_for_user_adding();

            public static bool is_person_found(int personID) => DVLD_DAL.People.is_person_found(personID);

        }

        public class Users
        {
            public static int authonticate(string username, string password) => DVLD_DAL.Users.authonticate(username, password);

            public static bool is_active_user(int personID) => DVLD_DAL.Users.is_active(personID);

            public static int get_user_id(int userID) => DVLD_DAL.Users.get_user_id(userID);

            public static DVLDShared.stUser get_user_data(int userID) => DVLD_DAL.Users.get_user_info(userID);

            public static DataTable get_all_users() => DVLD_DAL.Users.get_all_users();

            public static bool is_repeated_user_id_but_personal(string username,int UserID) => DVLD_DAL.Users.is_repeated_user_id_but_personal(username,UserID);

            public static bool is_repeated_user_id(string username) => DVLD_DAL.Users.is_repeated_user_id(username);

            public static int add_new_user(DVLDShared.stUser user)
            {
                if (string.IsNullOrWhiteSpace(user.username) || DVLD_DAL.Users.is_repeated_user_id_but_personal(user.username, user.userID)
                    || string.IsNullOrWhiteSpace(user.password))
                {
                    return -1;
                }
                return DVLD_DAL.Users.save_new_user(user);
            }

            public static bool delete_user(int user) => DVLD_DAL.Users.delete_user(user);

            public static bool update_user(DVLDShared.stUser user)
            {
                if (string.IsNullOrWhiteSpace(user.username) || DVLD_DAL.Users.is_repeated_user_id_but_personal(user.username,user.userID)
                    || string.IsNullOrWhiteSpace(user.password))
                {
                    return false;
                }

                return DVLD_DAL.Users.update_user(user);
            }
            
            public static bool update_user_password(int userID,string password) =>DVLD_DAL.Users.update_user_password(userID,password);
        }

        public class Applications
        {
            public static int add_new_application(int personID, int applicationTypeID) => DVLD_DAL.Applications.add_new_application(personID,applicationTypeID);

            public static int add_new_application(int personID, int applicationTypeID, decimal paidmoney) => DVLD_DAL.Applications.add_new_application(personID, applicationTypeID, paidmoney);

            public static DataTable get_all_applicationsTypes() => DVLD_DAL.Applications.get_all_applicationsTypes();

            public static bool update_applicationtype(int id, string title, string fees) => DVLD_DAL.Applications.update_applicationtype(id, title, fees);

            public static DataTable get_all_TestTypes() => DVLD_DAL.Applications.get_all_TestTypes();

            public static bool update_testType(int id, string title, string description, string fees) => DVLD_DAL.Applications.update_testType(id, title, description, fees);

            public static DataTable get_all_applications() => DVLD_DAL.Applications.get_all_applications();

            public static List<string> get_all_licenseClasses() => DVLD_DAL.Applications.get_all_license_class();

            public static int add_new_LocalDrvingLicenseApplication(int personID, int ApplicationID, int ClassID) => DVLD_DAL.Applications.add_new_local_driving_application(personID, ApplicationID, ClassID);

            public static bool cant_add_new_local_driving_application(string NationalityNumber, string drivingClass) => DVLD_DAL.Applications.cant_add_new_local_driving_application(NationalityNumber, drivingClass);

            public static int get_applicationID_by_personID(int personID) => DVLD_DAL.Applications.get_applicationID_by_personID(personID);

            public static bool canacel_applicationID(int localDrivingLicesnseApplicationID) => DVLD_DAL.Applications.canacel_applicationID(localDrivingLicesnseApplicationID);

            public static DVLDShared.stApplication get_application_basic_info(int applicationID) => DVLD_DAL.Applications.get_application_basic_info(applicationID);

            public static DVLDShared.stApplicationType get_application_Type_Info(int applicaionTypeID) => DVLD_DAL.Applications.get_applicationType_Info(applicaionTypeID);

            public static int get_applicationID_by_LDLA(int localDrivingLicenseApplicationID) => DVLD_DAL.Applications.get_applicationID_by_LDLA(localDrivingLicenseApplicationID);

            public static DataTable get_testAppoitments(int LDAL_ID, byte typeID) => DVLD_DAL.Applications.get_testAppoitments(LDAL_ID, typeID);

            public static bool add_testApptoitments(int LDLA, byte typeID, DateTime testDate, int UserID,decimal paidFees) => DVLD_DAL.Applications.add_testApptoitments(LDLA, typeID, testDate, UserID, paidFees);

            public static decimal get_testTypeFees(int testTypeID) => DVLD_DAL.Applications.get_testTypeFees(testTypeID);

            public static bool update_testAppoitment(int AppointmnetID,DateTime newTestDate) =>DVLD_DAL.Applications.update_testApptoitments(AppointmnetID, newTestDate);
        
            public static bool save_test_withCase(int testAppointmentID, bool testResult, string notes) =>DVLD_DAL.Applications.save_test_withCase(testAppointmentID, testResult, notes);

            public static bool delete_localDrivingLicenseApplication(int LDLA_ID) => DVLD_DAL.Applications.delete_localDrivingLicenseApplication(LDLA_ID);
        }

        public class Licenses
        {
            public static int issue_new_license(DVLDShared.stLicense license) => DVLD_DAL.Licenses.issue_new_license(license);

            public static int get_license_class_ID(string className) => DVLD_DAL.Licenses.get_license_class_ID(className);

            public static int DefaultValidityLengthAge(int classID) => DVLD_DAL.Licenses.DefaultValidityLengthAge(classID);

            public static DVLDShared.stLicense get_licenseInfo(int licenseID) => DVLD_DAL.Licenses.get_licesnseInfo(licenseID);

            public static string get_licenseClassName(int licenseClassID) => DVLD_DAL.Licenses.get_licenseClassName(licenseClassID);

            public static DVLDShared.stLicense get_licenseInfo_By_AppID(int AppID) => DVLD_DAL.Licenses.get_licesnseInfo_ByAppID(AppID);

            public static bool person_have_this_license(string nationaltiyNo, string drvingClass) => DVLD_DAL.Licenses.person_have_this_license(nationaltiyNo, drvingClass);

            public static DataTable get_Driver_local_license(int driverID) => DVLD_DAL.Licenses.get_Driver_local_license(driverID);

            public static DataTable get_Driver_international_license(int driverID) => DVLD_DAL.Licenses.get_Driver_international_license(driverID);

            public static List<int> get_all_licenseID() => DVLD_DAL.Licenses.get_all_licenseID();

            public static int issue_new_international_license(DVLDShared.stInternationalLicense license) => DVLD_DAL.Licenses.issue_new_international_license(license);

            public static bool has_license_with_class3(int driverID) => DVLD_DAL.Licenses.has_license_with_class3(driverID);

            public static bool has_same_international_license(int local_licenseID) => DVLD_DAL.Licenses.has_same_international_license(local_licenseID);

            public static DVLDShared.stInternationalLicense get_international_licenseInfo(int internationalLicenseID) => DVLD_DAL.Licenses.get_international_licenseInfo(internationalLicenseID);

            public static DataTable get_all_international_licenses() => DVLD_DAL.Licenses.get_all_international_licenses();

            public static decimal get_licenseClassFees(int licenseClassID) => DVLD_DAL.Licenses.get_licenseClassFees(licenseClassID);

            public static bool set_license_not_active(int licenseID) => DVLD_DAL.Licenses.set_license_not_active(licenseID);

            public static int add_detain_license(DVLDShared.stDetainLicense detainLicense) => DVLD_DAL.Licenses.add_detain_license(detainLicense);

            public static bool IsDetainLicense(int licenseID) => DVLD_DAL.Licenses.IsDetainLicense(licenseID);

            public static DVLDShared.stDetainLicense get_detain_license_info(int licenseID) => DVLD_DAL.Licenses.get_detain_license_info(licenseID);

            public static bool release_detainLicense(int detainLicenseID, int applicationID) => DVLD_DAL.Licenses.release_detainLicense(detainLicenseID, applicationID);

            public static DataTable get_all_detainLicense() => DVLD_DAL.Licenses.get_all_detainLicense();
        }

        public class Drivers
        {
            public static int add_new_driver(DVLDShared.stDriver driver) => DVLD_DAL.Drivers.add_new_driver(driver);

            public static int get_personID_FromDriverID(int driverID) => DVLD_DAL.Drivers.get_personID_FromDriverID(driverID);

            public static int get_DriverID_by_PerosnID(int personID) => DVLD_DAL.Drivers.get_DriverID_by_PerosnID(personID);

            public static DataTable get_all_drivers() => DVLD_DAL.Drivers.get_all_drivers();
        }

        public static List<String> get_all_countries() => DVLD_DAL.get_all_countries();
    }
}
