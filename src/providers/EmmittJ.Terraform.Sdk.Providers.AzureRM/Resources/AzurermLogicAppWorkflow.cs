using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for access_control in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppWorkflowAccessControlBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppWorkflowIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_workflow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppWorkflow : TerraformResource
{
    public AzurermLogicAppWorkflow(string name) : base("azurerm_logic_app_workflow", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The integration_service_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("integration_service_environment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IntegrationServiceEnvironmentId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformPropertyName("logic_app_integration_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogicAppIntegrationAccountId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The workflow_parameters attribute.
    /// </summary>
    [TerraformPropertyName("workflow_parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? WorkflowParameters { get; set; }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformPropertyName("workflow_schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkflowSchema { get; set; }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformPropertyName("workflow_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkflowVersion { get; set; }

    /// <summary>
    /// Block for access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControl block(s) allowed")]
    [TerraformPropertyName("access_control")]
    public TerraformList<TerraformBlock<AzurermLogicAppWorkflowAccessControlBlock>>? AccessControl { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermLogicAppWorkflowIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLogicAppWorkflowTimeoutsBlock>? Timeouts { get; set; } = new();

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

}
