using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup_datasource_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The cluster_scoped_resources_enabled attribute.
    /// </summary>
    [TerraformProperty("cluster_scoped_resources_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ClusterScopedResourcesEnabled { get; set; }

    /// <summary>
    /// The excluded_namespaces attribute.
    /// </summary>
    [TerraformProperty("excluded_namespaces")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ExcludedNamespaces { get; set; }

    /// <summary>
    /// The excluded_resource_types attribute.
    /// </summary>
    [TerraformProperty("excluded_resource_types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>
    /// The included_namespaces attribute.
    /// </summary>
    [TerraformProperty("included_namespaces")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? IncludedNamespaces { get; set; }

    /// <summary>
    /// The included_resource_types attribute.
    /// </summary>
    [TerraformProperty("included_resource_types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? IncludedResourceTypes { get; set; }

    /// <summary>
    /// The label_selectors attribute.
    /// </summary>
    [TerraformProperty("label_selectors")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? LabelSelectors { get; set; }

    /// <summary>
    /// The volume_snapshot_enabled attribute.
    /// </summary>
    [TerraformProperty("volume_snapshot_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VolumeSnapshotEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_kubernetes_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataProtectionBackupInstanceKubernetesCluster : TerraformResource
{
    public AzurermDataProtectionBackupInstanceKubernetesCluster(string name) : base("azurerm_data_protection_backup_instance_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    [TerraformProperty("backup_policy_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BackupPolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformProperty("kubernetes_cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KubernetesClusterId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    [TerraformProperty("snapshot_resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SnapshotResourceGroupName { get; set; }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    [TerraformProperty("vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VaultId { get; set; }

    /// <summary>
    /// Block for backup_datasource_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupDatasourceParameters block(s) allowed")]
    [TerraformProperty("backup_datasource_parameters")]
    public TerraformList<TerraformBlock<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>>? BackupDatasourceParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock>? Timeouts { get; set; }

}
