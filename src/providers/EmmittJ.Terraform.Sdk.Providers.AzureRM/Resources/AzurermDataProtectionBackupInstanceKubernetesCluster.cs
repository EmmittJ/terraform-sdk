using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backup_datasource_parameters in .
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock
{
    /// <summary>
    /// The cluster_scoped_resources_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cluster_scoped_resources_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ClusterScopedResourcesEnabled { get; set; }

    /// <summary>
    /// The excluded_namespaces attribute.
    /// </summary>
    [TerraformPropertyName("excluded_namespaces")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludedNamespaces { get; set; }

    /// <summary>
    /// The excluded_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("excluded_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExcludedResourceTypes { get; set; }

    /// <summary>
    /// The included_namespaces attribute.
    /// </summary>
    [TerraformPropertyName("included_namespaces")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludedNamespaces { get; set; }

    /// <summary>
    /// The included_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("included_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? IncludedResourceTypes { get; set; }

    /// <summary>
    /// The label_selectors attribute.
    /// </summary>
    [TerraformPropertyName("label_selectors")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LabelSelectors { get; set; }

    /// <summary>
    /// The volume_snapshot_enabled attribute.
    /// </summary>
    [TerraformPropertyName("volume_snapshot_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VolumeSnapshotEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_kubernetes_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataProtectionBackupInstanceKubernetesCluster : TerraformResource
{
    public AzurermDataProtectionBackupInstanceKubernetesCluster(string name) : base("azurerm_data_protection_backup_instance_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    [TerraformPropertyName("backup_policy_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BackupPolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformPropertyName("kubernetes_cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KubernetesClusterId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    [TerraformPropertyName("snapshot_resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SnapshotResourceGroupName { get; set; }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    [TerraformPropertyName("vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VaultId { get; set; }

    /// <summary>
    /// Block for backup_datasource_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupDatasourceParameters block(s) allowed")]
    [TerraformPropertyName("backup_datasource_parameters")]
    public TerraformList<TerraformBlock<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>>? BackupDatasourceParameters { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock>? Timeouts { get; set; }

}
