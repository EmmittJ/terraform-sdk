using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_password_policy resource.
/// </summary>
public partial class AwsIamAccountPasswordPolicy : TerraformResource
{
    public AwsIamAccountPasswordPolicy(string name) : base("aws_iam_account_password_policy", name)
    {
    }

    /// <summary>
    /// The allow_users_to_change_password attribute.
    /// </summary>
    [TerraformProperty("allow_users_to_change_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowUsersToChangePassword { get; set; }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    [TerraformProperty("hard_expiry")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> HardExpiry { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    [TerraformProperty("max_password_age")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxPasswordAge { get; set; }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    [TerraformProperty("minimum_password_length")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumPasswordLength { get; set; }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    [TerraformProperty("password_reuse_prevention")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> PasswordReusePrevention { get; set; }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    [TerraformProperty("require_lowercase_characters")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireLowercaseCharacters { get; set; }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    [TerraformProperty("require_numbers")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireNumbers { get; set; }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    [TerraformProperty("require_symbols")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireSymbols { get; set; }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    [TerraformProperty("require_uppercase_characters")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> RequireUppercaseCharacters { get; set; }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    [TerraformProperty("expire_passwords")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ExpirePasswords { get; }

}
