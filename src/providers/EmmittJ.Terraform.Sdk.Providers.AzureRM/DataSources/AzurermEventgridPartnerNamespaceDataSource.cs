using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventgrid_partner_namespace Terraform data source.
/// Retrieves information about a azurerm_eventgrid_partner_namespace.
/// </summary>
public partial class AzurermEventgridPartnerNamespaceDataSource(string name) : TerraformDataSource("azurerm_eventgrid_partner_namespace", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InboundIpRule
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "inbound_ip_rule").ResolveNodes(ctx));
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The partner_registration_id attribute.
    /// </summary>
    public TerraformValue<string> PartnerRegistrationId
    {
        get => new TerraformReference<string>(this, "partner_registration_id");
    }

    /// <summary>
    /// The partner_topic_routing_mode attribute.
    /// </summary>
    public TerraformValue<string> PartnerTopicRoutingMode
    {
        get => new TerraformReference<string>(this, "partner_topic_routing_mode");
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string> PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
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
    public AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridPartnerNamespaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
