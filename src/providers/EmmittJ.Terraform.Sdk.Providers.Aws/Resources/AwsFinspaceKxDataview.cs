using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for segment_configurations in AwsFinspaceKxDataview.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxDataviewSegmentConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "segment_configurations";

    /// <summary>
    /// The db_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbPaths is required")]
    public TerraformList<string>? DbPaths
    {
        get => GetArgument<TerraformList<string>>("db_paths");
        set => SetArgument("db_paths", value);
    }

    /// <summary>
    /// The on_demand attribute.
    /// </summary>
    public TerraformValue<bool>? OnDemand
    {
        get => GetArgument<TerraformValue<bool>>("on_demand");
        set => SetArgument("on_demand", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFinspaceKxDataview.
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxDataviewTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_finspace_kx_dataview Terraform resource.
/// Manages a aws_finspace_kx_dataview resource.
/// </summary>
public partial class AwsFinspaceKxDataview(string name) : TerraformResource("aws_finspace_kx_dataview", name)
{
    /// <summary>
    /// The auto_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoUpdate is required")]
    public required TerraformValue<bool> AutoUpdate
    {
        get => GetArgument<TerraformValue<bool>>("auto_update");
        set => SetArgument("auto_update", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformValue<string> AzMode
    {
        get => GetArgument<TerraformValue<string>>("az_mode");
        set => SetArgument("az_mode", value);
    }

    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    public TerraformValue<string>? ChangesetId
    {
        get => GetArgument<TerraformValue<string>>("changeset_id");
        set => SetArgument("changeset_id", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformValue<string> EnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("environment_id");
        set => SetArgument("environment_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The read_write attribute.
    /// </summary>
    public TerraformValue<bool>? ReadWrite
    {
        get => GetArgument<TerraformValue<bool>>("read_write");
        set => SetArgument("read_write", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreatedTimestamp
        => AsReference("created_timestamp");

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTimestamp
        => AsReference("last_modified_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// SegmentConfigurations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFinspaceKxDataviewSegmentConfigurationsBlock>? SegmentConfigurations
    {
        get => GetArgument<TerraformList<AwsFinspaceKxDataviewSegmentConfigurationsBlock>>("segment_configurations");
        set => SetArgument("segment_configurations", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFinspaceKxDataviewTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFinspaceKxDataviewTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
