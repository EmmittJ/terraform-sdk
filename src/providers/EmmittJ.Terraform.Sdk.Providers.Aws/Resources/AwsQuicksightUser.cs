using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_user resource.
/// </summary>
public partial class AwsQuicksightUser : TerraformResource
{
    public AwsQuicksightUser(string name) : base("aws_quicksight_user", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    [TerraformProperty("iam_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityType is required")]
    [TerraformProperty("identity_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityType { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    [TerraformProperty("session_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SessionName { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserRole is required")]
    [TerraformProperty("user_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserRole { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The user_invitation_url attribute.
    /// </summary>
    [TerraformProperty("user_invitation_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserInvitationUrl { get; }

}
