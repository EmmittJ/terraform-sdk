using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identities in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightIamPolicyAssignmentIdentitiesBlock() : TerraformBlock("identities")
{
    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Group { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformProperty("user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? User { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_iam_policy_assignment resource.
/// </summary>
public partial class AwsQuicksightIamPolicyAssignment : TerraformResource
{
    public AwsQuicksightIamPolicyAssignment(string name) : base("aws_quicksight_iam_policy_assignment", name)
    {
    }

    /// <summary>
    /// The assignment_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentName is required")]
    [TerraformProperty("assignment_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AssignmentName { get; set; }

    /// <summary>
    /// The assignment_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssignmentStatus is required")]
    [TerraformProperty("assignment_status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AssignmentStatus { get; set; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [TerraformProperty("policy_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PolicyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for identities.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("identities")]
    public TerraformList<AwsQuicksightIamPolicyAssignmentIdentitiesBlock> Identities { get; set; } = new();

    /// <summary>
    /// The assignment_id attribute.
    /// </summary>
    [TerraformProperty("assignment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssignmentId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
