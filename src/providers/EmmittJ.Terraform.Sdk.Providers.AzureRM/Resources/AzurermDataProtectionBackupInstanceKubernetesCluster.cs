using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for backup_datasource_parameters in .
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
    [TerraformArgument("cluster_scoped_resources_enabled")]
    public TerraformValue<bool>? ClusterScopedResourcesEnabled
    {
        get => new TerraformReference<bool>(this, "cluster_scoped_resources_enabled");
        set => SetArgument("cluster_scoped_resources_enabled", value);
    }

    /// <summary>
    /// The excluded_namespaces attribute.
    /// </summary>
    [TerraformArgument("excluded_namespaces")]
    public TerraformList<string>? ExcludedNamespaces
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_namespaces").ResolveNodes(ctx));
        set => SetArgument("excluded_namespaces", value);
    }

    /// <summary>
    /// The excluded_resource_types attribute.
    /// </summary>
    [TerraformArgument("excluded_resource_types")]
    public TerraformList<string>? ExcludedResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "excluded_resource_types").ResolveNodes(ctx));
        set => SetArgument("excluded_resource_types", value);
    }

    /// <summary>
    /// The included_namespaces attribute.
    /// </summary>
    [TerraformArgument("included_namespaces")]
    public TerraformList<string>? IncludedNamespaces
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_namespaces").ResolveNodes(ctx));
        set => SetArgument("included_namespaces", value);
    }

    /// <summary>
    /// The included_resource_types attribute.
    /// </summary>
    [TerraformArgument("included_resource_types")]
    public TerraformList<string>? IncludedResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_resource_types").ResolveNodes(ctx));
        set => SetArgument("included_resource_types", value);
    }

    /// <summary>
    /// The label_selectors attribute.
    /// </summary>
    [TerraformArgument("label_selectors")]
    public TerraformList<string>? LabelSelectors
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "label_selectors").ResolveNodes(ctx));
        set => SetArgument("label_selectors", value);
    }

    /// <summary>
    /// The volume_snapshot_enabled attribute.
    /// </summary>
    [TerraformArgument("volume_snapshot_enabled")]
    public TerraformValue<bool>? VolumeSnapshotEnabled
    {
        get => new TerraformReference<bool>(this, "volume_snapshot_enabled");
        set => SetArgument("volume_snapshot_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPolicyId is required")]
    [TerraformArgument("backup_policy_id")]
    public required TerraformValue<string> BackupPolicyId
    {
        get => new TerraformReference<string>(this, "backup_policy_id");
        set => SetArgument("backup_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformArgument("kubernetes_cluster_id")]
    public required TerraformValue<string> KubernetesClusterId
    {
        get => new TerraformReference<string>(this, "kubernetes_cluster_id");
        set => SetArgument("kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The snapshot_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotResourceGroupName is required")]
    [TerraformArgument("snapshot_resource_group_name")]
    public required TerraformValue<string> SnapshotResourceGroupName
    {
        get => new TerraformReference<string>(this, "snapshot_resource_group_name");
        set => SetArgument("snapshot_resource_group_name", value);
    }

    /// <summary>
    /// The vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultId is required")]
    [TerraformArgument("vault_id")]
    public required TerraformValue<string> VaultId
    {
        get => new TerraformReference<string>(this, "vault_id");
        set => SetArgument("vault_id", value);
    }

    /// <summary>
    /// Block for backup_datasource_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupDatasourceParameters block(s) allowed")]
    [TerraformArgument("backup_datasource_parameters")]
    public TerraformList<AzurermDataProtectionBackupInstanceKubernetesClusterBackupDatasourceParametersBlock> BackupDatasourceParameters { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataProtectionBackupInstanceKubernetesClusterTimeoutsBlock Timeouts { get; set; } = new();

}
