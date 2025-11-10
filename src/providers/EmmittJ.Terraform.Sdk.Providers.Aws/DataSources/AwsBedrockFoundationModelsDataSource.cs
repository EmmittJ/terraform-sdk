using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_foundation_models.
/// </summary>
public class AwsBedrockFoundationModelsDataSource : TerraformDataSource
{
    public AwsBedrockFoundationModelsDataSource(string name) : base("aws_bedrock_foundation_models", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
        this.WithOutput("model_summaries");
    }

    /// <summary>
    /// The by_customization_type attribute.
    /// </summary>
    public TerraformProperty<string>? ByCustomizationType
    {
        get => GetProperty<TerraformProperty<string>>("by_customization_type");
        set => this.WithProperty("by_customization_type", value);
    }

    /// <summary>
    /// The by_inference_type attribute.
    /// </summary>
    public TerraformProperty<string>? ByInferenceType
    {
        get => GetProperty<TerraformProperty<string>>("by_inference_type");
        set => this.WithProperty("by_inference_type", value);
    }

    /// <summary>
    /// The by_output_modality attribute.
    /// </summary>
    public TerraformProperty<string>? ByOutputModality
    {
        get => GetProperty<TerraformProperty<string>>("by_output_modality");
        set => this.WithProperty("by_output_modality", value);
    }

    /// <summary>
    /// The by_provider attribute.
    /// </summary>
    public TerraformProperty<string>? ByProvider
    {
        get => GetProperty<TerraformProperty<string>>("by_provider");
        set => this.WithProperty("by_provider", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The model_summaries attribute.
    /// </summary>
    public TerraformExpression ModelSummaries => this["model_summaries"];

}
