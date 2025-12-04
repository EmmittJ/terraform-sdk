using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_artifact_registry_version Terraform data source.
/// Retrieves information about a google_artifact_registry_version.
/// </summary>
public partial class GoogleArtifactRegistryVersionDataSource(string name) : TerraformDataSource("google_artifact_registry_version", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The package_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PackageName is required")]
    public required TerraformValue<string> PackageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("package_name");
        set => SetArgument("package_name", value);
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
    /// The repository_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryId is required")]
    public required TerraformValue<string> RepositoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_id");
        set => SetArgument("repository_id", value);
    }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionName is required")]
    public required TerraformValue<string> VersionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("version_name");
        set => SetArgument("version_name", value);
    }

    /// <summary>
    /// The view attribute.
    /// </summary>
    public TerraformValue<string>? View
    {
        get => GetArgument<TerraformValue<string>>("view");
        set => SetArgument("view", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformMap<string> Annotations
        => AsReference("annotations");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The related_tags attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RelatedTags
        => AsReference("related_tags");

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
