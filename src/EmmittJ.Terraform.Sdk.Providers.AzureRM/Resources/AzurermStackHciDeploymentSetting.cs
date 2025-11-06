using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stack_hci_deployment_setting resource.
/// </summary>
public class AzurermStackHciDeploymentSetting : TerraformResource
{
    public AzurermStackHciDeploymentSetting(string name) : base("azurerm_stack_hci_deployment_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arc_resource_ids attribute.
    /// </summary>
    public List<string>? ArcResourceIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("arc_resource_ids")?.Value;
        set => this.WithProperty("arc_resource_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    public string? StackHciClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_hci_cluster_id")?.Value;
        set => this.WithProperty("stack_hci_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
