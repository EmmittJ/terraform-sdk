using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfrontkeyvaluestore_key Terraform resource.
/// Manages a aws_cloudfrontkeyvaluestore_key resource.
/// </summary>
public partial class AwsCloudfrontkeyvaluestoreKey(string name) : TerraformResource("aws_cloudfrontkeyvaluestore_key", name)
{
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
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    public required TerraformValue<string> KeyValueStoreArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_value_store_arn");
        set => SetArgument("key_value_store_arn", value);
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

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    public TerraformValue<double> TotalSizeInBytes
        => CreateReference("total_size_in_bytes");

}
