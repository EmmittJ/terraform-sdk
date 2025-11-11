using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_patch_baseline.
/// </summary>
public partial class AwsSsmPatchBaselineDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselineDataSource(string name) : base("aws_ssm_patch_baseline", name)
    {
    }

    /// <summary>
    /// The default_baseline attribute.
    /// </summary>
    [TerraformProperty("default_baseline")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultBaseline { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [TerraformProperty("operating_system")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperatingSystem { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [TerraformProperty("owner")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The approval_rule attribute.
    /// </summary>
    [TerraformProperty("approval_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ApprovalRule { get; }

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    [TerraformProperty("approved_patches")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ApprovedPatches { get; }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    [TerraformProperty("approved_patches_compliance_level")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApprovedPatchesComplianceLevel { get; }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    [TerraformProperty("approved_patches_enable_non_security")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ApprovedPatchesEnableNonSecurity { get; }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    [TerraformProperty("available_security_updates_compliance_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailableSecurityUpdatesComplianceStatus { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The global_filter attribute.
    /// </summary>
    [TerraformProperty("global_filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> GlobalFilter { get; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Json { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    [TerraformProperty("rejected_patches")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> RejectedPatches { get; }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    [TerraformProperty("rejected_patches_action")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RejectedPatchesAction { get; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Source { get; }

}
