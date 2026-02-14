using System;
using System.Collections.Generic;
using System.Net;


namespace DVLD_Shared
{
    public class DVLDShared
    {
        public struct stPerson
        {
            public int personID { get; set; }
            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int Gender { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public int NationaltityCountryID { get; set; }
            public string ImagePath { get; set; }
        }

        public struct stUser
        {
            public int userID { get; set; }
            public int personID { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public bool isActive { get; set; }
        }

        public static List<string> countries { get; set; } = new List<string>();
        public static List<string> LicenseClasses { get; set; } = new List<string>();

        public static stUser currentUser;
        public static stPerson currentPerson;

        public struct stApplication
        {
            public int ApplicationID { get; set; }
            public int ApplicationPersonID { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public byte ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public int UserID { get; set; }
        }

        public struct stApplicationType
        {
            public int ApplicationTypeID { get; set; }
            public string ApplicationTitle { get; set; }
            public decimal Fees { get; set; }
        }

        public enum enApplicationStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3
        }

        public enum enAppplicationTyoes
        {
            NewLocalDrivingLicenseApplication = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForALostDrivingLicense = 3,
            ReplacementForADamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5,
            NewInternationalLicense = 6
        }

        public struct stLicense
        {
            public int LicenseID { get; set; }
            public int applicationID { get; set; }
            public int driverID { get; set; }
            public int licenseClassID { get; set; }
            public DateTime issueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public string Notes { get; set; }
            public decimal paidFees { get; set; }
            public bool isActive { get; set; }
            public byte issueReason { get; set; }
            public int CreatedByUserID { get; set; }

        }

        public struct stDetainLicense
        {
            public int DetainID { get; set; }
            public int LicenseID { get; set; }
            public DateTime DetainDate { get; set; }
            public decimal FineFees { get; set; }
            public int CreatedByUserID { get; set; }
            public bool IsReleased { get; set; }
            public DateTime? ReleaseDate { get; set; }
            public int? ReleasedByUserID { get; set; }
            public int? ReleaseApplicationID { get; set; }

        }

        public struct stInternationalLicense
        {
            public int InternationalLicenseID { get; set; }
            public int applicationID { get; set; }
            public int driverID { get; set; }
            public int localLicenseID { get; set; }
            public DateTime issueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public bool isActive { get; set; }
            public int CreatedByUserID { get; set; }
        }

        public struct stDriver
        {
            public int driverID { get; set; }
            public int personID { get; set; }
            public int createdByUserID { get; set; }
            public DateTime createdDate { get; set; }
        }

        public enum enIssueReason
        {
            FirstTime = 1,
            RenewLicense = 2,
            DamagedLicense = 3,
            LostLicense = 4
        }

    }
}
