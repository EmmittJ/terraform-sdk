using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_storagegateway_tape_pool resource.
/// </summary>
public class AwsStoragegatewayTapePool : TerraformResource
{
    public AwsStoragegatewayTapePool(string name) : base("aws_storagegateway_tape_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    public string? PoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_name")?.Value;
        set => this.WithProperty("pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_lock_time_in_days attribute.
    /// </summary>
    public double? RetentionLockTimeInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_lock_time_in_days")?.Value;
        set => this.WithProperty("retention_lock_time_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The retention_lock_type attribute.
    /// </summary>
    public string? RetentionLockType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retention_lock_type")?.Value;
        set => this.WithProperty("retention_lock_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public string? StorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_class")?.Value;
        set => this.WithProperty("storage_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
