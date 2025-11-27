using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for restore_config in GoogleGkeBackupRestorePlan.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_config";

    /// <summary>
    /// If True, restore all namespaced resources in the Backup.
    /// Setting this field to False will result in an error.
    /// </summary>
    public TerraformValue<bool>? AllNamespaces
    {
        get => new TerraformReference<bool>(this, "all_namespaces");
        set => SetArgument("all_namespaces", value);
    }

    /// <summary>
    /// Defines the behavior for handling the situation where cluster-scoped resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;CLUSTER_RESOURCE_CONFLICT_POLICY_UNSPECIFIED&#39;
    /// if &#39;clusterResourceRestoreScope&#39; is anyting other than &#39;noGroupKinds&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#clusterresourceconflictpolicy
    /// for more information on each policy option. Possible values: [&amp;quot;USE_EXISTING_VERSION&amp;quot;, &amp;quot;USE_BACKUP_VERSION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ClusterResourceConflictPolicy
    {
        get => new TerraformReference<string>(this, "cluster_resource_conflict_policy");
        set => SetArgument("cluster_resource_conflict_policy", value);
    }

    /// <summary>
    /// Defines the behavior for handling the situation where sets of namespaced resources
    /// being restored already exist in the target cluster.
    /// This MUST be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#namespacedresourcerestoremode
    /// for more information on each mode. Possible values: [&amp;quot;DELETE_AND_RESTORE&amp;quot;, &amp;quot;FAIL_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_SKIP_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_VOLUME_ON_CONFLICT&amp;quot;, &amp;quot;MERGE_REPLACE_ON_CONFLICT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? NamespacedResourceRestoreMode
    {
        get => new TerraformReference<string>(this, "namespaced_resource_restore_mode");
        set => SetArgument("namespaced_resource_restore_mode", value);
    }

    /// <summary>
    /// Do not restore any namespaced resources if set to &amp;quot;True&amp;quot;.
    /// Specifying this field to &amp;quot;False&amp;quot; is not allowed.
    /// </summary>
    public TerraformValue<bool>? NoNamespaces
    {
        get => new TerraformReference<bool>(this, "no_namespaces");
        set => SetArgument("no_namespaces", value);
    }

    /// <summary>
    /// Specifies the mechanism to be used to restore volume data.
    /// This should be set to a value other than &#39;NAMESPACED_RESOURCE_RESTORE_MODE_UNSPECIFIED&#39;
    /// if the &#39;namespacedResourceRestoreScope&#39; is anything other than &#39;noNamespaces&#39;.
    /// If not specified, it will be treated as &#39;NO_VOLUME_DATA_RESTORATION&#39;.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#VolumeDataRestorePolicy
    /// for more information on each policy option. Possible values: [&amp;quot;RESTORE_VOLUME_DATA_FROM_BACKUP&amp;quot;, &amp;quot;REUSE_VOLUME_HANDLE_FROM_BACKUP&amp;quot;, &amp;quot;NO_VOLUME_DATA_RESTORATION&amp;quot;]
    /// </summary>
    public TerraformValue<string>? VolumeDataRestorePolicy
    {
        get => new TerraformReference<string>(this, "volume_data_restore_policy");
        set => SetArgument("volume_data_restore_policy", value);
    }

    /// <summary>
    /// ClusterResourceRestoreScope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterResourceRestoreScope block(s) allowed")]
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlock>? ClusterResourceRestoreScope
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlock>>("cluster_resource_restore_scope");
        set => SetArgument("cluster_resource_restore_scope", value);
    }

    /// <summary>
    /// ExcludedNamespaces block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludedNamespaces block(s) allowed")]
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockExcludedNamespacesBlock>? ExcludedNamespaces
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockExcludedNamespacesBlock>>("excluded_namespaces");
        set => SetArgument("excluded_namespaces", value);
    }

    /// <summary>
    /// RestoreOrder block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreOrder block(s) allowed")]
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlock>? RestoreOrder
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlock>>("restore_order");
        set => SetArgument("restore_order", value);
    }

    /// <summary>
    /// SelectedApplications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectedApplications block(s) allowed")]
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlock>? SelectedApplications
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlock>>("selected_applications");
        set => SetArgument("selected_applications", value);
    }

    /// <summary>
    /// SelectedNamespaces block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectedNamespaces block(s) allowed")]
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedNamespacesBlock>? SelectedNamespaces
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedNamespacesBlock>>("selected_namespaces");
        set => SetArgument("selected_namespaces", value);
    }

    /// <summary>
    /// TransformationRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlock>? TransformationRules
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlock>>("transformation_rules");
        set => SetArgument("transformation_rules", value);
    }

    /// <summary>
    /// VolumeDataRestorePolicyBindings block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockVolumeDataRestorePolicyBindingsBlock>? VolumeDataRestorePolicyBindings
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockVolumeDataRestorePolicyBindingsBlock>>("volume_data_restore_policy_bindings");
        set => SetArgument("volume_data_restore_policy_bindings", value);
    }

}

/// <summary>
/// Block type for cluster_resource_restore_scope in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_resource_restore_scope";

    /// <summary>
    /// If True, all valid cluster-scoped resources will be restored.
    /// Mutually exclusive to any other field in &#39;clusterResourceRestoreScope&#39;.
    /// </summary>
    public TerraformValue<bool>? AllGroupKinds
    {
        get => new TerraformReference<bool>(this, "all_group_kinds");
        set => SetArgument("all_group_kinds", value);
    }

    /// <summary>
    /// If True, no cluster-scoped resources will be restored.
    /// Mutually exclusive to any other field in &#39;clusterResourceRestoreScope&#39;.
    /// </summary>
    public TerraformValue<bool>? NoGroupKinds
    {
        get => new TerraformReference<bool>(this, "no_group_kinds");
        set => SetArgument("no_group_kinds", value);
    }

    /// <summary>
    /// ExcludedGroupKinds block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlockExcludedGroupKindsBlock>? ExcludedGroupKinds
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlockExcludedGroupKindsBlock>>("excluded_group_kinds");
        set => SetArgument("excluded_group_kinds", value);
    }

    /// <summary>
    /// SelectedGroupKinds block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlockSelectedGroupKindsBlock>? SelectedGroupKinds
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlockSelectedGroupKindsBlock>>("selected_group_kinds");
        set => SetArgument("selected_group_kinds", value);
    }

}

/// <summary>
/// Block type for excluded_group_kinds in GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlockExcludedGroupKindsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_group_kinds";

    /// <summary>
    /// API Group string of a Kubernetes resource, e.g.
    /// &amp;quot;apiextensions.k8s.io&amp;quot;, &amp;quot;storage.k8s.io&amp;quot;, etc.
    /// Use empty string for core group.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// Kind of a Kubernetes resource, e.g.
    /// &amp;quot;CustomResourceDefinition&amp;quot;, &amp;quot;StorageClass&amp;quot;, etc.
    /// </summary>
    public TerraformValue<string>? ResourceKind
    {
        get => new TerraformReference<string>(this, "resource_kind");
        set => SetArgument("resource_kind", value);
    }

}

/// <summary>
/// Block type for selected_group_kinds in GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockClusterResourceRestoreScopeBlockSelectedGroupKindsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_group_kinds";

    /// <summary>
    /// API Group string of a Kubernetes resource, e.g.
    /// &amp;quot;apiextensions.k8s.io&amp;quot;, &amp;quot;storage.k8s.io&amp;quot;, etc.
    /// Use empty string for core group.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// Kind of a Kubernetes resource, e.g.
    /// &amp;quot;CustomResourceDefinition&amp;quot;, &amp;quot;StorageClass&amp;quot;, etc.
    /// </summary>
    public TerraformValue<string>? ResourceKind
    {
        get => new TerraformReference<string>(this, "resource_kind");
        set => SetArgument("resource_kind", value);
    }

}

/// <summary>
/// Block type for excluded_namespaces in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockExcludedNamespacesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "excluded_namespaces";

    /// <summary>
    /// A list of Kubernetes Namespaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespaces is required")]
    public TerraformList<string>? Namespaces
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "namespaces").ResolveNodes(ctx));
        set => SetArgument("namespaces", value);
    }

}

/// <summary>
/// Block type for restore_order in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "restore_order";

    /// <summary>
    /// GroupKindDependencies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKindDependencies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKindDependencies block(s) required")]
    public required TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlock> GroupKindDependencies
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlock>>("group_kind_dependencies");
        set => SetArgument("group_kind_dependencies", value);
    }

}

/// <summary>
/// Block type for group_kind_dependencies in GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_kind_dependencies";

    /// <summary>
    /// Requiring block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Requiring is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Requiring block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requiring block(s) allowed")]
    public required TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlockRequiringBlock> Requiring
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlockRequiringBlock>>("requiring");
        set => SetArgument("requiring", value);
    }

    /// <summary>
    /// Satisfying block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Satisfying is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Satisfying block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Satisfying block(s) allowed")]
    public required TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlockSatisfyingBlock> Satisfying
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlockSatisfyingBlock>>("satisfying");
        set => SetArgument("satisfying", value);
    }

}

/// <summary>
/// Block type for requiring in GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlockRequiringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "requiring";

    /// <summary>
    /// API Group of a Kubernetes resource, e.g.
    /// &amp;quot;apiextensions.k8s.io&amp;quot;, &amp;quot;storage.k8s.io&amp;quot;, etc.
    /// Use empty string for core group.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// Kind of a Kubernetes resource, e.g.
    /// &amp;quot;CustomResourceDefinition&amp;quot;, &amp;quot;StorageClass&amp;quot;, etc.
    /// </summary>
    public TerraformValue<string>? ResourceKind
    {
        get => new TerraformReference<string>(this, "resource_kind");
        set => SetArgument("resource_kind", value);
    }

}

/// <summary>
/// Block type for satisfying in GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockRestoreOrderBlockGroupKindDependenciesBlockSatisfyingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "satisfying";

    /// <summary>
    /// API Group of a Kubernetes resource, e.g.
    /// &amp;quot;apiextensions.k8s.io&amp;quot;, &amp;quot;storage.k8s.io&amp;quot;, etc.
    /// Use empty string for core group.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// Kind of a Kubernetes resource, e.g.
    /// &amp;quot;CustomResourceDefinition&amp;quot;, &amp;quot;StorageClass&amp;quot;, etc.
    /// </summary>
    public TerraformValue<string>? ResourceKind
    {
        get => new TerraformReference<string>(this, "resource_kind");
        set => SetArgument("resource_kind", value);
    }

}

/// <summary>
/// Block type for selected_applications in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_applications";

    /// <summary>
    /// NamespacedNames block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacedNames is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NamespacedNames block(s) required")]
    public required TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlockNamespacedNamesBlock> NamespacedNames
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlockNamespacedNamesBlock>>("namespaced_names");
        set => SetArgument("namespaced_names", value);
    }

}

/// <summary>
/// Block type for namespaced_names in GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedApplicationsBlockNamespacedNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "namespaced_names";

    /// <summary>
    /// The name of a Kubernetes Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace of a Kubernetes Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

}

/// <summary>
/// Block type for selected_namespaces in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockSelectedNamespacesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_namespaces";

    /// <summary>
    /// A list of Kubernetes Namespaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespaces is required")]
    public TerraformList<string>? Namespaces
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "namespaces").ResolveNodes(ctx));
        set => SetArgument("namespaces", value);
    }

}

/// <summary>
/// Block type for transformation_rules in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation_rules";

    /// <summary>
    /// The description is a user specified string description
    /// of the transformation rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// FieldActions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldActions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldActions block(s) required")]
    public required TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockFieldActionsBlock> FieldActions
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockFieldActionsBlock>>("field_actions");
        set => SetArgument("field_actions", value);
    }

    /// <summary>
    /// ResourceFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceFilter block(s) allowed")]
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlock>? ResourceFilter
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlock>>("resource_filter");
        set => SetArgument("resource_filter", value);
    }

}

/// <summary>
/// Block type for field_actions in GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockFieldActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_actions";

    /// <summary>
    /// A string containing a JSON Pointer value that references the
    /// location in the target document to move the value from.
    /// </summary>
    public TerraformValue<string>? FromPath
    {
        get => new TerraformReference<string>(this, "from_path");
        set => SetArgument("from_path", value);
    }

    /// <summary>
    /// Specifies the operation to perform. Possible values: [&amp;quot;REMOVE&amp;quot;, &amp;quot;MOVE&amp;quot;, &amp;quot;COPY&amp;quot;, &amp;quot;ADD&amp;quot;, &amp;quot;TEST&amp;quot;, &amp;quot;REPLACE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Op is required")]
    public required TerraformValue<string> Op
    {
        get => new TerraformReference<string>(this, "op");
        set => SetArgument("op", value);
    }

    /// <summary>
    /// A string containing a JSON-Pointer value that references a
    /// location within the target document where the operation is performed.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// A string that specifies the desired value in string format
    /// to use for transformation.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_filter in GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_filter";

    /// <summary>
    /// This is a JSONPath expression that matches specific fields of
    /// candidate resources and it operates as a filtering parameter
    /// (resources that are not matched with this expression will not
    /// be candidates for transformation).
    /// </summary>
    public TerraformValue<string>? JsonPath
    {
        get => new TerraformReference<string>(this, "json_path");
        set => SetArgument("json_path", value);
    }

    /// <summary>
    /// (Filtering parameter) Any resource subject to transformation must
    /// be contained within one of the listed Kubernetes Namespace in the
    /// Backup. If this field is not provided, no namespace filtering will
    /// be performed (all resources in all Namespaces, including all
    /// cluster-scoped resources, will be candidates for transformation).
    /// To mix cluster-scoped and namespaced resources in the same rule,
    /// use an empty string (&amp;quot;&amp;quot;) as one of the target namespaces.
    /// </summary>
    public TerraformList<string>? Namespaces
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "namespaces").ResolveNodes(ctx));
        set => SetArgument("namespaces", value);
    }

    /// <summary>
    /// GroupKinds block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlockGroupKindsBlock>? GroupKinds
    {
        get => GetArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlockGroupKindsBlock>>("group_kinds");
        set => SetArgument("group_kinds", value);
    }

}

/// <summary>
/// Block type for group_kinds in GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockTransformationRulesBlockResourceFilterBlockGroupKindsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_kinds";

    /// <summary>
    /// API Group string of a Kubernetes resource, e.g.
    /// &amp;quot;apiextensions.k8s.io&amp;quot;, &amp;quot;storage.k8s.io&amp;quot;, etc.
    /// Use empty string for core group.
    /// </summary>
    public TerraformValue<string>? ResourceGroup
    {
        get => new TerraformReference<string>(this, "resource_group");
        set => SetArgument("resource_group", value);
    }

    /// <summary>
    /// Kind of a Kubernetes resource, e.g.
    /// &amp;quot;CustomResourceDefinition&amp;quot;, &amp;quot;StorageClass&amp;quot;, etc.
    /// </summary>
    public TerraformValue<string>? ResourceKind
    {
        get => new TerraformReference<string>(this, "resource_kind");
        set => SetArgument("resource_kind", value);
    }

}

/// <summary>
/// Block type for volume_data_restore_policy_bindings in GoogleGkeBackupRestorePlanRestoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupRestorePlanRestoreConfigBlockVolumeDataRestorePolicyBindingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume_data_restore_policy_bindings";

    /// <summary>
    /// Specifies the mechanism to be used to restore this volume data.
    /// See https://cloud.google.com/kubernetes-engine/docs/add-on/backup-for-gke/reference/rest/v1/RestoreConfig#VolumeDataRestorePolicy
    /// for more information on each policy option. Possible values: [&amp;quot;RESTORE_VOLUME_DATA_FROM_BACKUP&amp;quot;, &amp;quot;REUSE_VOLUME_HANDLE_FROM_BACKUP&amp;quot;, &amp;quot;NO_VOLUME_DATA_RESTORATION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The volume type, as determined by the PVC&#39;s
    /// bound PV, to apply the policy to. Possible values: [&amp;quot;GCE_PERSISTENT_DISK&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeType is required")]
    public required TerraformValue<string> VolumeType
    {
        get => new TerraformReference<string>(this, "volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeBackupRestorePlan.
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupRestorePlanTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_gke_backup_restore_plan Terraform resource.
/// Manages a google_gke_backup_restore_plan resource.
/// </summary>
public partial class GoogleGkeBackupRestorePlan(string name) : TerraformResource("google_gke_backup_restore_plan", name)
{
    /// <summary>
    /// A reference to the BackupPlan from which Backups may be used
    /// as the source for Restores created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlan is required")]
    public required TerraformValue<string> BackupPlan
    {
        get => new TerraformReference<string>(this, "backup_plan");
        set => SetArgument("backup_plan", value);
    }

    /// <summary>
    /// The source cluster from which Restores will be created via this RestorePlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => new TerraformReference<string>(this, "cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// User specified descriptive string for this RestorePlan.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The region of the Restore Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The State of the RestorePlan.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Detailed description of why RestorePlan is in its current state.
    /// </summary>
    public TerraformValue<string> StateReason
    {
        get => new TerraformReference<string>(this, "state_reason");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// RestoreConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RestoreConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreConfig block(s) allowed")]
    public required TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlock> RestoreConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupRestorePlanRestoreConfigBlock>>("restore_config");
        set => SetArgument("restore_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeBackupRestorePlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeBackupRestorePlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
