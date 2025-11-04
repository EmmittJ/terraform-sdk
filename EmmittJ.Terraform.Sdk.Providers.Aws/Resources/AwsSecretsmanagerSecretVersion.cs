using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_secret_version resource.
/// </summary>
public class AwsSecretsmanagerSecretVersion : TerraformResource
{
    public AwsSecretsmanagerSecretVersion(string name) : base("aws_secretsmanager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("has_secret_string_wo");
        this.DeclareOutput("version_id");
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
    /// The secret_binary attribute.
    /// </summary>
    public string? SecretBinary
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_binary")?.Value;
        set => this.WithProperty("secret_binary", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public string? SecretId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_id")?.Value;
        set => this.WithProperty("secret_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public string? SecretString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_string")?.Value;
        set => this.WithProperty("secret_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_string_wo attribute.
    /// </summary>
    public string? SecretStringWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secret_string_wo")?.Value;
        set => this.WithProperty("secret_string_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secret_string_wo_version attribute.
    /// </summary>
    public double? SecretStringWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("secret_string_wo_version")?.Value;
        set => this.WithProperty("secret_string_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public HashSet<string>? VersionStages
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("version_stages")?.Value;
        set => this.WithProperty("version_stages", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The has_secret_string_wo attribute.
    /// </summary>
    public TerraformExpression HasSecretStringWo => this["has_secret_string_wo"];

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
