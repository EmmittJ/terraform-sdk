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
public class AwsAvailabilityZonesDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("group_names");
        SetOutput("names");
        SetOutput("zone_ids");
        SetOutput("all_availability_zones");
        SetOutput("exclude_names");
        SetOutput("exclude_zone_ids");
        SetOutput("id");
        SetOutput("region");
        SetOutput("state");
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
    /// The exclude_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExcludeNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("exclude_names");
        set => SetProperty("exclude_names", value);
    }

    /// <summary>
    /// The exclude_zone_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExcludeZoneIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("exclude_zone_ids");
        set => SetProperty("exclude_zone_ids", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAvailabilityZonesDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAvailabilityZonesDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
