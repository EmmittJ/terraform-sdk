using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_service_versions.
/// </summary>
public class AzurermKubernetesServiceVersionsDataSource : TerraformDataSource
{
    public AzurermKubernetesServiceVersionsDataSource(string name) : base("azurerm_kubernetes_service_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    [TerraformArgument("include_preview")]
    public TerraformValue<bool>? IncludePreview
    {
        get => new TerraformReference<bool>(this, "include_preview");
        set => SetArgument("include_preview", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformArgument("version_prefix")]
    public TerraformValue<string>? VersionPrefix
    {
        get => new TerraformReference<string>(this, "version_prefix");
        set => SetArgument("version_prefix", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformArgument("default_version")]
    public TerraformValue<string> DefaultVersion
    {
        get => new TerraformReference<string>(this, "default_version");
    }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformArgument("latest_version")]
    public TerraformValue<string> LatestVersion
    {
        get => new TerraformReference<string>(this, "latest_version");
    }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformArgument("versions")]
    public TerraformList<string> Versions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "versions").ResolveNodes(ctx));
    }

}
