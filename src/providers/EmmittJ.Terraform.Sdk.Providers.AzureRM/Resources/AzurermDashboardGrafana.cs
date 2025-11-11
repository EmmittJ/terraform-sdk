using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_monitor_workspace_integrations in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformProperty("resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDashboardGrafanaIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for smtp in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDashboardGrafanaSmtpBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    [TerraformProperty("from_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FromAddress { get; set; }

    /// <summary>
    /// The from_name attribute.
    /// </summary>
    [TerraformProperty("from_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FromName { get; set; }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformProperty("host")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Host { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The start_tls_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTlsPolicy is required")]
    [TerraformProperty("start_tls_policy")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StartTlsPolicy { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformProperty("user")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> User { get; set; }

    /// <summary>
    /// The verification_skip_enabled attribute.
    /// </summary>
    [TerraformProperty("verification_skip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VerificationSkipEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDashboardGrafanaTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dashboard_grafana resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDashboardGrafana : TerraformResource
{
    public AzurermDashboardGrafana(string name) : base("azurerm_dashboard_grafana", name)
    {
    }

    /// <summary>
    /// The api_key_enabled attribute.
    /// </summary>
    [TerraformProperty("api_key_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApiKeyEnabled { get; set; }

    /// <summary>
    /// The auto_generated_domain_name_label_scope attribute.
    /// </summary>
    [TerraformProperty("auto_generated_domain_name_label_scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoGeneratedDomainNameLabelScope { get; set; }

    /// <summary>
    /// The deterministic_outbound_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("deterministic_outbound_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeterministicOutboundIpEnabled { get; set; }

    /// <summary>
    /// The grafana_major_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrafanaMajorVersion is required")]
    [TerraformProperty("grafana_major_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GrafanaMajorVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zone_redundancy_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_redundancy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneRedundancyEnabled { get; set; }

    /// <summary>
    /// Block for azure_monitor_workspace_integrations.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("azure_monitor_workspace_integrations")]
    public partial TerraformList<TerraformBlock<AzurermDashboardGrafanaAzureMonitorWorkspaceIntegrationsBlock>>? AzureMonitorWorkspaceIntegrations { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermDashboardGrafanaIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for smtp.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Smtp block(s) allowed")]
    [TerraformProperty("smtp")]
    public partial TerraformList<TerraformBlock<AzurermDashboardGrafanaSmtpBlock>>? Smtp { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDashboardGrafanaTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The grafana_version attribute.
    /// </summary>
    [TerraformProperty("grafana_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GrafanaVersion { get; }

    /// <summary>
    /// The outbound_ip attribute.
    /// </summary>
    [TerraformProperty("outbound_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundIp { get; }

}
