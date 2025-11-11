using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_custom_models.
/// </summary>
public partial class AwsBedrockCustomModelsDataSource : TerraformDataSource
{
    public AwsBedrockCustomModelsDataSource(string name) : base("aws_bedrock_custom_models", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The model_summaries attribute.
    /// </summary>
    [TerraformProperty("model_summaries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ModelSummaries { get; }

}
