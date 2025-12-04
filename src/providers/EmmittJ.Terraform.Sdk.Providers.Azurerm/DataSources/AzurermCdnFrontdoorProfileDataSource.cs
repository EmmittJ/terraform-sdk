using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorProfileDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorProfileDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_cdn_frontdoor_profile Terraform data source.
/// Retrieves information about a azurerm_cdn_frontdoor_profile.
/// </summary>
public partial class AzurermCdnFrontdoorProfileDataSource(string name) : TerraformDataSource("azurerm_cdn_frontdoor_profile", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The log_scrubbing_rule attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogScrubbingRule
        => AsReference("log_scrubbing_rule");

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformValue<string> ResourceGuid
        => AsReference("resource_guid");

    /// <summary>
    /// The response_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double> ResponseTimeoutSeconds
        => AsReference("response_timeout_seconds");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorProfileDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorProfileDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
