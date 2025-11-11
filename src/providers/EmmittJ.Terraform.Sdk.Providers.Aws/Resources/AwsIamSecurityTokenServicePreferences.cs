using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_security_token_service_preferences resource.
/// </summary>
public partial class AwsIamSecurityTokenServicePreferences : TerraformResource
{
    public AwsIamSecurityTokenServicePreferences(string name) : base("aws_iam_security_token_service_preferences", name)
    {
    }

    /// <summary>
    /// The global_endpoint_token_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalEndpointTokenVersion is required")]
    [TerraformProperty("global_endpoint_token_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GlobalEndpointTokenVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

}
