using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identities in .
/// Nesting mode: list
/// </summary>
public class AwsQuicksightIamPolicyAssignmentIdentitiesBlock : ITerraformBlock
{
    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Group { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? User { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AssignmentName { get; set; }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentStatus is required")]
    [TerraformPropertyName("assignment_status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AssignmentStatus { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Namespace { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "namespace");

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [TerraformPropertyName("policy_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PolicyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for identities.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("identities")]
    public TerraformList<TerraformBlock<AwsQuicksightIamPolicyAssignmentIdentitiesBlock>>? Identities { get; set; } = new();

    /// <summary>
    /// The assignment_id attribute.
    /// </summary>
    [TerraformPropertyName("assignment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssignmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "assignment_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
