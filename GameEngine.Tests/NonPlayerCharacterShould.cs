using Xunit;

namespace GameEngine.Tests
{
    public class NonPlayerCharacterShould
    {
        // using MemberData for getting an external class to use a multiple params for a single unit test
        [Theory]
        [Trait("Category","Theory for Multiple Parameter")]
        [MemberData(nameof(InternalHealthDamageTestData.TestData), MemberType = typeof(InternalHealthDamageTestData))]
        public void TakeDamage(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }

        // using MemberData for getting an external file to use a multiple params for a single unit test
        [Theory]
        [Trait("Category", "Theory for Multiple Parameter")]
        [MemberData(nameof(ExternalHealthDamageTestData.TestData), MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamageFromExternalData(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }

        // using XUnit's DataAttribute for getting an external file to use a multiple params for a single unit test
        [Theory]
        [Trait("Category", "Theory for Multiple Parameter")]
        [HealthDamageData]
        public void TakeDamageFromDataAttribute(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }

        // using inline data for testing multiple parameters for a single unit test
        //[Theory]
        //[Trait("Category", "Theory for Multiple Parameter")]
        //[InlineData(0, 100)]
        //[InlineData(1, 99)]
        //[InlineData(50, 50)]
        //[InlineData(101, 1)]
        //public void TakeDamage(int damage, int expectedHealth)
        //{
        //    NonPlayerCharacter sut = new NonPlayerCharacter();

        //    sut.TakeDamage(damage);

        //    Assert.Equal(expectedHealth, sut.Health);
        //}
    }
}
