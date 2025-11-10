using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_password_policy resource.
/// </summary>
public class AwsIamAccountPasswordPolicy : TerraformResource
{
    public AwsIamAccountPasswordPolicy(string name) : base("aws_iam_account_password_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("expire_passwords");
        SetOutput("allow_users_to_change_password");
        SetOutput("hard_expiry");
        SetOutput("id");
        SetOutput("max_password_age");
        SetOutput("minimum_password_length");
        SetOutput("password_reuse_prevention");
        SetOutput("require_lowercase_characters");
        SetOutput("require_numbers");
        SetOutput("require_symbols");
        SetOutput("require_uppercase_characters");
    }

    /// <summary>
    /// The allow_users_to_change_password attribute.
    /// </summary>
    public TerraformProperty<bool> AllowUsersToChangePassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_users_to_change_password");
        set => SetProperty("allow_users_to_change_password", value);
    }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    public TerraformProperty<bool> HardExpiry
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hard_expiry");
        set => SetProperty("hard_expiry", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    public TerraformProperty<double> MaxPasswordAge
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_password_age");
        set => SetProperty("max_password_age", value);
    }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    public TerraformProperty<double> MinimumPasswordLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("minimum_password_length");
        set => SetProperty("minimum_password_length", value);
    }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    public TerraformProperty<double> PasswordReusePrevention
    {
        get => GetRequiredOutput<TerraformProperty<double>>("password_reuse_prevention");
        set => SetProperty("password_reuse_prevention", value);
    }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    public TerraformProperty<bool> RequireLowercaseCharacters
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_lowercase_characters");
        set => SetProperty("require_lowercase_characters", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformProperty<bool> RequireNumbers
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_numbers");
        set => SetProperty("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformProperty<bool> RequireSymbols
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_symbols");
        set => SetProperty("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    public TerraformProperty<bool> RequireUppercaseCharacters
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_uppercase_characters");
        set => SetProperty("require_uppercase_characters", value);
    }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    public TerraformExpression ExpirePasswords => this["expire_passwords"];

}
