using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_foundation_model.
/// </summary>
public class AwsBedrockFoundationModelDataSource : TerraformDataSource
{
    public AwsBedrockFoundationModelDataSource(string name) : base("aws_bedrock_foundation_model", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("customizations_supported");
        this.WithOutput("id");
        this.WithOutput("inference_types_supported");
        this.WithOutput("input_modalities");
        this.WithOutput("model_arn");
        this.WithOutput("model_name");
        this.WithOutput("output_modalities");
        this.WithOutput("provider_name");
        this.WithOutput("response_streaming_supported");
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformProperty<string> ModelId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("model_id");
        set => this.WithProperty("model_id", value);
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
    /// The customizations_supported attribute.
    /// </summary>
    public TerraformExpression CustomizationsSupported => this["customizations_supported"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The inference_types_supported attribute.
    /// </summary>
    public TerraformExpression InferenceTypesSupported => this["inference_types_supported"];

    /// <summary>
    /// The input_modalities attribute.
    /// </summary>
    public TerraformExpression InputModalities => this["input_modalities"];

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformExpression ModelArn => this["model_arn"];

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    public TerraformExpression ModelName => this["model_name"];

    /// <summary>
    /// The output_modalities attribute.
    /// </summary>
    public TerraformExpression OutputModalities => this["output_modalities"];

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformExpression ProviderName => this["provider_name"];

    /// <summary>
    /// The response_streaming_supported attribute.
    /// </summary>
    public TerraformExpression ResponseStreamingSupported => this["response_streaming_supported"];

}
