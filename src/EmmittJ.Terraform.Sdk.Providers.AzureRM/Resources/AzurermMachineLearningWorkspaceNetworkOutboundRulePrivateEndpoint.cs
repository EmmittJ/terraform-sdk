using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The service_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_resource_id");
        set => this.WithProperty("service_resource_id", value);
    }

    /// <summary>
    /// The spark_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SparkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("spark_enabled");
        set => this.WithProperty("spark_enabled", value);
    }

    /// <summary>
    /// The sub_resource_target attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubResourceTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sub_resource_target");
        set => this.WithProperty("sub_resource_target", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
