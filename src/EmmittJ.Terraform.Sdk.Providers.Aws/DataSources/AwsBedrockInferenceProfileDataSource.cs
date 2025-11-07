using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_inference_profile.
/// </summary>
public class AwsBedrockInferenceProfileDataSource : TerraformDataSource
{
    public AwsBedrockInferenceProfileDataSource(string name) : base("aws_bedrock_inference_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("description");
        this.DeclareOutput("inference_profile_arn");
        this.DeclareOutput("inference_profile_name");
        this.DeclareOutput("models");
        this.DeclareOutput("status");
        this.DeclareOutput("type");
        this.DeclareOutput("updated_at");
    }

    /// <summary>
    /// The inference_profile_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InferenceProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inference_profile_id");
        set => this.WithProperty("inference_profile_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The inference_profile_arn attribute.
    /// </summary>
    public TerraformExpression InferenceProfileArn => this["inference_profile_arn"];

    /// <summary>
    /// The inference_profile_name attribute.
    /// </summary>
    public TerraformExpression InferenceProfileName => this["inference_profile_name"];

    /// <summary>
    /// The models attribute.
    /// </summary>
    public TerraformExpression Models => this["models"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
