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
    public TerraformProperty<TerraformProperty<string>>? Cak { get; set; }

    /// <summary>
    /// The ckn attribute.
    /// </summary>
    [TerraformPropertyName("ckn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Ckn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ckn");

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionId is required")]
    [TerraformPropertyName("connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformPropertyName("secret_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SecretArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_arn");

    /// <summary>
    /// The start_on attribute.
    /// </summary>
    [TerraformPropertyName("start_on")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartOn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_on");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
