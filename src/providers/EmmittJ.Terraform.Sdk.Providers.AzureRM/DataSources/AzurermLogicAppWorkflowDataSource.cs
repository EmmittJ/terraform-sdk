using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppWorkflowDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_logic_app_workflow.
/// </summary>
public partial class AzurermLogicAppWorkflowDataSource : TerraformDataSource
{
    public AzurermLogicAppWorkflowDataSource(string name) : base("azurerm_logic_app_workflow", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogicAppWorkflowDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformProperty("access_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessEndpoint { get; }

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("connector_endpoint_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ConnectorEndpointIpAddresses { get; }

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("connector_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ConnectorOutboundIpAddresses { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformProperty("logic_app_integration_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LogicAppIntegrationAccountId { get; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Parameters { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("workflow_endpoint_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> WorkflowEndpointIpAddresses { get; }

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("workflow_outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> WorkflowOutboundIpAddresses { get; }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformProperty("workflow_schema")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkflowSchema { get; }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformProperty("workflow_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkflowVersion { get; }

}
