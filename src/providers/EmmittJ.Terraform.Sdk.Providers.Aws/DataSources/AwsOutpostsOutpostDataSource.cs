using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_outposts_outpost Terraform data source.
/// Retrieves information about a aws_outposts_outpost.
/// </summary>
public partial class AwsOutpostsOutpostDataSource(string name) : TerraformDataSource("aws_outposts_outpost", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string>? OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => AsReference("availability_zone");

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
        => AsReference("availability_zone_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    public TerraformValue<string> LifecycleStatus
        => AsReference("lifecycle_status");

    /// <summary>
    /// The site_arn attribute.
    /// </summary>
    public TerraformValue<string> SiteArn
        => AsReference("site_arn");

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string> SiteId
        => AsReference("site_id");

    /// <summary>
    /// The supported_hardware_type attribute.
    /// </summary>
    public TerraformValue<string> SupportedHardwareType
        => AsReference("supported_hardware_type");

}
