using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;
using ClassLibraryBL.Entities;


namespace ClassLibraryBL.EntityFacade
{
    public class loginFacade
        {

        LogicUnivSystemEntities luse = new LogicUnivSystemEntities();
        
        User userentity = new User();
        public bool loginvalidate(string email, string password)
        {
            var count = (from x in luse.users where x.email == email & x.password == password select x).Count();
            int countNo = count;

            if(countNo > 0){
                return true;
            }
            else
            {
                return false;
            }
        }

        public user getuserinfo(string email, string password)
        {
            var userData = (from x in luse.users where x.email == email & x.password == password select x);
            
            return userData.SingleOrDefault();
        }
        public User fillInEntity(string email, string password)
        {
            if(loginvalidate(email,password)){
                user datainfo = getuserinfo(email, password);
                userentity.UserId = datainfo.userId;
                userentity.Name = datainfo.name;
                userentity.Email = datainfo.email;
                userentity.PhotoNo = datainfo.phoneNo;
                userentity.Address = datainfo.address;
                userentity.RoleId = datainfo.roleId;
                userentity.DepartmentId = datainfo.departmentId;
                return userentity;
            }
            else
            {
                return null;
            }
        } 

    }
}
