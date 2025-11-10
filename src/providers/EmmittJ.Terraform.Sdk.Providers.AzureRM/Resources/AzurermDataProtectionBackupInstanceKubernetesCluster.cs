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
        set => SetProperty("cluster_scoped_resources_enabled", value);
    }

    /// <summary>
    /// The excluded_namespaces attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedNamespaces
    {
        set => SetProperty("excluded_namespaces", value);
    }

    /// <summary>
    /// The excluded_resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludedResourceTypes
    {
        set => SetProperty("excluded_resource_types", value);
    }

    /// <summary>
    /// The included_namespaces attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedNamespaces
    {
        set => SetProperty("included_namespaces", value);
    }

    /// <summary>
    /// The included_resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IncludedResourceTypes
    {
        set => SetProperty("included_resource_types", value);
    }

    /// <summary>
    /// The label_selectors attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LabelSelectors
    {
        set => SetProperty("label_selectors", value);
    }

    /// <summary>
    /// The volume_snapshot_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VolumeSnapshotEnabled
    {
        set => SetProperty("volume_snapshot_enabled", value);
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
/// Manages a azurerm_data_protection_backup_instance_kubernetes_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataProtectionBackupInstanceKubernetesCluster : TerraformResource
{
    public AzurermDataProtectionBackupInstanceKubernetesCluster(string name) : base("azurerm_data_protection_backup_instance_kubernetes_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_policy_id");
        SetOutput("id");
        SetOutput("kubernetes_cluster_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("snapshot_resource_group_name");
        SetOutput("vault_id");
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformProperty<string> BackupPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_policy_id");
        set => SetProperty("backup_policy_id", value);
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
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformProperty<string> KubernetesClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kubernetes_cluster_id");
        set => SetProperty("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    public required TerraformProperty<string> SnapshotResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("snapshot_resource_group_name");
        set => SetProperty("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformProperty<string> VaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_id");
        set => SetProperty("vault_id", value);
    }

    /// <summary>
    /// Block for backup_datasource_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupDatasourceParameters block(s) allowed")]
    public List<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>? BackupDatasourceParameters
    {
        set => SetProperty("backup_datasource_parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
