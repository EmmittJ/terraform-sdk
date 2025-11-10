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
        SetOutput("created_at");
        SetOutput("description");
        SetOutput("inference_profile_arn");
        SetOutput("inference_profile_name");
        SetOutput("models");
        SetOutput("status");
        SetOutput("type");
        SetOutput("updated_at");
        SetOutput("inference_profile_id");
        SetOutput("region");
    }

    /// <summary>
    /// The inference_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InferenceProfileId is required")]
    public required TerraformProperty<string> InferenceProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("inference_profile_id");
        set => SetProperty("inference_profile_id", value);
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
