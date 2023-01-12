﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsTrue(string v)
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
