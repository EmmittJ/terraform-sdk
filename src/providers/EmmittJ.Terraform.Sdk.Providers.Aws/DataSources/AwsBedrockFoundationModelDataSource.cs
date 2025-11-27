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
        get => new TerraformReference<string>(this, "model_id");
        set => SetArgument("model_id", value);
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
    /// The customizations_supported attribute.
    /// </summary>
    public TerraformSet<string> CustomizationsSupported
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "customizations_supported").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The inference_types_supported attribute.
    /// </summary>
    public TerraformSet<string> InferenceTypesSupported
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "inference_types_supported").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_modalities attribute.
    /// </summary>
    public TerraformSet<string> InputModalities
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "input_modalities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformValue<string> ModelArn
    {
        get => new TerraformReference<string>(this, "model_arn");
    }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    public TerraformValue<string> ModelName
    {
        get => new TerraformReference<string>(this, "model_name");
    }

    /// <summary>
    /// The output_modalities attribute.
    /// </summary>
    public TerraformSet<string> OutputModalities
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "output_modalities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
    }

    /// <summary>
    /// The response_streaming_supported attribute.
    /// </summary>
    public TerraformValue<bool> ResponseStreamingSupported
    {
        get => new TerraformReference<bool>(this, "response_streaming_supported");
    }

}
