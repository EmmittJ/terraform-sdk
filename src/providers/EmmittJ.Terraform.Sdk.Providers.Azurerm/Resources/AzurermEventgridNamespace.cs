using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermEventgridNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for inbound_ip_rule in AzurermEventgridNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceInboundIpRuleBlock : TerraformBlock
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
/// Block type for timeouts in AzurermEventgridNamespace.
/// Nesting mode: single
/// </summary>
public class AzurermEventgridNamespaceTimeoutsBlock : TerraformBlock
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
/// Block type for topic_spaces_configuration in AzurermEventgridNamespace.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceTopicSpacesConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topic_spaces_configuration";

    /// <summary>
    /// The alternative_authentication_name_source attribute.
    /// </summary>
    public TerraformList<string>? AlternativeAuthenticationNameSource
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "alternative_authentication_name_source").ResolveNodes(ctx));
        set => SetArgument("alternative_authentication_name_source", value);
    }

    /// <summary>
    /// The maximum_client_sessions_per_authentication_name attribute.
    /// </summary>
    public TerraformValue<double>? MaximumClientSessionsPerAuthenticationName
    {
        get => new TerraformReference<double>(this, "maximum_client_sessions_per_authentication_name");
        set => SetArgument("maximum_client_sessions_per_authentication_name", value);
    }

    /// <summary>
    /// The maximum_session_expiry_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? MaximumSessionExpiryInHours
    {
        get => new TerraformReference<double>(this, "maximum_session_expiry_in_hours");
        set => SetArgument("maximum_session_expiry_in_hours", value);
    }

    /// <summary>
    /// The route_topic_id attribute.
    /// </summary>
    public TerraformValue<string>? RouteTopicId
    {
        get => new TerraformReference<string>(this, "route_topic_id");
        set => SetArgument("route_topic_id", value);
    }

    /// <summary>
    /// DynamicRoutingEnrichment block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlockDynamicRoutingEnrichmentBlock>? DynamicRoutingEnrichment
    {
        get => GetArgument<TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlockDynamicRoutingEnrichmentBlock>>("dynamic_routing_enrichment");
        set => SetArgument("dynamic_routing_enrichment", value);
    }

    /// <summary>
    /// StaticRoutingEnrichment block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlockStaticRoutingEnrichmentBlock>? StaticRoutingEnrichment
    {
        get => GetArgument<TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlockStaticRoutingEnrichmentBlock>>("static_routing_enrichment");
        set => SetArgument("static_routing_enrichment", value);
    }

}

/// <summary>
/// Block type for dynamic_routing_enrichment in AzurermEventgridNamespaceTopicSpacesConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceTopicSpacesConfigurationBlockDynamicRoutingEnrichmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamic_routing_enrichment";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for static_routing_enrichment in AzurermEventgridNamespaceTopicSpacesConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceTopicSpacesConfigurationBlockStaticRoutingEnrichmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_routing_enrichment";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a azurerm_eventgrid_namespace Terraform resource.
/// Manages a azurerm_eventgrid_namespace resource.
/// </summary>
public partial class AzurermEventgridNamespace(string name) : TerraformResource("azurerm_eventgrid_namespace", name)
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
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
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermEventgridNamespaceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermEventgridNamespaceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// InboundIpRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(128, ErrorMessage = "Maximum 128 InboundIpRule block(s) allowed")]
    public TerraformList<AzurermEventgridNamespaceInboundIpRuleBlock>? InboundIpRule
    {
        get => GetArgument<TerraformList<AzurermEventgridNamespaceInboundIpRuleBlock>>("inbound_ip_rule");
        set => SetArgument("inbound_ip_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridNamespaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridNamespaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TopicSpacesConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlock>? TopicSpacesConfiguration
    {
        get => GetArgument<TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlock>>("topic_spaces_configuration");
        set => SetArgument("topic_spaces_configuration", value);
    }

}
