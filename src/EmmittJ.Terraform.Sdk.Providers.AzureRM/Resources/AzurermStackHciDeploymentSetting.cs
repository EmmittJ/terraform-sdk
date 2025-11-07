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
    public TerraformProperty<List<string>>? ArcResourceIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("arc_resource_ids");
        set => this.WithProperty("arc_resource_ids", value);
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
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? StackHciClusterId
    {
        get => GetProperty<TerraformProperty<string>>("stack_hci_cluster_id");
        set => this.WithProperty("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

}
