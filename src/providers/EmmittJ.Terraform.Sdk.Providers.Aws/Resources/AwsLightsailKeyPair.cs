using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_key_pair resource.
/// </summary>
public partial class AwsLightsailKeyPair : TerraformResource
{
    public AwsLightsailKeyPair(string name) : base("aws_lightsail_key_pair", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    [TerraformProperty("pgp_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PgpKey { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PublicKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The encrypted_fingerprint attribute.
    /// </summary>
    [TerraformProperty("encrypted_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptedFingerprint { get; }

    /// <summary>
    /// The encrypted_private_key attribute.
    /// </summary>
    [TerraformProperty("encrypted_private_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptedPrivateKey { get; }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformProperty("private_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrivateKey { get; }

}
