using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_random_password.
/// </summary>
public class AwsSecretsmanagerRandomPasswordDataSource : TerraformDataSource
{
    public AwsSecretsmanagerRandomPasswordDataSource(string name) : base("aws_secretsmanager_random_password", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("random_password");
    }

    /// <summary>
    /// The exclude_characters attribute.
    /// </summary>
    public string? ExcludeCharacters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("exclude_characters")?.Value;
        set => this.WithProperty("exclude_characters", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    public bool? ExcludeLowercase
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_lowercase")?.Value;
        set => this.WithProperty("exclude_lowercase", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    public bool? ExcludeNumbers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_numbers")?.Value;
        set => this.WithProperty("exclude_numbers", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    public bool? ExcludePunctuation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_punctuation")?.Value;
        set => this.WithProperty("exclude_punctuation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    public bool? ExcludeUppercase
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_uppercase")?.Value;
        set => this.WithProperty("exclude_uppercase", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The include_space attribute.
    /// </summary>
    public bool? IncludeSpace
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_space")?.Value;
        set => this.WithProperty("include_space", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public double? PasswordLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_length")?.Value;
        set => this.WithProperty("password_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The require_each_included_type attribute.
    /// </summary>
    public bool? RequireEachIncludedType
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_each_included_type")?.Value;
        set => this.WithProperty("require_each_included_type", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    public TerraformExpression RandomPassword => this["random_password"];

}
