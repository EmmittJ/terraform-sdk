using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrock_foundation_models Terraform data source.
/// Retrieves information about a aws_bedrock_foundation_models.
/// </summary>
public partial class AwsBedrockFoundationModelsDataSource(string name) : TerraformDataSource("aws_bedrock_foundation_models", name)
{
    /// <summary>
    /// The by_customization_type attribute.
    /// </summary>
    public TerraformValue<string>? ByCustomizationType
    {
        get => new TerraformReference<string>(this, "by_customization_type");
        set => SetArgument("by_customization_type", value);
    }

    /// <summary>
    /// The by_inference_type attribute.
    /// </summary>
    public TerraformValue<string>? ByInferenceType
    {
        get => new TerraformReference<string>(this, "by_inference_type");
        set => SetArgument("by_inference_type", value);
    }

    /// <summary>
    /// The by_output_modality attribute.
    /// </summary>
    public TerraformValue<string>? ByOutputModality
    {
        get => new TerraformReference<string>(this, "by_output_modality");
        set => SetArgument("by_output_modality", value);
    }

    /// <summary>
    /// The by_provider attribute.
    /// </summary>
    public TerraformValue<string>? ByProvider
    {
        get => new TerraformReference<string>(this, "by_provider");
        set => SetArgument("by_provider", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The model_summaries attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ModelSummaries
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "model_summaries").ResolveNodes(ctx));
    }

}
