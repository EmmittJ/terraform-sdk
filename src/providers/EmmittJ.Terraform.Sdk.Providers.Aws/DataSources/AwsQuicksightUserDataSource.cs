using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_user.
/// </summary>
public class AwsQuicksightUserDataSource : TerraformDataSource
{
    public AwsQuicksightUserDataSource(string name) : base("aws_quicksight_user", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AwsAccountId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Active => new TerraformReference(this, "active");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [TerraformPropertyName("custom_permissions_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomPermissionsName => new TerraformReference(this, "custom_permissions_name");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Email => new TerraformReference(this, "email");

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdentityType => new TerraformReference(this, "identity_type");

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrincipalId => new TerraformReference(this, "principal_id");

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [TerraformPropertyName("user_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserRole => new TerraformReference(this, "user_role");

}
