// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform.Tests;

public class TerraformAnnotationsTests
{
    [Fact]
    public void TerraformConfigurationAnnotation_ImplementsIResourceAnnotation()
    {
        // Arrange & Act
        var annotation = new TerraformConfigurationAnnotation();

        // Assert
        Assert.IsAssignableFrom<IResourceAnnotation>(annotation);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_OutputPathIsNullByDefault()
    {
        // Arrange & Act
        var annotation = new TerraformConfigurationAnnotation();

        // Assert
        Assert.Null(annotation.OutputPath);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_CanSetOutputPath()
    {
        // Arrange
        var annotation = new TerraformConfigurationAnnotation();
        var path = "/path/to/terraform";

        // Act
        annotation.OutputPath = path;

        // Assert
        Assert.Equal(path, annotation.OutputPath);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_CanUpdateOutputPath()
    {
        // Arrange
        var annotation = new TerraformConfigurationAnnotation
        {
            OutputPath = "/first/path"
        };
        var newPath = "/second/path";

        // Act
        annotation.OutputPath = newPath;

        // Assert
        Assert.Equal(newPath, annotation.OutputPath);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_CanBeAddedToResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var resource = builder.AddContainer("test", "image").Resource;
        var annotation = new TerraformConfigurationAnnotation
        {
            OutputPath = "/test"
        };

        // Act
        resource.Annotations.Add(annotation);

        // Assert
        Assert.Contains(annotation, resource.Annotations);
        var retrieved = resource.Annotations.OfType<TerraformConfigurationAnnotation>().FirstOrDefault();
        Assert.NotNull(retrieved);
        Assert.Equal("/test", retrieved.OutputPath);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_MultipleInstancesCanExistInCollection()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var resource = builder.AddContainer("test", "image").Resource;
        var annotation1 = new TerraformConfigurationAnnotation { OutputPath = "/first" };
        var annotation2 = new TerraformConfigurationAnnotation { OutputPath = "/second" };

        // Act
        resource.Annotations.Add(annotation1);
        resource.Annotations.Add(annotation2);

        // Assert
        var annotations = resource.Annotations.OfType<TerraformConfigurationAnnotation>().ToList();
        Assert.Equal(2, annotations.Count);
    }
}
