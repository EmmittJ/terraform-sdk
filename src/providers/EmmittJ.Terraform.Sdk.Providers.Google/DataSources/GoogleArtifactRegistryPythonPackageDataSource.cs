using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_python_package Terraform data source.
/// Retrieves information about a google_artifact_registry_python_package.
/// </summary>
public partial class GoogleArtifactRegistryPythonPackageDataSource(string name) : TerraformDataSource("google_artifact_registry_python_package", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The region of the Artifact Registry repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the Python package.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformValue<string> PackageName
    {
        get => new TerraformReference<string>(this, "package_name");
        set => SetArgument("package_name", value);
    }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The repository ID containing the Python package.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => new TerraformReference<string>(this, "repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// The time the package was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The fully qualified name of the Python package.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The time the package was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// The version of the Python package.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
