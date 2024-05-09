using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj
{
    internal class cls_Actions
    {
        private static int ID;
        public static int userId {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public static string Login(string username, string password)
        {
            using (EN_Users db = new EN_Users())
            {
                var userFind = db.tbl_Users.ToList().FirstOrDefault(
                    user => user.username == username && user.password == password
                );

                if (userFind != null)
                {
                    string userRole = userFind.role == 0 ? "simpleuser" : "admin";
                    userId = userFind.userId;
                    return userRole;
                }

                MessageBox.Show("Your username or password is incorrect!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public static void LoadData(TextBox txt_FirstName, TextBox txt_LastName, TextBox txt_Age)
        {
            using (EN_Users db = new EN_Users())
            {
                var currentUser = db.tbl_Profiles.ToList().First(user => user.userId == userId);
                txt_FirstName.Text = currentUser.firstName;
                txt_LastName.Text = currentUser.lastName;
                txt_Age.Text = currentUser.age.ToString();
            }
        }

        public static void UpdateData(TextBox txt_FirstName, TextBox txt_LastName, TextBox txt_Age, int mainId)
        {
            using (EN_Users db = new EN_Users())
            {
                var currentUser = db.tbl_Profiles.ToList().First(user => user.userId == mainId);
                currentUser.firstName = txt_FirstName.Text;
                currentUser.lastName = txt_LastName.Text;
                currentUser.age = Convert.ToInt32(txt_Age.Text);

                db.SaveChanges();
                MessageBox.Show("Your new data updated!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static List<view_GetOnlySimpleusers> GetSimpleusersData()
        {
            using (EN_Users db = new EN_Users())
            {
                return db.view_GetOnlySimpleusers.ToList();
            }
        }

        public static List<view_GetOnlyAdmins> GetAdminsData()
        {
            using (EN_Users db = new EN_Users())
            {
                return db.view_GetOnlyAdmins.ToList();
            }
        }

        public static void AddUser(string username, string password, string firstName, string lastName, int age)
        {
            using (EN_Users db = new EN_Users())
            {
                tbl_Users newUser = new tbl_Users()
                {
                    username = username,
                    password = password,
                };
                db.tbl_Users.Add(newUser);

                db.SaveChanges();

                tbl_Profiles newProfile = new tbl_Profiles()
                {
                    userId = newUser.userId,
                    firstName = firstName,
                    lastName = lastName,
                    age = age
                };
                db.tbl_Profiles.Add(newProfile);

                db.SaveChanges();
            }
            MessageBox.Show("New user added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
        public static bool DeleteUser(int userId)
        {
            using (EN_Users db = new EN_Users())
            {
                tbl_Users userFound = db.tbl_Users.FirstOrDefault(user => user.userId == userId);
                tbl_Profiles profileFound = db.tbl_Profiles.FirstOrDefault(user => user.userId == userId);

                if (userFound != null || profileFound != null)
                {
                    string message = $"Are you sure you want to delete user '{profileFound.firstName} {profileFound.lastName}' with id '{profileFound.userId}'?";
                    DialogResult result =  MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result.Equals(DialogResult.Yes))
                    {
                        db.tbl_Users.Remove(userFound);
                        db.tbl_Profiles.Remove(profileFound);
                        db.SaveChanges();
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    return false;
                }

                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void AddMessage(string subject, string body, int simpleuserId, int adminId)
        {
            using (EN_Users db = new EN_Users())
            {
                tbl_Messages newMessage = new tbl_Messages();
                newMessage.adminId = adminId;
                newMessage.simpleuserId = simpleuserId;
                newMessage.subject = subject;
                newMessage.bodyText = body;
                db.tbl_Messages.Add(newMessage);
                db.SaveChanges();

                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
        public static List<tbl_Messages> GetMessagesData()
        {
            using (EN_Users db = new EN_Users())
            {
                return db.tbl_Messages.ToList();
            }
        }

        public static bool DeleteMessage(int messageId)
        {
            using (EN_Users db = new EN_Users())
            {
                tbl_Messages messageFound = db.tbl_Messages.FirstOrDefault(message => message.messageId == messageId);

                if (messageFound != null)
                {
                    string message = $"Are you sure you want to delete message with subject '{messageFound.subject}' and Id '{messageFound.messageId}'?";
                    DialogResult result = MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result.Equals(DialogResult.Yes))
                    {
                        db.tbl_Messages.Remove(messageFound);
                        db.SaveChanges();
                        MessageBox.Show("Message deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    return false;
                }

                MessageBox.Show("Message not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
