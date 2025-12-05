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
        get => GetArgument<TerraformValue<bool>>("allow_users_to_change_password");
        set => SetArgument("allow_users_to_change_password", value);
    }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    public TerraformValue<bool> HardExpiry
    {
        get => GetArgument<TerraformValue<bool>>("hard_expiry") ?? CreateReference("hard_expiry");
        set => SetArgument("hard_expiry", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    public TerraformValue<double> MaxPasswordAge
    {
        get => GetArgument<TerraformValue<double>>("max_password_age") ?? CreateReference("max_password_age");
        set => SetArgument("max_password_age", value);
    }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    public TerraformValue<double>? MinimumPasswordLength
    {
        get => GetArgument<TerraformValue<double>>("minimum_password_length");
        set => SetArgument("minimum_password_length", value);
    }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    public TerraformValue<double> PasswordReusePrevention
    {
        get => GetArgument<TerraformValue<double>>("password_reuse_prevention") ?? CreateReference("password_reuse_prevention");
        set => SetArgument("password_reuse_prevention", value);
    }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    public TerraformValue<bool> RequireLowercaseCharacters
    {
        get => GetArgument<TerraformValue<bool>>("require_lowercase_characters") ?? CreateReference("require_lowercase_characters");
        set => SetArgument("require_lowercase_characters", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformValue<bool> RequireNumbers
    {
        get => GetArgument<TerraformValue<bool>>("require_numbers") ?? CreateReference("require_numbers");
        set => SetArgument("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformValue<bool> RequireSymbols
    {
        get => GetArgument<TerraformValue<bool>>("require_symbols") ?? CreateReference("require_symbols");
        set => SetArgument("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    public TerraformValue<bool> RequireUppercaseCharacters
    {
        get => GetArgument<TerraformValue<bool>>("require_uppercase_characters") ?? CreateReference("require_uppercase_characters");
        set => SetArgument("require_uppercase_characters", value);
    }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    public TerraformValue<bool> ExpirePasswords
        => CreateReference("expire_passwords");

}
