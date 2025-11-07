using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_evidently_project resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsEvidentlyProject : TerraformResource
{
    public AwsEvidentlyProject(string name) : base("aws_evidently_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("active_experiment_count");
        this.DeclareOutput("active_launch_count");
        this.DeclareOutput("arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("experiment_count");
        this.DeclareOutput("feature_count");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("launch_count");
        this.DeclareOutput("status");
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The active_experiment_count attribute.
    /// </summary>
    public TerraformExpression ActiveExperimentCount => this["active_experiment_count"];

    /// <summary>
    /// The active_launch_count attribute.
    /// </summary>
    public TerraformExpression ActiveLaunchCount => this["active_launch_count"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The experiment_count attribute.
    /// </summary>
    public TerraformExpression ExperimentCount => this["experiment_count"];

    /// <summary>
    /// The feature_count attribute.
    /// </summary>
    public TerraformExpression FeatureCount => this["feature_count"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The launch_count attribute.
    /// </summary>
    public TerraformExpression LaunchCount => this["launch_count"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
