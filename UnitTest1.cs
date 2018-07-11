namespace AppTests
{
	using System.Threading.Tasks;
	using ApprovalTests;
	using ApprovalTests.Reporters;
	using NUnit.Framework;

	[TestFixture]
	public class UnitTest1
	{
		[Test]
		[UseReporter(typeof(DiffReporter), typeof(NUnitReporter))]
		public async Task Abc()
		{
			await Task.Delay(1);
			Approvals.Verify("abc");
		}
	}
}
