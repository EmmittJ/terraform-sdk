using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_ipam.
/// </summary>
public class AwsVpcIpamDataSource : TerraformDataSource
{
    public AwsVpcIpamDataSource(string name) : base("aws_vpc_ipam", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_association_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultResourceDiscoveryAssociationId => new TerraformReference(this, "default_resource_discovery_association_id");

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultResourceDiscoveryId => new TerraformReference(this, "default_resource_discovery_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    [TerraformPropertyName("enable_private_gua")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnablePrivateGua => new TerraformReference(this, "enable_private_gua");

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    [TerraformPropertyName("ipam_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpamRegion => new TerraformReference(this, "ipam_region");

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    [TerraformPropertyName("metered_account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MeteredAccount => new TerraformReference(this, "metered_account");

    /// <summary>
    /// The operating_regions attribute.
    /// </summary>
    [TerraformPropertyName("operating_regions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OperatingRegions => new TerraformReference(this, "operating_regions");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerId => new TerraformReference(this, "owner_id");

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("private_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateDefaultScopeId => new TerraformReference(this, "private_default_scope_id");

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("public_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicDefaultScopeId => new TerraformReference(this, "public_default_scope_id");

    /// <summary>
    /// The resource_discovery_association_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_discovery_association_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ResourceDiscoveryAssociationCount => new TerraformReference(this, "resource_discovery_association_count");

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    [TerraformPropertyName("scope_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScopeCount => new TerraformReference(this, "scope_count");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The state_message attribute.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateMessage => new TerraformReference(this, "state_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Tier => new TerraformReference(this, "tier");

}
