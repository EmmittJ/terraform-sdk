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
        get => new TerraformReference<string>(this, "db_instance_identifier");
        set => SetArgument("db_instance_identifier", value);
    }

    /// <summary>
    /// The db_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DbSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "db_snapshot_identifier");
        set => SetArgument("db_snapshot_identifier", value);
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
    /// The include_public attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePublic
    {
        get => new TerraformReference<bool>(this, "include_public");
        set => SetArgument("include_public", value);
    }

    /// <summary>
    /// The include_shared attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeShared
    {
        get => new TerraformReference<bool>(this, "include_shared");
        set => SetArgument("include_shared", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformValue<bool>? MostRecent
    {
        get => new TerraformReference<bool>(this, "most_recent");
        set => SetArgument("most_recent", value);
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
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotType
    {
        get => new TerraformReference<string>(this, "snapshot_type");
        set => SetArgument("snapshot_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
    {
        get => new TerraformReference<double>(this, "allocated_storage");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string> DbSnapshotArn
    {
        get => new TerraformReference<string>(this, "db_snapshot_arn");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
    {
        get => new TerraformReference<string>(this, "engine");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double> Iops
    {
        get => new TerraformReference<double>(this, "iops");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
    {
        get => new TerraformReference<string>(this, "license_model");
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformValue<string> OptionGroupName
    {
        get => new TerraformReference<string>(this, "option_group_name");
    }

    /// <summary>
    /// The original_snapshot_create_time attribute.
    /// </summary>
    public TerraformValue<string> OriginalSnapshotCreateTime
    {
        get => new TerraformReference<string>(this, "original_snapshot_create_time");
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The snapshot_create_time attribute.
    /// </summary>
    public TerraformValue<string> SnapshotCreateTime
    {
        get => new TerraformReference<string>(this, "snapshot_create_time");
    }

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    public TerraformValue<string> SourceDbSnapshotIdentifier
    {
        get => new TerraformReference<string>(this, "source_db_snapshot_identifier");
    }

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformValue<string> SourceRegion
    {
        get => new TerraformReference<string>(this, "source_region");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}
