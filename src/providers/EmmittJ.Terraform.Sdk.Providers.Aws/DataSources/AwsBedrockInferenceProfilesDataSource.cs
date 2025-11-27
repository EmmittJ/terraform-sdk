using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrock_inference_profiles Terraform data source.
/// Retrieves information about a aws_bedrock_inference_profiles.
/// </summary>
public partial class AwsBedrockInferenceProfilesDataSource(string name) : TerraformDataSource("aws_bedrock_inference_profiles", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The inference_profile_summaries attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InferenceProfileSummaries
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "inference_profile_summaries").ResolveNodes(ctx));
    }

}
