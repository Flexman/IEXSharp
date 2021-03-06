using VSLee.IEXSharp;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace VSLee.IEXSharpTest.V1
{
	public class ReferenceDataTest
	{
		private IEXV1RestClient prodClient;

		[SetUp]
		public void Setup()
		{
			prodClient = new IEXV1RestClient();
		}

		[Test]
		public async Task SymbolsAsyncTest()
		{
			var response = await prodClient.ReferenceData.SymbolsAsync();

			Assert.IsNull(response.ErrorMessage);
			Assert.IsNotNull(response.Data);
			Assert.GreaterOrEqual(response.Data.Count(), 1);
		}

		[Test]
		public async Task IEXCorporateActionsAsyncTest()
		{
			var response = await prodClient.ReferenceData.IEXCorporateActionsAsync();

			Assert.IsNull(response.ErrorMessage);
			Assert.IsNotNull(response.Data);
			Assert.GreaterOrEqual(response.Data.Count(), 1);
		}

		[Test]
		public async Task IEXDividentsAsyncTest()
		{
			var response = await prodClient.ReferenceData.IEXDividentsAsync();

			Assert.IsNull(response.ErrorMessage);
			Assert.IsNotNull(response.Data);
			Assert.GreaterOrEqual(response.Data.Count(), 1);
		}

		[Test]
		public async Task IEXNextDayExDateAsyncTest()
		{
			var response = await prodClient.ReferenceData.IEXNextDayExDateAsync();

			Assert.IsNull(response.ErrorMessage);
			Assert.IsNotNull(response.Data);
			Assert.GreaterOrEqual(response.Data.Count(), 1);
		}

		[Test]
		public async Task IEXListedSymbolDirectoryAsyncTest()
		{
			var response = await prodClient.ReferenceData.IEXListedSymbolDirectoryAsync();

			Assert.IsNull(response.ErrorMessage);
			Assert.IsNotNull(response.Data);
			Assert.GreaterOrEqual(response.Data.Count(), 1);
		}
	}
}