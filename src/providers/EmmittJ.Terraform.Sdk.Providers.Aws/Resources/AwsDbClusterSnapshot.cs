using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDbClusterSnapshot.
/// Nesting mode: single
/// </summary>
public class AwsDbClusterSnapshotTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_db_cluster_snapshot Terraform resource.
/// Manages a aws_db_cluster_snapshot resource.
/// </summary>
public partial class AwsDbClusterSnapshot(string name) : TerraformResource("aws_db_cluster_snapshot", name)
{
    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    public required TerraformValue<string> DbClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_cluster_identifier");
        set => SetArgument("db_cluster_identifier", value);
    }

    /// <summary>
    /// The db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterSnapshotIdentifier is required")]
    public required TerraformValue<string> DbClusterSnapshotIdentifier
    {
        get => GetArgument<TerraformValue<string>>("db_cluster_snapshot_identifier");
        set => SetArgument("db_cluster_snapshot_identifier", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The shared_accounts attribute.
    /// </summary>
    public TerraformSet<string>? SharedAccounts
    {
        get => GetArgument<TerraformSet<string>>("shared_accounts");
        set => SetArgument("shared_accounts", value);
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
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformValue<double> AllocatedStorage
        => AsReference("allocated_storage");

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformList<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string> DbClusterSnapshotArn
        => AsReference("db_cluster_snapshot_arn");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string> Engine
        => AsReference("engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
        => AsReference("engine_version");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformValue<string> LicenseModel
        => AsReference("license_model");

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
        => AsReference("port");

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformValue<string> SnapshotType
        => AsReference("snapshot_type");

    /// <summary>
    /// The source_db_cluster_snapshot_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceDbClusterSnapshotArn
        => AsReference("source_db_cluster_snapshot_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformValue<bool> StorageEncrypted
        => AsReference("storage_encrypted");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbClusterSnapshotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbClusterSnapshotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
