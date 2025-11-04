using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_inference_profiles.
/// </summary>
public class AwsBedrockInferenceProfilesDataSource : TerraformDataSource
{
    public AwsBedrockInferenceProfilesDataSource(string name) : base("aws_bedrock_inference_profiles", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("inference_profile_summaries");
    }

    /// <summary>
    /// The inference_profile_summaries attribute.
    /// </summary>
    public TerraformExpression InferenceProfileSummaries => this["inference_profile_summaries"];

}
