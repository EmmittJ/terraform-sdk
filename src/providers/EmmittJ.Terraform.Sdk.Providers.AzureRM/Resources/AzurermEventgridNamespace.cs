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
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for inbound_ip_rule in .
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
    [TerraformArgument("action")]
    public TerraformValue<string>? Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    [TerraformArgument("ip_mask")]
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
public class AzurermEventgridNamespaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for topic_spaces_configuration in .
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
    [TerraformArgument("alternative_authentication_name_source")]
    public TerraformList<string>? AlternativeAuthenticationNameSource
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "alternative_authentication_name_source").ResolveNodes(ctx));
        set => SetArgument("alternative_authentication_name_source", value);
    }

    /// <summary>
    /// The maximum_client_sessions_per_authentication_name attribute.
    /// </summary>
    [TerraformArgument("maximum_client_sessions_per_authentication_name")]
    public TerraformValue<double>? MaximumClientSessionsPerAuthenticationName
    {
        get => new TerraformReference<double>(this, "maximum_client_sessions_per_authentication_name");
        set => SetArgument("maximum_client_sessions_per_authentication_name", value);
    }

    /// <summary>
    /// The maximum_session_expiry_in_hours attribute.
    /// </summary>
    [TerraformArgument("maximum_session_expiry_in_hours")]
    public TerraformValue<double>? MaximumSessionExpiryInHours
    {
        get => new TerraformReference<double>(this, "maximum_session_expiry_in_hours");
        set => SetArgument("maximum_session_expiry_in_hours", value);
    }

    /// <summary>
    /// The route_topic_id attribute.
    /// </summary>
    [TerraformArgument("route_topic_id")]
    public TerraformValue<string>? RouteTopicId
    {
        get => new TerraformReference<string>(this, "route_topic_id");
        set => SetArgument("route_topic_id", value);
    }

}

/// <summary>
/// Manages a azurerm_eventgrid_namespace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermEventgridNamespace : TerraformResource
{
    public AzurermEventgridNamespace(string name) : base("azurerm_eventgrid_namespace", name)
    {
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermEventgridNamespaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for inbound_ip_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(128, ErrorMessage = "Maximum 128 InboundIpRule block(s) allowed")]
    [TerraformArgument("inbound_ip_rule")]
    public TerraformList<AzurermEventgridNamespaceInboundIpRuleBlock> InboundIpRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermEventgridNamespaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for topic_spaces_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("topic_spaces_configuration")]
    public TerraformList<AzurermEventgridNamespaceTopicSpacesConfigurationBlock> TopicSpacesConfiguration { get; set; } = new();

}
