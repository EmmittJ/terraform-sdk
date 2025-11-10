using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup_datasource_parameters in .
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_scoped_resources_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ClusterScopedResourcesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cluster_scoped_resources_enabled");
        set => WithProperty("cluster_scoped_resources_enabled", value);
    }

    /// <summary>
    /// The excluded_namespaces attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedNamespaces
    {
        get => GetProperty<List<TerraformProperty<string>>>("excluded_namespaces");
        set => WithProperty("excluded_namespaces", value);
    }

    /// <summary>
    /// The excluded_resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("excluded_resource_types");
        set => WithProperty("excluded_resource_types", value);
    }

    /// <summary>
    /// The included_namespaces attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedNamespaces
    {
        get => GetProperty<List<TerraformProperty<string>>>("included_namespaces");
        set => WithProperty("included_namespaces", value);
    }

    /// <summary>
    /// The included_resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("included_resource_types");
        set => WithProperty("included_resource_types", value);
    }

    /// <summary>
    /// The label_selectors attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LabelSelectors
    {
        get => GetProperty<List<TerraformProperty<string>>>("label_selectors");
        set => WithProperty("label_selectors", value);
    }

    /// <summary>
    /// The volume_snapshot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VolumeSnapshotEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("volume_snapshot_enabled");
        set => WithProperty("volume_snapshot_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformProperty<string> BackupPolicyId
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformProperty<string> KubernetesClusterId
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_cluster_id");
        set => this.WithProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    public required TerraformProperty<string> SnapshotResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("snapshot_resource_group_name");
        set => this.WithProperty("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

    /// <summary>
    /// Block for backup_datasource_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupDatasourceParameters block(s) allowed")]
    public List<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>? BackupDatasourceParameters
    {
        get => GetProperty<List<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>>("backup_datasource_parameters");
        set => this.WithProperty("backup_datasource_parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
