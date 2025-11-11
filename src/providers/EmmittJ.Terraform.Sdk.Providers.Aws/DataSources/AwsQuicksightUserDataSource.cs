using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_user.
/// </summary>
public partial class AwsQuicksightUserDataSource : TerraformDataSource
{
    public AwsQuicksightUserDataSource(string name) : base("aws_quicksight_user", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Active { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [TerraformProperty("custom_permissions_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomPermissionsName { get; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Email { get; }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformProperty("identity_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdentityType { get; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformProperty("principal_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrincipalId { get; }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [TerraformProperty("user_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserRole { get; }

}
