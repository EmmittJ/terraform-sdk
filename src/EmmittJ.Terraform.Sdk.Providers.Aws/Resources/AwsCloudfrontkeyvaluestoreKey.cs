using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudfrontkeyvaluestore_key resource.
/// </summary>
public class AwsCloudfrontkeyvaluestoreKey : TerraformResource
{
    public AwsCloudfrontkeyvaluestoreKey(string name) : base("aws_cloudfrontkeyvaluestore_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("total_size_in_bytes");
    }

    /// <summary>
    /// The key to put.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The value to put.
    /// </summary>
    public string? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// Total size of the Key Value Store in bytes.
    /// </summary>
    public TerraformExpression TotalSizeInBytes => this["total_size_in_bytes"];

}
