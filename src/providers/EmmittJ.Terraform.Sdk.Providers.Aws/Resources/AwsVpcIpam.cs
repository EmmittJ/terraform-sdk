using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for operating_regions in .
/// Nesting mode: set
/// </summary>
public partial class AwsVpcIpamOperatingRegionsBlock() : TerraformBlock("operating_regions")
{
    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    [TerraformProperty("region_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RegionName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcIpamTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_ipam resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVpcIpam : TerraformResource
{
    public AwsVpcIpam(string name) : base("aws_vpc_ipam", name)
    {
    }

    /// <summary>
    /// The cascade attribute.
    /// </summary>
    [TerraformProperty("cascade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Cascade { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enable_private_gua attribute.
    /// </summary>
    [TerraformProperty("enable_private_gua")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePrivateGua { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metered_account attribute.
    /// </summary>
    [TerraformProperty("metered_account")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MeteredAccount { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [TerraformProperty("tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Tier { get; set; }

    /// <summary>
    /// Block for operating_regions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatingRegions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OperatingRegions block(s) required")]
    [TerraformProperty("operating_regions")]
    public required TerraformSet<AwsVpcIpamOperatingRegionsBlock> OperatingRegions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsVpcIpamTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The scope_count attribute.
    /// </summary>
    [TerraformProperty("scope_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ScopeCount { get; }

}
