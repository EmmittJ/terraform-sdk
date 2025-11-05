// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using Xunit;

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
    public void TerraformConfigurationAnnotation_WorkingDirectoryIsNullByDefault()
    {
        // Arrange & Act
        var annotation = new TerraformConfigurationAnnotation();

        // Assert
        Assert.Null(annotation.WorkingDirectory);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_CanSetWorkingDirectory()
    {
        // Arrange
        var annotation = new TerraformConfigurationAnnotation();
        var directory = "/path/to/terraform";

        // Act
        annotation.WorkingDirectory = directory;

        // Assert
        Assert.Equal(directory, annotation.WorkingDirectory);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_CanUpdateWorkingDirectory()
    {
        // Arrange
        var annotation = new TerraformConfigurationAnnotation
        {
            WorkingDirectory = "/first/path"
        };
        var newDirectory = "/second/path";

        // Act
        annotation.WorkingDirectory = newDirectory;

        // Assert
        Assert.Equal(newDirectory, annotation.WorkingDirectory);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_CanBeAddedToResource()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var resource = builder.AddContainer("test", "image").Resource;
        var annotation = new TerraformConfigurationAnnotation
        {
            WorkingDirectory = "/test"
        };

        // Act
        resource.Annotations.Add(annotation);

        // Assert
        Assert.Contains(annotation, resource.Annotations);
        var retrieved = resource.Annotations.OfType<TerraformConfigurationAnnotation>().FirstOrDefault();
        Assert.NotNull(retrieved);
        Assert.Equal("/test", retrieved.WorkingDirectory);
    }

    [Fact]
    public void TerraformConfigurationAnnotation_MultipleInstancesCanExistInCollection()
    {
        // Arrange
        var builder = DistributedApplication.CreateBuilder();
        var resource = builder.AddContainer("test", "image").Resource;
        var annotation1 = new TerraformConfigurationAnnotation { WorkingDirectory = "/first" };
        var annotation2 = new TerraformConfigurationAnnotation { WorkingDirectory = "/second" };

        // Act
        resource.Annotations.Add(annotation1);
        resource.Annotations.Add(annotation2);

        // Assert
        var annotations = resource.Annotations.OfType<TerraformConfigurationAnnotation>().ToList();
        Assert.Equal(2, annotations.Count);
    }
}
