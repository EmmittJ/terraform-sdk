using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrock_foundation_model Terraform data source.
/// Retrieves information about a aws_bedrock_foundation_model.
/// </summary>
public partial class AwsBedrockFoundationModelDataSource(string name) : TerraformDataSource("aws_bedrock_foundation_model", name)
{
    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    public required TerraformValue<string> ModelId
    {
        get => GetRequiredArgument<TerraformValue<string>>("model_id");
        set => SetArgument("model_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The customizations_supported attribute.
    /// </summary>
    public TerraformSet<string> CustomizationsSupported
        => CreateReference("customizations_supported");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The inference_types_supported attribute.
    /// </summary>
    public TerraformSet<string> InferenceTypesSupported
        => CreateReference("inference_types_supported");

    /// <summary>
    /// The input_modalities attribute.
    /// </summary>
    public TerraformSet<string> InputModalities
        => CreateReference("input_modalities");

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformValue<string> ModelArn
        => CreateReference("model_arn");

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    public TerraformValue<string> ModelName
        => CreateReference("model_name");

    /// <summary>
    /// The output_modalities attribute.
    /// </summary>
    public TerraformSet<string> OutputModalities
        => CreateReference("output_modalities");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
        => CreateReference("provider_name");

    /// <summary>
    /// The response_streaming_supported attribute.
    /// </summary>
    public TerraformValue<bool> ResponseStreamingSupported
        => CreateReference("response_streaming_supported");

}
