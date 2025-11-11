using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_studio resource.
/// </summary>
public partial class AwsEmrStudio : TerraformResource
{
    public AwsEmrStudio(string name) : base("aws_emr_studio", name)
    {
    }

    /// <summary>
    /// The auth_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthMode is required")]
    [TerraformProperty("auth_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthMode { get; set; }

    /// <summary>
    /// The default_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultS3Location is required")]
    [TerraformProperty("default_s3_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultS3Location { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The encryption_key_arn attribute.
    /// </summary>
    [TerraformProperty("encryption_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionKeyArn { get; set; }

    /// <summary>
    /// The engine_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineSecurityGroupId is required")]
    [TerraformProperty("engine_security_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineSecurityGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idp_auth_url attribute.
    /// </summary>
    [TerraformProperty("idp_auth_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdpAuthUrl { get; set; }

    /// <summary>
    /// The idp_relay_state_parameter_name attribute.
    /// </summary>
    [TerraformProperty("idp_relay_state_parameter_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdpRelayStateParameterName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformProperty("service_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [TerraformProperty("user_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserRole { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// The workspace_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceSecurityGroupId is required")]
    [TerraformProperty("workspace_security_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkspaceSecurityGroupId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
