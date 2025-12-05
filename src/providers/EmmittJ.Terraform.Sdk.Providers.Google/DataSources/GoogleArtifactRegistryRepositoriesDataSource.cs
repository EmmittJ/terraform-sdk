using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_repositories Terraform data source.
/// Retrieves information about a google_artifact_registry_repositories.
/// </summary>
public partial class GoogleArtifactRegistryRepositoriesDataSource(string name) : TerraformDataSource("google_artifact_registry_repositories", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name_filter attribute.
    /// </summary>
    public TerraformValue<string>? NameFilter
    {
        get => GetArgument<TerraformValue<string>>("name_filter");
        set => SetArgument("name_filter", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The repositories attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Repositories
        => CreateReference("repositories");

}
