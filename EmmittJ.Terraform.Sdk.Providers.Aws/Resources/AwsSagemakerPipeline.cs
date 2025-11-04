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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pipeline_definition attribute.
    /// </summary>
    public string? PipelineDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_definition")?.Value;
        set => this.WithProperty("pipeline_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pipeline_description attribute.
    /// </summary>
    public string? PipelineDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_description")?.Value;
        set => this.WithProperty("pipeline_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pipeline_display_name attribute.
    /// </summary>
    public string? PipelineDisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_display_name")?.Value;
        set => this.WithProperty("pipeline_display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pipeline_name attribute.
    /// </summary>
    public string? PipelineName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pipeline_name")?.Value;
        set => this.WithProperty("pipeline_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
