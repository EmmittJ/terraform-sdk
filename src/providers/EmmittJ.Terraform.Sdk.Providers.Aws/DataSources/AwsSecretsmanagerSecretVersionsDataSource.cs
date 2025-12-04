using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_secretsmanager_secret_versions Terraform data source.
/// Retrieves information about a aws_secretsmanager_secret_versions.
/// </summary>
public partial class AwsSecretsmanagerSecretVersionsDataSource(string name) : TerraformDataSource("aws_secretsmanager_secret_versions", name)
{
    /// <summary>
    /// The include_deprecated attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeprecated
    {
        get => GetArgument<TerraformValue<bool>>("include_deprecated");
        set => SetArgument("include_deprecated", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Versions
        => AsReference("versions");

}
