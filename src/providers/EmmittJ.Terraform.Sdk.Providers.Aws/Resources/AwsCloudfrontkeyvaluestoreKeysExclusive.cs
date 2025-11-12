using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_key_value_pair in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock() : TerraformBlock("resource_key_value_pair")
{
    /// <summary>
    /// The key to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_cloudfrontkeyvaluestore_keys_exclusive resource.
/// </summary>
public partial class AwsCloudfrontkeyvaluestoreKeysExclusive : TerraformResource
{
    public AwsCloudfrontkeyvaluestoreKeysExclusive(string name) : base("aws_cloudfrontkeyvaluestore_keys_exclusive", name)
    {
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    [TerraformProperty("key_value_store_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyValueStoreArn { get; set; }

    /// <summary>
    /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
    /// </summary>
    [TerraformProperty("max_batch_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxBatchSize { get; set; }

    /// <summary>
    /// Block for resource_key_value_pair.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("resource_key_value_pair")]
    public TerraformSet<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock> ResourceKeyValuePair { get; set; } = new();

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    [TerraformProperty("total_size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TotalSizeInBytes { get; }

}
