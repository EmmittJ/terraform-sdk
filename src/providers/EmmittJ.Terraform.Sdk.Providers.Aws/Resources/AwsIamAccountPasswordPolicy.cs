using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_password_policy resource.
/// </summary>
public class AwsIamAccountPasswordPolicy : TerraformResource
{
    public AwsIamAccountPasswordPolicy(string name) : base("aws_iam_account_password_policy", name)
    {
    }

    /// <summary>
    /// The allow_users_to_change_password attribute.
    /// </summary>
    [TerraformPropertyName("allow_users_to_change_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowUsersToChangePassword { get; set; }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    [TerraformPropertyName("hard_expiry")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> HardExpiry { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    [TerraformPropertyName("max_password_age")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxPasswordAge { get; set; } = default!;

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    [TerraformPropertyName("minimum_password_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumPasswordLength { get; set; }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    [TerraformPropertyName("password_reuse_prevention")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PasswordReusePrevention { get; set; } = default!;

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    [TerraformPropertyName("require_lowercase_characters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireLowercaseCharacters { get; set; } = default!;

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    [TerraformPropertyName("require_numbers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireNumbers { get; set; } = default!;

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    [TerraformPropertyName("require_symbols")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireSymbols { get; set; } = default!;

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    [TerraformPropertyName("require_uppercase_characters")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> RequireUppercaseCharacters { get; set; } = default!;

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    [TerraformPropertyName("expire_passwords")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExpirePasswords => new TerraformReference(this, "expire_passwords");

}
