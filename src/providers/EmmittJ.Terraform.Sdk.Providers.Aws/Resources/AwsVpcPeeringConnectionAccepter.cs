using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for accepter in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionAccepterAccepterBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    [TerraformPropertyName("allow_remote_vpc_dns_resolution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowRemoteVpcDnsResolution { get; set; }

}

/// <summary>
/// Block type for requester in .
/// Nesting mode: list
/// </summary>
public class AwsVpcPeeringConnectionAccepterRequesterBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_remote_vpc_dns_resolution attribute.
    /// </summary>
    [TerraformPropertyName("allow_remote_vpc_dns_resolution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowRemoteVpcDnsResolution { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcPeeringConnectionAccepterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_vpc_peering_connection_accepter resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcPeeringConnectionAccepter : TerraformResource
{
    public AwsVpcPeeringConnectionAccepter(string name) : base("aws_vpc_peering_connection_accepter", name)
    {
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    [TerraformPropertyName("auto_accept")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoAccept { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vpc_peering_connection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcPeeringConnectionId is required")]
    [TerraformPropertyName("vpc_peering_connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcPeeringConnectionId { get; set; }

    /// <summary>
    /// Block for accepter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Accepter block(s) allowed")]
    [TerraformPropertyName("accepter")]
    public TerraformList<TerraformBlock<AwsVpcPeeringConnectionAccepterAccepterBlock>>? Accepter { get; set; } = new();

    /// <summary>
    /// Block for requester.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Requester block(s) allowed")]
    [TerraformPropertyName("requester")]
    public TerraformList<TerraformBlock<AwsVpcPeeringConnectionAccepterRequesterBlock>>? Requester { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVpcPeeringConnectionAccepterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The accept_status attribute.
    /// </summary>
    [TerraformPropertyName("accept_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AcceptStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "accept_status");

    /// <summary>
    /// The peer_owner_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_owner_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerOwnerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_owner_id");

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    [TerraformPropertyName("peer_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_region");

    /// <summary>
    /// The peer_vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerVpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_vpc_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

}
