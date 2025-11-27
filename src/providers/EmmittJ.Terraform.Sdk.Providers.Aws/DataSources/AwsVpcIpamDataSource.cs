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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryAssociationId
    {
        get => new TerraformReference<string>(this, "default_resource_discovery_association_id");
    }

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultResourceDiscoveryId
    {
        get => new TerraformReference<string>(this, "default_resource_discovery_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    public TerraformValue<bool> EnablePrivateGua
    {
        get => new TerraformReference<bool>(this, "enable_private_gua");
    }

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    public TerraformValue<string> IpamRegion
    {
        get => new TerraformReference<string>(this, "ipam_region");
    }

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    public TerraformValue<string> MeteredAccount
    {
        get => new TerraformReference<string>(this, "metered_account");
    }

    /// <summary>
    /// The operating_regions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OperatingRegions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "operating_regions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PrivateDefaultScopeId
    {
        get => new TerraformReference<string>(this, "private_default_scope_id");
    }

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    public TerraformValue<string> PublicDefaultScopeId
    {
        get => new TerraformReference<string>(this, "public_default_scope_id");
    }

    /// <summary>
    /// The resource_discovery_association_count attribute.
    /// </summary>
    public TerraformValue<double> ResourceDiscoveryAssociationCount
    {
        get => new TerraformReference<double>(this, "resource_discovery_association_count");
    }

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    public TerraformValue<double> ScopeCount
    {
        get => new TerraformReference<double>(this, "scope_count");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The state_message attribute.
    /// </summary>
    public TerraformValue<string> StateMessage
    {
        get => new TerraformReference<string>(this, "state_message");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
    }

}
