using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identities in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightIamPolicyAssignmentIdentitiesBlock
{
    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Group { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? User { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_iam_policy_assignment resource.
/// </summary>
public class AwsQuicksightIamPolicyAssignment : TerraformResource
{
    public AwsQuicksightIamPolicyAssignment(string name) : base("aws_quicksight_iam_policy_assignment", name)
    {
    }

    /// <summary>
    /// The assignment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentName is required")]
    [TerraformPropertyName("assignment_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AssignmentName { get; set; }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentStatus is required")]
    [TerraformPropertyName("assignment_status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AssignmentStatus { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AwsAccountId { get; set; } = default!;

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Namespace { get; set; } = default!;

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [TerraformPropertyName("policy_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PolicyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for identities.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("identities")]
    public TerraformList<TerraformBlock<AwsQuicksightIamPolicyAssignmentIdentitiesBlock>>? Identities { get; set; }

    /// <summary>
    /// The assignment_id attribute.
    /// </summary>
    [TerraformPropertyName("assignment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssignmentId => new TerraformReference(this, "assignment_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
