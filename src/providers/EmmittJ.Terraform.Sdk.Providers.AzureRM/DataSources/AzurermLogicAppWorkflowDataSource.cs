using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_logic_app_workflow.
/// </summary>
public class AzurermLogicAppWorkflowDataSource : TerraformDataSource
{
    public AzurermLogicAppWorkflowDataSource(string name) : base("azurerm_logic_app_workflow", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogicAppWorkflowDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("access_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessEndpoint => new TerraformReference(this, "access_endpoint");

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("connector_endpoint_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ConnectorEndpointIpAddresses => new TerraformReference(this, "connector_endpoint_ip_addresses");

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("connector_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ConnectorOutboundIpAddresses => new TerraformReference(this, "connector_outbound_ip_addresses");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformPropertyName("logic_app_integration_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogicAppIntegrationAccountId => new TerraformReference(this, "logic_app_integration_account_id");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Parameters => new TerraformReference(this, "parameters");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("workflow_endpoint_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> WorkflowEndpointIpAddresses => new TerraformReference(this, "workflow_endpoint_ip_addresses");

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("workflow_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> WorkflowOutboundIpAddresses => new TerraformReference(this, "workflow_outbound_ip_addresses");

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformPropertyName("workflow_schema")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkflowSchema => new TerraformReference(this, "workflow_schema");

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformPropertyName("workflow_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkflowVersion => new TerraformReference(this, "workflow_version");

}
