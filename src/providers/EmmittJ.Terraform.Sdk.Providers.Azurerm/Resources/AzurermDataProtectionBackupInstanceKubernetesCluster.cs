using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for backup_datasource_parameters in AzurermDataProtectionBackupInstanceKubernetesCluster.
/// Nesting mode: list
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_datasource_parameters";

    /// <summary>
    /// The cluster_scoped_resources_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ClusterScopedResourcesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cluster_scoped_resources_enabled");
        set => SetArgument("cluster_scoped_resources_enabled", value);
    }

    /// <summary>
    /// The excluded_namespaces attribute.
    /// </summary>
    public TerraformList<string>? ExcludedNamespaces
    {
        get => GetArgument<TerraformList<string>>("excluded_namespaces");
        set => SetArgument("excluded_namespaces", value);
    }

    /// <summary>
    /// The excluded_resource_types attribute.
    /// </summary>
    public TerraformList<string>? ExcludedResourceTypes
    {
        get => GetArgument<TerraformList<string>>("excluded_resource_types");
        set => SetArgument("excluded_resource_types", value);
    }

    /// <summary>
    /// The included_namespaces attribute.
    /// </summary>
    public TerraformList<string>? IncludedNamespaces
    {
        get => GetArgument<TerraformList<string>>("included_namespaces");
        set => SetArgument("included_namespaces", value);
    }

    /// <summary>
    /// The included_resource_types attribute.
    /// </summary>
    public TerraformList<string>? IncludedResourceTypes
    {
        get => GetArgument<TerraformList<string>>("included_resource_types");
        set => SetArgument("included_resource_types", value);
    }

    /// <summary>
    /// The label_selectors attribute.
    /// </summary>
    public TerraformList<string>? LabelSelectors
    {
        get => GetArgument<TerraformList<string>>("label_selectors");
        set => SetArgument("label_selectors", value);
    }

    /// <summary>
    /// The volume_snapshot_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VolumeSnapshotEnabled
    {
        get => GetArgument<TerraformValue<bool>>("volume_snapshot_enabled");
        set => SetArgument("volume_snapshot_enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataProtectionBackupInstanceKubernetesCluster.
/// Nesting mode: single
/// </summary>
public class AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_data_protection_backup_instance_kubernetes_cluster Terraform resource.
/// Manages a azurerm_data_protection_backup_instance_kubernetes_cluster resource.
/// </summary>
public partial class AzurermDataProtectionBackupInstanceKubernetesCluster(string name) : TerraformResource("azurerm_data_protection_backup_instance_kubernetes_cluster", name)
{
    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    public required TerraformValue<string> BackupPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    public required TerraformValue<string> KubernetesClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("kubernetes_cluster_id");
        set => SetArgument("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    public required TerraformValue<string> SnapshotResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("snapshot_resource_group_name");
        set => SetArgument("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    public required TerraformValue<string> VaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// BackupDatasourceParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupDatasourceParameters block(s) allowed")]
    public TerraformList<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>? BackupDatasourceParameters
    {
        get => GetArgument<TerraformList<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock>>("backup_datasource_parameters");
        set => SetArgument("backup_datasource_parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
