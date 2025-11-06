using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public bool? AllAvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("all_availability_zones")?.Value;
        set => this.WithProperty("all_availability_zones", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The exclude_names attribute.
    /// </summary>
    public HashSet<string>? ExcludeNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("exclude_names")?.Value;
        set => this.WithProperty("exclude_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The exclude_zone_ids attribute.
    /// </summary>
    public HashSet<string>? ExcludeZoneIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("exclude_zone_ids")?.Value;
        set => this.WithProperty("exclude_zone_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
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
