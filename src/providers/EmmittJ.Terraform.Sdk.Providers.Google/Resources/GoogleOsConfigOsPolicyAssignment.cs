using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for instance_filter in GoogleOsConfigOsPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_filter";

    /// <summary>
    /// Target all VMs in the project. If true, no other criteria is permitted.
    /// </summary>
    public TerraformValue<bool>? All
    {
        get => GetArgument<TerraformValue<bool>>("all");
        set => SetArgument("all", value);
    }

    /// <summary>
    /// ExclusionLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockExclusionLabelsBlock>? ExclusionLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockExclusionLabelsBlock>>("exclusion_labels");
        set => SetArgument("exclusion_labels", value);
    }

    /// <summary>
    /// InclusionLabels block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockInclusionLabelsBlock>? InclusionLabels
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockInclusionLabelsBlock>>("inclusion_labels");
        set => SetArgument("inclusion_labels", value);
    }

    /// <summary>
    /// Inventories block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockInventoriesBlock>? Inventories
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockInventoriesBlock>>("inventories");
        set => SetArgument("inventories", value);
    }

}

/// <summary>
/// Block type for exclusion_labels in GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockExclusionLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_labels";

    /// <summary>
    /// Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for inclusion_labels in GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockInclusionLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inclusion_labels";

    /// <summary>
    /// Labels are identified by key/value pairs in this map. A VM should contain all the key/value pairs specified in this map to be selected.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for inventories in GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentInstanceFilterBlockInventoriesBlock : TerraformBlock
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
    /// The OS version Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of &#39;7&#39;, specify the following value for this field &#39;7.*&#39; An empty string matches all OS versions.
    /// </summary>
    public TerraformValue<string>? OsVersion
    {
        get => GetArgument<TerraformValue<string>>("os_version");
        set => SetArgument("os_version", value);
    }

}


/// <summary>
/// Block type for os_policies in GoogleOsConfigOsPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_policies";

    /// <summary>
    /// This flag determines the OS policy compliance status when none of the resource groups within the policy are applicable for a VM. Set this value to &#39;true&#39; if the policy needs to be reported as compliant even if the policy has nothing to validate or enforce.
    /// </summary>
    public TerraformValue<bool>? AllowNoResourceGroupMatch
    {
        get => GetArgument<TerraformValue<bool>>("allow_no_resource_group_match");
        set => SetArgument("allow_no_resource_group_match", value);
    }

    /// <summary>
    /// Policy description. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id of the OS policy with the following restrictions:
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
    /// Policy mode Possible values: [&amp;quot;MODE_UNSPECIFIED&amp;quot;, &amp;quot;VALIDATION&amp;quot;, &amp;quot;ENFORCEMENT&amp;quot;]
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
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlock> ResourceGroups
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlock>>("resource_groups");
        set => SetArgument("resource_groups", value);
    }

}

/// <summary>
/// Block type for resource_groups in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_groups";

    /// <summary>
    /// InventoryFilters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock>? InventoryFilters
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock>>("inventory_filters");
        set => SetArgument("inventory_filters", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock> Resources
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

}

/// <summary>
/// Block type for inventory_filters in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockInventoryFiltersBlock : TerraformBlock
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
    /// Prefix matches are supported if asterisk(*) is provided as the last character. For example, to match all versions with a major version of &#39;7&#39;, specify the following value for this field &#39;7.*&#39;
    /// An empty string matches all OS versions.
    /// </summary>
    public TerraformValue<string>? OsVersion
    {
        get => GetArgument<TerraformValue<string>>("os_version");
        set => SetArgument("os_version", value);
    }

}

/// <summary>
/// Block type for resources in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// The id of the resource with the following restrictions:
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock>? Exec
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock>>("exec");
        set => SetArgument("exec", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Pkg block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Pkg block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock>? Pkg
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock>>("pkg");
        set => SetArgument("pkg", value);
    }

    /// <summary>
    /// Repository block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock>? Repository
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock>>("repository");
        set => SetArgument("repository", value);
    }

}

/// <summary>
/// Block type for exec in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exec";

    /// <summary>
    /// Enforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Enforce block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock>? Enforce
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// Validate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validate block(s) allowed")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock> Validate
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock>>("validate");
        set => SetArgument("validate", value);
    }

}

/// <summary>
/// Block type for enforce in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock : TerraformBlock
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
    /// The script interpreter to use. Possible values: [&amp;quot;INTERPRETER_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interpreter is required")]
    public required TerraformValue<string> Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.
    /// </summary>
    public TerraformValue<string>? OutputFilePath
    {
        get => GetArgument<TerraformValue<string>>("output_file_path");
        set => SetArgument("output_file_path", value);
    }

    /// <summary>
    /// An inline script. The size of the script is limited to 1024 characters.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockGcsBlock : TerraformBlock
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
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
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
/// Block type for remote in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockEnforceBlockFileBlockRemoteBlock : TerraformBlock
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
    /// URI from which to fetch the object. It should contain both the protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for validate in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock : TerraformBlock
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
    /// The script interpreter to use. Possible values: [&amp;quot;INTERPRETER_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;SHELL&amp;quot;, &amp;quot;POWERSHELL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interpreter is required")]
    public required TerraformValue<string> Interpreter
    {
        get => GetArgument<TerraformValue<string>>("interpreter");
        set => SetArgument("interpreter", value);
    }

    /// <summary>
    /// Only recorded for enforce Exec. Path to an output file (that is created by this Exec) whose content will be recorded in OSPolicyResourceCompliance after a successful run. Absence or failure to read this file will result in this ExecResource being non-compliant. Output file size is limited to 100K bytes.
    /// </summary>
    public TerraformValue<string>? OutputFilePath
    {
        get => GetArgument<TerraformValue<string>>("output_file_path");
        set => SetArgument("output_file_path", value);
    }

    /// <summary>
    /// An inline script. The size of the script is limited to 1024 characters.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations based on the file type:
    /// Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockGcsBlock : TerraformBlock
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
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
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
/// Block type for remote in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockExecBlockValidateBlockFileBlockRemoteBlock : TerraformBlock
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
    /// URI from which to fetch the object. It should contain both the protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// A a file with this content. The size of the content is limited to 1024 characters.
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
    /// Consists of three octal digits which represent, in order, the permissions of the owner, group, and other users for the file (similarly to the numeric mode used in the linux chmod utility). Each digit represents a three bit number with the 4 bit corresponding to the read permissions, the 2 bit corresponds to the write bit, and the one bit corresponds to the execute permission. Default behavior is 755.
    /// Below are some examples of permissions and their associated values: read, write, and execute: 7 read and execute: 5 read and write: 6 read only: 4
    /// </summary>
    public TerraformValue<string> Permissions
        => AsReference("permissions");

    /// <summary>
    /// Desired state of the file. Possible values: [&amp;quot;DESIRED_STATE_UNSPECIFIED&amp;quot;, &amp;quot;PRESENT&amp;quot;, &amp;quot;ABSENT&amp;quot;, &amp;quot;CONTENTS_MATCH&amp;quot;]
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations based on the file type: Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockGcsBlock : TerraformBlock
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
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
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
/// Block type for remote in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockFileBlockFileBlockRemoteBlock : TerraformBlock
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
    /// URI from which to fetch the object. It should contain both the protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for pkg in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pkg";

    /// <summary>
    /// The desired state the agent should maintain for this package. Possible values: [&amp;quot;DESIRED_STATE_UNSPECIFIED&amp;quot;, &amp;quot;INSTALLED&amp;quot;, &amp;quot;REMOVED&amp;quot;]
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Deb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deb block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock>? Deb
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock>>("deb");
        set => SetArgument("deb", value);
    }

    /// <summary>
    /// Googet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Googet block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock>? Googet
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock>>("googet");
        set => SetArgument("googet", value);
    }

    /// <summary>
    /// Msi block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Msi block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock>? Msi
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock>>("msi");
        set => SetArgument("msi", value);
    }

    /// <summary>
    /// Rpm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rpm block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock>? Rpm
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock>>("rpm");
        set => SetArgument("rpm", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockAptBlock : TerraformBlock
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
/// Block type for deb in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deb";

    /// <summary>
    /// Whether dependencies should also be installed. - install when false: &#39;dpkg -i package&#39; - install when true: &#39;apt-get update &amp;amp;&amp;amp; apt-get -y install package.deb&#39;
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
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations based on the file type:
    /// Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockGcsBlock : TerraformBlock
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
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
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
/// Block type for remote in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockDebBlockSourceBlockRemoteBlock : TerraformBlock
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
    /// URI from which to fetch the object. It should contain both the protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for googet in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockGoogetBlock : TerraformBlock
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
/// Block type for msi in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "msi";

    /// <summary>
    /// Additional properties to use during installation. This should be in the format of Property=Setting. Appended to the defaults of &#39;ACTION=INSTALL REBOOT=ReallySuppress&#39;.
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
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations based on the file type:
    /// Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockGcsBlock : TerraformBlock
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
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
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
/// Block type for remote in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockMsiBlockSourceBlockRemoteBlock : TerraformBlock
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
    /// URI from which to fetch the object. It should contain both the protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for rpm in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rpm";

    /// <summary>
    /// Whether dependencies should also be installed. - install when false: &#39;rpm --upgrade --replacepkgs package.rpm&#39; - install when true: &#39;yum -y install package.rpm&#39; or &#39;zypper -y install package.rpm&#39;
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
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for source in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Defaults to false. When false, files are subject to validations based on the file type:
    /// Remote: A checksum must be specified. Cloud Storage: An object generation number must be specified.
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
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock>? Gcs
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock>>("gcs");
        set => SetArgument("gcs", value);
    }

    /// <summary>
    /// Remote block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Remote block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock>? Remote
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock>>("remote");
        set => SetArgument("remote", value);
    }

}

/// <summary>
/// Block type for gcs in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockGcsBlock : TerraformBlock
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
    public TerraformValue<double>? Generation
    {
        get => GetArgument<TerraformValue<double>>("generation");
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
/// Block type for remote in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockRpmBlockSourceBlockRemoteBlock : TerraformBlock
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
    /// URI from which to fetch the object. It should contain both the protocol and path following the format &#39;{protocol}://{location}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for yum in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockYumBlock : TerraformBlock
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
/// Block type for zypper in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockPkgBlockZypperBlock : TerraformBlock
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
/// Block type for repository in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository";

    /// <summary>
    /// Apt block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Apt block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock>? Apt
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock>>("apt");
        set => SetArgument("apt", value);
    }

    /// <summary>
    /// Goo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Goo block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock>? Goo
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock>>("goo");
        set => SetArgument("goo", value);
    }

    /// <summary>
    /// Yum block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Yum block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock>? Yum
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock>>("yum");
        set => SetArgument("yum", value);
    }

    /// <summary>
    /// Zypper block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zypper block(s) allowed")]
    public TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock>? Zypper
    {
        get => GetArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock>>("zypper");
        set => SetArgument("zypper", value);
    }

}

/// <summary>
/// Block type for apt in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockAptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apt";

    /// <summary>
    /// Type of archive files in this repository. Possible values: [&amp;quot;ARCHIVE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;DEB&amp;quot;, &amp;quot;DEB_SRC&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArchiveType is required")]
    public required TerraformValue<string> ArchiveType
    {
        get => GetArgument<TerraformValue<string>>("archive_type");
        set => SetArgument("archive_type", value);
    }

    /// <summary>
    /// List of components for this repository. Must contain at least one item.
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
    /// URI of the key file for this repository. The agent maintains a keyring at &#39;/etc/apt/trusted.gpg.d/osconfig_agent_managed.gpg&#39;.
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
/// Block type for goo in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockGooBlock : TerraformBlock
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
/// Block type for yum in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockYumBlock : TerraformBlock
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
    /// A one word, unique name for this repository. This is the &#39;repo id&#39; in the yum config file and also the &#39;display_name&#39; if &#39;display_name&#39; is omitted. This id is also used as the unique identifier when checking for resource conflicts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for zypper in GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentOsPoliciesBlockResourceGroupsBlockResourcesBlockRepositoryBlockZypperBlock : TerraformBlock
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
    /// A one word, unique name for this repository. This is the &#39;repo id&#39; in the zypper config file and also the &#39;display_name&#39; if &#39;display_name&#39; is omitted. This id is also used as the unique identifier when checking for GuestPolicy conflicts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Block type for rollout in GoogleOsConfigOsPolicyAssignment.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentRolloutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout";

    /// <summary>
    /// This determines the minimum duration of time to wait after the configuration changes are applied through the current rollout. A VM continues to count towards the &#39;disruption_budget&#39; at least until this duration of time has passed after configuration changes are applied.
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
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentRolloutBlockDisruptionBudgetBlock> DisruptionBudget
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentRolloutBlockDisruptionBudgetBlock>>("disruption_budget");
        set => SetArgument("disruption_budget", value);
    }

}

/// <summary>
/// Block type for disruption_budget in GoogleOsConfigOsPolicyAssignmentRolloutBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentRolloutBlockDisruptionBudgetBlock : TerraformBlock
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
    /// Specifies the relative value defined as a percentage, which will be multiplied by a reference value.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOsConfigOsPolicyAssignment.
/// Nesting mode: single
/// </summary>
public class GoogleOsConfigOsPolicyAssignmentTimeoutsBlock : TerraformBlock
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
/// Represents a google_os_config_os_policy_assignment Terraform resource.
/// Manages a google_os_config_os_policy_assignment resource.
/// </summary>
public partial class GoogleOsConfigOsPolicyAssignment(string name) : TerraformResource("google_os_config_os_policy_assignment", name)
{
    /// <summary>
    /// OS policy assignment description. Length of the description is limited to 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Set to true to skip awaiting rollout during resource creation and update.
    /// </summary>
    public TerraformValue<bool>? SkipAwaitRollout
    {
        get => GetArgument<TerraformValue<bool>>("skip_await_rollout");
        set => SetArgument("skip_await_rollout", value);
    }

    /// <summary>
    /// Output only. Indicates that this revision has been successfully rolled out in this zone and new VMs will be assigned OS policies from this revision.
    /// For a given OS policy assignment, there is only one revision with a value of &#39;true&#39; for this field.
    /// </summary>
    public TerraformValue<bool> Baseline
        => AsReference("baseline");

    /// <summary>
    /// Output only. Indicates that this revision deletes the OS policy assignment.
    /// </summary>
    public TerraformValue<bool> Deleted
        => AsReference("deleted");

    /// <summary>
    /// The etag for this OS policy assignment. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Output only. Indicates that reconciliation is in progress for the revision. This value is &#39;true&#39; when the &#39;rollout_state&#39; is one of:
    /// * IN_PROGRESS
    /// * CANCELLING
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Output only. The timestamp that the revision was created.
    /// </summary>
    public TerraformValue<string> RevisionCreateTime
        => AsReference("revision_create_time");

    /// <summary>
    /// Output only. The assignment revision ID A new revision is committed whenever a rollout is triggered for a OS policy assignment
    /// </summary>
    public TerraformValue<string> RevisionId
        => AsReference("revision_id");

    /// <summary>
    /// Output only. OS policy assignment rollout state
    /// </summary>
    public TerraformValue<string> RolloutState
        => AsReference("rollout_state");

    /// <summary>
    /// Output only. Server generated unique id for the OS policy assignment resource.
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
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock> InstanceFilter
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentInstanceFilterBlock>>("instance_filter");
        set => SetArgument("instance_filter", value);
    }

    /// <summary>
    /// OsPolicies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsPolicies block(s) required")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock> OsPolicies
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentOsPoliciesBlock>>("os_policies");
        set => SetArgument("os_policies", value);
    }

    /// <summary>
    /// Rollout block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rollout is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rollout block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rollout block(s) allowed")]
    public required TerraformList<GoogleOsConfigOsPolicyAssignmentRolloutBlock> Rollout
    {
        get => GetRequiredArgument<TerraformList<GoogleOsConfigOsPolicyAssignmentRolloutBlock>>("rollout");
        set => SetArgument("rollout", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOsConfigOsPolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOsConfigOsPolicyAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
