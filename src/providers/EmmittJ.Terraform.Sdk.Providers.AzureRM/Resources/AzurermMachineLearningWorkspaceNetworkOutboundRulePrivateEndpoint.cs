using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint resource.
/// </summary>
public class AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint : TerraformResource
{
    public AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpoint(string name) : base("azurerm_machine_learning_workspace_network_outbound_rule_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("name");
        SetOutput("service_resource_id");
        SetOutput("spark_enabled");
        SetOutput("sub_resource_target");
        SetOutput("workspace_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The service_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceResourceId is required")]
    public required TerraformProperty<string> ServiceResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_resource_id");
        set => SetProperty("service_resource_id", value);
    }

    /// <summary>
    /// The spark_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SparkEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("spark_enabled");
        set => SetProperty("spark_enabled", value);
    }

    /// <summary>
    /// The sub_resource_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubResourceTarget is required")]
    public required TerraformProperty<string> SubResourceTarget
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sub_resource_target");
        set => SetProperty("sub_resource_target", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMachineLearningWorkspaceNetworkOutboundRulePrivateEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
