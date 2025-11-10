using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAvailabilityZonesDataSourceFilterBlock : TerraformBlock
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
public class AwsAvailabilityZonesDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_availability_zones.
/// </summary>
public class AwsAvailabilityZonesDataSource : TerraformDataSource
{
    public AwsAvailabilityZonesDataSource(string name) : base("aws_availability_zones", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("group_names");
        this.DeclareOutput("names");
        this.DeclareOutput("zone_ids");
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
    /// The exclude_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludeNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("exclude_names");
        set => this.WithProperty("exclude_names", value);
    }

    /// <summary>
    /// The exclude_zone_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludeZoneIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("exclude_zone_ids");
        set => this.WithProperty("exclude_zone_ids", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAvailabilityZonesDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsAvailabilityZonesDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAvailabilityZonesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAvailabilityZonesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The group_names attribute.
    /// </summary>
    public TerraformExpression GroupNames => this["group_names"];

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

    /// <summary>
    /// The zone_ids attribute.
    /// </summary>
    public TerraformExpression ZoneIds => this["zone_ids"];

}
