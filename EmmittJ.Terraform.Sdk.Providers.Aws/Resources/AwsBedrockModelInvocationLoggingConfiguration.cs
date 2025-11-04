using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrock_model_invocation_logging_configuration resource.
/// </summary>
public class AwsBedrockModelInvocationLoggingConfiguration : TerraformResource
{
    public AwsBedrockModelInvocationLoggingConfiguration(string name) : base("aws_bedrock_model_invocation_logging_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
