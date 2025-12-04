using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for additional_workspace in AzurermIotSecuritySolution.
/// Nesting mode: set
/// </summary>
public class AzurermIotSecuritySolutionAdditionalWorkspaceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_workspace";

    /// <summary>
    /// The data_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTypes is required")]
    public required TerraformSet<string> DataTypes
    {
        get => GetArgument<TerraformSet<string>>("data_types");
        set => SetArgument("data_types", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

}


/// <summary>
/// Block type for recommendations_enabled in AzurermIotSecuritySolution.
/// Nesting mode: list
/// </summary>
public class AzurermIotSecuritySolutionRecommendationsEnabledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recommendations_enabled";

    /// <summary>
    /// The acr_authentication attribute.
    /// </summary>
    public TerraformValue<bool>? AcrAuthentication
    {
        get => GetArgument<TerraformValue<bool>>("acr_authentication");
        set => SetArgument("acr_authentication", value);
    }

    /// <summary>
    /// The agent_send_unutilized_msg attribute.
    /// </summary>
    public TerraformValue<bool>? AgentSendUnutilizedMsg
    {
        get => GetArgument<TerraformValue<bool>>("agent_send_unutilized_msg");
        set => SetArgument("agent_send_unutilized_msg", value);
    }

    /// <summary>
    /// The baseline attribute.
    /// </summary>
    public TerraformValue<bool>? Baseline
    {
        get => GetArgument<TerraformValue<bool>>("baseline");
        set => SetArgument("baseline", value);
    }

    /// <summary>
    /// The edge_hub_mem_optimize attribute.
    /// </summary>
    public TerraformValue<bool>? EdgeHubMemOptimize
    {
        get => GetArgument<TerraformValue<bool>>("edge_hub_mem_optimize");
        set => SetArgument("edge_hub_mem_optimize", value);
    }

    /// <summary>
    /// The edge_logging_option attribute.
    /// </summary>
    public TerraformValue<bool>? EdgeLoggingOption
    {
        get => GetArgument<TerraformValue<bool>>("edge_logging_option");
        set => SetArgument("edge_logging_option", value);
    }

    /// <summary>
    /// The inconsistent_module_settings attribute.
    /// </summary>
    public TerraformValue<bool>? InconsistentModuleSettings
    {
        get => GetArgument<TerraformValue<bool>>("inconsistent_module_settings");
        set => SetArgument("inconsistent_module_settings", value);
    }

    /// <summary>
    /// The install_agent attribute.
    /// </summary>
    public TerraformValue<bool>? InstallAgent
    {
        get => GetArgument<TerraformValue<bool>>("install_agent");
        set => SetArgument("install_agent", value);
    }

    /// <summary>
    /// The ip_filter_deny_all attribute.
    /// </summary>
    public TerraformValue<bool>? IpFilterDenyAll
    {
        get => GetArgument<TerraformValue<bool>>("ip_filter_deny_all");
        set => SetArgument("ip_filter_deny_all", value);
    }

    /// <summary>
    /// The ip_filter_permissive_rule attribute.
    /// </summary>
    public TerraformValue<bool>? IpFilterPermissiveRule
    {
        get => GetArgument<TerraformValue<bool>>("ip_filter_permissive_rule");
        set => SetArgument("ip_filter_permissive_rule", value);
    }

    /// <summary>
    /// The open_ports attribute.
    /// </summary>
    public TerraformValue<bool>? OpenPorts
    {
        get => GetArgument<TerraformValue<bool>>("open_ports");
        set => SetArgument("open_ports", value);
    }

    /// <summary>
    /// The permissive_firewall_policy attribute.
    /// </summary>
    public TerraformValue<bool>? PermissiveFirewallPolicy
    {
        get => GetArgument<TerraformValue<bool>>("permissive_firewall_policy");
        set => SetArgument("permissive_firewall_policy", value);
    }

    /// <summary>
    /// The permissive_input_firewall_rules attribute.
    /// </summary>
    public TerraformValue<bool>? PermissiveInputFirewallRules
    {
        get => GetArgument<TerraformValue<bool>>("permissive_input_firewall_rules");
        set => SetArgument("permissive_input_firewall_rules", value);
    }

    /// <summary>
    /// The permissive_output_firewall_rules attribute.
    /// </summary>
    public TerraformValue<bool>? PermissiveOutputFirewallRules
    {
        get => GetArgument<TerraformValue<bool>>("permissive_output_firewall_rules");
        set => SetArgument("permissive_output_firewall_rules", value);
    }

    /// <summary>
    /// The privileged_docker_options attribute.
    /// </summary>
    public TerraformValue<bool>? PrivilegedDockerOptions
    {
        get => GetArgument<TerraformValue<bool>>("privileged_docker_options");
        set => SetArgument("privileged_docker_options", value);
    }

    /// <summary>
    /// The shared_credentials attribute.
    /// </summary>
    public TerraformValue<bool>? SharedCredentials
    {
        get => GetArgument<TerraformValue<bool>>("shared_credentials");
        set => SetArgument("shared_credentials", value);
    }

    /// <summary>
    /// The vulnerable_tls_cipher_suite attribute.
    /// </summary>
    public TerraformValue<bool>? VulnerableTlsCipherSuite
    {
        get => GetArgument<TerraformValue<bool>>("vulnerable_tls_cipher_suite");
        set => SetArgument("vulnerable_tls_cipher_suite", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermIotSecuritySolution.
/// Nesting mode: single
/// </summary>
public class AzurermIotSecuritySolutionTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_iot_security_solution Terraform resource.
/// Manages a azurerm_iot_security_solution resource.
/// </summary>
public partial class AzurermIotSecuritySolution(string name) : TerraformResource("azurerm_iot_security_solution", name)
{
    /// <summary>
    /// The disabled_data_sources attribute.
    /// </summary>
    public TerraformSet<string>? DisabledDataSources
    {
        get => GetArgument<TerraformSet<string>>("disabled_data_sources");
        set => SetArgument("disabled_data_sources", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The events_to_export attribute.
    /// </summary>
    public TerraformSet<string>? EventsToExport
    {
        get => GetArgument<TerraformSet<string>>("events_to_export");
        set => SetArgument("events_to_export", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubIds is required")]
    public required TerraformSet<string> IothubIds
    {
        get => GetArgument<TerraformSet<string>>("iothub_ids");
        set => SetArgument("iothub_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The log_unmasked_ips_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LogUnmaskedIpsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("log_unmasked_ips_enabled");
        set => SetArgument("log_unmasked_ips_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_for_resources attribute.
    /// </summary>
    public TerraformValue<string>? QueryForResources
    {
        get => GetArgument<TerraformValue<string>>("query_for_resources");
        set => SetArgument("query_for_resources", value);
    }

    /// <summary>
    /// The query_subscription_ids attribute.
    /// </summary>
    public TerraformSet<string>? QuerySubscriptionIds
    {
        get => GetArgument<TerraformSet<string>>("query_subscription_ids");
        set => SetArgument("query_subscription_ids", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AdditionalWorkspace block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermIotSecuritySolutionAdditionalWorkspaceBlock>? AdditionalWorkspace
    {
        get => GetArgument<TerraformSet<AzurermIotSecuritySolutionAdditionalWorkspaceBlock>>("additional_workspace");
        set => SetArgument("additional_workspace", value);
    }

    /// <summary>
    /// RecommendationsEnabled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecommendationsEnabled block(s) allowed")]
    public TerraformList<AzurermIotSecuritySolutionRecommendationsEnabledBlock>? RecommendationsEnabled
    {
        get => GetArgument<TerraformList<AzurermIotSecuritySolutionRecommendationsEnabledBlock>>("recommendations_enabled");
        set => SetArgument("recommendations_enabled", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIotSecuritySolutionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIotSecuritySolutionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
