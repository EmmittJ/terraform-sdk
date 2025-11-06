using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? KeyValueStoreArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_value_store_arn")?.Value;
        set => this.WithProperty("key_value_store_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Maximum resource key values pairs that you wills update in a single API request. AWS has a default quota of 50 keys or a 3 MB payload, whichever is reached first
    /// </summary>
    public double? MaxBatchSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_batch_size")?.Value;
        set => this.WithProperty("max_batch_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    public TerraformExpression TotalSizeInBytes => this["total_size_in_bytes"];

}
