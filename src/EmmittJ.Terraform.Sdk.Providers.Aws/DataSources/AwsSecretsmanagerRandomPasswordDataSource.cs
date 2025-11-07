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
    public TerraformLiteralProperty<string>? ExcludeCharacters
    {
        get => GetProperty<TerraformLiteralProperty<string>>("exclude_characters");
        set => this.WithProperty("exclude_characters", value);
    }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExcludeLowercase
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_lowercase");
        set => this.WithProperty("exclude_lowercase", value);
    }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExcludeNumbers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_numbers");
        set => this.WithProperty("exclude_numbers", value);
    }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExcludePunctuation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_punctuation");
        set => this.WithProperty("exclude_punctuation", value);
    }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExcludeUppercase
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_uppercase");
        set => this.WithProperty("exclude_uppercase", value);
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
    /// The include_space attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IncludeSpace
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_space");
        set => this.WithProperty("include_space", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PasswordLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("password_length");
        set => this.WithProperty("password_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The require_each_included_type attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RequireEachIncludedType
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("require_each_included_type");
        set => this.WithProperty("require_each_included_type", value);
    }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    public TerraformExpression RandomPassword => this["random_password"];

}
