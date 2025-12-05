using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsAvailabilityZoneDataSource.
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZoneDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAvailabilityZoneDataSource.
/// Nesting mode: single
/// </summary>
public class AwsAvailabilityZoneDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_availability_zone Terraform data source.
/// Retrieves information about a aws_availability_zone.
/// </summary>
public partial class AwsAvailabilityZoneDataSource(string name) : TerraformDataSource("aws_availability_zone", name)
{
    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    public TerraformValue<bool>? AllAvailabilityZones
    {
        get => GetArgument<TerraformValue<bool>>("all_availability_zones");
        set => SetArgument("all_availability_zones", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state") ?? CreateReference("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => GetArgument<TerraformValue<string>>("zone_id") ?? CreateReference("zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The group_long_name attribute.
    /// </summary>
    public TerraformValue<string> GroupLongName
        => CreateReference("group_long_name");

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformValue<string> GroupName
        => CreateReference("group_name");

    /// <summary>
    /// The name_suffix attribute.
    /// </summary>
    public TerraformValue<string> NameSuffix
        => CreateReference("name_suffix");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformValue<string> NetworkBorderGroup
        => CreateReference("network_border_group");

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformValue<string> OptInStatus
        => CreateReference("opt_in_status");

    /// <summary>
    /// The parent_zone_id attribute.
    /// </summary>
    public TerraformValue<string> ParentZoneId
        => CreateReference("parent_zone_id");

    /// <summary>
    /// The parent_zone_name attribute.
    /// </summary>
    public TerraformValue<string> ParentZoneName
        => CreateReference("parent_zone_name");

    /// <summary>
    /// The zone_type attribute.
    /// </summary>
    public TerraformValue<string> ZoneType
        => CreateReference("zone_type");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAvailabilityZoneDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsAvailabilityZoneDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAvailabilityZoneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAvailabilityZoneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
