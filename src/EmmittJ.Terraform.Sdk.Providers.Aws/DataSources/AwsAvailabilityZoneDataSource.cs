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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("group_long_name");
        this.DeclareOutput("group_name");
        this.DeclareOutput("name_suffix");
        this.DeclareOutput("network_border_group");
        this.DeclareOutput("opt_in_status");
        this.DeclareOutput("parent_zone_id");
        this.DeclareOutput("parent_zone_name");
        this.DeclareOutput("zone_type");
    }

    /// <summary>
    /// The all_availability_zones attribute.
    /// </summary>
    public TerraformProperty<bool>? AllAvailabilityZones
    {
        get => GetProperty<TerraformProperty<bool>>("all_availability_zones");
        set => this.WithProperty("all_availability_zones", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAvailabilityZoneDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsAvailabilityZoneDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAvailabilityZoneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAvailabilityZoneDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
