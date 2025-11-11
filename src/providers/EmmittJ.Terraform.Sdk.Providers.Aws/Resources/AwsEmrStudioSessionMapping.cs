using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_studio_session_mapping resource.
/// </summary>
public partial class AwsEmrStudioSessionMapping : TerraformResource
{
    public AwsEmrStudioSessionMapping(string name) : base("aws_emr_studio_session_mapping", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformProperty("identity_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IdentityId { get; set; }

    /// <summary>
    /// The identity_name attribute.
    /// </summary>
    [TerraformProperty("identity_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> IdentityName { get; set; }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityType is required")]
    [TerraformProperty("identity_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The session_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionPolicyArn is required")]
    [TerraformProperty("session_policy_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SessionPolicyArn { get; set; }

    /// <summary>
    /// The studio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioId is required")]
    [TerraformProperty("studio_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StudioId { get; set; }

}
