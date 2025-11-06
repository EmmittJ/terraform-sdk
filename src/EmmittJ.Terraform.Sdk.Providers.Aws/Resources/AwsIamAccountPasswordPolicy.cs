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
    public bool? AllowUsersToChangePassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_users_to_change_password")?.Value;
        set => this.WithProperty("allow_users_to_change_password", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hard_expiry attribute.
    /// </summary>
    public bool? HardExpiry
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hard_expiry")?.Value;
        set => this.WithProperty("hard_expiry", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_password_age attribute.
    /// </summary>
    public double? MaxPasswordAge
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_password_age")?.Value;
        set => this.WithProperty("max_password_age", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The minimum_password_length attribute.
    /// </summary>
    public double? MinimumPasswordLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("minimum_password_length")?.Value;
        set => this.WithProperty("minimum_password_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The password_reuse_prevention attribute.
    /// </summary>
    public double? PasswordReusePrevention
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_reuse_prevention")?.Value;
        set => this.WithProperty("password_reuse_prevention", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The require_lowercase_characters attribute.
    /// </summary>
    public bool? RequireLowercaseCharacters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_lowercase_characters")?.Value;
        set => this.WithProperty("require_lowercase_characters", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public bool? RequireNumbers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_numbers")?.Value;
        set => this.WithProperty("require_numbers", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public bool? RequireSymbols
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_symbols")?.Value;
        set => this.WithProperty("require_symbols", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The require_uppercase_characters attribute.
    /// </summary>
    public bool? RequireUppercaseCharacters
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_uppercase_characters")?.Value;
        set => this.WithProperty("require_uppercase_characters", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The expire_passwords attribute.
    /// </summary>
    public TerraformExpression ExpirePasswords => this["expire_passwords"];

}
