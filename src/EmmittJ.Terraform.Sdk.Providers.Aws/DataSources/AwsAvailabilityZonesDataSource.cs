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
    public TerraformLiteralProperty<bool>? AllAvailabilityZones
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("all_availability_zones");
        set => this.WithProperty("all_availability_zones", value);
    }

    /// <summary>
    /// The exclude_names attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ExcludeNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("exclude_names");
        set => this.WithProperty("exclude_names", value);
    }

    /// <summary>
    /// The exclude_zone_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ExcludeZoneIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("exclude_zone_ids");
        set => this.WithProperty("exclude_zone_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state");
        set => this.WithProperty("state", value);
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
