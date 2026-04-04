using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MgenixMember.Domain.Entities.MemberPortal.Response
{
    public class ProfileResponse
    {
            public string StatusCode { get; set; }
            public int ClientId { get; set; }
            public int Title { get; set; }
            public string WalletAddress { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FathersName { get; set; }
            public string MaritalStatus { get; set; }
            public string MaritalDate { get; set; }
            public string PinCode { get; set; }
            public int Gender { get; set; }
            public string MobileNo { get; set; }
            public string NomineeName { get; set; }
            public string NomineeDOB { get; set; }
            public string NomineeRelation { get; set; }
            public string EmailId { get; set; }
            public string Facebook { get; set; }
            public string Twitter { get; set; }
            public string AlternateNo { get; set; }
            public string DOB { get; set; }
            public string Address { get; set; }
            public string CountryId { get; set; }
            public string StateId { get; set; }
            public string CityId { get; set; }
            public string ProfilePic { get; set; }
            public string IFSC { get; set; }
            public string BankName { get; set; }
            public string BranchName { get; set; }
            public string AccountNo { get; set; }
            public string AccountHolderName { get; set; }
            public string TransactionPWD { get; set; }
            public string Passbook { get; set; }
    }
}
