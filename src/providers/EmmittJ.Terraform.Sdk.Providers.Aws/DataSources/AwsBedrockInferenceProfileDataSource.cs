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
        get => new TerraformReference<string>(this, "inference_profile_id");
        set => SetArgument("inference_profile_id", value);
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
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The inference_profile_arn attribute.
    /// </summary>
    public TerraformValue<string> InferenceProfileArn
    {
        get => new TerraformReference<string>(this, "inference_profile_arn");
    }

    /// <summary>
    /// The inference_profile_name attribute.
    /// </summary>
    public TerraformValue<string> InferenceProfileName
    {
        get => new TerraformReference<string>(this, "inference_profile_name");
    }

    /// <summary>
    /// The models attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Models
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "models").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
    {
        get => new TerraformReference<string>(this, "updated_at");
    }

}
