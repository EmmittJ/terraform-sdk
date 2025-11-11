using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_apns_voip_channel resource.
/// </summary>
public partial class AwsPinpointApnsVoipChannel : TerraformResource
{
    public AwsPinpointApnsVoipChannel(string name) : base("aws_pinpoint_apns_voip_channel", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformProperty("bundle_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BundleId { get; set; }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    [TerraformProperty("default_authentication_method")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultAuthenticationMethod { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformProperty("private_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The team_id attribute.
    /// </summary>
    [TerraformProperty("team_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TeamId { get; set; }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    [TerraformProperty("token_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TokenKey { get; set; }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    [TerraformProperty("token_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TokenKeyId { get; set; }

}
