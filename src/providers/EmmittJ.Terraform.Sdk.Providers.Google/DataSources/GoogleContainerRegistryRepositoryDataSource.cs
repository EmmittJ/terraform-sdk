using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_registry_repository Terraform data source.
/// Retrieves information about a google_container_registry_repository.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleContainerRegistryRepositoryDataSource(string name) : TerraformDataSource("google_container_registry_repository", name)
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    public TerraformValue<string> RepositoryUrl
    {
        get => new TerraformReference<string>(this, "repository_url");
    }

}
