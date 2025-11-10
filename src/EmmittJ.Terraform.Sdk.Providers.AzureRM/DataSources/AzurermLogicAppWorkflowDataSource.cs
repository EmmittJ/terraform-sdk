using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowDataSourceTimeoutsBlock : TerraformBlock
{
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
/// Retrieves information about a azurerm_logic_app_workflow.
/// </summary>
public class AzurermLogicAppWorkflowDataSource : TerraformDataSource
{
    public AzurermLogicAppWorkflowDataSource(string name) : base("azurerm_logic_app_workflow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_endpoint");
        this.DeclareOutput("connector_endpoint_ip_addresses");
        this.DeclareOutput("connector_outbound_ip_addresses");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("logic_app_integration_account_id");
        this.DeclareOutput("parameters");
        this.DeclareOutput("tags");
        this.DeclareOutput("workflow_endpoint_ip_addresses");
        this.DeclareOutput("workflow_outbound_ip_addresses");
        this.DeclareOutput("workflow_schema");
        this.DeclareOutput("workflow_version");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogicAppWorkflowDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogicAppWorkflowDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    public TerraformExpression LogicAppIntegrationAccountId => this["logic_app_integration_account_id"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WorkflowEndpointIpAddresses => this["workflow_endpoint_ip_addresses"];

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WorkflowOutboundIpAddresses => this["workflow_outbound_ip_addresses"];

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    public TerraformExpression WorkflowSchema => this["workflow_schema"];

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    public TerraformExpression WorkflowVersion => this["workflow_version"];

}
