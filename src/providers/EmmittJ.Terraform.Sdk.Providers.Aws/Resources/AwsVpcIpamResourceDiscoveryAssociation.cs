using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcIpamResourceDiscoveryAssociation.
/// Nesting mode: single
/// </summary>
public class AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpc_ipam_resource_discovery_association Terraform resource.
/// Manages a aws_vpc_ipam_resource_discovery_association resource.
/// </summary>
public partial class AwsVpcIpamResourceDiscoveryAssociation(string name) : TerraformResource("aws_vpc_ipam_resource_discovery_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipam_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamId is required")]
    public required TerraformValue<string> IpamId
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipam_id");
        set => SetArgument("ipam_id", value);
    }

    /// <summary>
    /// The ipam_resource_discovery_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamResourceDiscoveryId is required")]
    public required TerraformValue<string> IpamResourceDiscoveryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipam_resource_discovery_id");
        set => SetArgument("ipam_resource_discovery_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The ipam_arn attribute.
    /// </summary>
    public TerraformValue<string> IpamArn
        => AsReference("ipam_arn");

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    public TerraformValue<string> IpamRegion
        => AsReference("ipam_region");

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool> IsDefault
        => AsReference("is_default");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcIpamResourceDiscoveryAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
