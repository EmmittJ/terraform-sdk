using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_key_value_pair in .
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock : TerraformBlock
{
    /// <summary>
    /// The key to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Manages a aws_cloudfrontkeyvaluestore_keys_exclusive resource.
/// </summary>
public class AwsCloudfrontkeyvaluestoreKeysExclusive : TerraformResource
{
    public AwsCloudfrontkeyvaluestoreKeysExclusive(string name) : base("aws_cloudfrontkeyvaluestore_keys_exclusive", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("total_size_in_bytes");
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    public required TerraformProperty<string> KeyValueStoreArn
    {
        get => GetProperty<TerraformProperty<string>>("key_value_store_arn");
        set => this.WithProperty("key_value_store_arn", value);
    }

    /// <summary>
    /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
    /// </summary>
    public TerraformProperty<double>? MaxBatchSize
    {
        get => GetProperty<TerraformProperty<double>>("max_batch_size");
        set => this.WithProperty("max_batch_size", value);
    }

    /// <summary>
    /// Block for resource_key_value_pair.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock>? ResourceKeyValuePair
    {
        get => GetProperty<HashSet<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock>>("resource_key_value_pair");
        set => this.WithProperty("resource_key_value_pair", value);
    }

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    public TerraformExpression TotalSizeInBytes => this["total_size_in_bytes"];

}
