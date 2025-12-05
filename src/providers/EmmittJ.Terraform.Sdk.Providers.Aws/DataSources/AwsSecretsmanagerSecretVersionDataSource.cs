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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id") ?? CreateReference("version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// The version_stage attribute.
    /// </summary>
    public TerraformValue<string>? VersionStage
    {
        get => GetArgument<TerraformValue<string>>("version_stage");
        set => SetArgument("version_stage", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => CreateReference("created_date");

    /// <summary>
    /// The secret_binary attribute.
    /// </summary>
    public TerraformValue<string> SecretBinary
        => CreateReference("secret_binary");

    /// <summary>
    /// The secret_string attribute.
    /// </summary>
    public TerraformValue<string> SecretString
        => CreateReference("secret_string");

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public TerraformSet<string> VersionStages
        => CreateReference("version_stages");

}
