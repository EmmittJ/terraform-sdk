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
    public TerraformProperty<List<TerraformProperty<string>>>? GrantTokens { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformPropertyName("key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AwsAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_hsm_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CloudHsmClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cloud_hsm_cluster_id");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomKeyStoreId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_key_store_id");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    [TerraformPropertyName("customer_master_key_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerMasterKeySpec => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_master_key_spec");

    /// <summary>
    /// The deletion_date attribute.
    /// </summary>
    [TerraformPropertyName("deletion_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_date");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enabled");

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    [TerraformPropertyName("expiration_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_model");

    /// <summary>
    /// The key_manager attribute.
    /// </summary>
    [TerraformPropertyName("key_manager")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyManager => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_manager");

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    [TerraformPropertyName("key_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeySpec => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_spec");

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    [TerraformPropertyName("key_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_state");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [TerraformPropertyName("key_usage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KeyUsage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_usage");

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    [TerraformPropertyName("multi_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MultiRegion => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "multi_region");

    /// <summary>
    /// The multi_region_configuration attribute.
    /// </summary>
    [TerraformPropertyName("multi_region_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MultiRegionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "multi_region_configuration");

    /// <summary>
    /// The origin attribute.
    /// </summary>
    [TerraformPropertyName("origin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Origin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "origin");

    /// <summary>
    /// The pending_deletion_window_in_days attribute.
    /// </summary>
    [TerraformPropertyName("pending_deletion_window_in_days")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PendingDeletionWindowInDays => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "pending_deletion_window_in_days");

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    [TerraformPropertyName("valid_to")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidTo => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_to");

    /// <summary>
    /// The xks_key_configuration attribute.
    /// </summary>
    [TerraformPropertyName("xks_key_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> XksKeyConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "xks_key_configuration");

}
