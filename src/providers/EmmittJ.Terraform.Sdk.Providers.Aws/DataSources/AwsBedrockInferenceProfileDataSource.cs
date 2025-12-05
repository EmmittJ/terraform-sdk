using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_bedrock_inference_profile Terraform data source.
/// Retrieves information about a aws_bedrock_inference_profile.
/// </summary>
public partial class AwsBedrockInferenceProfileDataSource(string name) : TerraformDataSource("aws_bedrock_inference_profile", name)
{
    /// <summary>
    /// The inference_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InferenceProfileId is required")]
    public required TerraformValue<string> InferenceProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("inference_profile_id");
        set => SetArgument("inference_profile_id", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The inference_profile_arn attribute.
    /// </summary>
    public TerraformValue<string> InferenceProfileArn
        => CreateReference("inference_profile_arn");

    /// <summary>
    /// The inference_profile_name attribute.
    /// </summary>
    public TerraformValue<string> InferenceProfileName
        => CreateReference("inference_profile_name");

    /// <summary>
    /// The models attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Models
        => CreateReference("models");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => CreateReference("updated_at");

}
