using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Represents a azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint Terraform resource.
/// Manages a azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint resource.
/// </summary>
public partial class AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint(string name) : TerraformResource("azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The service_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceResourceId is required")]
    public required TerraformValue<string> ServiceResourceId
    {
        get => new TerraformReference<string>(this, "service_resource_id");
        set => SetArgument("service_resource_id", value);
    }

    /// <summary>
    /// The spark_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SparkEnabled
    {
        get => new TerraformReference<bool>(this, "spark_enabled");
        set => SetArgument("spark_enabled", value);
    }

    /// <summary>
    /// The sub_resource_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubResourceTarget is required")]
    public required TerraformValue<string> SubResourceTarget
    {
        get => new TerraformReference<string>(this, "sub_resource_target");
        set => SetArgument("sub_resource_target", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
