using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_workspace in .
/// Nesting mode: set
/// </summary>
public partial class AzurermIotSecuritySolutionAdditionalWorkspaceBlock() : TerraformBlock("additional_workspace")
{
    /// <summary>
    /// The data_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTypes is required")]
    [TerraformProperty("data_types")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> DataTypes { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceId { get; set; }

}

/// <summary>
/// Block type for recommendations_enabled in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIotSecuritySolutionRecommendationsEnabledBlock() : TerraformBlock("recommendations_enabled")
{
    /// <summary>
    /// The acr_authentication attribute.
    /// </summary>
    [TerraformProperty("acr_authentication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AcrAuthentication { get; set; }

    /// <summary>
    /// The agent_send_unutilized_msg attribute.
    /// </summary>
    [TerraformProperty("agent_send_unutilized_msg")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AgentSendUnutilizedMsg { get; set; }

    /// <summary>
    /// The baseline attribute.
    /// </summary>
    [TerraformProperty("baseline")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Baseline { get; set; }

    /// <summary>
    /// The edge_hub_mem_optimize attribute.
    /// </summary>
    [TerraformProperty("edge_hub_mem_optimize")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EdgeHubMemOptimize { get; set; }

    /// <summary>
    /// The edge_logging_option attribute.
    /// </summary>
    [TerraformProperty("edge_logging_option")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EdgeLoggingOption { get; set; }

    /// <summary>
    /// The inconsistent_module_settings attribute.
    /// </summary>
    [TerraformProperty("inconsistent_module_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InconsistentModuleSettings { get; set; }

    /// <summary>
    /// The install_agent attribute.
    /// </summary>
    [TerraformProperty("install_agent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InstallAgent { get; set; }

    /// <summary>
    /// The ip_filter_deny_all attribute.
    /// </summary>
    [TerraformProperty("ip_filter_deny_all")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IpFilterDenyAll { get; set; }

    /// <summary>
    /// The ip_filter_permissive_rule attribute.
    /// </summary>
    [TerraformProperty("ip_filter_permissive_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IpFilterPermissiveRule { get; set; }

    /// <summary>
    /// The open_ports attribute.
    /// </summary>
    [TerraformProperty("open_ports")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OpenPorts { get; set; }

    /// <summary>
    /// The permissive_firewall_policy attribute.
    /// </summary>
    [TerraformProperty("permissive_firewall_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PermissiveFirewallPolicy { get; set; }

    /// <summary>
    /// The permissive_input_firewall_rules attribute.
    /// </summary>
    [TerraformProperty("permissive_input_firewall_rules")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PermissiveInputFirewallRules { get; set; }

    /// <summary>
    /// The permissive_output_firewall_rules attribute.
    /// </summary>
    [TerraformProperty("permissive_output_firewall_rules")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PermissiveOutputFirewallRules { get; set; }

    /// <summary>
    /// The privileged_docker_options attribute.
    /// </summary>
    [TerraformProperty("privileged_docker_options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivilegedDockerOptions { get; set; }

    /// <summary>
    /// The shared_credentials attribute.
    /// </summary>
    [TerraformProperty("shared_credentials")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SharedCredentials { get; set; }

    /// <summary>
    /// The vulnerable_tls_cipher_suite attribute.
    /// </summary>
    [TerraformProperty("vulnerable_tls_cipher_suite")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VulnerableTlsCipherSuite { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIotSecuritySolutionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_iot_security_solution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermIotSecuritySolution : TerraformResource
{
    public AzurermIotSecuritySolution(string name) : base("azurerm_iot_security_solution", name)
    {
    }

    /// <summary>
    /// The disabled_data_sources attribute.
    /// </summary>
    [TerraformProperty("disabled_data_sources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? DisabledDataSources { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The events_to_export attribute.
    /// </summary>
    [TerraformProperty("events_to_export")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EventsToExport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The iothub_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubIds is required")]
    [TerraformProperty("iothub_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IothubIds { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformProperty("log_analytics_workspace_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    [TerraformProperty("log_unmasked_ips_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LogUnmaskedIpsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_for_resources attribute.
    /// </summary>
    [TerraformProperty("query_for_resources")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> QueryForResources { get; set; }

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    [TerraformProperty("query_subscription_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> QuerySubscriptionIds { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for additional_workspace.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("additional_workspace")]
    public TerraformSet<AzurermIotSecuritySolutionAdditionalWorkspaceBlock> AdditionalWorkspace { get; set; } = new();

    /// <summary>
    /// Block for recommendations_enabled.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecommendationsEnabled block(s) allowed")]
    [TerraformProperty("recommendations_enabled")]
    public TerraformList<AzurermIotSecuritySolutionRecommendationsEnabledBlock> RecommendationsEnabled { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermIotSecuritySolutionTimeoutsBlock Timeouts { get; set; } = new();

}
