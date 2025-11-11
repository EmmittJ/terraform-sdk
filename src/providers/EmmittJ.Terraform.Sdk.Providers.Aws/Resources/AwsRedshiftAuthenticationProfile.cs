using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_authentication_profile resource.
/// </summary>
public partial class AwsRedshiftAuthenticationProfile : TerraformResource
{
    public AwsRedshiftAuthenticationProfile(string name) : base("aws_redshift_authentication_profile", name)
    {
    }

    /// <summary>
    /// The authentication_profile_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProfileContent is required")]
    [TerraformProperty("authentication_profile_content")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationProfileContent { get; set; }

    /// <summary>
    /// The authentication_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProfileName is required")]
    [TerraformProperty("authentication_profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationProfileName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
