using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zarodolgozat.Dal;
using Zarodolgozat;

namespace Zarodolgozat.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ClientValidate_WithoutName()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                FirstName = null
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_WithoutFirstNameButWithLastName()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                FirstName = null,
                LastName = "Horváth"
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_SSNIsNull()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                SSN = 0
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_SSNIs1Million()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                SSN = 1000000000
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_ZipCodeIs100()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                HAZIPCode = 100
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_ZipCodeIs10000()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                HAZIPCode = 10000
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_PAZipCodeIs999()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                PAZIPCode = 999
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_PAZipCodeIs1106()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                FirstName = "István",
                LastName = "Kiss",
                BirthName = "Kiss István",
                BirthPlace = "Budapest",
                BirthDate = DateTime.Parse("1960/01/01"),
                MothersLastName = "Ágnes",
                MothersFirstName = "Szabó",
                SSN = 111222333,
                HAZIPCode = 1106,
                HALocality = "Budapest",
                HAStreet = "Jászberényi út",
                HANumber = "47/E",
                PAZIPCode = 1106,
                PALocality = "Budapest",
                PAStreet = "Jászberényi út",
                PANumber = "47/E"
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void ClientValidate_PAZipCodeIs1106ButNoPALocality()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                FirstName = "István",
                LastName = "Kiss",
                BirthName = "Kiss István",
                BirthPlace = "Budapest",
                BirthDate = DateTime.Parse("1960/01/01"),
                MothersLastName = "Ágnes",
                MothersFirstName = "Szabó",
                SSN = 111222333,
                HAZIPCode = 1106,
                HALocality = "Budapest",
                HAStreet = "Jászberényi út",
                HANumber = "47/E",
                PAZIPCode = 1106,
                PAStreet = "Jászberényi út",
                PANumber = "47/E"
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }

        [TestMethod]
        public void ClientValidate_PAZipCodeIs10000()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                PAZIPCode = 10000
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test);
        }


    }
}
