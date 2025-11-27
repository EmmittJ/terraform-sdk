using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for orchestrated_resource in GoogleOsConfigV2PolicyOrchestrator.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "orchestrated_resource";

    /// <summary>
    /// Optional. ID of the resource to be used while generating set of affected resources.
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// OsPolicyAssignmentV1Payload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsPolicyAssignmentV1Payload block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock>? OsPolicyAssignmentV1Payload
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock>>("os_policy_assignment_v1_payload");
        set => SetArgument("os_policy_assignment_v1_payload", value);
    }

}

/// <summary>
/// Block type for os_policy_assignment_v1_payload in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_policy_assignment_v1_payload";

    /// <summary>
    /// Output only. Indicates that this revision has been successfully rolled out in this zone
    /// and new VMs will be assigned OS policies from this revision.
    /// 
    /// For a given OS policy assignment, there is only one revision with a value
    /// of &#39;true&#39; for this field.
    /// </summary>
    public TerraformValue<bool> Baseline
    {
        get => new TerraformReference<bool>(this, "baseline");
    }

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    public TerraformValue<bool> Deleted
    {
        get => new TerraformReference<bool>(this, "deleted");
    }

    /// <summary>
    /// OS policy assignment description.
    /// Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress for the revision.
    /// This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// Output only. The timestamp that the revision was created.
    /// </summary>
    public TerraformValue<string> RevisionCreateTime
    {
        get => new TerraformReference<string>(this, "revision_create_time");
    }

    /// <summary>
    /// Output only. The assignment revision ID
    /// A new revision is committed whenever a rollout is triggered for a OS policy
    /// assignment
    /// </summary>
    public TerraformValue<string> RevisionId
    {
        get => new TerraformReference<string>(this, "revision_id");
    }

    /// <summary>
    /// Output only. OS policy assignment rollout state
    /// Possible values:
    /// ROLLOUT_STATE_UNSPECIFIED
    /// IN_PROGRESS
    /// CANCELLING
    /// CANCELLED
    /// SUCCEEDED
    /// </summary>
    public TerraformValue<string> RolloutState
    {
        get => new TerraformReference<string>(this, "rollout_state");
    }

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment resource.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// InstanceFilter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InstanceFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFilter block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock> InstanceFilter
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock>>("instance_filter");
        set => SetArgument("instance_filter", value);
    }

    /// <summary>
    /// OsPolicies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsPolicies block(s) required")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock> OsPolicies
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock>>("os_policies");
        set => SetArgument("os_policies", value);
    }

    /// <summary>
    /// Rollout block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rollout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock> Rollout
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock>>("rollout");
        set => SetArgument("rollout", value);
    }

}

/// <summary>
/// Block type for instance_filter in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// ExclusionLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockExclusionLabelsBlock>? ExclusionLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockExclusionLabelsBlock>>("exclusion_labels");
        set => SetArgument("exclusion_labels", value);
    }

    /// <summary>
    /// InclusionLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInclusionLabelsBlock>? InclusionLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInclusionLabelsBlock>>("inclusion_labels");
        set => SetArgument("inclusion_labels", value);
    }

    /// <summary>
    /// Inventories block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInventoriesBlock>? Inventories
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInventoriesBlock>>("inventories");
        set => SetArgument("inventories", value);
    }

}

/// <summary>
/// Block type for exclusion_labels in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockExclusionLabelsBlock : TerraformBlock
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for inclusion_labels in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInclusionLabelsBlock : TerraformBlock
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for inventories in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockInstanceFilterBlockInventoriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inventories";

    /// <summary>
    /// Required. The OS short name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsShortName is required")]
    public required TerraformValue<string> OsShortName
    {
        get => new TerraformReference<string>(this, "os_short_name");
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
        get => new TerraformReference<string>(this, "os_version");
        set => SetArgument("os_version", value);
    }

}

/// <summary>
/// Block type for os_policies in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_no_resource_group_match");
        set => SetArgument("allow_no_resource_group_match", value);
    }

    /// <summary>
    /// Policy description.
    /// Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Required. The id of the OS policy with the following restrictions:
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Required. Policy mode
    /// Possible values:
    /// MODE_UNSPECIFIED
    /// VALIDATION
    /// ENFORCEMENT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// ResourceGroups block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroups is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceGroups block(s) required")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock> ResourceGroups
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock>>("resource_groups");
        set => SetArgument("resource_groups", value);
    }

}

/// <summary>
/// Block type for resource_groups in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_groups";

    /// <summary>
    /// InventoryFilters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock>? InventoryFilters
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock>>("inventory_filters");
        set => SetArgument("inventory_filters", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock> Resources
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

}

/// <summary>
/// Block type for inventory_filters in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inventory_filters";

    /// <summary>
    /// Required. The OS short name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsShortName is required")]
    public required TerraformValue<string> OsShortName
    {
        get => new TerraformReference<string>(this, "os_short_name");
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
        get => new TerraformReference<string>(this, "os_version");
        set => SetArgument("os_version", value);
    }

}

/// <summary>
/// Block type for resources in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Required. The id of the resource with the following restrictions:
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Exec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Exec block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock>? Exec
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Pkg block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pkg block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock>? Pkg
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock>>("pkg");
        set => SetArgument("pkg", value);
    }

    /// <summary>
    /// Repository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock>? Repository
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock>>("repository");
        set => SetArgument("repository", value);
    }

}

/// <summary>
/// Block type for exec in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exec";

    /// <summary>
    /// Enforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Enforce block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock>? Enforce
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Validate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validate block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock> Validate
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock>>("validate");
        set => SetArgument("validate", value);
    }

}

/// <summary>
/// Block type for enforce in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "args").ResolveNodes(ctx));
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Required. The script interpreter to use.
    /// Possible values:
    /// INTERPRETER_UNSPECIFIED
    /// NONE
    /// SHELL
    /// POWERSHELL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interpreter is required")]
    public required TerraformValue<string> Interpreter
    {
        get => new TerraformReference<string>(this, "interpreter");
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
        get => new TerraformReference<string>(this, "output_file_path");
        set => SetArgument("output_file_path", value);
    }

    /// <summary>
    /// An inline script.
    /// The size of the script is limited to 32KiB.
    /// </summary>
    public TerraformValue<string>? Script
    {
        get => new TerraformReference<string>(this, "script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => new TerraformReference<string>(this, "local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Required. Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Required. Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// Required. URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for validate in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "args").ResolveNodes(ctx));
        set => SetArgument("args", value);
    }

    /// <summary>
    /// Required. The script interpreter to use.
    /// Possible values:
    /// INTERPRETER_UNSPECIFIED
    /// NONE
    /// SHELL
    /// POWERSHELL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interpreter is required")]
    public required TerraformValue<string> Interpreter
    {
        get => new TerraformReference<string>(this, "interpreter");
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
        get => new TerraformReference<string>(this, "output_file_path");
        set => SetArgument("output_file_path", value);
    }

    /// <summary>
    /// An inline script.
    /// The size of the script is limited to 32KiB.
    /// </summary>
    public TerraformValue<string>? Script
    {
        get => new TerraformReference<string>(this, "script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => new TerraformReference<string>(this, "local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Required. Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Required. Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// Required. URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// Required. The absolute path of the file within the VM.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
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
        get => new TerraformReference<string>(this, "permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Required. Desired state of the file.
    /// Possible values:
    /// DESIRED_STATE_UNSPECIFIED
    /// PRESENT
    /// ABSENT
    /// CONTENTS_MATCH
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => new TerraformReference<string>(this, "local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Required. Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Required. Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// Required. URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for pkg in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pkg";

    /// <summary>
    /// Required. The desired state the agent should maintain for this package.
    /// Possible values:
    /// DESIRED_STATE_UNSPECIFIED
    /// INSTALLED
    /// REMOVED
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformValue<string> DesiredState
    {
        get => new TerraformReference<string>(this, "desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// Apt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Apt block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Deb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deb block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock>? Deb
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock>>("deb");
        set => SetArgument("deb", value);
    }

    /// <summary>
    /// Googet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Googet block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock>? Googet
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock>>("googet");
        set => SetArgument("googet", value);
    }

    /// <summary>
    /// Msi block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Msi block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock>? Msi
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock>>("msi");
        set => SetArgument("msi", value);
    }

    /// <summary>
    /// Rpm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rpm block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock>? Rpm
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock>>("rpm");
        set => SetArgument("rpm", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt";

    /// <summary>
    /// Required. Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for deb in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "pull_deps");
        set => SetArgument("pull_deps", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => new TerraformReference<string>(this, "local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Required. Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Required. Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// Required. URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for googet in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "googet";

    /// <summary>
    /// Required. Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for msi in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock : TerraformBlock
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
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => new TerraformReference<string>(this, "local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Required. Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Required. Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// Required. URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for rpm in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "pull_deps");
        set => SetArgument("pull_deps", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "allow_insecure");
        set => SetArgument("allow_insecure", value);
    }

    /// <summary>
    /// A local path within the VM to use.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => new TerraformReference<string>(this, "local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// Gcs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gcs block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs";

    /// <summary>
    /// Required. Bucket of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Generation number of the Cloud Storage object.
    /// </summary>
    public TerraformValue<string>? Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
    }

    /// <summary>
    /// Required. Name of the Cloud Storage object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => new TerraformReference<string>(this, "object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for remote in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "sha256_checksum");
        set => SetArgument("sha256_checksum", value);
    }

    /// <summary>
    /// Required. URI from which to fetch the object. It should contain both the
    /// protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for yum in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yum";

    /// <summary>
    /// Required. Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for zypper in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zypper";

    /// <summary>
    /// Required. Package name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for repository in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository";

    /// <summary>
    /// Apt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Apt block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Goo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Goo block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock>? Goo
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock>>("goo");
        set => SetArgument("goo", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt";

    /// <summary>
    /// Required. Type of archive files in this repository.
    /// Possible values:
    /// ARCHIVE_TYPE_UNSPECIFIED
    /// DEB
    /// DEB_SRC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArchiveType is required")]
    public required TerraformValue<string> ArchiveType
    {
        get => new TerraformReference<string>(this, "archive_type");
        set => SetArgument("archive_type", value);
    }

    /// <summary>
    /// Required. List of components for this repository. Must contain at least one
    /// item.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Components is required")]
    public TerraformList<string>? Components
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "components").ResolveNodes(ctx));
        set => SetArgument("components", value);
    }

    /// <summary>
    /// Required. Distribution of this repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Distribution is required")]
    public required TerraformValue<string> Distribution
    {
        get => new TerraformReference<string>(this, "distribution");
        set => SetArgument("distribution", value);
    }

    /// <summary>
    /// URI of the key file for this repository. The agent maintains a
    /// keyring at &#39;/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg&#39;.
    /// </summary>
    public TerraformValue<string>? GpgKey
    {
        get => new TerraformReference<string>(this, "gpg_key");
        set => SetArgument("gpg_key", value);
    }

    /// <summary>
    /// Required. URI for this repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for goo in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "goo";

    /// <summary>
    /// Required. The name of the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Required. The url of the repository.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for yum in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "yum";

    /// <summary>
    /// Required. The location of the repository directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseUrl is required")]
    public required TerraformValue<string> BaseUrl
    {
        get => new TerraformReference<string>(this, "base_url");
        set => SetArgument("base_url", value);
    }

    /// <summary>
    /// The display name of the repository.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// URIs of GPG keys.
    /// </summary>
    public TerraformList<string>? GpgKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gpg_keys").ResolveNodes(ctx));
        set => SetArgument("gpg_keys", value);
    }

    /// <summary>
    /// Required. A one word, unique name for this repository. This is  the &#39;repo
    /// id&#39; in the yum config file and also the &#39;display_name&#39; if
    /// &#39;display_name&#39; is omitted. This id is also used as the unique
    /// identifier when checking for resource conflicts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for zypper in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zypper";

    /// <summary>
    /// Required. The location of the repository directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseUrl is required")]
    public required TerraformValue<string> BaseUrl
    {
        get => new TerraformReference<string>(this, "base_url");
        set => SetArgument("base_url", value);
    }

    /// <summary>
    /// The display name of the repository.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// URIs of GPG keys.
    /// </summary>
    public TerraformList<string>? GpgKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "gpg_keys").ResolveNodes(ctx));
        set => SetArgument("gpg_keys", value);
    }

    /// <summary>
    /// Required. A one word, unique name for this repository. This is the &#39;repo
    /// id&#39; in the zypper config file and also the &#39;display_name&#39; if
    /// &#39;display_name&#39; is omitted. This id is also used as the unique
    /// identifier when checking for GuestPolicy conflicts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for rollout in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout";

    /// <summary>
    /// Required. This determines the minimum duration of time to wait after the
    /// configuration changes are applied through the current rollout. A
    /// VM continues to count towards the &#39;disruption_budget&#39; at least
    /// until this duration of time has passed after configuration changes are
    /// applied.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinWaitDuration is required")]
    public required TerraformValue<string> MinWaitDuration
    {
        get => new TerraformReference<string>(this, "min_wait_duration");
        set => SetArgument("min_wait_duration", value);
    }

    /// <summary>
    /// DisruptionBudget block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisruptionBudget is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DisruptionBudget block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DisruptionBudget block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlockDisruptionBudgetBlock> DisruptionBudget
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlockDisruptionBudgetBlock>>("disruption_budget");
        set => SetArgument("disruption_budget", value);
    }

}

/// <summary>
/// Block type for disruption_budget in GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlockOsPolicyAssignmentV1PayloadBlockRolloutBlockDisruptionBudgetBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "fixed");
        set => SetArgument("fixed", value);
    }

    /// <summary>
    /// Specifies the relative value defined as a percentage, which will be
    /// multiplied by a reference value.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => new TerraformReference<double>(this, "percent");
        set => SetArgument("percent", value);
    }

}


/// <summary>
/// Block type for orchestration_scope in GoogleOsConfigV2PolicyOrchestrator.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "orchestration_scope";

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlock>? Selectors
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

}

/// <summary>
/// Block type for selectors in GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selectors";

    /// <summary>
    /// LocationSelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocationSelector block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlockLocationSelectorBlock>? LocationSelector
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlockLocationSelectorBlock>>("location_selector");
        set => SetArgument("location_selector", value);
    }

    /// <summary>
    /// ResourceHierarchySelector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceHierarchySelector block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlockResourceHierarchySelectorBlock>? ResourceHierarchySelector
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlockResourceHierarchySelectorBlock>>("resource_hierarchy_selector");
        set => SetArgument("resource_hierarchy_selector", value);
    }

}

/// <summary>
/// Block type for location_selector in GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlockLocationSelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location_selector";

    /// <summary>
    /// Optional. Names of the locations in scope.
    /// Format: &#39;us-central1-a&#39;
    /// </summary>
    public TerraformList<string>? IncludedLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_locations").ResolveNodes(ctx));
        set => SetArgument("included_locations", value);
    }

}

/// <summary>
/// Block type for resource_hierarchy_selector in GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlockSelectorsBlockResourceHierarchySelectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_hierarchy_selector";

    /// <summary>
    /// Optional. Names of the folders in scope.
    /// Format: &#39;folders/{folder_id}&#39;
    /// </summary>
    public TerraformList<string>? IncludedFolders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_folders").ResolveNodes(ctx));
        set => SetArgument("included_folders", value);
    }

    /// <summary>
    /// Optional. Names of the projects in scope.
    /// Format: &#39;projects/{project_number}&#39;
    /// </summary>
    public TerraformList<string>? IncludedProjects
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "included_projects").ResolveNodes(ctx));
        set => SetArgument("included_projects", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOsConfigV2PolicyOrchestrator.
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigV2PolicyOrchestratorTimeoutsBlock : TerraformBlock
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
/// Represents a google_os_config_v2_policy_orchestrator Terraform resource.
/// Manages a google_os_config_v2_policy_orchestrator resource.
/// </summary>
public partial class GoogleOsConfigV2PolicyOrchestrator(string name) : TerraformResource("google_os_config_v2_policy_orchestrator", name)
{
    /// <summary>
    /// Required. Action to be done by the orchestrator in
    /// &#39;projects/{project_id}/zones/{zone_id}&#39; locations defined by the
    /// &#39;orchestration_scope&#39;. Allowed values:
    /// - &#39;UPSERT&#39; - Orchestrator will create or update target resources.
    /// - &#39;DELETE&#39; - Orchestrator will delete target resources, if they exist
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Optional. Freeform text describing the purpose of the resource.
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
    /// Optional. Labels as key value pairs
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
    /// Required. The logical identifier of the policy orchestrator, with the following
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
        get => new TerraformReference<string>(this, "policy_orchestrator_id");
        set => SetArgument("policy_orchestrator_id", value);
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
    /// Optional. State of the orchestrator. Can be updated to change orchestrator behaviour.
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
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// Output only. Timestamp when the policy orchestrator resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Immutable. Identifier. In form of
    /// * &#39;organizations/{organization_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;folders/{folder_id}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// * &#39;projects/{project_id_or_number}/locations/global/policyOrchestrators/{orchestrator_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Describes the state of the orchestration process.
    /// </summary>
    public TerraformList<TerraformMap<object>> OrchestrationState
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "orchestration_state").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Set to true, if the there are ongoing changes being applied by the
    /// orchestrator.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
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
    /// Output only. Timestamp when the policy orchestrator resource was last modified.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// OrchestratedResource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrchestratedResource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OrchestratedResource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestratedResource block(s) allowed")]
    public required TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlock> OrchestratedResource
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestratedResourceBlock>>("orchestrated_resource");
        set => SetArgument("orchestrated_resource", value);
    }

    /// <summary>
    /// OrchestrationScope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrchestrationScope block(s) allowed")]
    public TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlock>? OrchestrationScope
    {
        get => GetArgument<TerraformList<GoogleOsConfigV2PolicyOrchestratorOrchestrationScopeBlock>>("orchestration_scope");
        set => SetArgument("orchestration_scope", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOsConfigV2PolicyOrchestratorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOsConfigV2PolicyOrchestratorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
