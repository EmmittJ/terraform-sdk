using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_ipam.
/// </summary>
public partial class AwsVpcIpamDataSource : TerraformDataSource
{
    public AwsVpcIpamDataSource(string name) : base("aws_vpc_ipam", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_resource_discovery_association_id attribute.
    /// </summary>
    [TerraformProperty("default_resource_discovery_association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultResourceDiscoveryAssociationId { get; }

    /// <summary>
    /// The default_resource_discovery_id attribute.
    /// </summary>
    [TerraformProperty("default_resource_discovery_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultResourceDiscoveryId { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    [TerraformProperty("enable_private_gua")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnablePrivateGua { get; }

    /// <summary>
    /// The ipam_region attribute.
    /// </summary>
    [TerraformProperty("ipam_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpamRegion { get; }

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    [TerraformProperty("metered_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MeteredAccount { get; }

    /// <summary>
    /// The operating_regions attribute.
    /// </summary>
    [TerraformProperty("operating_regions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OperatingRegions { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The private_default_scope_id attribute.
    /// </summary>
    [TerraformProperty("private_default_scope_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateDefaultScopeId { get; }

    /// <summary>
    /// The public_default_scope_id attribute.
    /// </summary>
    [TerraformProperty("public_default_scope_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicDefaultScopeId { get; }

    /// <summary>
    /// The resource_discovery_association_count attribute.
    /// </summary>
    [TerraformProperty("resource_discovery_association_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ResourceDiscoveryAssociationCount { get; }

    /// <summary>
    /// The scope_count attribute.
    /// </summary>
    [TerraformProperty("scope_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ScopeCount { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The state_message attribute.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tier { get; }

}
