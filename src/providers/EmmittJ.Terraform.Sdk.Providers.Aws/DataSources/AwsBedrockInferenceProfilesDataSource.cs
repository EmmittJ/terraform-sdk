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
        SetOutput("inference_profile_summaries");
        SetOutput("region");
        SetOutput("type");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The inference_profile_summaries attribute.
    /// </summary>
    public TerraformExpression InferenceProfileSummaries => this["inference_profile_summaries"];

}
