using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codecommit_repository.
/// </summary>
public class AwsCodecommitRepositoryDataSource : TerraformDataSource
{
    public AwsCodecommitRepositoryDataSource(string name) : base("aws_codecommit_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("clone_url_http");
        SetOutput("clone_url_ssh");
        SetOutput("kms_key_id");
        SetOutput("repository_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("repository_name");
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
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository_name");
        set => SetProperty("repository_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The clone_url_http attribute.
    /// </summary>
    public TerraformExpression CloneUrlHttp => this["clone_url_http"];

    /// <summary>
    /// The clone_url_ssh attribute.
    /// </summary>
    public TerraformExpression CloneUrlSsh => this["clone_url_ssh"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The repository_id attribute.
    /// </summary>
    public TerraformExpression RepositoryId => this["repository_id"];

}
