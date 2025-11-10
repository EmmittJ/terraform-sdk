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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformProperty<string> PoolName
    {
        get => GetProperty<TerraformProperty<string>>("pool_name");
        set => this.WithProperty("pool_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retention_lock_time_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionLockTimeInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_lock_time_in_days");
        set => this.WithProperty("retention_lock_time_in_days", value);
    }

    /// <summary>
    /// The retention_lock_type attribute.
    /// </summary>
    public TerraformProperty<string>? RetentionLockType
    {
        get => GetProperty<TerraformProperty<string>>("retention_lock_type");
        set => this.WithProperty("retention_lock_type", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformProperty<string> StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("storage_class");
        set => this.WithProperty("storage_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
