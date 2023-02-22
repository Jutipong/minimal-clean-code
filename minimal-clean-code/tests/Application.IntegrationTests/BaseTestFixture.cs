using NUnit.Framework;

using static minimal_clean_code.Application.IntegrationTests.Testing;

namespace minimal_clean_code.Application.IntegrationTests;
[TestFixture]
public abstract class BaseTestFixture
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
