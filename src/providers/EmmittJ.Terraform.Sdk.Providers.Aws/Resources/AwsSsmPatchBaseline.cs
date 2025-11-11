using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for approval_rule in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmPatchBaselineApprovalRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The approve_after_days attribute.
    /// </summary>
    [TerraformProperty("approve_after_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ApproveAfterDays { get; set; }

    /// <summary>
    /// The approve_until_date attribute.
    /// </summary>
    [TerraformProperty("approve_until_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApproveUntilDate { get; set; }

    /// <summary>
    /// The compliance_level attribute.
    /// </summary>
    [TerraformProperty("compliance_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComplianceLevel { get; set; }

    /// <summary>
    /// The enable_non_security attribute.
    /// </summary>
    [TerraformProperty("enable_non_security")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableNonSecurity { get; set; }

}

/// <summary>
/// Block type for global_filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmPatchBaselineGlobalFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmPatchBaselineSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    [TerraformProperty("configuration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Configuration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The products attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Products is required")]
    [TerraformProperty("products")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Products { get; set; }

}

/// <summary>
/// Manages a aws_ssm_patch_baseline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmPatchBaseline : TerraformResource
{
    public AwsSsmPatchBaseline(string name) : base("aws_ssm_patch_baseline", name)
    {
    }

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    [TerraformProperty("approved_patches")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ApprovedPatches { get; set; }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    [TerraformProperty("approved_patches_compliance_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApprovedPatchesComplianceLevel { get; set; }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    [TerraformProperty("approved_patches_enable_non_security")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApprovedPatchesEnableNonSecurity { get; set; }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    [TerraformProperty("available_security_updates_compliance_status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailableSecurityUpdatesComplianceStatus { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [TerraformProperty("operating_system")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperatingSystem { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    [TerraformProperty("rejected_patches")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RejectedPatches { get; set; }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    [TerraformProperty("rejected_patches_action")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RejectedPatchesAction { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for approval_rule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("approval_rule")]
    public partial TerraformList<TerraformBlock<AwsSsmPatchBaselineApprovalRuleBlock>>? ApprovalRule { get; set; }

    /// <summary>
    /// Block for global_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 GlobalFilter block(s) allowed")]
    [TerraformProperty("global_filter")]
    public partial TerraformList<TerraformBlock<AwsSsmPatchBaselineGlobalFilterBlock>>? GlobalFilter { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<AwsSsmPatchBaselineSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Json { get; }

}
