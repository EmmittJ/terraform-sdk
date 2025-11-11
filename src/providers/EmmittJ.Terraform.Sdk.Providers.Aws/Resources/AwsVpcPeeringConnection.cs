using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcPeeringConnectionAccepterBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    [TerraformProperty("allow_remote_vpc_dns_resolution")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowRemoteVpcDnsResolution { get; set; }

}

/// <summary>
/// Block type for requester in .
/// Nesting mode: list
/// </summary>
public partial class AwsVpcPeeringConnectionRequesterBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    [TerraformProperty("allow_remote_vpc_dns_resolution")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowRemoteVpcDnsResolution { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVpcPeeringConnectionTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_vpc_peering_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVpcPeeringConnection : TerraformResource
{
    public AwsVpcPeeringConnection(string name) : base("aws_vpc_peering_connection", name)
    {
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    [TerraformProperty("auto_accept")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoAccept { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    [TerraformProperty("peer_owner_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PeerOwnerId { get; set; }

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformProperty("peer_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PeerRegion { get; set; }

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerVpcId is required")]
    [TerraformProperty("peer_vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeerVpcId { get; set; }

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
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

    /// <summary>
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    [TerraformProperty("accepter")]
    public partial TerraformList<TerraformBlock<AwsVpcPeeringConnectionAccepterBlock>>? Accepter { get; set; }

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    [TerraformProperty("requester")]
    public partial TerraformList<TerraformBlock<AwsVpcPeeringConnectionRequesterBlock>>? Requester { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsVpcPeeringConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accept_status attribute.
    /// </summary>
    [TerraformProperty("accept_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AcceptStatus { get; }

}
