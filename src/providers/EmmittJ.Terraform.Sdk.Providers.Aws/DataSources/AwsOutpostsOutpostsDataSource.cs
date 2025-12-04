using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_outposts_outposts Terraform data source.
/// Retrieves information about a aws_outposts_outposts.
/// </summary>
public partial class AwsOutpostsOutpostsDataSource(string name) : TerraformDataSource("aws_outposts_outposts", name)
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
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
    /// The site_id attribute.
    /// </summary>
    public TerraformValue<string>? SiteId
    {
        get => GetArgument<TerraformValue<string>>("site_id");
        set => SetArgument("site_id", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformSet<string> Arns
        => AsReference("arns");

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformSet<string> Ids
        => AsReference("ids");

}
