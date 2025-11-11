using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_security_token_service_preferences resource.
/// </summary>
public class AwsIamSecurityTokenServicePreferences : TerraformResource
{
    public AwsIamSecurityTokenServicePreferences(string name) : base("aws_iam_security_token_service_preferences", name)
    {
    }

    /// <summary>
    /// The global_endpoint_token_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalEndpointTokenVersion is required")]
    [TerraformPropertyName("global_endpoint_token_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GlobalEndpointTokenVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

}
