using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfrontkeyvaluestore_key resource.
/// </summary>
public class AwsCloudfrontkeyvaluestoreKey : TerraformResource
{
    public AwsCloudfrontkeyvaluestoreKey(string name) : base("aws_cloudfrontkeyvaluestore_key", name)
    {
    }

    /// <summary>
    /// The key to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    [TerraformPropertyName("key_value_store_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyValueStoreArn { get; set; }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    [TerraformPropertyName("total_size_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalSizeInBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_size_in_bytes");

}
