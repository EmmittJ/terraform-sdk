using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_key_value_pair in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock : ITerraformBlock
{
    /// <summary>
    /// The key to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Manages a aws_cloudfrontkeyvaluestore_keys_exclusive resource.
/// </summary>
public class AwsCloudfrontkeyvaluestoreKeysExclusive : TerraformResource
{
    public AwsCloudfrontkeyvaluestoreKeysExclusive(string name) : base("aws_cloudfrontkeyvaluestore_keys_exclusive", name)
    {
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    [TerraformPropertyName("key_value_store_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyValueStoreArn { get; set; }

    /// <summary>
    /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
    /// </summary>
    [TerraformPropertyName("max_batch_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxBatchSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_batch_size");

    /// <summary>
    /// Block for resource_key_value_pair.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("resource_key_value_pair")]
    public TerraformSet<TerraformBlock<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock>>? ResourceKeyValuePair { get; set; } = new();

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    [TerraformPropertyName("total_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalSizeInBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_size_in_bytes");

}
