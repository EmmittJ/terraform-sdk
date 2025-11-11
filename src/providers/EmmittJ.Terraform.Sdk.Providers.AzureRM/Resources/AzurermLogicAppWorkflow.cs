using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for access_control in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppWorkflowAccessControlBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLogicAppWorkflowIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppWorkflowTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_workflow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLogicAppWorkflow : TerraformResource
{
    public AzurermLogicAppWorkflow(string name) : base("azurerm_logic_app_workflow", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The integration_service_environment_id attribute.
    /// </summary>
    [TerraformProperty("integration_service_environment_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IntegrationServiceEnvironmentId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformProperty("logic_app_integration_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LogicAppIntegrationAccountId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workflow_parameters attribute.
    /// </summary>
    [TerraformProperty("workflow_parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? WorkflowParameters { get; set; }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformProperty("workflow_schema")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WorkflowSchema { get; set; }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformProperty("workflow_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WorkflowVersion { get; set; }

    /// <summary>
    /// Block for access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControl block(s) allowed")]
    [TerraformProperty("access_control")]
    public TerraformList<TerraformBlock<AzurermLogicAppWorkflowAccessControlBlock>>? AccessControl { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermLogicAppWorkflowIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogicAppWorkflowTimeoutsBlock>? Timeouts { get; set; }

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

}
