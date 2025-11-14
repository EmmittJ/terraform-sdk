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
/// Block type for access_control in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppWorkflowAccessControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control";

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppWorkflowIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppWorkflowTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The integration_service_environment_id attribute.
    /// </summary>
    [TerraformArgument("integration_service_environment_id")]
    public TerraformValue<string>? IntegrationServiceEnvironmentId
    {
        get => new TerraformReference<string>(this, "integration_service_environment_id");
        set => SetArgument("integration_service_environment_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    [TerraformArgument("logic_app_integration_account_id")]
    public TerraformValue<string>? LogicAppIntegrationAccountId
    {
        get => new TerraformReference<string>(this, "logic_app_integration_account_id");
        set => SetArgument("logic_app_integration_account_id", value);
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
    /// The parameters attribute.
    /// </summary>
    [TerraformArgument("parameters")]
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workflow_parameters attribute.
    /// </summary>
    [TerraformArgument("workflow_parameters")]
    public TerraformMap<string>? WorkflowParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "workflow_parameters").ResolveNodes(ctx));
        set => SetArgument("workflow_parameters", value);
    }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    [TerraformArgument("workflow_schema")]
    public TerraformValue<string>? WorkflowSchema
    {
        get => new TerraformReference<string>(this, "workflow_schema");
        set => SetArgument("workflow_schema", value);
    }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    [TerraformArgument("workflow_version")]
    public TerraformValue<string>? WorkflowVersion
    {
        get => new TerraformReference<string>(this, "workflow_version");
        set => SetArgument("workflow_version", value);
    }

    /// <summary>
    /// Block for access_control.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControl block(s) allowed")]
    [TerraformArgument("access_control")]
    public TerraformList<AzurermLogicAppWorkflowAccessControlBlock> AccessControl { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermLogicAppWorkflowIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLogicAppWorkflowTimeoutsBlock Timeouts { get; set; } = new();

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

}
