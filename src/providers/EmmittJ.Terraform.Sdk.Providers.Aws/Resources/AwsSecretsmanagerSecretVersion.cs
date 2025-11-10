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
        SetOutput("arn");
        SetOutput("has_secret_string_wo");
        SetOutput("version_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("secret_binary");
        SetOutput("secret_id");
        SetOutput("secret_string");
        SetOutput("secret_string_wo");
        SetOutput("secret_string_wo_version");
        SetOutput("version_stages");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    public TerraformProperty<string> SecretBinary
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_binary");
        set => SetProperty("secret_binary", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_id");
        set => SetProperty("secret_id", value);
    }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public TerraformProperty<string> SecretString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_string");
        set => SetProperty("secret_string", value);
    }

    /// <summary>
    /// The secret_string_wo attribute.
    /// </summary>
    public TerraformProperty<string> SecretStringWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_string_wo");
        set => SetProperty("secret_string_wo", value);
    }

    /// <summary>
    /// The secret_string_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> SecretStringWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("secret_string_wo_version");
        set => SetProperty("secret_string_wo_version", value);
    }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VersionStages
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("version_stages");
        set => SetProperty("version_stages", value);
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
