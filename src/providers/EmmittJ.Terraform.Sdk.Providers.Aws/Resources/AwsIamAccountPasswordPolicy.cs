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
    public TerraformProperty<TerraformProperty<bool>>? AllowUsersToChangePassword { get; set; }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    [TerraformPropertyName("hard_expiry")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> HardExpiry { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "hard_expiry");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    [TerraformPropertyName("max_password_age")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxPasswordAge { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_password_age");

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    [TerraformPropertyName("minimum_password_length")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinimumPasswordLength { get; set; }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    [TerraformPropertyName("password_reuse_prevention")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PasswordReusePrevention { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "password_reuse_prevention");

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    [TerraformPropertyName("require_lowercase_characters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireLowercaseCharacters { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_lowercase_characters");

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    [TerraformPropertyName("require_numbers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireNumbers { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_numbers");

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    [TerraformPropertyName("require_symbols")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireSymbols { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_symbols");

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    [TerraformPropertyName("require_uppercase_characters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> RequireUppercaseCharacters { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_uppercase_characters");

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    [TerraformPropertyName("expire_passwords")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExpirePasswords => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "expire_passwords");

}
