using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfrontkeyvaluestore_key resource.
/// </summary>
public partial class AwsCloudfrontkeyvaluestoreKey : TerraformResource
{
    public AwsCloudfrontkeyvaluestoreKey(string name) : base("aws_cloudfrontkeyvaluestore_key", name)
    {
    }

    /// <summary>
    /// The key to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyValueStoreArn is required")]
    [TerraformProperty("key_value_store_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyValueStoreArn { get; set; }

    /// <summary>
    /// The value to put.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    [TerraformProperty("total_size_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TotalSizeInBytes { get; }

}
