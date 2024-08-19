using System;
using CrispyWaffle.Serialization;
using EditoraInovacao.Sankhya.Entities.Transport;
using FluentAssertions;
using Xunit;

namespace EditoraInovacao.Sankhya.Entities.Tests;

public class ModelSerializationTests
{
    [Fact]
    public void Test_Serialize_And_Deserialize_Brand()
    {
        var brand = new Brand
        {
            Code = 1,
            CodeUser = 123,
            Name = "Test Brand",
            Title = "Brand Title",
            Description = "Brand Description",
            Keywords = "keyword1, keyword2",
            IsActive = true,
            IsInPlatform = false,
            DateChanged = DateTime.Now,
        };

        var json = (string)brand.GetCustomSerializer(SerializerFormat.Json);
        var deserializedBrand = brand.GetCustomSerializer(SerializerFormat.Json).Deserialize(json);

        deserializedBrand.Code.Should().Be(brand.Code);
        deserializedBrand.CodeUser.Should().Be(brand.CodeUser);
        deserializedBrand.Name.Should().Be(brand.Name);
        deserializedBrand.Title.Should().Be(brand.Title);
        deserializedBrand.Description.Should().Be(brand.Description);
        deserializedBrand.Keywords.Should().Be(brand.Keywords);
        deserializedBrand.IsActive.Should().Be(brand.IsActive);
        deserializedBrand.IsInPlatform.Should().Be(brand.IsInPlatform);
        deserializedBrand.DateChanged.Should().Be(brand.DateChanged);
    }
}
