using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for access_control in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppWorkflowAccessControlBlock : TerraformBlock
{
}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppWorkflowIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_logic_app_workflow resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppWorkflow : TerraformResource
{
    public AzurermLogicAppWorkflow(string name) : base("azurerm_logic_app_workflow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_endpoint");
        SetOutput("connector_endpoint_ip_addresses");
        SetOutput("connector_outbound_ip_addresses");
        SetOutput("workflow_endpoint_ip_addresses");
        SetOutput("workflow_outbound_ip_addresses");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("integration_service_environment_id");
        SetOutput("location");
        SetOutput("logic_app_integration_account_id");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("workflow_parameters");
        SetOutput("workflow_schema");
        SetOutput("workflow_version");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The integration_service_environment_id attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationServiceEnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_service_environment_id");
        set => SetProperty("integration_service_environment_id", value);
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
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    public TerraformProperty<string> LogicAppIntegrationAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logic_app_integration_account_id");
        set => SetProperty("logic_app_integration_account_id", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
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
    /// The workflow_parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> WorkflowParameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("workflow_parameters");
        set => SetProperty("workflow_parameters", value);
    }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    public TerraformProperty<string> WorkflowSchema
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workflow_schema");
        set => SetProperty("workflow_schema", value);
    }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    public TerraformProperty<string> WorkflowVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workflow_version");
        set => SetProperty("workflow_version", value);
    }

    /// <summary>
    /// Block for access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControl block(s) allowed")]
    public List<AzurermLogicAppWorkflowAccessControlBlock>? AccessControl
    {
        set => SetProperty("access_control", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermLogicAppWorkflowIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppWorkflowTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    public TerraformExpression AccessEndpoint => this["access_endpoint"];

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformExpression ConnectorEndpointIpAddresses => this["connector_endpoint_ip_addresses"];

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression ConnectorOutboundIpAddresses => this["connector_outbound_ip_addresses"];

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WorkflowEndpointIpAddresses => this["workflow_endpoint_ip_addresses"];

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WorkflowOutboundIpAddresses => this["workflow_outbound_ip_addresses"];

}
