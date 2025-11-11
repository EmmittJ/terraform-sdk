using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_key.
/// </summary>
public class AwsKmsKeyDataSource : TerraformDataSource
{
    public AwsKmsKeyDataSource(string name) : base("aws_kms_key", name)
    {
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    [TerraformPropertyName("grant_tokens")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? GrantTokens { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AwsAccountId => new TerraformReference(this, "aws_account_id");

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_hsm_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudHsmClusterId => new TerraformReference(this, "cloud_hsm_cluster_id");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomKeyStoreId => new TerraformReference(this, "custom_key_store_id");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformPropertyName("customer_master_key_spec")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerMasterKeySpec => new TerraformReference(this, "customer_master_key_spec");

    /// <summary>
    /// The deletion_date attribute.
    /// </summary>
    [TerraformPropertyName("deletion_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeletionDate => new TerraformReference(this, "deletion_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Enabled => new TerraformReference(this, "enabled");

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    [TerraformPropertyName("expiration_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpirationModel => new TerraformReference(this, "expiration_model");

    /// <summary>
    /// The key_manager attribute.
    /// </summary>
    [TerraformPropertyName("key_manager")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyManager => new TerraformReference(this, "key_manager");

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    [TerraformPropertyName("key_spec")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeySpec => new TerraformReference(this, "key_spec");

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    [TerraformPropertyName("key_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyState => new TerraformReference(this, "key_state");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformPropertyName("key_usage")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyUsage => new TerraformReference(this, "key_usage");

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    [TerraformPropertyName("multi_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiRegion => new TerraformReference(this, "multi_region");

    /// <summary>
    /// The multi_region_configuration attribute.
    /// </summary>
    [TerraformPropertyName("multi_region_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MultiRegionConfiguration => new TerraformReference(this, "multi_region_configuration");

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [TerraformPropertyName("origin")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Origin => new TerraformReference(this, "origin");

    /// <summary>
    /// The pending_deletion_window_in_days attribute.
    /// </summary>
    [TerraformPropertyName("pending_deletion_window_in_days")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PendingDeletionWindowInDays => new TerraformReference(this, "pending_deletion_window_in_days");

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    [TerraformPropertyName("valid_to")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ValidTo => new TerraformReference(this, "valid_to");

    /// <summary>
    /// The xks_key_configuration attribute.
    /// </summary>
    [TerraformPropertyName("xks_key_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> XksKeyConfiguration => new TerraformReference(this, "xks_key_configuration");

}
