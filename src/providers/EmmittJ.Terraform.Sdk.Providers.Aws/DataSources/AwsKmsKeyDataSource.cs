using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_key.
/// </summary>
public partial class AwsKmsKeyDataSource : TerraformDataSource
{
    public AwsKmsKeyDataSource(string name) : base("aws_kms_key", name)
    {
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformProperty("grant_tokens")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AwsAccountId { get; }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformProperty("cloud_hsm_cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudHsmClusterId { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformProperty("custom_key_store_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomKeyStoreId { get; }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformProperty("customer_master_key_spec")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerMasterKeySpec { get; }

    /// <summary>
    /// The deletion_date attribute.
    /// </summary>
    [TerraformProperty("deletion_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeletionDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    [TerraformProperty("expiration_model")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpirationModel { get; }

    /// <summary>
    /// The key_manager attribute.
    /// </summary>
    [TerraformProperty("key_manager")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyManager { get; }

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    [TerraformProperty("key_spec")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeySpec { get; }

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    [TerraformProperty("key_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyState { get; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformProperty("key_usage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KeyUsage { get; }

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    [TerraformProperty("multi_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MultiRegion { get; }

    /// <summary>
    /// The multi_region_configuration attribute.
    /// </summary>
    [TerraformProperty("multi_region_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MultiRegionConfiguration { get; }

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [TerraformProperty("origin")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Origin { get; }

    /// <summary>
    /// The pending_deletion_window_in_days attribute.
    /// </summary>
    [TerraformProperty("pending_deletion_window_in_days")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PendingDeletionWindowInDays { get; }

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    [TerraformProperty("valid_to")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ValidTo { get; }

    /// <summary>
    /// The xks_key_configuration attribute.
    /// </summary>
    [TerraformProperty("xks_key_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> XksKeyConfiguration { get; }

}
