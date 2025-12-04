using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsGlueCatalogTableOptimizer.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOptimizerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// OrphanFileDeletionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlock>? OrphanFileDeletionConfiguration
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlock>>("orphan_file_deletion_configuration");
        set => SetArgument("orphan_file_deletion_configuration", value);
    }

    /// <summary>
    /// RetentionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlock>? RetentionConfiguration
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlock>>("retention_configuration");
        set => SetArgument("retention_configuration", value);
    }

}

/// <summary>
/// Block type for orphan_file_deletion_configuration in AwsGlueCatalogTableOptimizerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "orphan_file_deletion_configuration";

    /// <summary>
    /// IcebergConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlockIcebergConfigurationBlock>? IcebergConfiguration
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlockIcebergConfigurationBlock>>("iceberg_configuration");
        set => SetArgument("iceberg_configuration", value);
    }

}

/// <summary>
/// Block type for iceberg_configuration in AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOptimizerConfigurationBlockOrphanFileDeletionConfigurationBlockIcebergConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iceberg_configuration";

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The orphan_file_retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double>? OrphanFileRetentionPeriodInDays
    {
        get => GetArgument<TerraformValue<double>>("orphan_file_retention_period_in_days");
        set => SetArgument("orphan_file_retention_period_in_days", value);
    }

    /// <summary>
    /// The run_rate_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? RunRateInHours
    {
        get => GetArgument<TerraformValue<double>>("run_rate_in_hours");
        set => SetArgument("run_rate_in_hours", value);
    }

}

/// <summary>
/// Block type for retention_configuration in AwsGlueCatalogTableOptimizerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_configuration";

    /// <summary>
    /// IcebergConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlockIcebergConfigurationBlock>? IcebergConfiguration
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlockIcebergConfigurationBlock>>("iceberg_configuration");
        set => SetArgument("iceberg_configuration", value);
    }

}

/// <summary>
/// Block type for iceberg_configuration in AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogTableOptimizerConfigurationBlockRetentionConfigurationBlockIcebergConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iceberg_configuration";

    /// <summary>
    /// The clean_expired_files attribute.
    /// </summary>
    public TerraformValue<bool>? CleanExpiredFiles
    {
        get => GetArgument<TerraformValue<bool>>("clean_expired_files");
        set => SetArgument("clean_expired_files", value);
    }

    /// <summary>
    /// The number_of_snapshots_to_retain attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfSnapshotsToRetain
    {
        get => GetArgument<TerraformValue<double>>("number_of_snapshots_to_retain");
        set => SetArgument("number_of_snapshots_to_retain", value);
    }

    /// <summary>
    /// The run_rate_in_hours attribute.
    /// </summary>
    public TerraformValue<double>? RunRateInHours
    {
        get => GetArgument<TerraformValue<double>>("run_rate_in_hours");
        set => SetArgument("run_rate_in_hours", value);
    }

    /// <summary>
    /// The snapshot_retention_period_in_days attribute.
    /// </summary>
    public TerraformValue<double>? SnapshotRetentionPeriodInDays
    {
        get => GetArgument<TerraformValue<double>>("snapshot_retention_period_in_days");
        set => SetArgument("snapshot_retention_period_in_days", value);
    }

}


/// <summary>
/// Represents a aws_glue_catalog_table_optimizer Terraform resource.
/// Manages a aws_glue_catalog_table_optimizer resource.
/// </summary>
public partial class AwsGlueCatalogTableOptimizer(string name) : TerraformResource("aws_glue_catalog_table_optimizer", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformValue<string> CatalogId
    {
        get => GetArgument<TerraformValue<string>>("catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
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
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsGlueCatalogTableOptimizerConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
