using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsSecuritylakeDataLake.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeDataLakeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_configuration").ResolveNodes(ctx));
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// LifecycleConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlock>? LifecycleConfiguration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlock>>("lifecycle_configuration");
        set => SetArgument("lifecycle_configuration", value);
    }

    /// <summary>
    /// ReplicationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeDataLakeConfigurationBlockReplicationConfigurationBlock>? ReplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeDataLakeConfigurationBlockReplicationConfigurationBlock>>("replication_configuration");
        set => SetArgument("replication_configuration", value);
    }

}

/// <summary>
/// Block type for lifecycle_configuration in AwsSecuritylakeDataLakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_configuration";

    /// <summary>
    /// Expiration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlockExpirationBlock>? Expiration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlockExpirationBlock>>("expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// Transition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlockTransitionBlock>? Transition
    {
        get => GetArgument<TerraformSet<AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlockTransitionBlock>>("transition");
        set => SetArgument("transition", value);
    }

}

/// <summary>
/// Block type for expiration in AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlockExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiration";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

}

/// <summary>
/// Block type for transition in AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsSecuritylakeDataLakeConfigurationBlockLifecycleConfigurationBlockTransitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transition";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => new TerraformReference<double>(this, "days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
        set => SetArgument("storage_class", value);
    }

}

/// <summary>
/// Block type for replication_configuration in AwsSecuritylakeDataLakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeDataLakeConfigurationBlockReplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_configuration";

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSecuritylakeDataLake.
/// Nesting mode: single
/// </summary>
public class AwsSecuritylakeDataLakeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_securitylake_data_lake Terraform resource.
/// Manages a aws_securitylake_data_lake resource.
/// </summary>
public partial class AwsSecuritylakeDataLake(string name) : TerraformResource("aws_securitylake_data_lake", name)
{
    /// <summary>
    /// The meta_store_manager_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetaStoreManagerRoleArn is required")]
    public required TerraformValue<string> MetaStoreManagerRoleArn
    {
        get => new TerraformReference<string>(this, "meta_store_manager_role_arn");
        set => SetArgument("meta_store_manager_role_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    public TerraformValue<string> S3BucketArn
    {
        get => new TerraformReference<string>(this, "s3_bucket_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeDataLakeConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeDataLakeConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSecuritylakeDataLakeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSecuritylakeDataLakeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
