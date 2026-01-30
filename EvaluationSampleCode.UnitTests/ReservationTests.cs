using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_WhenUserIsAdmin_ShouldReturnTrue()
        {
            var admin = new User { IsAdmin = true };
            var reservation = new Reservation(new User { IsAdmin = false });

            var result = reservation.CanBeCancelledBy(admin);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_WhenUserIsOwner_ShouldReturnTrue()
        {
            var user = new User { IsAdmin = false };
            var reservation = new Reservation(user);

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }
        
    }
}
