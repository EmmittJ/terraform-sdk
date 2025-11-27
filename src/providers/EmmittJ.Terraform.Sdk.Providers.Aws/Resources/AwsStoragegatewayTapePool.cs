using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_storagegateway_tape_pool Terraform resource.
/// Manages a aws_storagegateway_tape_pool resource.
/// </summary>
public partial class AwsStoragegatewayTapePool(string name) : TerraformResource("aws_storagegateway_tape_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => new TerraformReference<string>(this, "pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention_lock_time_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionLockTimeInDays
    {
        get => new TerraformReference<double>(this, "retention_lock_time_in_days");
        set => SetArgument("retention_lock_time_in_days", value);
    }

    /// <summary>
    /// The retention_lock_type attribute.
    /// </summary>
    public TerraformValue<string>? RetentionLockType
    {
        get => new TerraformReference<string>(this, "retention_lock_type");
        set => SetArgument("retention_lock_type", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
