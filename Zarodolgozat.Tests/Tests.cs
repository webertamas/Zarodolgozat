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
            Assert.IsFalse(test = false);
        }

        [TestMethod]
        public void ClientValidate_SSNIsNull()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                SSN=0
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test = false);
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
            Assert.IsFalse(test = false);
        }

        [TestMethod]
        public void ClientValidate_ZipCodeIs100()
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client(
                )
            {
                HAZIPCode=100
            }
            );
            bool test = vm.ClientValidate();
            Assert.IsFalse(test = false);
        }
    }
}
