using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_secretsmanager_secret_version Terraform data source.
/// Retrieves information about a aws_secretsmanager_secret_version.
/// </summary>
public partial class AwsSecretsmanagerSecretVersionDataSource(string name) : TerraformDataSource("aws_secretsmanager_secret_version", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => new TerraformReference<string>(this, "secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    public TerraformValue<string>? VersionStage
    {
        get => new TerraformReference<string>(this, "version_stage");
        set => SetArgument("version_stage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    public TerraformValue<string> SecretBinary
    {
        get => new TerraformReference<string>(this, "secret_binary");
    }

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public TerraformValue<string> SecretString
    {
        get => new TerraformReference<string>(this, "secret_string");
    }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public TerraformSet<string> VersionStages
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "version_stages").ResolveNodes(ctx));
    }

}
