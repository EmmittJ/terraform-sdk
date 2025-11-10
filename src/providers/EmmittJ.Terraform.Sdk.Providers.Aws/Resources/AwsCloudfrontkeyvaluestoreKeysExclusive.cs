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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        SetOutput("total_size_in_bytes");
        SetOutput("key_value_store_arn");
        SetOutput("max_batch_size");
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    public required TerraformProperty<string> KeyValueStoreArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_value_store_arn");
        set => SetProperty("key_value_store_arn", value);
    }

    /// <summary>
    /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
    /// </summary>
    public TerraformProperty<double> MaxBatchSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_batch_size");
        set => SetProperty("max_batch_size", value);
    }

    /// <summary>
    /// Block for resource_key_value_pair.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock>? ResourceKeyValuePair
    {
        set => SetProperty("resource_key_value_pair", value);
    }

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    public TerraformExpression TotalSizeInBytes => this["total_size_in_bytes"];

}
