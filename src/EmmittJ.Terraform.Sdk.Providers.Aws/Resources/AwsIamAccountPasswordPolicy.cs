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
    public TerraformLiteralProperty<bool>? AllowUsersToChangePassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_users_to_change_password");
        set => this.WithProperty("allow_users_to_change_password", value);
    }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HardExpiry
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hard_expiry");
        set => this.WithProperty("hard_expiry", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxPasswordAge
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_password_age");
        set => this.WithProperty("max_password_age", value);
    }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinimumPasswordLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_password_length");
        set => this.WithProperty("minimum_password_length", value);
    }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PasswordReusePrevention
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_reuse_prevention");
        set => this.WithProperty("password_reuse_prevention", value);
    }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireLowercaseCharacters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_lowercase_characters");
        set => this.WithProperty("require_lowercase_characters", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireNumbers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_numbers");
        set => this.WithProperty("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireSymbols
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_symbols");
        set => this.WithProperty("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireUppercaseCharacters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_uppercase_characters");
        set => this.WithProperty("require_uppercase_characters", value);
    }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    public TerraformExpression ExpirePasswords => this["expire_passwords"];

}
