using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_account_password_policy Terraform resource.
/// Manages a aws_iam_account_password_policy resource.
/// </summary>
public partial class AwsIamAccountPasswordPolicy(string name) : TerraformResource("aws_iam_account_password_policy", name)
{
    /// <summary>
    /// The allow_users_to_change_password attribute.
    /// </summary>
    public TerraformValue<bool>? AllowUsersToChangePassword
    {
        get => new TerraformReference<bool>(this, "allow_users_to_change_password");
        set => SetArgument("allow_users_to_change_password", value);
    }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    public TerraformValue<bool> HardExpiry
    {
        get => new TerraformReference<bool>(this, "hard_expiry");
        set => SetArgument("hard_expiry", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    public TerraformValue<double> MaxPasswordAge
    {
        get => new TerraformReference<double>(this, "max_password_age");
        set => SetArgument("max_password_age", value);
    }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    public TerraformValue<double>? MinimumPasswordLength
    {
        get => new TerraformReference<double>(this, "minimum_password_length");
        set => SetArgument("minimum_password_length", value);
    }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    public TerraformValue<double> PasswordReusePrevention
    {
        get => new TerraformReference<double>(this, "password_reuse_prevention");
        set => SetArgument("password_reuse_prevention", value);
    }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    public TerraformValue<bool> RequireLowercaseCharacters
    {
        get => new TerraformReference<bool>(this, "require_lowercase_characters");
        set => SetArgument("require_lowercase_characters", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformValue<bool> RequireNumbers
    {
        get => new TerraformReference<bool>(this, "require_numbers");
        set => SetArgument("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformValue<bool> RequireSymbols
    {
        get => new TerraformReference<bool>(this, "require_symbols");
        set => SetArgument("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    public TerraformValue<bool> RequireUppercaseCharacters
    {
        get => new TerraformReference<bool>(this, "require_uppercase_characters");
        set => SetArgument("require_uppercase_characters", value);
    }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    public TerraformValue<bool> ExpirePasswords
    {
        get => new TerraformReference<bool>(this, "expire_passwords");
    }

}
