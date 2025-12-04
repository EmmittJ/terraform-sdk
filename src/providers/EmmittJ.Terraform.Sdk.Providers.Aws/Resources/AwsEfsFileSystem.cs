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
        get => GetArgument<TerraformValue<string>>("transition_to_archive");
        set => SetArgument("transition_to_archive", value);
    }

    /// <summary>
    /// The transition_to_ia attribute.
    /// </summary>
    public TerraformValue<string>? TransitionToIa
    {
        get => GetArgument<TerraformValue<string>>("transition_to_ia");
        set => SetArgument("transition_to_ia", value);
    }

    /// <summary>
    /// The transition_to_primary_storage_class attribute.
    /// </summary>
    public TerraformValue<string>? TransitionToPrimaryStorageClass
    {
        get => GetArgument<TerraformValue<string>>("transition_to_primary_storage_class");
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
        get => GetArgument<TerraformValue<string>>("replication_overwrite") ?? AsReference("replication_overwrite");
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
        get => GetArgument<TerraformValue<string>>("availability_zone_name") ?? AsReference("availability_zone_name");
        set => SetArgument("availability_zone_name", value);
    }

    /// <summary>
    /// The creation_token attribute.
    /// </summary>
    public TerraformValue<string> CreationToken
    {
        get => GetArgument<TerraformValue<string>>("creation_token") ?? AsReference("creation_token");
        set => SetArgument("creation_token", value);
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => GetArgument<TerraformValue<bool>>("encrypted") ?? AsReference("encrypted");
        set => SetArgument("encrypted", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? AsReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The performance_mode attribute.
    /// </summary>
    public TerraformValue<string> PerformanceMode
    {
        get => GetArgument<TerraformValue<string>>("performance_mode") ?? AsReference("performance_mode");
        set => SetArgument("performance_mode", value);
    }

    /// <summary>
    /// The provisioned_throughput_in_mibps attribute.
    /// </summary>
    public TerraformValue<double>? ProvisionedThroughputInMibps
    {
        get => GetArgument<TerraformValue<double>>("provisioned_throughput_in_mibps");
        set => SetArgument("provisioned_throughput_in_mibps", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The throughput_mode attribute.
    /// </summary>
    public TerraformValue<string>? ThroughputMode
    {
        get => GetArgument<TerraformValue<string>>("throughput_mode");
        set => SetArgument("throughput_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => AsReference("availability_zone_id");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => AsReference("dns_name");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The number_of_mount_targets attribute.
    /// </summary>
    public TerraformValue<double> NumberOfMountTargets
        => AsReference("number_of_mount_targets");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SizeInBytes
        => AsReference("size_in_bytes");

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
