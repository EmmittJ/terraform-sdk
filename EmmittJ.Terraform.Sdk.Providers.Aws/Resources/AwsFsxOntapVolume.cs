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
    public bool? BypassSnaplockEnterpriseRetention
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_snaplock_enterprise_retention")?.Value;
        set => this.WithProperty("bypass_snaplock_enterprise_retention", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The copy_tags_to_backups attribute.
    /// </summary>
    public bool? CopyTagsToBackups
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_backups")?.Value;
        set => this.WithProperty("copy_tags_to_backups", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The final_backup_tags attribute.
    /// </summary>
    public Dictionary<string, string>? FinalBackupTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("final_backup_tags")?.Value;
        set => this.WithProperty("final_backup_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The junction_path attribute.
    /// </summary>
    public string? JunctionPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("junction_path")?.Value;
        set => this.WithProperty("junction_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ontap_volume_type attribute.
    /// </summary>
    public string? OntapVolumeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ontap_volume_type")?.Value;
        set => this.WithProperty("ontap_volume_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_style attribute.
    /// </summary>
    public string? SecurityStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_style")?.Value;
        set => this.WithProperty("security_style", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size_in_bytes attribute.
    /// </summary>
    public string? SizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("size_in_bytes")?.Value;
        set => this.WithProperty("size_in_bytes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size_in_megabytes attribute.
    /// </summary>
    public double? SizeInMegabytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("size_in_megabytes")?.Value;
        set => this.WithProperty("size_in_megabytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The skip_final_backup attribute.
    /// </summary>
    public bool? SkipFinalBackup
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_final_backup")?.Value;
        set => this.WithProperty("skip_final_backup", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The snapshot_policy attribute.
    /// </summary>
    public string? SnapshotPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("snapshot_policy")?.Value;
        set => this.WithProperty("snapshot_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_efficiency_enabled attribute.
    /// </summary>
    public bool? StorageEfficiencyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("storage_efficiency_enabled")?.Value;
        set => this.WithProperty("storage_efficiency_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The storage_virtual_machine_id attribute.
    /// </summary>
    public string? StorageVirtualMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_virtual_machine_id")?.Value;
        set => this.WithProperty("storage_virtual_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The volume_style attribute.
    /// </summary>
    public string? VolumeStyle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_style")?.Value;
        set => this.WithProperty("volume_style", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public string? VolumeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_type")?.Value;
        set => this.WithProperty("volume_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
