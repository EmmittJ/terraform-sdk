using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_custom_models.
/// </summary>
public class AwsBedrockCustomModelsDataSource : TerraformDataSource
{
    public AwsBedrockCustomModelsDataSource(string name) : base("aws_bedrock_custom_models", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("model_summaries");
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
