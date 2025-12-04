using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for orchestrated_resource in GoogleOsConfigV2PolicyOrchestratorForFolder.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "orchestrated_resource";

    /// <summary>
    /// ID of the resource to be used while generating set of affected resources.
    /// 
    /// For UPSERT action the value is auto-generated during PolicyOrchestrator
    /// creation when not set. When the value is set it should following next
    /// restrictions:
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the project.
    /// 
    /// For DELETE action, ID must be specified explicitly during
    /// PolicyOrchestrator creation.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// OsPolicyAssignmentV1Payload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsPolicyAssignmentV1Payload block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock>? OsPolicyAssignmentV1Payload
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock>>("os_policy_assignment_v1_payload");
        set => SetArgument("os_policy_assignment_v1_payload", value);
    }

}

/// <summary>
/// Block type for os_policy_assignment_v1_payload in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_policy_assignment_v1_payload";

    /// <summary>
    /// Indicates that this revision has been successfully rolled out in this zone
    /// and new VMs will be assigned OS policies from this revision.
    /// 
    /// For a given OS policy assignment, there is only one revision with a value
    /// of &#39;true&#39; for this field.
    /// </summary>
    public TerraformValue<bool> Baseline
        => AsReference("baseline");

    /// <summary>
    /// Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    public TerraformValue<bool> Deleted
        => AsReference("deleted");

    /// <summary>
    /// OS policy assignment description.
    /// Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The etag for this OS policy assignment.
    /// If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Resource name.
    /// 
    /// Format:
    /// &#39;projects/{project_number}/locations/{location}/osPolicyAssignments/{os_policy_assignment_id}&#39;
    /// 
    /// This field is ignored when you create an OS policy assignment.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Indicates that reconciliation is in progress for the revision.
    /// This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The timestamp that the revision was created.
    /// </summary>
    public TerraformValue<string> RevisionCreateTime
        => AsReference("revision_create_time");

    /// <summary>
    /// The assignment revision ID
    /// A new revision is committed whenever a rollout is triggered for a OS policy
    /// assignment
    /// </summary>
    public TerraformValue<string> RevisionId
        => AsReference("revision_id");

    /// <summary>
    /// OS policy assignment rollout state
    /// Possible values:
    /// IN_PROGRESS
    /// CANCELLING
    /// CANCELLED
    /// SUCCEEDED
    /// </summary>
    public TerraformValue<string> RolloutState
        => AsReference("rollout_state");

    /// <summary>
    /// Server generated unique id for the OS policy assignment resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// InstanceFilter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock> InstanceFilter
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock>>("instance_filter");
        set => SetArgument("instance_filter", value);
    }

    /// <summary>
    /// OsPolicies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsPolicies block(s) required")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock> OsPolicies
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock>>("os_policies");
        set => SetArgument("os_policies", value);
    }

    /// <summary>
    /// Rollout block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rollout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock> Rollout
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock>>("rollout");
        set => SetArgument("rollout", value);
    }

}

/// <summary>
/// Block type for instance_filter in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_filter";

    /// <summary>
    /// Target all VMs in the project. If true, no other criteria is
    /// permitted.
    /// </summary>
    public TerraformValue<bool>? All
    {
        get => GetArgument<TerraformValue<bool>>("all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// ExclusionLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockExclusionLabelsBlock>? ExclusionLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockExclusionLabelsBlock>>("exclusion_labels");
        set => SetArgument("exclusion_labels", value);
    }

    /// <summary>
    /// InclusionLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInclusionLabelsBlock>? InclusionLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInclusionLabelsBlock>>("inclusion_labels");
        set => SetArgument("inclusion_labels", value);
    }

    /// <summary>
    /// Inventories block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInventoriesBlock>? Inventories
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInventoriesBlock>>("inventories");
        set => SetArgument("inventories", value);
    }

}

/// <summary>
/// Block type for exclusion_labels in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockExclusionLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_labels";

    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this
    /// map to be selected.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for inclusion_labels in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInclusionLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inclusion_labels";

    /// <summary>
    /// Labels are identified by key/value pairs in this map.
    /// A VM should contain all the key/value pairs specified in this
    /// map to be selected.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for inventories in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInventoriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inventories";

    /// <summary>
    /// The OS short name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsShortName is required")]
    public required TerraformValue<string> OsShortName
    {
        get => GetArgument<TerraformValue<string>>("os_short_name");
        set => SetArgument("os_short_name", value);
    }

    /// <summary>
    /// The OS version
    /// 
    /// Prefix matches are supported if asterisk(*) is provided as the
    /// last character. For example, to match all versions with a major
    /// version of &#39;7&#39;, specify the following value for this field &#39;7.*&#39;
    /// 
    /// An empty string matches all OS versions.
    /// </summary>
    public TerraformValue<string>? OsVersion
    {
        get => GetArgument<TerraformValue<string>>("os_version");
        set => SetArgument("os_version", value);
    }

}

/// <summary>
/// Block type for os_policies in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_policies";

    /// <summary>
    /// This flag determines the OS policy compliance status when none of the
    /// resource groups within the policy are applicable for a VM. Set this value
    /// to &#39;true&#39; if the policy needs to be reported as compliant even if the
    /// policy has nothing to validate or enforce.
    /// </summary>
    public TerraformValue<bool>? AllowNoResourceGroupMatch
    {
        get => GetArgument<TerraformValue<bool>>("allow_no_resource_group_match");
        set => SetArgument("allow_no_resource_group_match", value);
    }

    /// <summary>
    /// Policy description.
    /// Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id of the OS policy with the following restrictions:
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the assignment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Policy mode Possible values: [&amp;quot;VALIDATION&amp;quot;, &amp;quot;ENFORCEMENT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// ResourceGroups block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroups is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceGroups block(s) required")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock> ResourceGroups
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock>>("resource_groups");
        set => SetArgument("resource_groups", value);
    }

}

/// <summary>
/// Block type for resource_groups in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_groups";

    /// <summary>
    /// InventoryFilters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock>? InventoryFilters
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock>>("inventory_filters");
        set => SetArgument("inventory_filters", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock> Resources
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

}

/// <summary>
/// Block type for inventory_filters in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inventory_filters";

    /// <summary>
    /// The OS short name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsShortName is required")]
    public required TerraformValue<string> OsShortName
    {
        get => GetArgument<TerraformValue<string>>("os_short_name");
        set => SetArgument("os_short_name", value);
    }

    /// <summary>
    /// The OS version
    /// 
    /// Prefix matches are supported if asterisk(*) is provided as the
    /// last character. For example, to match all versions with a major
    /// version of &#39;7&#39;, specify the following value for this field &#39;7.*&#39;
    /// 
    /// An empty string matches all OS versions.
    /// </summary>
    public TerraformValue<string>? OsVersion
    {
        get => GetArgument<TerraformValue<string>>("os_version");
        set => SetArgument("os_version", value);
    }

}

/// <summary>
/// Block type for resources in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// The id of the resource with the following restrictions:
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the OS policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Exec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exec block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock>? Exec
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Pkg block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pkg block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock>? Pkg
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock>>("pkg");
        set => SetArgument("pkg", value);
    }

    /// <summary>
    /// Repository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock>? Repository
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock>>("repository");
        set => SetArgument("repository", value);
    }

}

/// <summary>
/// Block type for exec in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exec";

    /// <summary>
    /// Enforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Enforce block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock>? Enforce
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Validate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validate block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock> Validate
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock>>("validate");
        set => SetArgument("validate", value);
    }

}

/// <summary>
/// Block type for enforce in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enforce";

    /// <summary>
    /// Optional arguments to pass to the source during execution.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The script interpreter to use. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interpreter is required")]
    public required TerraformValue<string> Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// Only recorded for enforce Exec.
    /// Path to an output file (that is created by this Exec) whose
    /// content will be recorded in OSPolicyResourceCompliance after a
    /// successful run. Absence or failure to read this file will result in
    /// this ExecResource being non-compliant. Output file size is limited to
    /// 500K bytes.
    /// </summary>
    public TerraformValue<string>? OutputFilePath
    {
        get => GetArgument<TerraformValue<string>>("output_file_path");
        set => SetArgument("output_file_path", value);
    }

    /// <summary>
    /// An inline script.
    /// The size of the script is limited to 32KiB.
    /// </summary>
    public TerraformValue<string>? Script
    {
        get => GetArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations
    /// based on the file type:
    /// 
    /// Remote: A checksum must be specified.
    /// Cloud Storage: An object generation number must be specified.
    /// </summary>
    public TerraformValue<bool>? AllowInsecure
    {
        get => GetArgument<TerraformValue<bool>>("allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// SHA256 checksum of the remote file.
    /// </summary>
    public TerraformValue<string>? Sha256Checksum
    {
        get => GetArgument<TerraformValue<string>>("sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for validate in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validate";

    /// <summary>
    /// Optional arguments to pass to the source during execution.
    /// </summary>
    public TerraformList<string>? Args
    {
        get => GetArgument<TerraformList<string>>("args");
        set => SetArgument("args", value);
    }

    /// <summary>
    /// The script interpreter to use. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interpreter is required")]
    public required TerraformValue<string> Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// Only recorded for enforce Exec.
    /// Path to an output file (that is created by this Exec) whose
    /// content will be recorded in OSPolicyResourceCompliance after a
    /// successful run. Absence or failure to read this file will result in
    /// this ExecResource being non-compliant. Output file size is limited to
    /// 500K bytes.
    /// </summary>
    public TerraformValue<string>? OutputFilePath
    {
        get => GetArgument<TerraformValue<string>>("output_file_path");
        set => SetArgument("output_file_path", value);
    }

    /// <summary>
    /// An inline script.
    /// The size of the script is limited to 32KiB.
    /// </summary>
    public TerraformValue<string>? Script
    {
        get => GetArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations
    /// based on the file type:
    /// 
    /// Remote: A checksum must be specified.
    /// Cloud Storage: An object generation number must be specified.
    /// </summary>
    public TerraformValue<bool>? AllowInsecure
    {
        get => GetArgument<TerraformValue<bool>>("allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// SHA256 checksum of the remote file.
    /// </summary>
    public TerraformValue<string>? Sha256Checksum
    {
        get => GetArgument<TerraformValue<string>>("sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// A a file with this content.
    /// The size of the content is limited to 32KiB.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The absolute path of the file within the VM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Consists of three octal digits which represent, in
    /// order, the permissions of the owner, group, and other users for the
    /// file (similarly to the numeric mode used in the linux chmod
    /// utility). Each digit represents a three bit number with the 4 bit
    /// corresponding to the read permissions, the 2 bit corresponds to the
    /// write bit, and the one bit corresponds to the execute permission.
    /// Default behavior is 755.
    /// 
    /// Below are some examples of permissions and their associated values:
    /// read, write, and execute: 7
    /// read and execute: 5
    /// read and write: 6
    /// read only: 4
    /// </summary>
    public TerraformValue<string>? Permissions
    {
        get => GetArgument<TerraformValue<string>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Desired state of the file. Possible values: [&amp;quot;PRESENT&amp;quot;, &amp;quot;ABSENT&amp;quot;, &amp;quot;CONTENTS_MATCH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations
    /// based on the file type:
    /// 
    /// Remote: A checksum must be specified.
    /// Cloud Storage: An object generation number must be specified.
    /// </summary>
    public TerraformValue<bool>? AllowInsecure
    {
        get => GetArgument<TerraformValue<bool>>("allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// SHA256 checksum of the remote file.
    /// </summary>
    public TerraformValue<string>? Sha256Checksum
    {
        get => GetArgument<TerraformValue<string>>("sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for pkg in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pkg";

    /// <summary>
    /// The desired state the agent should maintain for this package. Possible values: [&amp;quot;INSTALLED&amp;quot;, &amp;quot;REMOVED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformValue<string> DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Apt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Apt block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Deb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deb block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock>? Deb
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock>>("deb");
        set => SetArgument("deb", value);
    }

    /// <summary>
    /// Googet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Googet block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock>? Googet
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock>>("googet");
        set => SetArgument("googet", value);
    }

    /// <summary>
    /// Msi block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Msi block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock>? Msi
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock>>("msi");
        set => SetArgument("msi", value);
    }

    /// <summary>
    /// Rpm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rpm block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock>? Rpm
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock>>("rpm");
        set => SetArgument("rpm", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt";

    /// <summary>
    /// Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for deb in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deb";

    /// <summary>
    /// Whether dependencies should also be installed.
    /// - install when false: &#39;dpkg -i package&#39;
    /// - install when true: &#39;apt-get update &amp;amp;&amp;amp; apt-get -y install
    /// package.deb&#39;
    /// </summary>
    public TerraformValue<bool>? PullDeps
    {
        get => GetArgument<TerraformValue<bool>>("pull_deps");
        set => SetArgument("pull_deps", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations
    /// based on the file type:
    /// 
    /// Remote: A checksum must be specified.
    /// Cloud Storage: An object generation number must be specified.
    /// </summary>
    public TerraformValue<bool>? AllowInsecure
    {
        get => GetArgument<TerraformValue<bool>>("allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// SHA256 checksum of the remote file.
    /// </summary>
    public TerraformValue<string>? Sha256Checksum
    {
        get => GetArgument<TerraformValue<string>>("sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for googet in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "googet";

    /// <summary>
    /// Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for msi in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "msi";

    /// <summary>
    /// Additional properties to use during installation.
    /// This should be in the format of Property=Setting.
    /// Appended to the defaults of &#39;ACTION=INSTALL
    /// REBOOT=ReallySuppress&#39;.
    /// </summary>
    public TerraformList<string>? Properties
    {
        get => GetArgument<TerraformList<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations
    /// based on the file type:
    /// 
    /// Remote: A checksum must be specified.
    /// Cloud Storage: An object generation number must be specified.
    /// </summary>
    public TerraformValue<bool>? AllowInsecure
    {
        get => GetArgument<TerraformValue<bool>>("allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// SHA256 checksum of the remote file.
    /// </summary>
    public TerraformValue<string>? Sha256Checksum
    {
        get => GetArgument<TerraformValue<string>>("sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for rpm in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rpm";

    /// <summary>
    /// Whether dependencies should also be installed.
    /// - install when false: &#39;rpm --upgrade --replacepkgs package.rpm&#39;
    /// - install when true: &#39;yum -y install package.rpm&#39; or
    /// &#39;zypper -y install package.rpm&#39;
    /// </summary>
    public TerraformValue<bool>? PullDeps
    {
        get => GetArgument<TerraformValue<bool>>("pull_deps");
        set => SetArgument("pull_deps", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations
    /// based on the file type:
    /// 
    /// Remote: A checksum must be specified.
    /// Cloud Storage: An object generation number must be specified.
    /// </summary>
    public TerraformValue<bool>? AllowInsecure
    {
        get => GetArgument<TerraformValue<bool>>("allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => GetArgument<TerraformValue<string>>("generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote";

    /// <summary>
    /// SHA256 checksum of the remote file.
    /// </summary>
    public TerraformValue<string>? Sha256Checksum
    {
        get => GetArgument<TerraformValue<string>>("sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for yum in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yum";

    /// <summary>
    /// Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for zypper in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zypper";

    /// <summary>
    /// Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for repository in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository";

    /// <summary>
    /// Apt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Apt block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Goo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Goo block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock>? Goo
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock>>("goo");
        set => SetArgument("goo", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt";

    /// <summary>
    /// Type of archive files in this repository. Possible values: [&amp;quot;DEB&amp;quot;, &amp;quot;DEB_SRC&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArchiveType is required")]
    public required TerraformValue<string> ArchiveType
    {
        get => GetArgument<TerraformValue<string>>("archive_type");
        set => SetArgument("archive_type", value);
    }

    /// <summary>
    /// List of components for this repository. Must contain at least one
    /// item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Components is required")]
    public TerraformList<string>? Components
    {
        get => GetArgument<TerraformList<string>>("components");
        set => SetArgument("components", value);
    }

    /// <summary>
    /// Distribution of this repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    public required TerraformValue<string> Distribution
    {
        get => GetArgument<TerraformValue<string>>("distribution");
        set => SetArgument("distribution", value);
    }

    /// <summary>
    /// URI of the key file for this repository. The agent maintains a
    /// keyring at &#39;/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg&#39;.
    /// </summary>
    public TerraformValue<string>? GpgKey
    {
        get => GetArgument<TerraformValue<string>>("gpg_key");
        set => SetArgument("gpg_key", value);
    }

    /// <summary>
    /// URI for this repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for goo in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "goo";

    /// <summary>
    /// The name of the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The url of the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for yum in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yum";

    /// <summary>
    /// The location of the repository directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseUrl is required")]
    public required TerraformValue<string> BaseUrl
    {
        get => GetArgument<TerraformValue<string>>("base_url");
        set => SetArgument("base_url", value);
    }

    /// <summary>
    /// The display name of the repository.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// URIs of GPG keys.
    /// </summary>
    public TerraformList<string>? GpgKeys
    {
        get => GetArgument<TerraformList<string>>("gpg_keys");
        set => SetArgument("gpg_keys", value);
    }

    /// <summary>
    /// A one word, unique name for this repository. This is  the &#39;repo
    /// id&#39; in the yum config file and also the &#39;display_name&#39; if
    /// &#39;display_name&#39; is omitted. This id is also used as the unique
    /// identifier when checking for resource conflicts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for zypper in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zypper";

    /// <summary>
    /// The location of the repository directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseUrl is required")]
    public required TerraformValue<string> BaseUrl
    {
        get => GetArgument<TerraformValue<string>>("base_url");
        set => SetArgument("base_url", value);
    }

    /// <summary>
    /// The display name of the repository.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// URIs of GPG keys.
    /// </summary>
    public TerraformList<string>? GpgKeys
    {
        get => GetArgument<TerraformList<string>>("gpg_keys");
        set => SetArgument("gpg_keys", value);
    }

    /// <summary>
    /// A one word, unique name for this repository. This is the &#39;repo
    /// id&#39; in the zypper config file and also the &#39;display_name&#39; if
    /// &#39;display_name&#39; is omitted. This id is also used as the unique
    /// identifier when checking for GuestPolicy conflicts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for rollout in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout";

    /// <summary>
    /// This determines the minimum duration of time to wait after the
    /// configuration changes are applied through the current rollout. A
    /// VM continues to count towards the &#39;disruption_budget&#39; at least
    /// until this duration of time has passed after configuration changes are
    /// applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinWaitDuration is required")]
    public required TerraformValue<string> MinWaitDuration
    {
        get => GetArgument<TerraformValue<string>>("min_wait_duration");
        set => SetArgument("min_wait_duration", value);
    }

    /// <summary>
    /// DisruptionBudget block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisruptionBudget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DisruptionBudget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DisruptionBudget block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlockDisruptionBudgetBlock> DisruptionBudget
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlockDisruptionBudgetBlock>>("disruption_budget");
        set => SetArgument("disruption_budget", value);
    }

}

/// <summary>
/// Block type for disruption_budget in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlockDisruptionBudgetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disruption_budget";

    /// <summary>
    /// Specifies a fixed value.
    /// </summary>
    public TerraformValue<double>? FixedAttribute
    {
        get => GetArgument<TerraformValue<double>>("fixed");
        set => SetArgument("fixed", value);
    }

    /// <summary>
    /// Specifies the relative value defined as a percentage, which will be
    /// multiplied by a reference value.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}


/// <summary>
/// Block type for orchestration_scope in GoogleOsConfigV2PolicyOrchestratorForFolder.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "orchestration_scope";

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlock>? Selectors
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selectors";

    /// <summary>
    /// LocationSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocationSelector block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlockLocationSelectorBlock>? LocationSelector
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlockLocationSelectorBlock>>("location_selector");
        set => SetArgument("location_selector", value);
    }

    /// <summary>
    /// ResourceHierarchySelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceHierarchySelector block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlockResourceHierarchySelectorBlock>? ResourceHierarchySelector
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlockResourceHierarchySelectorBlock>>("resource_hierarchy_selector");
        set => SetArgument("resource_hierarchy_selector", value);
    }

}

/// <summary>
/// Block type for location_selector in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlockLocationSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location_selector";

    /// <summary>
    /// Names of the locations in scope.
    /// Format: &#39;us-central1-a&#39;
    /// </summary>
    public TerraformList<string>? IncludedLocations
    {
        get => GetArgument<TerraformList<string>>("included_locations");
        set => SetArgument("included_locations", value);
    }

}

/// <summary>
/// Block type for resource_hierarchy_selector in GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlockSelectorsBlockResourceHierarchySelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_hierarchy_selector";

    /// <summary>
    /// Names of the folders in scope.
    /// Format: &#39;folders/{folder_id}&#39;
    /// </summary>
    public TerraformList<string>? IncludedFolders
    {
        get => GetArgument<TerraformList<string>>("included_folders");
        set => SetArgument("included_folders", value);
    }

    /// <summary>
    /// Names of the projects in scope.
    /// Format: &#39;projects/{project_number}&#39;
    /// </summary>
    public TerraformList<string>? IncludedProjects
    {
        get => GetArgument<TerraformList<string>>("included_projects");
        set => SetArgument("included_projects", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOsConfigV2PolicyOrchestratorForFolder.
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_os_config_v2_policy_orchestrator_for_folder Terraform resource.
/// Manages a google_os_config_v2_policy_orchestrator_for_folder resource.
/// </summary>
public partial class GoogleOsConfigV2PolicyOrchestratorForFolder(string name) : TerraformResource("google_os_config_v2_policy_orchestrator_for_folder", name)
{
    /// <summary>
    /// Action to be done by the orchestrator in
    /// &#39;projects/{project_id}/zones/{zone_id}&#39; locations defined by the
    /// &#39;orchestration_scope&#39;. Allowed values:
    /// - &#39;UPSERT&#39; - Orchestrator will create or update target resources.
    /// - &#39;DELETE&#39; - Orchestrator will delete target resources, if they exist
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Freeform text describing the purpose of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The parent resource name in the form of &#39;folders/{folder_id}/locations/global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformValue<string> FolderId
    {
        get => GetArgument<TerraformValue<string>>("folder_id");
        set => SetArgument("folder_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels as key value pairs
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The logical identifier of the policy orchestrator, with the following
    /// restrictions:
    /// 
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the parent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyOrchestratorId is required")]
    public required TerraformValue<string> PolicyOrchestratorId
    {
        get => GetArgument<TerraformValue<string>>("policy_orchestrator_id");
        set => SetArgument("policy_orchestrator_id", value);
    }

    /// <summary>
    /// State of the orchestrator. Can be updated to change orchestrator behaviour.
    /// Allowed values:
    /// - &#39;ACTIVE&#39; - orchestrator is actively looking for actions to be taken.
    /// - &#39;STOPPED&#39; - orchestrator won&#39;t make any changes.
    /// 
    /// Note: There might be more states added in the future. We use string here
    /// instead of an enum, to avoid the need of propagating new states to all the
    /// client code.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// Timestamp when the policy orchestrator resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of other
    /// fields, and may be sent on update and delete requests to ensure the
    /// client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Identifier. In form of
    /// * &#39;organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Describes the state of the orchestration process.
    /// </summary>
    public TerraformList<TerraformMap<object>> OrchestrationState
        => AsReference("orchestration_state");

    /// <summary>
    /// Set to true, if the there are ongoing changes being applied by the
    /// orchestrator.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timestamp when the policy orchestrator resource was last modified.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// OrchestratedResource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrchestratedResource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OrchestratedResource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestratedResource block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock> OrchestratedResource
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestratedResourceBlock>>("orchestrated_resource");
        set => SetArgument("orchestrated_resource", value);
    }

    /// <summary>
    /// OrchestrationScope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestrationScope block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock>? OrchestrationScope
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorForFolderOrchestrationScopeBlock>>("orchestration_scope");
        set => SetArgument("orchestration_scope", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOsConfigV2PolicyOrchestratorForFolderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
