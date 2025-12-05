using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for approval_rule in AwsSsmPatchBaseline.
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineApprovalRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "approval_rule";

    /// <summary>
    /// The approve_after_days attribute.
    /// </summary>
    public TerraformValue<double>? ApproveAfterDays
    {
        get => GetArgument<TerraformValue<double>>("approve_after_days");
        set => SetArgument("approve_after_days", value);
    }

    /// <summary>
    /// The approve_until_date attribute.
    /// </summary>
    public TerraformValue<string>? ApproveUntilDate
    {
        get => GetArgument<TerraformValue<string>>("approve_until_date");
        set => SetArgument("approve_until_date", value);
    }

    /// <summary>
    /// The compliance_level attribute.
    /// </summary>
    public TerraformValue<string>? ComplianceLevel
    {
        get => GetArgument<TerraformValue<string>>("compliance_level");
        set => SetArgument("compliance_level", value);
    }

    /// <summary>
    /// The enable_non_security attribute.
    /// </summary>
    public TerraformValue<bool>? EnableNonSecurity
    {
        get => GetArgument<TerraformValue<bool>>("enable_non_security");
        set => SetArgument("enable_non_security", value);
    }

    /// <summary>
    /// PatchFilter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatchFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PatchFilter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PatchFilter block(s) allowed")]
    public required TerraformList<AwsSsmPatchBaselineApprovalRuleBlockPatchFilterBlock> PatchFilter
    {
        get => GetRequiredArgument<TerraformList<AwsSsmPatchBaselineApprovalRuleBlockPatchFilterBlock>>("patch_filter");
        set => SetArgument("patch_filter", value);
    }

}

/// <summary>
/// Block type for patch_filter in AwsSsmPatchBaselineApprovalRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineApprovalRuleBlockPatchFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patch_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for global_filter in AwsSsmPatchBaseline.
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineGlobalFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global_filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for source in AwsSsmPatchBaseline.
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    public required TerraformValue<string> Configuration
    {
        get => GetRequiredArgument<TerraformValue<string>>("configuration");
        set => SetArgument("configuration", value);
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
    /// The products attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Products is required")]
    public TerraformList<string>? Products
    {
        get => GetArgument<TerraformList<string>>("products");
        set => SetArgument("products", value);
    }

}


/// <summary>
/// Represents a aws_ssm_patch_baseline Terraform resource.
/// Manages a aws_ssm_patch_baseline resource.
/// </summary>
public partial class AwsSsmPatchBaseline(string name) : TerraformResource("aws_ssm_patch_baseline", name)
{
    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    public TerraformSet<string>? ApprovedPatches
    {
        get => GetArgument<TerraformSet<string>>("approved_patches");
        set => SetArgument("approved_patches", value);
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformValue<string>? ApprovedPatchesComplianceLevel
    {
        get => GetArgument<TerraformValue<string>>("approved_patches_compliance_level");
        set => SetArgument("approved_patches_compliance_level", value);
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformValue<bool>? ApprovedPatchesEnableNonSecurity
    {
        get => GetArgument<TerraformValue<bool>>("approved_patches_enable_non_security");
        set => SetArgument("approved_patches_enable_non_security", value);
    }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformValue<string> AvailableSecurityUpdatesComplianceStatus
    {
        get => GetArgument<TerraformValue<string>>("available_security_updates_compliance_status") ?? CreateReference("available_security_updates_compliance_status");
        set => SetArgument("available_security_updates_compliance_status", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The operating_system attribute.
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => GetArgument<TerraformValue<string>>("operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformSet<string>? RejectedPatches
    {
        get => GetArgument<TerraformSet<string>>("rejected_patches");
        set => SetArgument("rejected_patches", value);
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformValue<string> RejectedPatchesAction
    {
        get => GetArgument<TerraformValue<string>>("rejected_patches_action") ?? CreateReference("rejected_patches_action");
        set => SetArgument("rejected_patches_action", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
        => CreateReference("json");

    /// <summary>
    /// ApprovalRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmPatchBaselineApprovalRuleBlock>? ApprovalRule
    {
        get => GetArgument<TerraformList<AwsSsmPatchBaselineApprovalRuleBlock>>("approval_rule");
        set => SetArgument("approval_rule", value);
    }

    /// <summary>
    /// GlobalFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 GlobalFilter block(s) allowed")]
    public TerraformList<AwsSsmPatchBaselineGlobalFilterBlock>? GlobalFilter
    {
        get => GetArgument<TerraformList<AwsSsmPatchBaselineGlobalFilterBlock>>("global_filter");
        set => SetArgument("global_filter", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Source block(s) allowed")]
    public TerraformList<AwsSsmPatchBaselineSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AwsSsmPatchBaselineSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}
