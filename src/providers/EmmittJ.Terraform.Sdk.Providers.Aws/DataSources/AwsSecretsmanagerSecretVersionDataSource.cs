using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_secretsmanager_secret_version.
/// </summary>
public class AwsSecretsmanagerSecretVersionDataSource : TerraformDataSource
{
    public AwsSecretsmanagerSecretVersionDataSource(string name) : base("aws_secretsmanager_secret_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_date");
        SetOutput("secret_binary");
        SetOutput("secret_string");
        SetOutput("version_stages");
        SetOutput("id");
        SetOutput("region");
        SetOutput("secret_id");
        SetOutput("version_id");
        SetOutput("version_stage");
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
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_id");
        set => SetProperty("secret_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string> VersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_id");
        set => SetProperty("version_id", value);
    }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    public TerraformProperty<string> VersionStage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_stage");
        set => SetProperty("version_stage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    public TerraformExpression SecretBinary => this["secret_binary"];

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public TerraformExpression SecretString => this["secret_string"];

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public TerraformExpression VersionStages => this["version_stages"];

}
