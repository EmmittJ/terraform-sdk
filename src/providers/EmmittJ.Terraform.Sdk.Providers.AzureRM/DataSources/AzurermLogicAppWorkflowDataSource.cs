using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLogicAppWorkflowDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    [TerraformArgument("access_endpoint")]
    public TerraformValue<string> AccessEndpoint
    {
        get => new TerraformReference<string>(this, "access_endpoint");
    }

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("connector_endpoint_ip_addresses")]
    public TerraformList<string> ConnectorEndpointIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connector_endpoint_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("connector_outbound_ip_addresses")]
    public TerraformList<string> ConnectorOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connector_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformArgument("logic_app_integration_account_id")]
    public TerraformValue<string> LogicAppIntegrationAccountId
    {
        get => new TerraformReference<string>(this, "logic_app_integration_account_id");
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("workflow_endpoint_ip_addresses")]
    public TerraformList<string> WorkflowEndpointIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "workflow_endpoint_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("workflow_outbound_ip_addresses")]
    public TerraformList<string> WorkflowOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "workflow_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformArgument("workflow_schema")]
    public TerraformValue<string> WorkflowSchema
    {
        get => new TerraformReference<string>(this, "workflow_schema");
    }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformArgument("workflow_version")]
    public TerraformValue<string> WorkflowVersion
    {
        get => new TerraformReference<string>(this, "workflow_version");
    }

}
