using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_traffic in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock : TerraformBlock
{
    /// <summary>
    /// The destination_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationIps is required")]
    public List<TerraformProperty<string>>? DestinationIps
    {
        get => GetProperty<List<TerraformProperty<string>>>("destination_ips");
        set => WithProperty("destination_ips", value);
    }

    /// <summary>
    /// The destination_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPorts is required")]
    public List<TerraformProperty<string>>? DestinationPorts
    {
        get => GetProperty<List<TerraformProperty<string>>>("destination_ports");
        set => WithProperty("destination_ports", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public List<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<List<TerraformProperty<string>>>("protocols");
        set => WithProperty("protocols", value);
    }

    /// <summary>
    /// The source_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceIps is required")]
    public List<TerraformProperty<string>>? SourceIps
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_ips");
        set => WithProperty("source_ips", value);
    }

    /// <summary>
    /// The source_ports attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePorts is required")]
    public List<TerraformProperty<string>>? SourcePorts
    {
        get => GetProperty<List<TerraformProperty<string>>>("source_ports");
        set => WithProperty("source_ports", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_network_manager_verifier_workspace_reachability_analysis_intent resource.
/// </summary>
public class AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent : TerraformResource
{
    public AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntent(string name) : base("azurerm_network_manager_verifier_workspace_reachability_analysis_intent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceId is required")]
    public required TerraformProperty<string> DestinationResourceId
    {
        get => GetProperty<TerraformProperty<string>>("destination_resource_id");
        set => this.WithProperty("destination_resource_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceResourceId is required")]
    public required TerraformProperty<string> SourceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The verifier_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifierWorkspaceId is required")]
    public required TerraformProperty<string> VerifierWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("verifier_workspace_id");
        set => this.WithProperty("verifier_workspace_id", value);
    }

    /// <summary>
    /// Block for ip_traffic.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpTraffic block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpTraffic block(s) allowed")]
    public List<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock>? IpTraffic
    {
        get => GetProperty<List<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentIpTrafficBlock>>("ip_traffic");
        set => this.WithProperty("ip_traffic", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkManagerVerifierWorkspaceReachabilityAnalysisIntentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
