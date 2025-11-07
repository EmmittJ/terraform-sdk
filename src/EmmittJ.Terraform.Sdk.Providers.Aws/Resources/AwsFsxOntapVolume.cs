using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_ontap_volume resource.
/// </summary>
public class AwsFsxOntapVolume : TerraformResource
{
    public AwsFsxOntapVolume(string name) : base("aws_fsx_ontap_volume", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("file_system_id");
        this.DeclareOutput("flexcache_endpoint_type");
        this.DeclareOutput("uuid");
    }

    /// <summary>
    /// The bypass_snaplock_enterprise_retention attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BypassSnaplockEnterpriseRetention
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_snaplock_enterprise_retention");
        set => this.WithProperty("bypass_snaplock_enterprise_retention", value);
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CopyTagsToBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_backups");
        set => this.WithProperty("copy_tags_to_backups", value);
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? FinalBackupTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("final_backup_tags");
        set => this.WithProperty("final_backup_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? JunctionPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("junction_path");
        set => this.WithProperty("junction_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OntapVolumeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ontap_volume_type");
        set => this.WithProperty("ontap_volume_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_style");
        set => this.WithProperty("security_style", value);
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("size_in_bytes");
        set => this.WithProperty("size_in_bytes", value);
    }

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SizeInMegabytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size_in_megabytes");
        set => this.WithProperty("size_in_megabytes", value);
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipFinalBackup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_backup");
        set => this.WithProperty("skip_final_backup", value);
    }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SnapshotPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_policy");
        set => this.WithProperty("snapshot_policy", value);
    }

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StorageEfficiencyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_efficiency_enabled");
        set => this.WithProperty("storage_efficiency_enabled", value);
    }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageVirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_virtual_machine_id");
        set => this.WithProperty("storage_virtual_machine_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The volume_style attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumeStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_style");
        set => this.WithProperty("volume_style", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_type");
        set => this.WithProperty("volume_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformExpression FileSystemId => this["file_system_id"];

    /// <summary>
    /// The flexcache_endpoint_type attribute.
    /// </summary>
    public TerraformExpression FlexcacheEndpointType => this["flexcache_endpoint_type"];

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    public TerraformExpression Uuid => this["uuid"];

}
