using DVLD_Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DVLDdataAccessLayer
{

    public class DVLD_DAL
    {
        public class People
        {
            public static DataTable get_all_people()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT PersonID,NationalNo,
                            FirstName,SecondName,ThirdName,LastName,
                            DateOfBirth,    
                            CASE
                            WHEN Gendor = 0 THEN 'Male'
                            WHEN Gendor = 1 THEN 'Female'
                            END AS [Gender],
                            Address,Phone,Email
                            FROM People";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static int save_new_person(DVLDShared.stPerson person1)
            {
                int personID = -1;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[People]
                                ([NationalNo]
                                ,[FirstName]
                                ,[SecondName]
                                ,[ThirdName]
                                ,[LastName]
                                ,[DateOfBirth]
                                ,[Gendor]
                                ,[Address]
                                ,[Phone]
                                ,[Email]
                                ,[NationalityCountryID]
                                ,[ImagePath])
                            VALUES
                                (@nationalID
                                ,@firstName
                                ,@secondName
                                ,@thirdName
                                ,@lastName
                                ,@dateOfBirth
                                ,@Gender
                                ,@Address
                                ,@Phone
                                ,@email
                                ,@NCI
                                ,@imagePath);
                                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nationalID", person1.NationalNo);
                        command.Parameters.AddWithValue("@firstName", person1.FirstName);
                        command.Parameters.AddWithValue("@secondName", person1.SecondName);
                        command.Parameters.AddWithValue("@lastName", person1.LastName);
                        command.Parameters.AddWithValue("@dateOfBirth", person1.DateOfBirth.Date.ToShortDateString());
                        command.Parameters.AddWithValue("@Gender", person1.Gender);
                        command.Parameters.AddWithValue("@Address", person1.Address);
                        command.Parameters.AddWithValue("@Phone", person1.Phone);
                        command.Parameters.AddWithValue("@NCI", person1.NationaltityCountryID);

                        command.Parameters.AddWithValue("@thirdName", (object)person1.ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@email", (object)person1.Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@imagePath", (object)person1.ImagePath ?? DBNull.Value);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int ID))
                                personID = ID;
                            else personID = -1;

                        }
                        catch
                        {
                            personID = -1;
                            throw;
                        }
                    }
                }
                return personID;
            }

            public static DVLDShared.stPerson get_person_data(int personID)
            {
                DVLDShared.stPerson person = new DVLDShared.stPerson();
                person.personID = personID;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM People WHERE PersonID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                person.NationalNo = (string)reader["NationalNo"];
                                person.FirstName = (string)reader["FirstName"];
                                person.SecondName = (string)reader["SecondName"];
                                person.LastName = (string)reader["LastName"];
                                person.DateOfBirth = (DateTime)reader["DateOfBirth"];
                                person.Gender = (byte)reader["Gendor"];
                                person.Address = (string)reader["Address"];
                                person.Phone = (string)reader["Phone"];
                                person.NationaltityCountryID = (int)reader["NationalityCountryID"];

                                person.Email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                                person.ThirdName = reader["ThirdName"] == DBNull.Value ? null : (string)reader["ThirdName"];
                                person.ImagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["imagePath"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return person;
            }

            public static DVLDShared.stPerson get_person_data(string NationalNo)
            {
                DVLDShared.stPerson person = new DVLDShared.stPerson();
                person.NationalNo = NationalNo;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM People WHERE NationalNo = @No";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@No", NationalNo);
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                person.personID = (int)reader["PersonID"];
                                person.FirstName = (string)reader["FirstName"];
                                person.SecondName = (string)reader["SecondName"];
                                person.LastName = (string)reader["LastName"];
                                person.DateOfBirth = (DateTime)reader["DateOfBirth"];
                                person.Gender = (byte)reader["Gendor"];
                                person.Address = (string)reader["Address"];
                                person.Phone = (string)reader["Phone"];
                                person.NationaltityCountryID = (int)reader["NationalityCountryID"];

                                person.Email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                                person.ThirdName = reader["ThirdName"] == DBNull.Value ? null : (string)reader["ThirdName"];
                                person.ImagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["imagePath"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return person;
            }

            public static bool update_person(DVLDShared.stPerson person)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[People]
                               SET [NationalNo] = @nationalID
                                  ,[FirstName] = @firstName
                                  ,[SecondName] = @secondName
                                  ,[ThirdName] = @thirdName
                                  ,[LastName] = @lastName
                                  ,[DateOfBirth] =@dateofbirth
                                  ,[Gendor] = @Gender
                                  ,[Address] = @Address
                                  ,[Phone] = @Phone
                                  ,[Email] = @email
                                  ,[NationalityCountryID] = @NCI
                                  ,[ImagePath] = @imagePath
                             WHERE PersonID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nationalID", person.NationalNo);
                        command.Parameters.AddWithValue("@firstName", person.FirstName);
                        command.Parameters.AddWithValue("@secondName", person.SecondName);
                        command.Parameters.AddWithValue("@lastName", person.LastName);
                        command.Parameters.AddWithValue("@dateofbirth", person.DateOfBirth.Date);
                        command.Parameters.AddWithValue("@Gender", person.Gender);
                        command.Parameters.AddWithValue("@Address", person.Address);
                        command.Parameters.AddWithValue("@Phone", person.Phone);
                        command.Parameters.AddWithValue("@NCI", person.NationaltityCountryID);
                        command.Parameters.AddWithValue("@id", person.personID);

                        command.Parameters.AddWithValue("@thirdName", (object)person.ThirdName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@email", (object)person.Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@imagePath", (object)person.ImagePath ?? DBNull.Value);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }

            public static bool delete_person(int personID)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "DELETE FROM People WHERE PersonID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                        }
                    }
                }
                return success;
            }

            public static bool is_unique_NationaltyNo(string nationalNumber)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT found = 1 FROM People WHERE NationalNo = @nationalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nationalNumber", nationalNumber);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return (result != null);
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            public static bool is_unique_NationalityNo_but_personal(string nationalNumber, int personID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT found = 1 FROM People WHERE NationalNo = @nationalNumber AND NOT(PersonID = @id)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nationalNumber", nationalNumber);
                        command.Parameters.AddWithValue("@id", personID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return (result != null);
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            public static List<string> get_all_nationalityNo_for_user_adding()
            {
                List<string> AllnationalityNo = new List<string>();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT NationalNo
                            FROM People WHERE PersonID NOT IN (SELECT PersonID FROM Users)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read()) AllnationalityNo.Add((string)reader["NationalNo"]);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return AllnationalityNo;
            }

            public static List<string> get_all_nationalityNo()
            {
                List<string> AllnationalityNo = new List<string>();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT NationalNo
                            FROM People";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read()) AllnationalityNo.Add((string)reader["NationalNo"]);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return AllnationalityNo;
            }

            public static List<int> get_all_personID()
            {
                List<int> peronsID = new List<int>();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT PersonID
                            FROM People";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read()) peronsID.Add((int)reader["PersonID"]);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return peronsID;
            }

            public static List<int> get_all_personID_for_user_adding()
            {
                List<int> all_personIDs = new List<int>();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT PersonID
                            FROM People WHERE PersonID NOT IN (SELECT PersonID FROM Users)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read()) all_personIDs.Add((int)reader["PersonID"]);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return all_personIDs;
            }

            public static int get_person_id_by_nationalityNo(string nationalNo)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {

                    string query = "SELECT PersonID FROM People WHERE NationalNo = @number";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@number", nationalNo);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static bool is_person_found(int personID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {

                    string query = "SELECT Found = 1 FROM People WHERE PersonID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null;

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

        }

        public class Users
        {
            public static int authonticate(string username, string password)
            {
                int personID = -1;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT PersonID FROM Users WHERE UserName = @username AND Password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            personID = result != null ? Convert.ToInt32(result) : 0;
                        }
                        catch
                        {
                            personID = -1;
                            throw;
                        }

                    }

                }
                return personID;
            }

            public static bool is_active(int personID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT COUNT(1) From Users WHERE PersonID = @id AND IsActive = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@id", personID);

                        try
                        {
                            object result = command.ExecuteScalar();
                            return ((Convert.ToBoolean(result) == true));
                        }
                        catch
                        {
                            return false;
                        }

                    }

                }

            }

            public static DVLDShared.stUser get_user_info(int userID)
            {
                DVLDShared.stUser user = new DVLDShared.stUser();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM Users WHERE UserID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", userID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                user.userID = (int)reader["UserID"];
                                user.personID = (int)reader["PersonID"];
                                user.username = (string)reader["UserName"];
                                user.password = (string)reader["Password"];
                                user.isActive = (bool)reader["IsActive"];
                            }
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return user;
            }

            public static int get_user_id(int personID)
            {
                int userID;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT UserID FROM Users WHERE PersonID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            userID = result != null ? (int)result : -1;
                        }
                        catch
                        {
                            userID = -1;
                            throw;
                        }
                    }
                }
                return userID;
            }

            public static DataTable get_all_users()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT UserID,PersonID,UserName,IsActive
                            FROM Users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static bool is_repeated_user_id(string username)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT found = 1 FROM Users WHERE UserName = @username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return (result != null);
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            public static bool is_repeated_user_id_but_personal(string username, int UserID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT found = 1 FROM Users WHERE UserName = @username AND NOT(UserID = @id)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@id", UserID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return (result != null);
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }

            public static int save_new_user(DVLDShared.stUser user)
            {
                user.userID = -1;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[Users]
                                          ([PersonID]
                                          ,[UserName]
                                          ,[Password]
                                          ,[IsActive])
                                    VALUES
                                          (@personID
                                          ,@username
                                          ,@password
                                          ,@isactive)
                                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personID", user.personID);
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@password", user.password);
                        command.Parameters.AddWithValue("@isactive", user.isActive);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            user.userID = result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return user.userID;
            }

            public static bool delete_user(int userID)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "DELETE FROM Users WHERE UserID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", userID);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                        }
                    }
                }
                return success;
            }

            public static bool update_user(DVLDShared.stUser user)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[Users]
                                      SET [PersonID] = @personID
                                         ,[UserName] = @username
                                         ,[Password] = @password
                                         ,[IsActive] = @isactive
                                    WHERE UserID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personID", user.personID);
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@password", user.password);
                        command.Parameters.AddWithValue("@isactive", user.isActive);
                        command.Parameters.AddWithValue("@id", user.userID);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }

            public static bool update_user_password(int userID, string password)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[Users]
                                      SET  [Password] = @password
                                    WHERE UserID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@id", userID);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }


        }

        public class Applications
        {
            public static DataTable get_all_applicationsTypes()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT *
                            FROM ApplicationTypes";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static bool update_applicationtype(int id, string title, string fees)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[ApplicationTypes]
                                       SET [ApplicationTypeTitle] = @title
                                          ,[ApplicationFees] = @fees
                                     WHERE ApplicationTypeID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@fees", fees);
                        command.Parameters.AddWithValue("@id", id);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }

            public static DataTable get_all_TestTypes()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT *
                            FROM TestTypes";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static bool update_testType(int id, string title, string description, string fees)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[TestTypes]
                                   SET [TestTypeTitle] = @title
                                      ,[TestTypeDescription] = @description
                                      ,[TestTypeFees] = @fees
                                 WHERE TestTypeID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@fees", fees);
                        command.Parameters.AddWithValue("@description", fees);
                        command.Parameters.AddWithValue("@id", id);
                        try
                        {
                            connection.Open();
                            success = (Convert.ToInt32(command.ExecuteNonQuery()) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }

            public static DataTable get_all_applications()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT *
                            FROM [dbo].[LocalDrivingLicenseApplications_View]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static List<string> get_all_license_class()
            {
                List<string> classes = new List<string>();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT ClassName FROM LicenseClasses";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        try
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                classes.Add(reader["ClassName"]?.ToString());

                            }
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                DVLDShared.LicenseClasses = classes;
                return classes;
            }

            private static int get_application_fee(int applicationTypeID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", applicationTypeID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                return Convert.ToInt32(result);
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return -1;
            }

            public static bool cant_add_new_local_driving_application(string nationaltiyNo, string drvingClass)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT Found = 1 FROM LocalDrivingLicenseApplications_View WHERE NationalNo = @number AND ClassName = @name AND Status != 'Cancelled'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@number", nationaltiyNo);
                        command.Parameters.AddWithValue("@name", drvingClass);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return (result != null);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static int add_new_application(int personID, int applicationTypeID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[Applications]
                                     ([ApplicantPersonID]
                                     ,[ApplicationDate]
                                     ,[ApplicationTypeID]
                                     ,[ApplicationStatus]
                                     ,[LastStatusDate]
                                     ,[PaidFees]
                                     ,[CreatedByUserID])
                               VALUES
                                     (@personID
                                     ,@applicationDate
                                     ,@applicationType
                                     ,@applicationStatus
                                     ,@lastStatusdate
                                     ,@paidFees
                                     ,@userID)
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personID", personID);
                        command.Parameters.AddWithValue("@applicationDate", DateTime.Now);
                        command.Parameters.AddWithValue("@applicationType", applicationTypeID);
                        command.Parameters.AddWithValue("@applicationStatus", 1);
                        command.Parameters.AddWithValue("@lastStatusdate", DateTime.Now);
                        command.Parameters.AddWithValue("@paidFees", get_application_fee(applicationTypeID));
                        command.Parameters.AddWithValue("@userID", DVLDShared.currentUser.userID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static int add_new_local_driving_application(int personID, int applicationTypeID, int classLicenseID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                                       ([ApplicationID]
                                       ,[LicenseClassID])
                                 VALUES
                                       (@applicationID
                                       ,@classID)
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@applicationID", add_new_application(personID, applicationTypeID));
                        command.Parameters.AddWithValue("@classID", classLicenseID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static int get_applicationID_by_personID(int personID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT ApplicationID FROM Applications WHERE  ApplicantPersonID = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", personID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static int get_applicationID_by_LDLA(int localDrivingLicenseApplicationID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", localDrivingLicenseApplicationID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static bool canacel_applicationID(int localDrivingLicenseApplicationID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[Applications]
                                  SET [ApplicationStatus] = @status
                                     ,[LastStatusDate] = @laststatusDate
                                WHERE ApplicationID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", 2);
                        command.Parameters.AddWithValue("@laststatusDate", DateTime.Now);
                        command.Parameters.AddWithValue("@id", get_applicationID_by_LDLA(localDrivingLicenseApplicationID));

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteNonQuery();
                            return (result != null);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static bool complete_applicationID(int ApplicationID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[Applications]
                                  SET [ApplicationStatus] = @status
                                     ,[LastStatusDate] = @laststatusDate
                                WHERE ApplicationID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", 3);
                        command.Parameters.AddWithValue("@laststatusDate", DateTime.Now);
                        command.Parameters.AddWithValue("@id", ApplicationID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteNonQuery();
                            return (result != null);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static DVLDShared.stApplication get_application_basic_info(int applicationID)
            {
                DVLDShared.stApplication application = new DVLDShared.stApplication();
                application.ApplicationID = applicationID;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM Applications WHERE ApplicationID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", applicationID);
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                application.ApplicationPersonID = (int)reader["ApplicantPersonID"];
                                application.ApplicationDate = (DateTime)reader["ApplicationDate"];
                                application.ApplicationTypeID = (int)reader["ApplicationTypeID"];
                                application.ApplicationStatus = (byte)reader["ApplicationStatus"];
                                application.LastStatusDate = (DateTime)reader["LastStatusDate"];
                                application.PaidFees = (decimal)reader["PaidFees"];
                                application.UserID = (int)reader["CreatedByUserID"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return application;
            }

            public static DVLDShared.stApplicationType get_applicationType_Info(int applicaionTypeID)
            {
                DVLDShared.stApplicationType applicationType = new DVLDShared.stApplicationType();
                applicationType.ApplicationTypeID = applicaionTypeID;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", applicaionTypeID);
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                applicationType.ApplicationTitle = (string)reader["ApplicationTypeTitle"];
                                applicationType.Fees = (decimal)reader["ApplicationFees"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return applicationType;
            }

            public static DataTable get_testAppoitments(int LDAL_ID, byte typeID)
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT [TestAppointmentID]
                                        ,[AppointmentDate]
                                        ,[PaidFees]
                                        ,[IsLocked]
                                    FROM [dbo].[TestAppointments]
                                    WHERE TestTypeID = @id AND LocalDrivingLicenseApplicationID = @ldaID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", typeID);
                        command.Parameters.AddWithValue("@ldaID", LDAL_ID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static bool add_testApptoitments(int LDLA, byte TesttypeID, DateTime testDate, int UserID, decimal paidFees)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[TestAppointments]
                                       ([TestTypeID]
                                       ,[LocalDrivingLicenseApplicationID]
                                       ,[AppointmentDate]
                                       ,[PaidFees]
                                       ,[CreatedByUserID]
                                       ,[IsLocked])
                                 VALUES
                                       (@typeID
                                       ,@LocalDrivingLicenseApplicationID
                                       ,@AppointmentDate
                                       ,@PaidFees
                                       ,@CreatedByUserID
                                       ,@IsLocked)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@typeID", TesttypeID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLA);
                        command.Parameters.AddWithValue("@AppointmentDate", testDate);
                        command.Parameters.AddWithValue("@PaidFees", paidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", UserID);
                        command.Parameters.AddWithValue("IsLocked", false);
                        try
                        {
                            connection.Open();
                            object rowsAffected = command.ExecuteNonQuery();
                            success = (rowsAffected != null);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }

                }
                return success;
            }

            public static bool update_testApptoitments(int appointementID, DateTime newTestDate)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[TestAppointments]
                                      SET [AppointmentDate] = @newDate
                                    WHERE TestAppointmentID = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", appointementID);
                        command.Parameters.AddWithValue("@newDate", newTestDate);
                        try
                        {
                            connection.Open();
                            object rowsAffected = command.ExecuteNonQuery();
                            success = (Convert.ToInt32(rowsAffected) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }

            public static decimal get_testTypeFees(int testTypeID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT TestTypeFees FROM TestTypes WHERE  TestTypeID = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", testTypeID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToDecimal(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            private static bool update_testApptoitmentCase(int TestappointementID)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[TestAppointments]
                                      SET IsLocked = @case
                                    WHERE TestAppointmentID = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", TestappointementID);
                        command.Parameters.AddWithValue("@case", true);

                        try
                        {
                            connection.Open();
                            object rowsAffected = command.ExecuteNonQuery();
                            success = (Convert.ToInt32(rowsAffected) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }

            public static bool save_test_withCase(int testAppointmentID, bool testResult, string notes)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[Tests]
                                   ([TestAppointmentID]
                                   ,[TestResult]
                                   ,[Notes]
                                   ,[CreatedByUserID])
                             VALUES
                                   (@TestAppointmentID
                                   ,@TestResult
                                   ,@Notes
                                   ,@CreatedByUserID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", testResult);
                        command.Parameters.AddWithValue("@Notes", notes);
                        command.Parameters.AddWithValue("@CreatedByUserID", DVLDShared.currentUser.userID);

                        try
                        {
                            connection.Open();
                            object rowsAffected = command.ExecuteNonQuery();
                            success = (Convert.ToInt32(rowsAffected) > 0);
                            if (success)
                            {
                                update_testApptoitmentCase(testAppointmentID);
                            }
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }

                    }

                }
                return success;
            }

            public static bool delete_localDrivingLicenseApplication(int LDLA_ID)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"DELETE FROM [dbo].[LocalDrivingLicenseApplications]
                                    WHERE LocalDrivingLicenseApplicationID = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", LDLA_ID);
                        try
                        {
                            connection.Open();
                            object rowsAffected = command.ExecuteNonQuery();
                            success = (Convert.ToInt32(rowsAffected) > 0);
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }
        }

        public class Licenses
        {
            public static int issue_new_license(DVLDShared.stLicense license)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[Licenses]
                                   ([ApplicationID]
                                   ,[DriverID]
                                   ,[LicenseClass]
                                   ,[IssueDate]
                                   ,[ExpirationDate]
                                   ,[Notes]
                                   ,[PaidFees]
                                   ,[IsActive]
                                   ,[IssueReason]
                                   ,[CreatedByUserID])
                             VALUES
                                   (@ApplicationID
                                   ,@DriverID
                                   ,@LicenseClass
                                   ,@IssueDate
                                   ,@ExpirationDate
                                   ,@Notes
                                   ,@PaidFees
                                   ,@IsActive
                                   ,@IssueReason
                                   ,@CreatedByUserID)
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ApplicationID", license.applicationID);
                        command.Parameters.AddWithValue("@DriverID", license.driverID);
                        command.Parameters.AddWithValue("@LicenseClass", license.licenseClassID);
                        command.Parameters.AddWithValue("@IssueDate", license.issueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                        command.Parameters.AddWithValue("@Notes", license.Notes);
                        command.Parameters.AddWithValue("@PaidFees", license.paidFees);
                        command.Parameters.AddWithValue("@IsActive", license.isActive);
                        command.Parameters.AddWithValue("@IssueReason", license.issueReason);
                        license.CreatedByUserID = DVLDShared.currentUser.userID;
                        command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                        try
                        {
                            connection.Open();
                            object id = command.ExecuteScalar();
                            license.LicenseID = id != null ? Convert.ToInt32(id) : -1;
                        }
                        catch
                        {
                            license.LicenseID = -1;
                            throw;
                        }
                    }
                }
                if (license.LicenseID != -1)
                {
                    Applications.complete_applicationID(license.applicationID);
                }
                return license.LicenseID;
            }

            public static int get_license_class_ID(string className)
            {
                int licenseID;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT LicenseClassID FROM LicenseClasses WHERE ClassName = @name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", className);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            licenseID = result != null ? (int)result : -1;
                        }
                        catch
                        {
                            licenseID = -1;
                            throw;
                        }
                    }
                }
                return licenseID;
            }

            public static int DefaultValidityLengthAge(int classID)
            {
                int AllowedAge;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT DefaultValidityLength FROM LicenseClasses WHERE LicenseClassID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", classID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            AllowedAge = result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            AllowedAge = -1;
                            throw;
                        }
                    }
                }
                return AllowedAge;
            }

            public static DVLDShared.stLicense get_licesnseInfo(int licenseID)
            {
                DVLDShared.stLicense license = new DVLDShared.stLicense();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM Licenses WHERE LicenseID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", licenseID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                license.LicenseID = (int)reader["LicenseID"];
                                license.applicationID = (int)reader["ApplicationID"];
                                license.driverID = (int)reader["DriverID"];
                                license.licenseClassID = (int)reader["LicenseClass"];
                                license.issueDate = (DateTime)reader["IssueDate"];
                                license.ExpirationDate = (DateTime)reader["ExpirationDate"];
                                license.Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                                license.paidFees = (decimal)reader["PaidFees"];
                                license.isActive = (bool)reader["IsActive"];
                                license.issueReason = (byte)reader["IssueReason"];
                                license.CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return license;
            }

            public static string get_licenseClassName(int licenseClassID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", licenseClassID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToString(result) : "";
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static DVLDShared.stLicense get_licesnseInfo_ByAppID(int AppID)
            {
                DVLDShared.stLicense license = new DVLDShared.stLicense();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM Licenses WHERE ApplicationID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", AppID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                license.LicenseID = (int)reader["LicenseID"];
                                license.applicationID = (int)reader["ApplicationID"];
                                license.driverID = (int)reader["DriverID"];
                                license.licenseClassID = (int)reader["LicenseClass"];
                                license.issueDate = (DateTime)reader["IssueDate"];
                                license.ExpirationDate = (DateTime)reader["ExpirationDate"];
                                license.Notes = (reader["Notes"] as string) ?? "";
                                license.paidFees = (decimal)reader["PaidFees"];
                                license.isActive = (bool)reader["IsActive"];
                                license.issueReason = (byte)reader["IssueReason"];
                                license.CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return license;
            }

            public static bool person_have_this_license(string nationaltiyNo, string drvingClass)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT Found = 1 FROM LocalDrivingLicenseApplications_View WHERE NationalNo = @number AND ClassName = @name AND Status = 'Completed'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@number", nationaltiyNo);
                        command.Parameters.AddWithValue("@name", drvingClass);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return (result != null);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static DataTable get_Driver_local_license(int driverID)
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT 
                                   L.LicenseID, 
                                   L.ApplicationID, 
                                   C.ClassName, -- here for name instead of number by inner join
                                   L.IssueDate, 
                                   L.ExpirationDate, 
                                   L.IsActive
                                FROM [dbo].[Licenses] L
                                INNER JOIN [dbo].[LicenseClasses] C ON L.LicenseClass = C.LicenseClassID
                                WHERE L.DriverID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("id", driverID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static DataTable get_Driver_international_license(int driverID)
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT [InternationalLicenseID]
                                     ,[ApplicationID]
                                     ,[IssuedUsingLocalLicenseID]
                                     ,[IssueDate]
                                     ,[ExpirationDate]
                                     ,[IsActive]
                                 FROM [dbo].[InternationalLicenses]
                                WHERE DriverID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("id", driverID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static List<int> get_all_licenseID()
            {
                List<int> LicenseID = new List<int>();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT LicenseID FROM Licenses";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read()) LicenseID.Add((int)reader["LicenseID"]);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return LicenseID;
            }

            public static int issue_new_international_license(DVLDShared.stInternationalLicense license)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[InternationalLicenses]
                                      ([ApplicationID]
                                      ,[DriverID]
                                      ,[IssuedUsingLocalLicenseID]
                                      ,[IssueDate]
                                      ,[ExpirationDate]
                                      ,[IsActive]
                                      ,[CreatedByUserID])
                                VALUES
                                      (@ApplicationID
                                      ,@DriverID
                                      ,@IssuedUsingLocalLicenseID
                                      ,@IssueDate
                                      ,@ExpirationDate
                                      ,@IsActive
                                      ,@CreatedByUserID)
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ApplicationID", license.applicationID);
                        command.Parameters.AddWithValue("@DriverID", license.driverID);
                        command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.localLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", license.issueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", license.isActive);
                        license.CreatedByUserID = DVLDShared.currentUser.userID;
                        command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                        try
                        {
                            connection.Open();
                            object id = command.ExecuteScalar();
                            license.InternationalLicenseID = id != null ? Convert.ToInt32(id) : -1;
                        }
                        catch
                        {
                            license.InternationalLicenseID = -1;
                            throw;
                        }
                    }
                }
                return license.InternationalLicenseID;
            }

            public static bool has_license_with_class3(int driverID)
            {
                bool found = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT found = 1 FROM Licenses WHERE DriverID = @drvierID AND LicenseClass = 3";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@drvierID", driverID);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                found = Convert.ToByte(result) != 0 ? true : false;
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return found;
            }

            public static bool has_same_international_license(int local_licenseID)
            {
                bool found = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT found = 1 FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @local_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        {
                            command.Parameters.AddWithValue("@local_id", local_licenseID);
                            try
                            {
                                connection.Open();
                                object result = command.ExecuteScalar();
                                if (result != null)
                                {
                                    found = Convert.ToByte(result) != 0 ? true : false;
                                }
                            }
                            catch
                            {
                                throw;
                            }
                        }
                    }
                    return found;
                }
            }

            public static DVLDShared.stInternationalLicense get_international_licenseInfo(int internationalLicenseID)
            {
                DVLDShared.stInternationalLicense license = new DVLDShared.stInternationalLicense();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", internationalLicenseID);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                license.InternationalLicenseID = internationalLicenseID;
                                license.applicationID = (int)reader["ApplicationID"];
                                license.driverID = (int)reader["DriverID"];
                                license.localLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                license.issueDate = (DateTime)reader["IssueDate"];
                                license.ExpirationDate = (DateTime)reader["ExpirationDate"];
                                license.isActive = (bool)reader["IsActive"];
                                license.CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                            reader.Close();

                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return license;
            }

            public static DataTable get_all_international_licenses()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT [InternationalLicenseID]
                                    ,[ApplicationID]
                                    ,[DriverID]
                                    ,[IssuedUsingLocalLicenseID]
                                    ,[IssueDate]
                                    ,[ExpirationDate]
                                    ,[IsActive]
                                FROM [dbo].[InternationalLicenses]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }

            public static decimal get_licenseClassFees(int licenseClassID)
            {
                decimal fees = 0;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", licenseClassID);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null) fees = Convert.ToDecimal(result);
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return fees;
            }

            public static bool set_license_not_active(int licenseID)
            {
                bool sucess = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"UPDATE [dbo].[Licenses] SET [IsActive] = 0 WHERE LicenseID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("id", licenseID);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteNonQuery();
                            if (result != null) sucess = Convert.ToByte(result) == 1 ? true : false;
                        }
                        catch
                        {
                            sucess = false;
                            throw;
                        }
                    }
                }
                return sucess;
            }

            public static int add_detain_license(DVLDShared.stDetainLicense detainLicense)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[DetainedLicenses]
                                   ([LicenseID]
                                   ,[DetainDate]
                                   ,[FineFees]
                                   ,[CreatedByUserID]
                                   ,[IsReleased]
                                   ,[ReleaseDate]
                                   ,[ReleasedByUserID]
                                   ,[ReleaseApplicationID])
                             VALUES
                                   (@LicenseID
                                   ,@DetainDate
                                   ,@FineFees
                                   ,@CreatedByUserID
                                   ,@IsReleased
                                   ,@ReleaseDate
                                   ,@ReleasedByUserID
                                   ,@ReleaseApplicationID)
                                    SELECT SCOPE_IDENTITY()";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", detainLicense.LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", detainLicense.DetainDate);
                        command.Parameters.AddWithValue("@FineFees", detainLicense.FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", detainLicense.CreatedByUserID);
                        command.Parameters.AddWithValue("@IsReleased", detainLicense.IsReleased);

                        command.Parameters.AddWithValue("@ReleaseDate", (object)detainLicense.ReleaseDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReleasedByUserID", (object)detainLicense.ReleasedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", (object)detainLicense.ReleaseApplicationID ?? DBNull.Value);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();

                            if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            {
                                detainLicense.DetainID = insertedID;
                            }
                            else
                            {
                                detainLicense.DetainID = -1;
                            }
                        }
                        catch
                        {
                            detainLicense.DetainID = -1;
                            throw;
                        }
                    }
                }
                return detainLicense.DetainID;
            }

            public static bool IsDetainLicense(int licenseID)
            {
                bool success = false;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT Found = 1 FROM [dbo].[DetainedLicenses] WHERE LicenseID = @id AND (IsReleased is NULL OR IsReleased = 0)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", licenseID);
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if(result != null && Convert.ToInt32(result) == 1)
                            {
                                success = true;
                            }
                            else
                            {
                                success = false;
                            }
                        }
                        catch
                        {
                            success = false;
                            throw;
                        }
                    }
                }
                return success;
            }
        }

        public class Drivers
        {
            public static int add_new_driver(DVLDShared.stDriver driver)
            {
                int driverID = get_DriverID_by_PerosnID(driver.personID);
                if (driverID != -1) return driverID;
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"INSERT INTO [dbo].[Drivers]
                                      ([PersonID]
                                      ,[CreatedByUserID]
                                      ,[CreatedDate])
                                VALUES
                                      (@PersonID
                                      ,@CreatedByUserID
                                      ,@CreatedDate)
                                    SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", driver.personID);
                        command.Parameters.AddWithValue("@CreatedByUserID", driver.createdByUserID);
                        command.Parameters.AddWithValue("@CreatedDate", driver.createdDate);

                        try
                        {
                            connection.Open();
                            object id = command.ExecuteScalar();
                            return id != null ? Convert.ToInt32(id) : -1;
                        }
                        catch
                        {
                            throw;
                        }

                    }
                }
            }

            public static int get_personID_FromDriverID(int driverID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT PersonID FROM Drivers WHERE DriverID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", driverID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static int get_DriverID_by_PerosnID(int personID)
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = "SELECT DriverID FROM Drivers WHERE PersonID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            return result != null ? Convert.ToInt32(result) : -1;
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
            }

            public static DataTable get_all_drivers()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
                {
                    string query = @"SELECT * FROM Drivers_View";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows) dt.Load(reader);
                            reader.Close();
                        }
                        catch
                        {
                            throw;
                        }
                    }
                }
                return dt;
            }
        }

        public static List<string> get_all_countries()
        {
            List<string> countries = new List<string>();
            using (SqlConnection connection = new SqlConnection(DataAccessSetting.connection_string))
            {
                string query = "SELECT CountryName FROM Countries";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            countries.Add(reader["CountryName"]?.ToString());

                        }
                        reader.Close();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            DVLDShared.countries = countries;
            return countries;
        }
    }
}

