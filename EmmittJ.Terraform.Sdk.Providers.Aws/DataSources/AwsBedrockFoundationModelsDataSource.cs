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
        this.DeclareOutput("id");
        this.DeclareOutput("model_summaries");
    }

    /// <summary>
    /// The by_customization_type attribute.
    /// </summary>
    public string? ByCustomizationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("by_customization_type")?.Value;
        set => this.WithProperty("by_customization_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The by_inference_type attribute.
    /// </summary>
    public string? ByInferenceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("by_inference_type")?.Value;
        set => this.WithProperty("by_inference_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The by_output_modality attribute.
    /// </summary>
    public string? ByOutputModality
    {
        get => GetProperty<TerraformLiteralProperty<string>>("by_output_modality")?.Value;
        set => this.WithProperty("by_output_modality", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The by_provider attribute.
    /// </summary>
    public string? ByProvider
    {
        get => GetProperty<TerraformLiteralProperty<string>>("by_provider")?.Value;
        set => this.WithProperty("by_provider", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
