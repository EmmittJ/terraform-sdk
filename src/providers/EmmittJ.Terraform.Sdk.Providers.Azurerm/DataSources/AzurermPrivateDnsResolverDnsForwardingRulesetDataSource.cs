using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsResolverDnsForwardingRulesetDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsResolverDnsForwardingRulesetDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_private_dns_resolver_dns_forwarding_ruleset Terraform data source.
/// Retrieves information about a azurerm_private_dns_resolver_dns_forwarding_ruleset.
/// </summary>
public partial class AzurermPrivateDnsResolverDnsForwardingRulesetDataSource(string name) : TerraformDataSource("azurerm_private_dns_resolver_dns_forwarding_ruleset", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The private_dns_resolver_outbound_endpoint_ids attribute.
    /// </summary>
    public TerraformList<string> PrivateDnsResolverOutboundEndpointIds
        => AsReference("private_dns_resolver_outbound_endpoint_ids");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsResolverDnsForwardingRulesetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsResolverDnsForwardingRulesetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
