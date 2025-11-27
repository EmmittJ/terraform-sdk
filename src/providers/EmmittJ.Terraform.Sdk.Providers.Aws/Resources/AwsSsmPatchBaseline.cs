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
        get => new TerraformReference<double>(this, "approve_after_days");
        set => SetArgument("approve_after_days", value);
    }

    /// <summary>
    /// The approve_until_date attribute.
    /// </summary>
    public TerraformValue<string>? ApproveUntilDate
    {
        get => new TerraformReference<string>(this, "approve_until_date");
        set => SetArgument("approve_until_date", value);
    }

    /// <summary>
    /// The compliance_level attribute.
    /// </summary>
    public TerraformValue<string>? ComplianceLevel
    {
        get => new TerraformReference<string>(this, "compliance_level");
        set => SetArgument("compliance_level", value);
    }

    /// <summary>
    /// The enable_non_security attribute.
    /// </summary>
    public TerraformValue<bool>? EnableNonSecurity
    {
        get => new TerraformReference<bool>(this, "enable_non_security");
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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The products attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Products is required")]
    public TerraformList<string>? Products
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "products").ResolveNodes(ctx));
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "approved_patches").ResolveNodes(ctx));
        set => SetArgument("approved_patches", value);
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformValue<string>? ApprovedPatchesComplianceLevel
    {
        get => new TerraformReference<string>(this, "approved_patches_compliance_level");
        set => SetArgument("approved_patches_compliance_level", value);
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformValue<bool>? ApprovedPatchesEnableNonSecurity
    {
        get => new TerraformReference<bool>(this, "approved_patches_enable_non_security");
        set => SetArgument("approved_patches_enable_non_security", value);
    }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformValue<string> AvailableSecurityUpdatesComplianceStatus
    {
        get => new TerraformReference<string>(this, "available_security_updates_compliance_status");
        set => SetArgument("available_security_updates_compliance_status", value);
    }

    /// <summary>
    /// The description attribute.
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => new TerraformReference<string>(this, "operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformSet<string>? RejectedPatches
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "rejected_patches").ResolveNodes(ctx));
        set => SetArgument("rejected_patches", value);
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformValue<string> RejectedPatchesAction
    {
        get => new TerraformReference<string>(this, "rejected_patches_action");
        set => SetArgument("rejected_patches_action", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
    {
        get => new TerraformReference<string>(this, "json");
    }

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
