using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_ipam Terraform data source.
/// Retrieves information about a aws_vpc_ipam.
/// </summary>
public partial class AwsVpcIpamDataSource(string name) : TerraformDataSource("aws_vpc_ipam", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryAssociationId
        => CreateReference("default_resource_discovery_association_id");

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryId
        => CreateReference("default_resource_discovery_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformValue<bool> EnablePrivateGua
        => CreateReference("enable_private_gua");

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    public TerraformValue<string> IpamRegion
        => CreateReference("ipam_region");

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    public TerraformValue<string> MeteredAccount
        => CreateReference("metered_account");

    /// <summary>
    /// The operating_regions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OperatingRegions
        => CreateReference("operating_regions");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDefaultScopeId
        => CreateReference("private_default_scope_id");

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PublicDefaultScopeId
        => CreateReference("public_default_scope_id");

    /// <summary>
    /// The resource_discovery_association_count attribute.
    /// </summary>
    public TerraformValue<double> ResourceDiscoveryAssociationCount
        => CreateReference("resource_discovery_association_count");

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformValue<double> ScopeCount
        => CreateReference("scope_count");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The state_message attribute.
    /// </summary>
    public TerraformValue<string> StateMessage
        => CreateReference("state_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
        => CreateReference("tier");

}
