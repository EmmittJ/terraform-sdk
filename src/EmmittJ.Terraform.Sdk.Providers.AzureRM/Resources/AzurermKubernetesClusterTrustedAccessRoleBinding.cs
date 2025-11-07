using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_cluster_trusted_access_role_binding resource.
/// </summary>
public class AzurermKubernetesClusterTrustedAccessRoleBinding : TerraformResource
{
    public AzurermKubernetesClusterTrustedAccessRoleBinding(string name) : base("azurerm_kubernetes_cluster_trusted_access_role_binding", name)
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KubernetesClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
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
    /// The roles attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Roles
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("roles");
        set => this.WithProperty("roles", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

}
