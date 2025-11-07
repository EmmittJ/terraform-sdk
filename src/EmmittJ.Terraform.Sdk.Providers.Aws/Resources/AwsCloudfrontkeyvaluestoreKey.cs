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
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the Key Value Store.
    /// </summary>
    public TerraformProperty<string>? KeyValueStoreArn
    {
        get => GetProperty<TerraformProperty<string>>("key_value_store_arn");
        set => this.WithProperty("key_value_store_arn", value);
    }

    /// <summary>
    /// The value to put.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => this.WithProperty("value", value);
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
