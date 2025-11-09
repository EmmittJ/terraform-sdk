using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("allocated_storage");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("db_snapshot_arn");
        this.DeclareOutput("encrypted");
        this.DeclareOutput("engine");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("iops");
        this.DeclareOutput("license_model");
        this.DeclareOutput("port");
        this.DeclareOutput("snapshot_type");
        this.DeclareOutput("source_region");
        this.DeclareOutput("storage_type");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTags
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags");
        set => this.WithProperty("copy_tags", value);
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationRegion
    {
        get => GetProperty<TerraformProperty<string>>("destination_region");
        set => this.WithProperty("destination_region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The option_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? OptionGroupName
    {
        get => GetProperty<TerraformProperty<string>>("option_group_name");
        set => this.WithProperty("option_group_name", value);
    }

    /// <summary>
    /// The presigned_url attribute.
    /// </summary>
    public TerraformProperty<string>? PresignedUrl
    {
        get => GetProperty<TerraformProperty<string>>("presigned_url");
        set => this.WithProperty("presigned_url", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The shared_accounts attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SharedAccounts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("shared_accounts");
        set => this.WithProperty("shared_accounts", value);
    }

    /// <summary>
    /// The source_db_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SourceDbSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("source_db_snapshot_identifier");
        set => this.WithProperty("source_db_snapshot_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_custom_availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? TargetCustomAvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("target_custom_availability_zone");
        set => this.WithProperty("target_custom_availability_zone", value);
    }

    /// <summary>
    /// The target_db_snapshot_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? TargetDbSnapshotIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("target_db_snapshot_identifier");
        set => this.WithProperty("target_db_snapshot_identifier", value);
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
