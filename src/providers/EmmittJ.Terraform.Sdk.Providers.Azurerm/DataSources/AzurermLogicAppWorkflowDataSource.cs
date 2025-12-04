using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogicAppWorkflowDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_logic_app_workflow Terraform data source.
/// Retrieves information about a azurerm_logic_app_workflow.
/// </summary>
public partial class AzurermLogicAppWorkflowDataSource(string name) : TerraformDataSource("azurerm_logic_app_workflow", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    public TerraformValue<string> AccessEndpoint
        => AsReference("access_endpoint");

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ConnectorEndpointIpAddresses
        => AsReference("connector_endpoint_ip_addresses");

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ConnectorOutboundIpAddresses
        => AsReference("connector_outbound_ip_addresses");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    public TerraformValue<string> LogicAppIntegrationAccountId
        => AsReference("logic_app_integration_account_id");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
        => AsReference("parameters");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WorkflowEndpointIpAddresses
        => AsReference("workflow_endpoint_ip_addresses");

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WorkflowOutboundIpAddresses
        => AsReference("workflow_outbound_ip_addresses");

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    public TerraformValue<string> WorkflowSchema
        => AsReference("workflow_schema");

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    public TerraformValue<string> WorkflowVersion
        => AsReference("workflow_version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppWorkflowDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppWorkflowDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
