using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_outpost.
/// </summary>
public class AwsOutpostsOutpostDataSource : TerraformDataSource
{
    public AwsOutpostsOutpostDataSource(string name) : base("aws_outposts_outpost", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("availability_zone_id");
        this.DeclareOutput("description");
        this.DeclareOutput("lifecycle_status");
        this.DeclareOutput("site_arn");
        this.DeclareOutput("site_id");
        this.DeclareOutput("supported_hardware_type");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The owner_id attribute.
    /// </summary>
    public string? OwnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner_id")?.Value;
        set => this.WithProperty("owner_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    public TerraformExpression LifecycleStatus => this["lifecycle_status"];

    /// <summary>
    /// The site_arn attribute.
    /// </summary>
    public TerraformExpression SiteArn => this["site_arn"];

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformExpression SiteId => this["site_id"];

    /// <summary>
    /// The supported_hardware_type attribute.
    /// </summary>
    public TerraformExpression SupportedHardwareType => this["supported_hardware_type"];

}
