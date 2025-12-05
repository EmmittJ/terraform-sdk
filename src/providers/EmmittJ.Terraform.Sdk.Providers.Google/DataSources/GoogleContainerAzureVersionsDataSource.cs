using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_container_azure_versions Terraform data source.
/// Retrieves information about a google_container_azure_versions.
/// </summary>
public partial class GoogleContainerAzureVersionsDataSource(string name) : TerraformDataSource("google_container_azure_versions", name)
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
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The supported_regions attribute.
    /// </summary>
    public TerraformList<string> SupportedRegions
        => CreateReference("supported_regions");

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    public TerraformList<string> ValidVersions
        => CreateReference("valid_versions");

}
