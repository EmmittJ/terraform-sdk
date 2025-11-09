using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codedeploy_app resource.
/// </summary>
public class AwsCodedeployApp : TerraformResource
{
    public AwsCodedeployApp(string name) : base("aws_codedeploy_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("github_account_name");
        this.DeclareOutput("linked_to_github");
    }

    /// <summary>
    /// The compute_platform attribute.
    /// </summary>
    public TerraformProperty<string>? ComputePlatform
    {
        get => GetProperty<TerraformProperty<string>>("compute_platform");
        set => this.WithProperty("compute_platform", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformExpression ApplicationId => this["application_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The github_account_name attribute.
    /// </summary>
    public TerraformExpression GithubAccountName => this["github_account_name"];

    /// <summary>
    /// The linked_to_github attribute.
    /// </summary>
    public TerraformExpression LinkedToGithub => this["linked_to_github"];

}
