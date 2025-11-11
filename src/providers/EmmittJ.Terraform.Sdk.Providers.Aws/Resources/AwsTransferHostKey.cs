using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_host_key resource.
/// </summary>
public partial class AwsTransferHostKey : TerraformResource
{
    public AwsTransferHostKey(string name) : base("aws_transfer_host_key", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The host_key_body attribute.
    /// </summary>
    [TerraformProperty("host_key_body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostKeyBody { get; set; }

    /// <summary>
    /// The host_key_body_wo attribute.
    /// </summary>
    [TerraformProperty("host_key_body_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostKeyBodyWo { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    [TerraformProperty("host_key_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostKeyFingerprint { get; }

    /// <summary>
    /// The host_key_id attribute.
    /// </summary>
    [TerraformProperty("host_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostKeyId { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
