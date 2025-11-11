using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_custom_key_store.
/// </summary>
public partial class AwsKmsCustomKeyStoreDataSource : TerraformDataSource
{
    public AwsKmsCustomKeyStoreDataSource(string name) : base("aws_kms_custom_key_store", name)
    {
    }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformProperty("custom_key_store_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CustomKeyStoreId { get; set; }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [TerraformProperty("custom_key_store_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CustomKeyStoreName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformProperty("cloud_hsm_cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CloudHsmClusterId { get; }

    /// <summary>
    /// The connection_state attribute.
    /// </summary>
    [TerraformProperty("connection_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionState { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    [TerraformProperty("trust_anchor_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrustAnchorCertificate { get; }

}
