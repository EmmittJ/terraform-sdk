using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for inbound_ip_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceInboundIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformProperty<string>? Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformProperty<string> IpMask
    {
        get => GetProperty<TerraformProperty<string>>("ip_mask");
        set => WithProperty("ip_mask", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridNamespaceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for topic_spaces_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermEventgridNamespaceTopicSpacesConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The alternative_authentication_name_source attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AlternativeAuthenticationNameSource
    {
        get => GetProperty<List<TerraformProperty<string>>>("alternative_authentication_name_source");
        set => WithProperty("alternative_authentication_name_source", value);
    }

    /// <summary>
    /// The maximum_client_sessions_per_authentication_name attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumClientSessionsPerAuthenticationName
    {
        get => GetProperty<TerraformProperty<double>>("maximum_client_sessions_per_authentication_name");
        set => WithProperty("maximum_client_sessions_per_authentication_name", value);
    }

    /// <summary>
    /// The maximum_session_expiry_in_hours attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumSessionExpiryInHours
    {
        get => GetProperty<TerraformProperty<double>>("maximum_session_expiry_in_hours");
        set => WithProperty("maximum_session_expiry_in_hours", value);
    }

    /// <summary>
    /// The route_topic_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteTopicId
    {
        get => GetProperty<TerraformProperty<string>>("route_topic_id");
        set => WithProperty("route_topic_id", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
    {
        get => GetProperty<TerraformProperty<double>>("capacity");
        set => this.WithProperty("capacity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformProperty<string>? PublicNetworkAccess
    {
        get => GetProperty<TerraformProperty<string>>("public_network_access");
        set => this.WithProperty("public_network_access", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermEventgridNamespaceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermEventgridNamespaceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for inbound_ip_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(128, ErrorMessage = "Maximum 128 InboundIpRule block(s) allowed")]
    public List<AzurermEventgridNamespaceInboundIpRuleBlock>? InboundIpRule
    {
        get => GetProperty<List<AzurermEventgridNamespaceInboundIpRuleBlock>>("inbound_ip_rule");
        set => this.WithProperty("inbound_ip_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventgridNamespaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermEventgridNamespaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for topic_spaces_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermEventgridNamespaceTopicSpacesConfigurationBlock>? TopicSpacesConfiguration
    {
        get => GetProperty<List<AzurermEventgridNamespaceTopicSpacesConfigurationBlock>>("topic_spaces_configuration");
        set => this.WithProperty("topic_spaces_configuration", value);
    }

}
