using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_logic_app_workflow Terraform resource.
/// Manages a azurerm_logic_app_workflow resource.
/// </summary>
public partial class AzurermLogicAppWorkflow(string name) : TerraformResource("azurerm_logic_app_workflow", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_service_environment_id attribute.
    /// </summary>
    public TerraformValue<string>? IntegrationServiceEnvironmentId
    {
        get => new TerraformReference<string>(this, "integration_service_environment_id");
        set => SetArgument("integration_service_environment_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The logic_app_integration_account_id attribute.
    /// </summary>
    public TerraformValue<string>? LogicAppIntegrationAccountId
    {
        get => new TerraformReference<string>(this, "logic_app_integration_account_id");
        set => SetArgument("logic_app_integration_account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workflow_parameters attribute.
    /// </summary>
    public TerraformMap<string>? WorkflowParameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "workflow_parameters").ResolveNodes(ctx));
        set => SetArgument("workflow_parameters", value);
    }

    /// <summary>
    /// The workflow_schema attribute.
    /// </summary>
    public TerraformValue<string>? WorkflowSchema
    {
        get => new TerraformReference<string>(this, "workflow_schema");
        set => SetArgument("workflow_schema", value);
    }

    /// <summary>
    /// The workflow_version attribute.
    /// </summary>
    public TerraformValue<string>? WorkflowVersion
    {
        get => new TerraformReference<string>(this, "workflow_version");
        set => SetArgument("workflow_version", value);
    }

    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    public TerraformValue<string> AccessEndpoint
    {
        get => new TerraformReference<string>(this, "access_endpoint");
    }

    /// <summary>
    /// The connector_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ConnectorEndpointIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connector_endpoint_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The connector_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ConnectorOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "connector_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workflow_endpoint_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WorkflowEndpointIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "workflow_endpoint_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workflow_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WorkflowOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "workflow_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// AccessControl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControl block(s) allowed")]
    public TerraformList<AzurermLogicAppWorkflowAccessControlBlock>? AccessControl
    {
        get => GetArgument<TerraformList<AzurermLogicAppWorkflowAccessControlBlock>>("access_control");
        set => SetArgument("access_control", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermLogicAppWorkflowIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermLogicAppWorkflowIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppWorkflowTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppWorkflowTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
