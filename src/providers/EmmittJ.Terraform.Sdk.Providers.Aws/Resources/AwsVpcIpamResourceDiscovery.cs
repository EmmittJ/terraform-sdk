using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for operating_regions in AwsVpcIpamResourceDiscovery.
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamResourceDiscoveryOperatingRegionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operating_regions";

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => new TerraformReference<string>(this, "region_name");
        set => SetArgument("region_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcIpamResourceDiscovery.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamResourceDiscoveryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpc_ipam_resource_discovery Terraform resource.
/// Manages a aws_vpc_ipam_resource_discovery resource.
/// </summary>
public partial class AwsVpcIpamResourceDiscovery(string name) : TerraformResource("aws_vpc_ipam_resource_discovery", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The ipam_resource_discovery_region attribute.
    /// </summary>
    public TerraformValue<string> IpamResourceDiscoveryRegion
    {
        get => new TerraformReference<string>(this, "ipam_resource_discovery_region");
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool> IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// OperatingRegions block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingRegions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    public required TerraformSet<AwsVpcIpamResourceDiscoveryOperatingRegionsBlock> OperatingRegions
    {
        get => GetRequiredArgument<TerraformSet<AwsVpcIpamResourceDiscoveryOperatingRegionsBlock>>("operating_regions");
        set => SetArgument("operating_regions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpamResourceDiscoveryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpamResourceDiscoveryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
