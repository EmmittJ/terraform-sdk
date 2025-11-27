using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for lifecycle_policy in AwsEfsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemLifecyclePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle_policy";

    /// <summary>
    /// The transition_to_archive attribute.
    /// </summary>
    public TerraformValue<string>? TransitionToArchive
    {
        get => new TerraformReference<string>(this, "transition_to_archive");
        set => SetArgument("transition_to_archive", value);
    }

    /// <summary>
    /// The transition_to_ia attribute.
    /// </summary>
    public TerraformValue<string>? TransitionToIa
    {
        get => new TerraformReference<string>(this, "transition_to_ia");
        set => SetArgument("transition_to_ia", value);
    }

    /// <summary>
    /// The transition_to_primary_storage_class attribute.
    /// </summary>
    public TerraformValue<string>? TransitionToPrimaryStorageClass
    {
        get => new TerraformReference<string>(this, "transition_to_primary_storage_class");
        set => SetArgument("transition_to_primary_storage_class", value);
    }

}


/// <summary>
/// Block type for protection in AwsEfsFileSystem.
/// Nesting mode: list
/// </summary>
public class AwsEfsFileSystemProtectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protection";

    /// <summary>
    /// The replication_overwrite attribute.
    /// </summary>
    public TerraformValue<string> ReplicationOverwrite
    {
        get => new TerraformReference<string>(this, "replication_overwrite");
        set => SetArgument("replication_overwrite", value);
    }

}


/// <summary>
/// Represents a aws_efs_file_system Terraform resource.
/// Manages a aws_efs_file_system resource.
/// </summary>
public partial class AwsEfsFileSystem(string name) : TerraformResource("aws_efs_file_system", name)
{
    /// <summary>
    /// The availability_zone_name attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneName
    {
        get => new TerraformReference<string>(this, "availability_zone_name");
        set => SetArgument("availability_zone_name", value);
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public TerraformValue<string> CreationToken
    {
        get => new TerraformReference<string>(this, "creation_token");
        set => SetArgument("creation_token", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformValue<string> PerformanceMode
    {
        get => new TerraformReference<string>(this, "performance_mode");
        set => SetArgument("performance_mode", value);
    }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double>? ProvisionedThroughputInMibps
    {
        get => new TerraformReference<double>(this, "provisioned_throughput_in_mibps");
        set => SetArgument("provisioned_throughput_in_mibps", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string>? ThroughputMode
    {
        get => new TerraformReference<string>(this, "throughput_mode");
        set => SetArgument("throughput_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The number_of_mount_targets attribute.
    /// </summary>
    public TerraformValue<double> NumberOfMountTargets
    {
        get => new TerraformReference<double>(this, "number_of_mount_targets");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SizeInBytes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "size_in_bytes").ResolveNodes(ctx));
    }

    /// <summary>
    /// LifecyclePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 LifecyclePolicy block(s) allowed")]
    public TerraformList<AwsEfsFileSystemLifecyclePolicyBlock>? LifecyclePolicy
    {
        get => GetArgument<TerraformList<AwsEfsFileSystemLifecyclePolicyBlock>>("lifecycle_policy");
        set => SetArgument("lifecycle_policy", value);
    }

    /// <summary>
    /// Protection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Protection block(s) allowed")]
    public TerraformList<AwsEfsFileSystemProtectionBlock>? Protection
    {
        get => GetArgument<TerraformList<AwsEfsFileSystemProtectionBlock>>("protection");
        set => SetArgument("protection", value);
    }

}
