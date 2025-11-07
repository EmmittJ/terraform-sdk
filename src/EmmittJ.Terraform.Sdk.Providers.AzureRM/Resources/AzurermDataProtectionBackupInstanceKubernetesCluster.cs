using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_kubernetes_cluster resource.
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesCluster : TerraformResource
{
    public AzurermDataProtectionBackupInstanceKubernetesCluster(string name) : base("azurerm_data_protection_backup_instance_kubernetes_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? KubernetesClusterId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? SnapshotResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_resource_group_name");
        set => this.WithProperty("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
