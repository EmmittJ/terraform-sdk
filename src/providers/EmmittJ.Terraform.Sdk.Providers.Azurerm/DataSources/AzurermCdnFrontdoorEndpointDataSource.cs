using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorEndpointDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorEndpointDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_cdn_frontdoor_endpoint Terraform data source.
/// Retrieves information about a azurerm_cdn_frontdoor_endpoint.
/// </summary>
public partial class AzurermCdnFrontdoorEndpointDataSource(string name) : TerraformDataSource("azurerm_cdn_frontdoor_endpoint", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
        set => SetArgument("profile_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorEndpointDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
