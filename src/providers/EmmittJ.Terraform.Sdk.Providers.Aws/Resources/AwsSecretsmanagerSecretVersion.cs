using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_secretsmanager_secret_version Terraform resource.
/// Manages a aws_secretsmanager_secret_version resource.
/// </summary>
public partial class AwsSecretsmanagerSecretVersion(string name) : TerraformResource("aws_secretsmanager_secret_version", name)
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
    /// The secret_binary attribute.
    /// </summary>
    public TerraformValue<string>? SecretBinary
    {
        get => GetArgument<TerraformValue<string>>("secret_binary");
        set => SetArgument("secret_binary", value);
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
    /// The secret_string attribute.
    /// </summary>
    public TerraformValue<string>? SecretString
    {
        get => GetArgument<TerraformValue<string>>("secret_string");
        set => SetArgument("secret_string", value);
    }

    /// <summary>
    /// The secret_string_wo attribute.
    /// </summary>
    public TerraformValue<string>? SecretStringWo
    {
        get => GetArgument<TerraformValue<string>>("secret_string_wo");
        set => SetArgument("secret_string_wo", value);
    }

    /// <summary>
    /// The secret_string_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? SecretStringWoVersion
    {
        get => GetArgument<TerraformValue<double>>("secret_string_wo_version");
        set => SetArgument("secret_string_wo_version", value);
    }

    /// <summary>
    /// The version_stages attribute.
    /// </summary>
    public TerraformSet<string> VersionStages
    {
        get => GetArgument<TerraformSet<string>>("version_stages") ?? CreateReference("version_stages");
        set => SetArgument("version_stages", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The has_secret_string_wo attribute.
    /// </summary>
    public TerraformValue<bool> HasSecretStringWo
        => CreateReference("has_secret_string_wo");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
        => CreateReference("version_id");

}
