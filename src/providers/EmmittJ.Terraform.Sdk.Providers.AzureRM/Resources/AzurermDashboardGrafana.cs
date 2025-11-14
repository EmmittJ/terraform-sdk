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
/// Block type for azure_monitor_workspace_integrations in .
/// Nesting mode: list
/// </summary>
public class AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_monitor_workspace_integrations";

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformArgument("resource_id")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermDashboardGrafanaIdentityBlock : TerraformBlock
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
/// Block type for smtp in .
/// Nesting mode: list
/// </summary>
public class AzurermDashboardGrafanaSmtpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "smtp";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    [TerraformArgument("from_address")]
    public required TerraformValue<string> FromAddress
    {
        get => new TerraformReference<string>(this, "from_address");
        set => SetArgument("from_address", value);
    }

    /// <summary>
    /// The from_name attribute.
    /// </summary>
    [TerraformArgument("from_name")]
    public TerraformValue<string>? FromName
    {
        get => new TerraformReference<string>(this, "from_name");
        set => SetArgument("from_name", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformArgument("host")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformArgument("password")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The start_tls_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTlsPolicy is required")]
    [TerraformArgument("start_tls_policy")]
    public required TerraformValue<string> StartTlsPolicy
    {
        get => new TerraformReference<string>(this, "start_tls_policy");
        set => SetArgument("start_tls_policy", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformArgument("user")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The verification_skip_enabled attribute.
    /// </summary>
    [TerraformArgument("verification_skip_enabled")]
    public TerraformValue<bool>? VerificationSkipEnabled
    {
        get => new TerraformReference<bool>(this, "verification_skip_enabled");
        set => SetArgument("verification_skip_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDashboardGrafanaTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_dashboard_grafana resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDashboardGrafana : TerraformResource
{
    public AzurermDashboardGrafana(string name) : base("azurerm_dashboard_grafana", name)
    {
    }

    /// <summary>
    /// The api_key_enabled attribute.
    /// </summary>
    [TerraformArgument("api_key_enabled")]
    public TerraformValue<bool>? ApiKeyEnabled
    {
        get => new TerraformReference<bool>(this, "api_key_enabled");
        set => SetArgument("api_key_enabled", value);
    }

    /// <summary>
    /// The auto_generated_domain_name_label_scope attribute.
    /// </summary>
    [TerraformArgument("auto_generated_domain_name_label_scope")]
    public TerraformValue<string>? AutoGeneratedDomainNameLabelScope
    {
        get => new TerraformReference<string>(this, "auto_generated_domain_name_label_scope");
        set => SetArgument("auto_generated_domain_name_label_scope", value);
    }

    /// <summary>
    /// The deterministic_outbound_ip_enabled attribute.
    /// </summary>
    [TerraformArgument("deterministic_outbound_ip_enabled")]
    public TerraformValue<bool>? DeterministicOutboundIpEnabled
    {
        get => new TerraformReference<bool>(this, "deterministic_outbound_ip_enabled");
        set => SetArgument("deterministic_outbound_ip_enabled", value);
    }

    /// <summary>
    /// The grafana_major_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaMajorVersion is required")]
    [TerraformArgument("grafana_major_version")]
    public required TerraformValue<string> GrafanaMajorVersion
    {
        get => new TerraformReference<string>(this, "grafana_major_version");
        set => SetArgument("grafana_major_version", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformArgument("zone_redundancy_enabled")]
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for azure_monitor_workspace_integrations.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("azure_monitor_workspace_integrations")]
    public TerraformList<AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock> AzureMonitorWorkspaceIntegrations { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermDashboardGrafanaIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for smtp.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Smtp block(s) allowed")]
    [TerraformArgument("smtp")]
    public TerraformList<AzurermDashboardGrafanaSmtpBlock> Smtp { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDashboardGrafanaTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    [TerraformArgument("grafana_version")]
    public TerraformValue<string> GrafanaVersion
    {
        get => new TerraformReference<string>(this, "grafana_version");
    }

    /// <summary>
    /// The outbound_ip attribute.
    /// </summary>
    [TerraformArgument("outbound_ip")]
    public TerraformList<string> OutboundIp
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "outbound_ip").ResolveNodes(ctx));
    }

}
