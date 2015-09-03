using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBL.Entities
{

    [DataContract]
    public class User
    {
        string userId;
        string name;
        string password;
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        string email;
         
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string photoNo;

         [DataMember]
        public string PhotoNo
        {
            get { return photoNo; }
            set { photoNo = value; }
        }
        string address;
         [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        int roleId;
         [DataMember]
        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        string departmentId;
         [DataMember]
        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
         [DataMember]
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
         [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
