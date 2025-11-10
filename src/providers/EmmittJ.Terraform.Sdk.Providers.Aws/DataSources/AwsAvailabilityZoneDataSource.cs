using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZoneDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAvailabilityZoneDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_availability_zone.
/// </summary>
public class AwsAvailabilityZoneDataSource : TerraformDataSource
{
    public AwsAvailabilityZoneDataSource(string name) : base("aws_availability_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("group_long_name");
        SetOutput("group_name");
        SetOutput("name_suffix");
        SetOutput("network_border_group");
        SetOutput("opt_in_status");
        SetOutput("parent_zone_id");
        SetOutput("parent_zone_name");
        SetOutput("zone_type");
        SetOutput("all_availability_zones");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("state");
        SetOutput("zone_id");
    }

    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    public TerraformProperty<bool> AllAvailabilityZones
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("all_availability_zones");
        set => SetProperty("all_availability_zones", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string> ZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_id");
        set => SetProperty("zone_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAvailabilityZoneDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAvailabilityZoneDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The group_long_name attribute.
    /// </summary>
    public TerraformExpression GroupLongName => this["group_long_name"];

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public TerraformExpression GroupName => this["group_name"];

    /// <summary>
    /// The name_suffix attribute.
    /// </summary>
    public TerraformExpression NameSuffix => this["name_suffix"];

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformExpression NetworkBorderGroup => this["network_border_group"];

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformExpression OptInStatus => this["opt_in_status"];

    /// <summary>
    /// The parent_zone_id attribute.
    /// </summary>
    public TerraformExpression ParentZoneId => this["parent_zone_id"];

    /// <summary>
    /// The parent_zone_name attribute.
    /// </summary>
    public TerraformExpression ParentZoneName => this["parent_zone_name"];

    /// <summary>
    /// The zone_type attribute.
    /// </summary>
    public TerraformExpression ZoneType => this["zone_type"];

}
