using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_key_value_pair in AwsCloudfrontkeyvaluestoreKeysExclusive.
/// Nesting mode: set
/// </summary>
public class AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_key_value_pair";

    /// <summary>
    /// The key to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_cloudfrontkeyvaluestore_keys_exclusive Terraform resource.
/// Manages a aws_cloudfrontkeyvaluestore_keys_exclusive resource.
/// </summary>
public partial class AwsCloudfrontkeyvaluestoreKeysExclusive(string name) : TerraformResource("aws_cloudfrontkeyvaluestore_keys_exclusive", name)
{
    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    public required TerraformValue<string> KeyValueStoreArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_value_store_arn");
        set => SetArgument("key_value_store_arn", value);
    }

    /// <summary>
    /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
    /// </summary>
    public TerraformValue<double> MaxBatchSize
    {
        get => GetArgument<TerraformValue<double>>("max_batch_size") ?? AsReference("max_batch_size");
        set => SetArgument("max_batch_size", value);
    }

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    public TerraformValue<double> TotalSizeInBytes
        => AsReference("total_size_in_bytes");

    /// <summary>
    /// ResourceKeyValuePair block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock>? ResourceKeyValuePair
    {
        get => GetArgument<TerraformSet<AwsCloudfrontkeyvaluestoreKeysExclusiveResourceKeyValuePairBlock>>("resource_key_value_pair");
        set => SetArgument("resource_key_value_pair", value);
    }

}
