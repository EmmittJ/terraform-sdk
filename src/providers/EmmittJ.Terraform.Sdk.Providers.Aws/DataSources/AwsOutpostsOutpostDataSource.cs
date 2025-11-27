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
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string>? OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => new TerraformReference<string>(this, "availability_zone_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    public TerraformValue<string> LifecycleStatus
    {
        get => new TerraformReference<string>(this, "lifecycle_status");
    }

    /// <summary>
    /// The site_arn attribute.
    /// </summary>
    public TerraformValue<string> SiteArn
    {
        get => new TerraformReference<string>(this, "site_arn");
    }

    /// <summary>
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string> SiteId
    {
        get => new TerraformReference<string>(this, "site_id");
    }

    /// <summary>
    /// The supported_hardware_type attribute.
    /// </summary>
    public TerraformValue<string> SupportedHardwareType
    {
        get => new TerraformReference<string>(this, "supported_hardware_type");
    }

}
