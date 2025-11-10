using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_delivery in .
/// Nesting mode: list
/// </summary>
public class AwsEvidentlyProjectDataDeliveryBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEvidentlyProjectTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_evidently_project resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEvidentlyProject : TerraformResource
{
    public AwsEvidentlyProject(string name) : base("aws_evidently_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("active_experiment_count");
        this.WithOutput("active_launch_count");
        this.WithOutput("arn");
        this.WithOutput("created_time");
        this.WithOutput("experiment_count");
        this.WithOutput("feature_count");
        this.WithOutput("last_updated_time");
        this.WithOutput("launch_count");
        this.WithOutput("status");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Block for data_delivery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataDelivery block(s) allowed")]
    public List<AwsEvidentlyProjectDataDeliveryBlock>? DataDelivery
    {
        get => GetProperty<List<AwsEvidentlyProjectDataDeliveryBlock>>("data_delivery");
        set => this.WithProperty("data_delivery", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEvidentlyProjectTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEvidentlyProjectTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
