using Xunit;

namespace ReactiveUI.Tests
{
    using System;

    public class BindingTypeConvertersTest
    {
        [Fact(Skip ="Skipped to diagnose xunit/threading/scheduling issue")]
        public void EqualityTypeConverterDoReferenceCastShouldConvertNullNullableValues()
        {
            double? nullDouble = null;
            double? expected = null;
            var result = EqualityTypeConverter.DoReferenceCast(nullDouble, typeof(double?));
            Assert.Equal(expected, result);
        }

        [Fact(Skip ="Skipped to diagnose xunit/threading/scheduling issue")]
        public void EqualityTypeConverterDoReferenceCastShouldConvertNullableValues()
        {
            double? doubleValue = 1.0;
            double? expected = 1.0;
            var result = EqualityTypeConverter.DoReferenceCast(doubleValue, typeof(double?));
            Assert.Equal(expected, result);
        }

        [Fact(Skip ="Skipped to diagnose xunit/threading/scheduling issue")]
        public void EqualityTypeConverterDoReferenceCastShouldThrowWhenConvertingFromNullNullableToValueType()
        {
            double? nullDouble = null;
            Assert.Throws<InvalidCastException>(() => EqualityTypeConverter.DoReferenceCast(nullDouble, typeof(double)));
        }

        [Fact(Skip ="Skipped to diagnose xunit/threading/scheduling issue")]
        public void EqualityTypeConverterDoReferenceCastNullableToValueType()
        {
            double? doubleValue = 1.0;
            double? expected = 1.0;
            var result = EqualityTypeConverter.DoReferenceCast(doubleValue, typeof(double));
            Assert.Equal(expected, result);
        }

        [Fact(Skip ="Skipped to diagnose xunit/threading/scheduling issue")]
        public void EqualityTypeConverterDoReferenceCastShouldConvertValueTypes()
        {
            double doubleValue = 1.0;
            var result = EqualityTypeConverter.DoReferenceCast(doubleValue, typeof(double));
            Assert.Equal(doubleValue, result);
        }
    }
}