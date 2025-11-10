using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogicAppWorkflowDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("access_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_endpoint");

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("connector_endpoint_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConnectorEndpointIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "connector_endpoint_ip_addresses");

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("connector_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ConnectorOutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "connector_outbound_ip_addresses");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformPropertyName("logic_app_integration_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogicAppIntegrationAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logic_app_integration_account_id");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Parameters => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "parameters");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("workflow_endpoint_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> WorkflowEndpointIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "workflow_endpoint_ip_addresses");

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("workflow_outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> WorkflowOutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "workflow_outbound_ip_addresses");

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformPropertyName("workflow_schema")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkflowSchema => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workflow_schema");

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformPropertyName("workflow_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkflowVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workflow_version");

}
