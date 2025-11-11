using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_key_pair resource.
/// </summary>
public partial class AwsKeyPair : TerraformResource
{
    public AwsKeyPair(string name) : base("aws_key_pair", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyName { get; set; }

    /// <summary>
    /// The key_name_prefix attribute.
    /// </summary>
    [TerraformProperty("key_name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyNamePrefix { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformProperty("public_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PublicKey { get; set; }

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
    /// The fingerprint attribute.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The key_pair_id attribute.
    /// </summary>
    [TerraformProperty("key_pair_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyPairId { get; }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [TerraformProperty("key_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyType { get; }

}
