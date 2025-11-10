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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomKeyStoreId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_key_store_id");

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomKeyStoreName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_key_store_name");

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
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_hsm_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudHsmClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloud_hsm_cluster_id");

    /// <summary>
    /// The connection_state attribute.
    /// </summary>
    [TerraformPropertyName("connection_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_state");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trust_anchor_certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustAnchorCertificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_anchor_certificate");

}
