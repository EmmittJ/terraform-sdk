using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_workflow resource.
/// </summary>
public class AzurermLogicAppWorkflow : TerraformResource
{
    public AzurermLogicAppWorkflow(string name) : base("azurerm_logic_app_workflow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_endpoint");
        this.DeclareOutput("connector_endpoint_ip_addresses");
        this.DeclareOutput("connector_outbound_ip_addresses");
        this.DeclareOutput("workflow_endpoint_ip_addresses");
        this.DeclareOutput("workflow_outbound_ip_addresses");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The integration_service_environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationServiceEnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("integration_service_environment_id");
        set => this.WithProperty("integration_service_environment_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogicAppIntegrationAccountId
    {
        get => GetProperty<TerraformProperty<string>>("logic_app_integration_account_id");
        set => this.WithProperty("logic_app_integration_account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workflow_parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? WorkflowParameters
    {
        get => GetProperty<TerraformMapProperty<string>>("workflow_parameters");
        set => this.WithProperty("workflow_parameters", value);
    }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    public TerraformProperty<string>? WorkflowSchema
    {
        get => GetProperty<TerraformProperty<string>>("workflow_schema");
        set => this.WithProperty("workflow_schema", value);
    }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    public TerraformProperty<string>? WorkflowVersion
    {
        get => GetProperty<TerraformProperty<string>>("workflow_version");
        set => this.WithProperty("workflow_version", value);
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
