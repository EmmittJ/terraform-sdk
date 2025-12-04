using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codecommit_repository Terraform data source.
/// Retrieves information about a aws_codecommit_repository.
/// </summary>
public partial class AwsCodecommitRepositoryDataSource(string name) : TerraformDataSource("aws_codecommit_repository", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The clone_url_http attribute.
    /// </summary>
    public TerraformValue<string> CloneUrlHttp
        => AsReference("clone_url_http");

    /// <summary>
    /// The clone_url_ssh attribute.
    /// </summary>
    public TerraformValue<string> CloneUrlSsh
        => AsReference("clone_url_ssh");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    public TerraformValue<string> RepositoryId
        => AsReference("repository_id");

}
