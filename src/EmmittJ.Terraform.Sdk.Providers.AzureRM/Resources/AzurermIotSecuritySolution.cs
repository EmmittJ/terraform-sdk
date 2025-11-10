using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for additional_workspace in .
/// Nesting mode: set
/// </summary>
public class AzurermIotSecuritySolutionAdditionalWorkspaceBlock : TerraformBlock
{
    /// <summary>
    /// The data_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTypes is required")]
    public HashSet<TerraformProperty<string>>? DataTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_types");
        set => WithProperty("data_types", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => WithProperty("workspace_id", value);
    }

}

/// <summary>
/// Block type for recommendations_enabled in .
/// Nesting mode: list
/// </summary>
public class AzurermIotSecuritySolutionRecommendationsEnabledBlock : TerraformBlock
{
    /// <summary>
    /// The acr_authentication attribute.
    /// </summary>
    public TerraformProperty<bool>? AcrAuthentication
    {
        get => GetProperty<TerraformProperty<bool>>("acr_authentication");
        set => WithProperty("acr_authentication", value);
    }

    /// <summary>
    /// The agent_send_unutilized_msg attribute.
    /// </summary>
    public TerraformProperty<bool>? AgentSendUnutilizedMsg
    {
        get => GetProperty<TerraformProperty<bool>>("agent_send_unutilized_msg");
        set => WithProperty("agent_send_unutilized_msg", value);
    }

    /// <summary>
    /// The baseline attribute.
    /// </summary>
    public TerraformProperty<bool>? Baseline
    {
        get => GetProperty<TerraformProperty<bool>>("baseline");
        set => WithProperty("baseline", value);
    }

    /// <summary>
    /// The edge_hub_mem_optimize attribute.
    /// </summary>
    public TerraformProperty<bool>? EdgeHubMemOptimize
    {
        get => GetProperty<TerraformProperty<bool>>("edge_hub_mem_optimize");
        set => WithProperty("edge_hub_mem_optimize", value);
    }

    /// <summary>
    /// The edge_logging_option attribute.
    /// </summary>
    public TerraformProperty<bool>? EdgeLoggingOption
    {
        get => GetProperty<TerraformProperty<bool>>("edge_logging_option");
        set => WithProperty("edge_logging_option", value);
    }

    /// <summary>
    /// The inconsistent_module_settings attribute.
    /// </summary>
    public TerraformProperty<bool>? InconsistentModuleSettings
    {
        get => GetProperty<TerraformProperty<bool>>("inconsistent_module_settings");
        set => WithProperty("inconsistent_module_settings", value);
    }

    /// <summary>
    /// The install_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? InstallAgent
    {
        get => GetProperty<TerraformProperty<bool>>("install_agent");
        set => WithProperty("install_agent", value);
    }

    /// <summary>
    /// The ip_filter_deny_all attribute.
    /// </summary>
    public TerraformProperty<bool>? IpFilterDenyAll
    {
        get => GetProperty<TerraformProperty<bool>>("ip_filter_deny_all");
        set => WithProperty("ip_filter_deny_all", value);
    }

    /// <summary>
    /// The ip_filter_permissive_rule attribute.
    /// </summary>
    public TerraformProperty<bool>? IpFilterPermissiveRule
    {
        get => GetProperty<TerraformProperty<bool>>("ip_filter_permissive_rule");
        set => WithProperty("ip_filter_permissive_rule", value);
    }

    /// <summary>
    /// The open_ports attribute.
    /// </summary>
    public TerraformProperty<bool>? OpenPorts
    {
        get => GetProperty<TerraformProperty<bool>>("open_ports");
        set => WithProperty("open_ports", value);
    }

    /// <summary>
    /// The permissive_firewall_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? PermissiveFirewallPolicy
    {
        get => GetProperty<TerraformProperty<bool>>("permissive_firewall_policy");
        set => WithProperty("permissive_firewall_policy", value);
    }

    /// <summary>
    /// The permissive_input_firewall_rules attribute.
    /// </summary>
    public TerraformProperty<bool>? PermissiveInputFirewallRules
    {
        get => GetProperty<TerraformProperty<bool>>("permissive_input_firewall_rules");
        set => WithProperty("permissive_input_firewall_rules", value);
    }

    /// <summary>
    /// The permissive_output_firewall_rules attribute.
    /// </summary>
    public TerraformProperty<bool>? PermissiveOutputFirewallRules
    {
        get => GetProperty<TerraformProperty<bool>>("permissive_output_firewall_rules");
        set => WithProperty("permissive_output_firewall_rules", value);
    }

    /// <summary>
    /// The privileged_docker_options attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivilegedDockerOptions
    {
        get => GetProperty<TerraformProperty<bool>>("privileged_docker_options");
        set => WithProperty("privileged_docker_options", value);
    }

    /// <summary>
    /// The shared_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? SharedCredentials
    {
        get => GetProperty<TerraformProperty<bool>>("shared_credentials");
        set => WithProperty("shared_credentials", value);
    }

    /// <summary>
    /// The vulnerable_tls_cipher_suite attribute.
    /// </summary>
    public TerraformProperty<bool>? VulnerableTlsCipherSuite
    {
        get => GetProperty<TerraformProperty<bool>>("vulnerable_tls_cipher_suite");
        set => WithProperty("vulnerable_tls_cipher_suite", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIotSecuritySolutionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iot_security_solution resource.
/// </summary>
public class AzurermIotSecuritySolution : TerraformResource
{
    public AzurermIotSecuritySolution(string name) : base("azurerm_iot_security_solution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disabled_data_sources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DisabledDataSources
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("disabled_data_sources");
        set => this.WithProperty("disabled_data_sources", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The events_to_export attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EventsToExport
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("events_to_export");
        set => this.WithProperty("events_to_export", value);
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
    /// The iothub_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubIds is required")]
    public HashSet<TerraformProperty<string>>? IothubIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("iothub_ids");
        set => this.WithProperty("iothub_ids", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LogUnmaskedIpsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("log_unmasked_ips_enabled");
        set => this.WithProperty("log_unmasked_ips_enabled", value);
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
    /// The query_for_resources attribute.
    /// </summary>
    public TerraformProperty<string>? QueryForResources
    {
        get => GetProperty<TerraformProperty<string>>("query_for_resources");
        set => this.WithProperty("query_for_resources", value);
    }

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? QuerySubscriptionIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("query_subscription_ids");
        set => this.WithProperty("query_subscription_ids", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for additional_workspace.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermIotSecuritySolutionAdditionalWorkspaceBlock>? AdditionalWorkspace
    {
        get => GetProperty<HashSet<AzurermIotSecuritySolutionAdditionalWorkspaceBlock>>("additional_workspace");
        set => this.WithProperty("additional_workspace", value);
    }

    /// <summary>
    /// Block for recommendations_enabled.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecommendationsEnabled block(s) allowed")]
    public List<AzurermIotSecuritySolutionRecommendationsEnabledBlock>? RecommendationsEnabled
    {
        get => GetProperty<List<AzurermIotSecuritySolutionRecommendationsEnabledBlock>>("recommendations_enabled");
        set => this.WithProperty("recommendations_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIotSecuritySolutionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermIotSecuritySolutionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
