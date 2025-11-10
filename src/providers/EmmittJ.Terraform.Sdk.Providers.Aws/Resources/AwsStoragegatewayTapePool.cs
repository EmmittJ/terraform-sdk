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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("pool_name");
        SetOutput("region");
        SetOutput("retention_lock_time_in_days");
        SetOutput("retention_lock_type");
        SetOutput("storage_class");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformProperty<string> PoolName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pool_name");
        set => SetProperty("pool_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The retention_lock_time_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionLockTimeInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_lock_time_in_days");
        set => SetProperty("retention_lock_time_in_days", value);
    }

    /// <summary>
    /// The retention_lock_type attribute.
    /// </summary>
    public TerraformProperty<string> RetentionLockType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("retention_lock_type");
        set => SetProperty("retention_lock_type", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformProperty<string> StorageClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_class");
        set => SetProperty("storage_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
