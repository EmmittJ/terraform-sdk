using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_gcm_channel resource.
/// </summary>
public class AwsPinpointGcmChannel : TerraformResource
{
    public AwsPinpointGcmChannel(string name) : base("aws_pinpoint_gcm_channel", name)
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformPropertyName("api_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApiKey { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    [TerraformPropertyName("default_authentication_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultAuthenticationMethod { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service_json attribute.
    /// </summary>
    [TerraformPropertyName("service_json")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceJson { get; set; }

}
