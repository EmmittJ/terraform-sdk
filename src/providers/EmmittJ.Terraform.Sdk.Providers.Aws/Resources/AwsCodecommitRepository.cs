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
        this.WithOutputrn");
        this.WithOutputlone_url_http");
        this.WithOutputlone_url_ssh");
        this.WithOutputepository_id");
    }

    /// <summary>
    /// The default_branch attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultBranch
    {
        get => GetProperty<TerraformProperty<string>>("default_branch");
        set => this.WithProperty("default_branch", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => this.WithProperty("repository_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
