using Newtonsoft.Json;
using Xunit;
using EditoraInovacao.Sankhya.Entities.Transport;

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
            User = new User { /* initialize properties */ }
        };

        var json = JsonConvert.SerializeObject(brand);
        var deserializedBrand = JsonConvert.DeserializeObject<Brand>(json);

        Assert.Equal(brand.Code, deserializedBrand.Code);
        Assert.Equal(brand.CodeUser, deserializedBrand.CodeUser);
        Assert.Equal(brand.Name, deserializedBrand.Name);
        Assert.Equal(brand.Title, deserializedBrand.Title);
        Assert.Equal(brand.Description, deserializedBrand.Description);
        Assert.Equal(brand.Keywords, deserializedBrand.Keywords);
        Assert.Equal(brand.IsActive, deserializedBrand.IsActive);
        Assert.Equal(brand.IsInPlatform, deserializedBrand.IsInPlatform);
        Assert.Equal(brand.DateChanged, deserializedBrand.DateChanged);
    }
}