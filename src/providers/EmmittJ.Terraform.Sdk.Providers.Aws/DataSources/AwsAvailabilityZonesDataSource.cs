using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsAvailabilityZonesDataSource.
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZonesDataSourceFilterBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAvailabilityZonesDataSource.
/// Nesting mode: single
/// </summary>
public class AwsAvailabilityZonesDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_availability_zones Terraform data source.
/// Retrieves information about a aws_availability_zones.
/// </summary>
public partial class AwsAvailabilityZonesDataSource(string name) : TerraformDataSource("aws_availability_zones", name)
{
    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    public TerraformValue<bool>? AllAvailabilityZones
    {
        get => new TerraformReference<bool>(this, "all_availability_zones");
        set => SetArgument("all_availability_zones", value);
    }

    /// <summary>
    /// The exclude_names attribute.
    /// </summary>
    public TerraformSet<string>? ExcludeNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exclude_names").ResolveNodes(ctx));
        set => SetArgument("exclude_names", value);
    }

    /// <summary>
    /// The exclude_zone_ids attribute.
    /// </summary>
    public TerraformSet<string>? ExcludeZoneIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exclude_zone_ids").ResolveNodes(ctx));
        set => SetArgument("exclude_zone_ids", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The group_names attribute.
    /// </summary>
    public TerraformSet<string> GroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "group_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformList<string> Names
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_ids attribute.
    /// </summary>
    public TerraformList<string> ZoneIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zone_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAvailabilityZonesDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsAvailabilityZonesDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAvailabilityZonesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAvailabilityZonesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
