using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_monitor_workspace_integrations in .
/// Nesting mode: list
/// </summary>
public class AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock : TerraformBlock
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        set => SetProperty("resource_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermDashboardGrafanaIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for smtp in .
/// Nesting mode: list
/// </summary>
public class AzurermDashboardGrafanaSmtpBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    public required TerraformProperty<string> FromAddress
    {
        set => SetProperty("from_address", value);
    }

    /// <summary>
    /// The from_name attribute.
    /// </summary>
    public TerraformProperty<string>? FromName
    {
        set => SetProperty("from_name", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The start_tls_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTlsPolicy is required")]
    public required TerraformProperty<string> StartTlsPolicy
    {
        set => SetProperty("start_tls_policy", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    public required TerraformProperty<string> User
    {
        set => SetProperty("user", value);
    }

    /// <summary>
    /// The verification_skip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VerificationSkipEnabled
    {
        set => SetProperty("verification_skip_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDashboardGrafanaTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("endpoint");
        SetOutput("grafana_version");
        SetOutput("outbound_ip");
        SetOutput("api_key_enabled");
        SetOutput("auto_generated_domain_name_label_scope");
        SetOutput("deterministic_outbound_ip_enabled");
        SetOutput("grafana_major_version");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("zone_redundancy_enabled");
    }

    /// <summary>
    /// The api_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ApiKeyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("api_key_enabled");
        set => SetProperty("api_key_enabled", value);
    }

    /// <summary>
    /// The auto_generated_domain_name_label_scope attribute.
    /// </summary>
    public TerraformProperty<string> AutoGeneratedDomainNameLabelScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_generated_domain_name_label_scope");
        set => SetProperty("auto_generated_domain_name_label_scope", value);
    }

    /// <summary>
    /// The deterministic_outbound_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DeterministicOutboundIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deterministic_outbound_ip_enabled");
        set => SetProperty("deterministic_outbound_ip_enabled", value);
    }

    /// <summary>
    /// The grafana_major_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaMajorVersion is required")]
    public required TerraformProperty<string> GrafanaMajorVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grafana_major_version");
        set => SetProperty("grafana_major_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundancyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundancy_enabled");
        set => SetProperty("zone_redundancy_enabled", value);
    }

    /// <summary>
    /// Block for azure_monitor_workspace_integrations.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock>? AzureMonitorWorkspaceIntegrations
    {
        set => SetProperty("azure_monitor_workspace_integrations", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermDashboardGrafanaIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for smtp.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Smtp block(s) allowed")]
    public List<AzurermDashboardGrafanaSmtpBlock>? Smtp
    {
        set => SetProperty("smtp", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDashboardGrafanaTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    public TerraformExpression GrafanaVersion => this["grafana_version"];

    /// <summary>
    /// The outbound_ip attribute.
    /// </summary>
    public TerraformExpression OutboundIp => this["outbound_ip"];

}
