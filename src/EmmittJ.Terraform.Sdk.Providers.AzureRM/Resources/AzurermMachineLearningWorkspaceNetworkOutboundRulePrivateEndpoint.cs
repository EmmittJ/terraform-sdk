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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The service_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("service_resource_id");
        set => this.WithProperty("service_resource_id", value);
    }

    /// <summary>
    /// The spark_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SparkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("spark_enabled");
        set => this.WithProperty("spark_enabled", value);
    }

    /// <summary>
    /// The sub_resource_target attribute.
    /// </summary>
    public TerraformProperty<string>? SubResourceTarget
    {
        get => GetProperty<TerraformProperty<string>>("sub_resource_target");
        set => this.WithProperty("sub_resource_target", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
