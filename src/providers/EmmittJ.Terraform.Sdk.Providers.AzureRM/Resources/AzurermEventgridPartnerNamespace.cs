using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for inbound_ip_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridPartnerNamespaceInboundIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inbound_ip_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformValue<string> IpMask
    {
        get => new TerraformReference<string>(this, "ip_mask");
        set => SetArgument("ip_mask", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridPartnerNamespaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_eventgrid_partner_namespace Terraform resource.
/// Manages a azurerm_eventgrid_partner_namespace resource.
/// </summary>
public partial class AzurermEventgridPartnerNamespace(string name) : TerraformResource("azurerm_eventgrid_partner_namespace", name)
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The partner_registration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerRegistrationId is required")]
    public required TerraformValue<string> PartnerRegistrationId
    {
        get => new TerraformReference<string>(this, "partner_registration_id");
        set => SetArgument("partner_registration_id", value);
    }

    /// <summary>
    /// The partner_topic_routing_mode attribute.
    /// </summary>
    public TerraformValue<string>? PartnerTopicRoutingMode
    {
        get => new TerraformReference<string>(this, "partner_topic_routing_mode");
        set => SetArgument("partner_topic_routing_mode", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// InboundIpRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(16, ErrorMessage = "Maximum 16 InboundIpRule block(s) allowed")]
    public TerraformList<AzurermEventgridPartnerNamespaceInboundIpRuleBlock>? InboundIpRule
    {
        get => GetArgument<TerraformList<AzurermEventgridPartnerNamespaceInboundIpRuleBlock>>("inbound_ip_rule");
        set => SetArgument("inbound_ip_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridPartnerNamespaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridPartnerNamespaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
