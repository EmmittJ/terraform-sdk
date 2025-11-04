using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("group_name");
        this.DeclareOutput("name_suffix");
        this.DeclareOutput("network_border_group");
        this.DeclareOutput("opt_in_status");
        this.DeclareOutput("parent_zone_id");
        this.DeclareOutput("parent_zone_name");
        this.DeclareOutput("region");
        this.DeclareOutput("zone_type");
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The zone_id attribute.
    /// </summary>
    public string? ZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone_id")?.Value;
        set => this.WithProperty("zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

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
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The zone_type attribute.
    /// </summary>
    public TerraformExpression ZoneType => this["zone_type"];

}
