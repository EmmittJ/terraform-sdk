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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service_resource_id attribute.
    /// </summary>
    public string? ServiceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_resource_id")?.Value;
        set => this.WithProperty("service_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spark_enabled attribute.
    /// </summary>
    public bool? SparkEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("spark_enabled")?.Value;
        set => this.WithProperty("spark_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sub_resource_target attribute.
    /// </summary>
    public string? SubResourceTarget
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sub_resource_target")?.Value;
        set => this.WithProperty("sub_resource_target", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
