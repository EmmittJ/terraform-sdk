using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control_sets in .
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerFrameworkControlSetsBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_auditmanager_framework resource.
/// </summary>
public class AwsAuditmanagerFramework : TerraformResource
{
    public AwsAuditmanagerFramework(string name) : base("aws_auditmanager_framework", name)
    {
    }

    /// <summary>
    /// The compliance_type attribute.
    /// </summary>
    [TerraformPropertyName("compliance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComplianceType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for control_sets.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("control_sets")]
    public TerraformSet<TerraformBlock<AwsAuditmanagerFrameworkControlSetsBlock>>? ControlSets { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The framework_type attribute.
    /// </summary>
    [TerraformPropertyName("framework_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FrameworkType => new TerraformReference(this, "framework_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
