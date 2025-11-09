using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_pipeline resource.
/// </summary>
public class AwsSagemakerPipeline : TerraformResource
{
    public AwsSagemakerPipeline(string name) : base("aws_sagemaker_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The pipeline_definition attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineDefinition
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_definition");
        set => this.WithProperty("pipeline_definition", value);
    }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineDescription
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_description");
        set => this.WithProperty("pipeline_description", value);
    }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineDisplayName
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_display_name");
        set => this.WithProperty("pipeline_display_name", value);
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public TerraformProperty<string>? PipelineName
    {
        get => GetProperty<TerraformProperty<string>>("pipeline_name");
        set => this.WithProperty("pipeline_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
