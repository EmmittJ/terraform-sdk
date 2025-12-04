using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_traffic in AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_traffic";

    /// <summary>
    /// The destination_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIps is required")]
    public TerraformList<string>? DestinationIps
    {
        get => GetArgument<TerraformList<string>>("destination_ips");
        set => SetArgument("destination_ips", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    public TerraformList<string>? DestinationPorts
    {
        get => GetArgument<TerraformList<string>>("destination_ports");
        set => SetArgument("destination_ports", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public TerraformList<string>? Protocols
    {
        get => GetArgument<TerraformList<string>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The source_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIps is required")]
    public TerraformList<string>? SourceIps
    {
        get => GetArgument<TerraformList<string>>("source_ips");
        set => SetArgument("source_ips", value);
    }

    /// <summary>
    /// The source_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    public TerraformList<string>? SourcePorts
    {
        get => GetArgument<TerraformList<string>>("source_ports");
        set => SetArgument("source_ports", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_network_manager_verifier_workspace_reachability_analysis_intent Terraform resource.
/// Manages a azurerm_network_manager_verifier_workspace_reachability_analysis_intent resource.
/// </summary>
public partial class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent(string name) : TerraformResource("azurerm_network_manager_verifier_workspace_reachability_analysis_intent", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceId is required")]
    public required TerraformValue<string> DestinationResourceId
    {
        get => GetArgument<TerraformValue<string>>("destination_resource_id");
        set => SetArgument("destination_resource_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceId is required")]
    public required TerraformValue<string> SourceResourceId
    {
        get => GetArgument<TerraformValue<string>>("source_resource_id");
        set => SetArgument("source_resource_id", value);
    }

    /// <summary>
    /// The verifier_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifierWorkspaceId is required")]
    public required TerraformValue<string> VerifierWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("verifier_workspace_id");
        set => SetArgument("verifier_workspace_id", value);
    }

    /// <summary>
    /// IpTraffic block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpTraffic is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpTraffic block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpTraffic block(s) allowed")]
    public required TerraformList<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock> IpTraffic
    {
        get => GetRequiredArgument<TerraformList<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock>>("ip_traffic");
        set => SetArgument("ip_traffic", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
