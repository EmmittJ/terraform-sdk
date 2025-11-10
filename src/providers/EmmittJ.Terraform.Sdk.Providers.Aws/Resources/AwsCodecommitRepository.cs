using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codecommit_repository resource.
/// </summary>
public class AwsCodecommitRepository : TerraformResource
{
    public AwsCodecommitRepository(string name) : base("aws_codecommit_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("clone_url_http");
        SetOutput("clone_url_ssh");
        SetOutput("repository_id");
        SetOutput("default_branch");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("region");
        SetOutput("repository_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The default_branch attribute.
    /// </summary>
    public TerraformProperty<string> DefaultBranch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_branch");
        set => SetProperty("default_branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
    /// The repository_id attribute.
    /// </summary>
    public TerraformExpression RepositoryId => this["repository_id"];

}
