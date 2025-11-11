using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint resource.
/// </summary>
public partial class AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint : TerraformResource
{
    public AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint(string name) : base("azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The service_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceResourceId is required")]
    [TerraformProperty("service_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceResourceId { get; set; }

    /// <summary>
    /// The spark_enabled attribute.
    /// </summary>
    [TerraformProperty("spark_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SparkEnabled { get; set; }

    /// <summary>
    /// The sub_resource_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubResourceTarget is required")]
    [TerraformProperty("sub_resource_target")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubResourceTarget { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformProperty("workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock>? Timeouts { get; set; }

}
