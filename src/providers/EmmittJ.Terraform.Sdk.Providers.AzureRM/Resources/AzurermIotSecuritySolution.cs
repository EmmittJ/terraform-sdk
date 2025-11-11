using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_workspace in .
/// Nesting mode: set
/// </summary>
public class AzurermIotSecuritySolutionAdditionalWorkspaceBlock
{
    /// <summary>
    /// The data_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTypes is required")]
    [TerraformPropertyName("data_types")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> DataTypes { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformPropertyName("workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkspaceId { get; set; }

}

/// <summary>
/// Block type for recommendations_enabled in .
/// Nesting mode: list
/// </summary>
public class AzurermIotSecuritySolutionRecommendationsEnabledBlock
{
    /// <summary>
    /// The acr_authentication attribute.
    /// </summary>
    [TerraformPropertyName("acr_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AcrAuthentication { get; set; }

    /// <summary>
    /// The agent_send_unutilized_msg attribute.
    /// </summary>
    [TerraformPropertyName("agent_send_unutilized_msg")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AgentSendUnutilizedMsg { get; set; }

    /// <summary>
    /// The baseline attribute.
    /// </summary>
    [TerraformPropertyName("baseline")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Baseline { get; set; }

    /// <summary>
    /// The edge_hub_mem_optimize attribute.
    /// </summary>
    [TerraformPropertyName("edge_hub_mem_optimize")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EdgeHubMemOptimize { get; set; }

    /// <summary>
    /// The edge_logging_option attribute.
    /// </summary>
    [TerraformPropertyName("edge_logging_option")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EdgeLoggingOption { get; set; }

    /// <summary>
    /// The inconsistent_module_settings attribute.
    /// </summary>
    [TerraformPropertyName("inconsistent_module_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InconsistentModuleSettings { get; set; }

    /// <summary>
    /// The install_agent attribute.
    /// </summary>
    [TerraformPropertyName("install_agent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InstallAgent { get; set; }

    /// <summary>
    /// The ip_filter_deny_all attribute.
    /// </summary>
    [TerraformPropertyName("ip_filter_deny_all")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IpFilterDenyAll { get; set; }

    /// <summary>
    /// The ip_filter_permissive_rule attribute.
    /// </summary>
    [TerraformPropertyName("ip_filter_permissive_rule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IpFilterPermissiveRule { get; set; }

    /// <summary>
    /// The open_ports attribute.
    /// </summary>
    [TerraformPropertyName("open_ports")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OpenPorts { get; set; }

    /// <summary>
    /// The permissive_firewall_policy attribute.
    /// </summary>
    [TerraformPropertyName("permissive_firewall_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PermissiveFirewallPolicy { get; set; }

    /// <summary>
    /// The permissive_input_firewall_rules attribute.
    /// </summary>
    [TerraformPropertyName("permissive_input_firewall_rules")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PermissiveInputFirewallRules { get; set; }

    /// <summary>
    /// The permissive_output_firewall_rules attribute.
    /// </summary>
    [TerraformPropertyName("permissive_output_firewall_rules")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PermissiveOutputFirewallRules { get; set; }

    /// <summary>
    /// The privileged_docker_options attribute.
    /// </summary>
    [TerraformPropertyName("privileged_docker_options")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivilegedDockerOptions { get; set; }

    /// <summary>
    /// The shared_credentials attribute.
    /// </summary>
    [TerraformPropertyName("shared_credentials")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SharedCredentials { get; set; }

    /// <summary>
    /// The vulnerable_tls_cipher_suite attribute.
    /// </summary>
    [TerraformPropertyName("vulnerable_tls_cipher_suite")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VulnerableTlsCipherSuite { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotSecuritySolutionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_iot_security_solution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIotSecuritySolution : TerraformResource
{
    public AzurermIotSecuritySolution(string name) : base("azurerm_iot_security_solution", name)
    {
    }

    /// <summary>
    /// The disabled_data_sources attribute.
    /// </summary>
    [TerraformPropertyName("disabled_data_sources")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DisabledDataSources { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The events_to_export attribute.
    /// </summary>
    [TerraformPropertyName("events_to_export")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EventsToExport { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The iothub_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubIds is required")]
    [TerraformPropertyName("iothub_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> IothubIds { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    [TerraformPropertyName("log_unmasked_ips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LogUnmaskedIpsEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_for_resources attribute.
    /// </summary>
    [TerraformPropertyName("query_for_resources")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> QueryForResources { get; set; } = default!;

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    [TerraformPropertyName("query_subscription_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> QuerySubscriptionIds { get; set; } = default!;

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for additional_workspace.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("additional_workspace")]
    public TerraformSet<TerraformBlock<AzurermIotSecuritySolutionAdditionalWorkspaceBlock>>? AdditionalWorkspace { get; set; }

    /// <summary>
    /// Block for recommendations_enabled.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecommendationsEnabled block(s) allowed")]
    [TerraformPropertyName("recommendations_enabled")]
    public TerraformList<TerraformBlock<AzurermIotSecuritySolutionRecommendationsEnabledBlock>>? RecommendationsEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermIotSecuritySolutionTimeoutsBlock>? Timeouts { get; set; }

}
