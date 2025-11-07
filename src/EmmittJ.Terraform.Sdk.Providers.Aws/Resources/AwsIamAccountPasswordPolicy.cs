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
        this.DeclareOutput("expire_passwords");
    }

    /// <summary>
    /// The allow_users_to_change_password attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowUsersToChangePassword
    {
        get => GetProperty<TerraformProperty<bool>>("allow_users_to_change_password");
        set => this.WithProperty("allow_users_to_change_password", value);
    }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    public TerraformProperty<bool>? HardExpiry
    {
        get => GetProperty<TerraformProperty<bool>>("hard_expiry");
        set => this.WithProperty("hard_expiry", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    public TerraformProperty<double>? MaxPasswordAge
    {
        get => GetProperty<TerraformProperty<double>>("max_password_age");
        set => this.WithProperty("max_password_age", value);
    }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumPasswordLength
    {
        get => GetProperty<TerraformProperty<double>>("minimum_password_length");
        set => this.WithProperty("minimum_password_length", value);
    }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordReusePrevention
    {
        get => GetProperty<TerraformProperty<double>>("password_reuse_prevention");
        set => this.WithProperty("password_reuse_prevention", value);
    }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireLowercaseCharacters
    {
        get => GetProperty<TerraformProperty<bool>>("require_lowercase_characters");
        set => this.WithProperty("require_lowercase_characters", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireNumbers
    {
        get => GetProperty<TerraformProperty<bool>>("require_numbers");
        set => this.WithProperty("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireSymbols
    {
        get => GetProperty<TerraformProperty<bool>>("require_symbols");
        set => this.WithProperty("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireUppercaseCharacters
    {
        get => GetProperty<TerraformProperty<bool>>("require_uppercase_characters");
        set => this.WithProperty("require_uppercase_characters", value);
    }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    public TerraformExpression ExpirePasswords => this["expire_passwords"];

}
