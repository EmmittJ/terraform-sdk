using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_key_pair resource.
/// </summary>
public class AwsLightsailKeyPair : TerraformResource
{
    public AwsLightsailKeyPair(string name) : base("aws_lightsail_key_pair", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    [TerraformPropertyName("pgp_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PgpKey { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_key");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The encrypted_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("encrypted_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptedFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encrypted_fingerprint");

    /// <summary>
    /// The encrypted_private_key attribute.
    /// </summary>
    [TerraformPropertyName("encrypted_private_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptedPrivateKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encrypted_private_key");

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_key");

}
