using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbSnapshotCopyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_db_snapshot_copy resource.
/// </summary>
public class AwsDbSnapshotCopy : TerraformResource
{
    public AwsDbSnapshotCopy(string name) : base("aws_db_snapshot_copy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocated_storage");
        SetOutput("availability_zone");
        SetOutput("db_snapshot_arn");
        SetOutput("encrypted");
        SetOutput("engine");
        SetOutput("engine_version");
        SetOutput("iops");
        SetOutput("license_model");
        SetOutput("port");
        SetOutput("snapshot_type");
        SetOutput("source_region");
        SetOutput("storage_type");
        SetOutput("vpc_id");
        SetOutput("copy_tags");
        SetOutput("destination_region");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("option_group_name");
        SetOutput("presigned_url");
        SetOutput("region");
        SetOutput("shared_accounts");
        SetOutput("source_db_snapshot_identifier");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("target_custom_availability_zone");
        SetOutput("target_db_snapshot_identifier");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The option_group_name attribute.
    /// </summary>
    public TerraformProperty<string> OptionGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("option_group_name");
        set => SetProperty("option_group_name", value);
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
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceDbSnapshotIdentifier is required")]
    public required TerraformProperty<string> SourceDbSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_db_snapshot_identifier");
        set => SetProperty("source_db_snapshot_identifier", value);
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
    /// The target_custom_availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> TargetCustomAvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_custom_availability_zone");
        set => SetProperty("target_custom_availability_zone", value);
    }

    /// <summary>
    /// The target_db_snapshot_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetDbSnapshotIdentifier is required")]
    public required TerraformProperty<string> TargetDbSnapshotIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_db_snapshot_identifier");
        set => SetProperty("target_db_snapshot_identifier", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbSnapshotCopyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    public TerraformExpression AllocatedStorage => this["allocated_storage"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The db_snapshot_arn attribute.
    /// </summary>
    public TerraformExpression DbSnapshotArn => this["db_snapshot_arn"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformExpression Engine => this["engine"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformExpression Iops => this["iops"];

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    public TerraformExpression LicenseModel => this["license_model"];

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The snapshot_type attribute.
    /// </summary>
    public TerraformExpression SnapshotType => this["snapshot_type"];

    /// <summary>
    /// The source_region attribute.
    /// </summary>
    public TerraformExpression SourceRegion => this["source_region"];

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformExpression StorageType => this["storage_type"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
