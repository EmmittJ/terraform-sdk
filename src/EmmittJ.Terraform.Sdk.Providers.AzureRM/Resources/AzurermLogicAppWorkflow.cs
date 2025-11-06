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
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The integration_service_environment_id attribute.
    /// </summary>
    public string? IntegrationServiceEnvironmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_service_environment_id")?.Value;
        set => this.WithProperty("integration_service_environment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    public string? LogicAppIntegrationAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logic_app_integration_account_id")?.Value;
        set => this.WithProperty("logic_app_integration_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workflow_parameters attribute.
    /// </summary>
    public Dictionary<string, string>? WorkflowParameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("workflow_parameters")?.Value;
        set => this.WithProperty("workflow_parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    public string? WorkflowSchema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workflow_schema")?.Value;
        set => this.WithProperty("workflow_schema", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    public string? WorkflowVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workflow_version")?.Value;
        set => this.WithProperty("workflow_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
