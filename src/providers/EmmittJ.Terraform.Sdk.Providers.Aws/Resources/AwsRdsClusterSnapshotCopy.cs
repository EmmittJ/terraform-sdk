using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterSnapshotCopyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_rds_cluster_snapshot_copy resource.
/// </summary>
public class AwsRdsClusterSnapshotCopy : TerraformResource
{
    public AwsRdsClusterSnapshotCopy(string name) : base("aws_rds_cluster_snapshot_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocated_storage");
        SetOutput("db_cluster_snapshot_arn");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("license_model");
        SetOutput("snapshot_type");
        SetOutput("storage_encrypted");
        SetOutput("storage_type");
        SetOutput("tags_all");
        SetOutput("vpc_id");
        SetOutput("copy_tags");
        SetOutput("destination_region");
        SetOutput("kms_key_id");
        SetOutput("presigned_url");
        SetOutput("region");
        SetOutput("shared_accounts");
        SetOutput("source_db_cluster_snapshot_identifier");
        SetOutput("tags");
        SetOutput("target_db_cluster_snapshot_identifier");
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformProperty<bool> CopyTags
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("copy_tags");
        set => SetProperty("copy_tags", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public TerraformProperty<string> DestinationRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_region");
        set => SetProperty("destination_region", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    public TerraformProperty<string> PresignedUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("presigned_url");
        set => SetProperty("presigned_url", value);
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
    /// The shared_accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SharedAccounts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("shared_accounts");
        set => SetProperty("shared_accounts", value);
    }

    /// <summary>
    /// The source_db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbClusterSnapshotIdentifier is required")]
    public required TerraformProperty<string> SourceDbClusterSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_db_cluster_snapshot_identifier");
        set => SetProperty("source_db_cluster_snapshot_identifier", value);
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
    /// The target_db_cluster_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbClusterSnapshotIdentifier is required")]
    public required TerraformProperty<string> TargetDbClusterSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_db_cluster_snapshot_identifier");
        set => SetProperty("target_db_cluster_snapshot_identifier", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRdsClusterSnapshotCopyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformExpression AllocatedStorage => this["allocated_storage"];

    /// <summary>
    /// The db_cluster_snapshot_arn attribute.
    /// </summary>
    public TerraformExpression DbClusterSnapshotArn => this["db_cluster_snapshot_arn"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformExpression SnapshotType => this["snapshot_type"];

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    public TerraformExpression StorageEncrypted => this["storage_encrypted"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
