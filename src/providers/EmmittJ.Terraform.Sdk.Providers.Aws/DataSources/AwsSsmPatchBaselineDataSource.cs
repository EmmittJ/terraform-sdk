using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_patch_baseline.
/// </summary>
public class AwsSsmPatchBaselineDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselineDataSource(string name) : base("aws_ssm_patch_baseline", name)
    {
    }

    /// <summary>
    /// The default_baseline attribute.
    /// </summary>
    [TerraformPropertyName("default_baseline")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DefaultBaseline { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    [TerraformPropertyName("operating_system")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OperatingSystem { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [TerraformPropertyName("owner")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Owner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The approval_rule attribute.
    /// </summary>
    [TerraformPropertyName("approval_rule")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ApprovalRule => new TerraformReference(this, "approval_rule");

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    [TerraformPropertyName("approved_patches")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ApprovedPatches => new TerraformReference(this, "approved_patches");

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    [TerraformPropertyName("approved_patches_compliance_level")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApprovedPatchesComplianceLevel => new TerraformReference(this, "approved_patches_compliance_level");

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    [TerraformPropertyName("approved_patches_enable_non_security")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ApprovedPatchesEnableNonSecurity => new TerraformReference(this, "approved_patches_enable_non_security");

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    [TerraformPropertyName("available_security_updates_compliance_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailableSecurityUpdatesComplianceStatus => new TerraformReference(this, "available_security_updates_compliance_status");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The global_filter attribute.
    /// </summary>
    [TerraformPropertyName("global_filter")]
    // Output-only attribute - read-only reference
    public TerraformList<object> GlobalFilter => new TerraformReference(this, "global_filter");

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformPropertyName("json")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Json => new TerraformReference(this, "json");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    [TerraformPropertyName("rejected_patches")]
    // Output-only attribute - read-only reference
    public TerraformList<string> RejectedPatches => new TerraformReference(this, "rejected_patches");

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    [TerraformPropertyName("rejected_patches_action")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RejectedPatchesAction => new TerraformReference(this, "rejected_patches_action");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Source => new TerraformReference(this, "source");

}
