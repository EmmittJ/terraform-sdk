using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_macsec_key_association resource.
/// </summary>
public class AwsDxMacsecKeyAssociation : TerraformResource
{
    public AwsDxMacsecKeyAssociation(string name) : base("aws_dx_macsec_key_association", name)
    {
    }

    /// <summary>
    /// The cak attribute.
    /// </summary>
    [TerraformPropertyName("cak")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cak { get; set; }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    [TerraformPropertyName("ckn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Ckn { get; set; } = default!;

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionId { get; set; }

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
    /// The secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("secret_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SecretArn { get; set; } = default!;

    /// <summary>
    /// The start_on attribute.
    /// </summary>
    [TerraformPropertyName("start_on")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartOn => new TerraformReference(this, "start_on");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
