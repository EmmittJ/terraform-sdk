using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_apns_voip_sandbox_channel resource.
/// </summary>
public class AwsPinpointApnsVoipSandboxChannel : TerraformResource
{
    public AwsPinpointApnsVoipSandboxChannel(string name) : base("aws_pinpoint_apns_voip_sandbox_channel", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformPropertyName("bundle_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BundleId { get; set; }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Certificate { get; set; }

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
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    [TerraformPropertyName("team_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TeamId { get; set; }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    [TerraformPropertyName("token_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TokenKey { get; set; }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    [TerraformPropertyName("token_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TokenKeyId { get; set; }

}
