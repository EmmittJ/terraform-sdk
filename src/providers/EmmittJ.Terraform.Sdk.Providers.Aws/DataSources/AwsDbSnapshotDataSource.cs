using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_db_snapshot Terraform data source.
/// Retrieves information about a aws_db_snapshot.
/// </summary>
public partial class AwsDbSnapshotDataSource(string name) : TerraformDataSource("aws_db_snapshot", name)
{
    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DbInstanceIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_instance_identifier");
        set => SetArgument("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DbSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_snapshot_identifier");
        set => SetArgument("db_snapshot_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_public attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePublic
    {
        get => GetArgument<TerraformValue<bool>>("include_public");
        set => SetArgument("include_public", value);
    }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeShared
    {
        get => GetArgument<TerraformValue<bool>>("include_shared");
        set => SetArgument("include_shared", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => GetArgument<TerraformValue<bool>>("most_recent");
        set => SetArgument("most_recent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotType
    {
        get => GetArgument<TerraformValue<string>>("snapshot_type");
        set => SetArgument("snapshot_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
        => CreateReference("allocated_storage");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string> DbSnapshotArn
        => CreateReference("db_snapshot_arn");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => CreateReference("encrypted");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => CreateReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => CreateReference("engine_version");

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
        => CreateReference("iops");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => CreateReference("kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => CreateReference("license_model");

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformValue<string> OptionGroupName
        => CreateReference("option_group_name");

    /// <summary>
    /// The original_snapshot_create_time attribute.
    /// </summary>
    public TerraformValue<string> OriginalSnapshotCreateTime
        => CreateReference("original_snapshot_create_time");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => CreateReference("port");

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    public TerraformValue<string> SnapshotCreateTime
        => CreateReference("snapshot_create_time");

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string> SourceDbSnapshotIdentifier
        => CreateReference("source_db_snapshot_identifier");

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformValue<string> SourceRegion
        => CreateReference("source_region");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
        => CreateReference("storage_type");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

}
