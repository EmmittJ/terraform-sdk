using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    public required TerraformValue<string> FromAddress
    {
        get => new TerraformReference<string>(this, "from_address");
        set => SetArgument("from_address", value);
    }

    /// <summary>
    /// The from_name attribute.
    /// </summary>
    public TerraformValue<string>? FromName
    {
        get => new TerraformReference<string>(this, "from_name");
        set => SetArgument("from_name", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => new TerraformReference<string>(this, "host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The start_tls_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTlsPolicy is required")]
    public required TerraformValue<string> StartTlsPolicy
    {
        get => new TerraformReference<string>(this, "start_tls_policy");
        set => SetArgument("start_tls_policy", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformValue<string> User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// The verification_skip_enabled attribute.
    /// </summary>
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
/// Represents a azurerm_dashboard_grafana Terraform resource.
/// Manages a azurerm_dashboard_grafana resource.
/// </summary>
public partial class AzurermDashboardGrafana(string name) : TerraformResource("azurerm_dashboard_grafana", name)
{
    /// <summary>
    /// The api_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ApiKeyEnabled
    {
        get => new TerraformReference<bool>(this, "api_key_enabled");
        set => SetArgument("api_key_enabled", value);
    }

    /// <summary>
    /// The auto_generated_domain_name_label_scope attribute.
    /// </summary>
    public TerraformValue<string>? AutoGeneratedDomainNameLabelScope
    {
        get => new TerraformReference<string>(this, "auto_generated_domain_name_label_scope");
        set => SetArgument("auto_generated_domain_name_label_scope", value);
    }

    /// <summary>
    /// The deterministic_outbound_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DeterministicOutboundIpEnabled
    {
        get => new TerraformReference<bool>(this, "deterministic_outbound_ip_enabled");
        set => SetArgument("deterministic_outbound_ip_enabled", value);
    }

    /// <summary>
    /// The grafana_major_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaMajorVersion is required")]
    public required TerraformValue<string> GrafanaMajorVersion
    {
        get => new TerraformReference<string>(this, "grafana_major_version");
        set => SetArgument("grafana_major_version", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundancyEnabled
    {
        get => new TerraformReference<bool>(this, "zone_redundancy_enabled");
        set => SetArgument("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// AzureMonitorWorkspaceIntegrations block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock>? AzureMonitorWorkspaceIntegrations
    {
        get => GetArgument<TerraformList<AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock>>("azure_monitor_workspace_integrations");
        set => SetArgument("azure_monitor_workspace_integrations", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermDashboardGrafanaIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermDashboardGrafanaIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Smtp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Smtp block(s) allowed")]
    public TerraformList<AzurermDashboardGrafanaSmtpBlock>? Smtp
    {
        get => GetArgument<TerraformList<AzurermDashboardGrafanaSmtpBlock>>("smtp");
        set => SetArgument("smtp", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDashboardGrafanaTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDashboardGrafanaTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
