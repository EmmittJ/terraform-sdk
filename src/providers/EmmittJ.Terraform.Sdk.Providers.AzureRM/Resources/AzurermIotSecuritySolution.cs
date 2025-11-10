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
        set => SetProperty("data_types", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        set => SetProperty("workspace_id", value);
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
        set => SetProperty("acr_authentication", value);
    }

    /// <summary>
    /// The agent_send_unutilized_msg attribute.
    /// </summary>
    public TerraformProperty<bool>? AgentSendUnutilizedMsg
    {
        set => SetProperty("agent_send_unutilized_msg", value);
    }

    /// <summary>
    /// The baseline attribute.
    /// </summary>
    public TerraformProperty<bool>? Baseline
    {
        set => SetProperty("baseline", value);
    }

    /// <summary>
    /// The edge_hub_mem_optimize attribute.
    /// </summary>
    public TerraformProperty<bool>? EdgeHubMemOptimize
    {
        set => SetProperty("edge_hub_mem_optimize", value);
    }

    /// <summary>
    /// The edge_logging_option attribute.
    /// </summary>
    public TerraformProperty<bool>? EdgeLoggingOption
    {
        set => SetProperty("edge_logging_option", value);
    }

    /// <summary>
    /// The inconsistent_module_settings attribute.
    /// </summary>
    public TerraformProperty<bool>? InconsistentModuleSettings
    {
        set => SetProperty("inconsistent_module_settings", value);
    }

    /// <summary>
    /// The install_agent attribute.
    /// </summary>
    public TerraformProperty<bool>? InstallAgent
    {
        set => SetProperty("install_agent", value);
    }

    /// <summary>
    /// The ip_filter_deny_all attribute.
    /// </summary>
    public TerraformProperty<bool>? IpFilterDenyAll
    {
        set => SetProperty("ip_filter_deny_all", value);
    }

    /// <summary>
    /// The ip_filter_permissive_rule attribute.
    /// </summary>
    public TerraformProperty<bool>? IpFilterPermissiveRule
    {
        set => SetProperty("ip_filter_permissive_rule", value);
    }

    /// <summary>
    /// The open_ports attribute.
    /// </summary>
    public TerraformProperty<bool>? OpenPorts
    {
        set => SetProperty("open_ports", value);
    }

    /// <summary>
    /// The permissive_firewall_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? PermissiveFirewallPolicy
    {
        set => SetProperty("permissive_firewall_policy", value);
    }

    /// <summary>
    /// The permissive_input_firewall_rules attribute.
    /// </summary>
    public TerraformProperty<bool>? PermissiveInputFirewallRules
    {
        set => SetProperty("permissive_input_firewall_rules", value);
    }

    /// <summary>
    /// The permissive_output_firewall_rules attribute.
    /// </summary>
    public TerraformProperty<bool>? PermissiveOutputFirewallRules
    {
        set => SetProperty("permissive_output_firewall_rules", value);
    }

    /// <summary>
    /// The privileged_docker_options attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivilegedDockerOptions
    {
        set => SetProperty("privileged_docker_options", value);
    }

    /// <summary>
    /// The shared_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? SharedCredentials
    {
        set => SetProperty("shared_credentials", value);
    }

    /// <summary>
    /// The vulnerable_tls_cipher_suite attribute.
    /// </summary>
    public TerraformProperty<bool>? VulnerableTlsCipherSuite
    {
        set => SetProperty("vulnerable_tls_cipher_suite", value);
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
/// Manages a azurerm_iot_security_solution resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIotSecuritySolution : TerraformResource
{
    public AzurermIotSecuritySolution(string name) : base("azurerm_iot_security_solution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disabled_data_sources");
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("events_to_export");
        SetOutput("id");
        SetOutput("iothub_ids");
        SetOutput("location");
        SetOutput("log_analytics_workspace_id");
        SetOutput("log_unmasked_ips_enabled");
        SetOutput("name");
        SetOutput("query_for_resources");
        SetOutput("query_subscription_ids");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The disabled_data_sources attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DisabledDataSources
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("disabled_data_sources");
        set => SetProperty("disabled_data_sources", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The events_to_export attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EventsToExport
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("events_to_export");
        set => SetProperty("events_to_export", value);
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
    /// The iothub_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubIds is required")]
    public HashSet<TerraformProperty<string>> IothubIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("iothub_ids");
        set => SetProperty("iothub_ids", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LogUnmaskedIpsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("log_unmasked_ips_enabled");
        set => SetProperty("log_unmasked_ips_enabled", value);
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
    /// The query_for_resources attribute.
    /// </summary>
    public TerraformProperty<string> QueryForResources
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_for_resources");
        set => SetProperty("query_for_resources", value);
    }

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> QuerySubscriptionIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("query_subscription_ids");
        set => SetProperty("query_subscription_ids", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for additional_workspace.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermIotSecuritySolutionAdditionalWorkspaceBlock>? AdditionalWorkspace
    {
        set => SetProperty("additional_workspace", value);
    }

    /// <summary>
    /// Block for recommendations_enabled.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecommendationsEnabled block(s) allowed")]
    public List<AzurermIotSecuritySolutionRecommendationsEnabledBlock>? RecommendationsEnabled
    {
        set => SetProperty("recommendations_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIotSecuritySolutionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
