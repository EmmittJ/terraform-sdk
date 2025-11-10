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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultResourceDiscoveryAssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_resource_discovery_association_id");

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    [TerraformPropertyName("default_resource_discovery_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultResourceDiscoveryId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_resource_discovery_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    [TerraformPropertyName("enable_private_gua")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnablePrivateGua => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_private_gua");

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    [TerraformPropertyName("ipam_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpamRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ipam_region");

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    [TerraformPropertyName("metered_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MeteredAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "metered_account");

    /// <summary>
    /// The operating_regions attribute.
    /// </summary>
    [TerraformPropertyName("operating_regions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OperatingRegions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "operating_regions");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_id");

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("private_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateDefaultScopeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_default_scope_id");

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    [TerraformPropertyName("public_default_scope_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicDefaultScopeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_default_scope_id");

    /// <summary>
    /// The resource_discovery_association_count attribute.
    /// </summary>
    [TerraformPropertyName("resource_discovery_association_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ResourceDiscoveryAssociationCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "resource_discovery_association_count");

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    [TerraformPropertyName("scope_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScopeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scope_count");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The state_message attribute.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tier");

}
