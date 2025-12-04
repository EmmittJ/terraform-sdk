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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => GetArgument<TerraformValue<string>>("pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retention_lock_time_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionLockTimeInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_lock_time_in_days");
        set => SetArgument("retention_lock_time_in_days", value);
    }

    /// <summary>
    /// The retention_lock_type attribute.
    /// </summary>
    public TerraformValue<string>? RetentionLockType
    {
        get => GetArgument<TerraformValue<string>>("retention_lock_type");
        set => SetArgument("retention_lock_type", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageClass is required")]
    public required TerraformValue<string> StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
