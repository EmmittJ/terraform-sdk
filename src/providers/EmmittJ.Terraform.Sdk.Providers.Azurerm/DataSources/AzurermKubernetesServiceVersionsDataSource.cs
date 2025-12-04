using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKubernetesServiceVersionsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_service_versions Terraform data source.
/// Retrieves information about a azurerm_kubernetes_service_versions.
/// </summary>
public partial class AzurermKubernetesServiceVersionsDataSource(string name) : TerraformDataSource("azurerm_kubernetes_service_versions", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePreview
    {
        get => GetArgument<TerraformValue<bool>>("include_preview");
        set => SetArgument("include_preview", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    public TerraformValue<string>? VersionPrefix
    {
        get => GetArgument<TerraformValue<string>>("version_prefix");
        set => SetArgument("version_prefix", value);
    }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformValue<string> DefaultVersion
        => AsReference("default_version");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformValue<string> LatestVersion
        => AsReference("latest_version");

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformList<string> Versions
        => AsReference("versions");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
