using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_custom_key_store.
/// </summary>
public class AwsKmsCustomKeyStoreDataSource : TerraformDataSource
{
    public AwsKmsCustomKeyStoreDataSource(string name) : base("aws_kms_custom_key_store", name)
    {
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomKeyStoreId { get; set; } = default!;

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomKeyStoreName { get; set; } = default!;

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
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_hsm_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudHsmClusterId => new TerraformReference(this, "cloud_hsm_cluster_id");

    /// <summary>
    /// The connection_state attribute.
    /// </summary>
    [TerraformPropertyName("connection_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionState => new TerraformReference(this, "connection_state");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trust_anchor_certificate")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrustAnchorCertificate => new TerraformReference(this, "trust_anchor_certificate");

}
