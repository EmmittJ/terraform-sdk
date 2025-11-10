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
        SetOutput("availability_zone");
        SetOutput("availability_zone_id");
        SetOutput("description");
        SetOutput("lifecycle_status");
        SetOutput("site_arn");
        SetOutput("site_id");
        SetOutput("supported_hardware_type");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("owner_id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// The owner_id attribute.
    /// </summary>
    public TerraformProperty<string> OwnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owner_id");
        set => SetProperty("owner_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
