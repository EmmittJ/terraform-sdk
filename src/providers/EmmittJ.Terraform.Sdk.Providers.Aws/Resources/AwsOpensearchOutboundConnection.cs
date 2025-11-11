using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchOutboundConnectionConnectionPropertiesBlock : TerraformBlockBase
{

}

/// <summary>
/// Block type for local_domain_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchOutboundConnectionLocalDomainInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    [TerraformProperty("owner_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OwnerId { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for remote_domain_info in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchOutboundConnectionRemoteDomainInfoBlock : TerraformBlockBase
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    [TerraformProperty("owner_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OwnerId { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOpensearchOutboundConnectionTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a aws_opensearch_outbound_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsOpensearchOutboundConnection : TerraformResource
{
    public AwsOpensearchOutboundConnection(string name) : base("aws_opensearch_outbound_connection", name)
    {
    }

    /// <summary>
    /// The accept_connection attribute.
    /// </summary>
    [TerraformProperty("accept_connection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AcceptConnection { get; set; }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionAlias is required")]
    [TerraformProperty("connection_alias")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionAlias { get; set; }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformProperty("connection_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ConnectionMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionProperties block(s) allowed")]
    [TerraformProperty("connection_properties")]
    public partial TerraformList<TerraformBlock<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>>? ConnectionProperties { get; set; }

    /// <summary>
    /// Block for local_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDomainInfo block(s) allowed")]
    [TerraformProperty("local_domain_info")]
    public partial TerraformList<TerraformBlock<AwsOpensearchOutboundConnectionLocalDomainInfoBlock>>? LocalDomainInfo { get; set; }

    /// <summary>
    /// Block for remote_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RemoteDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteDomainInfo block(s) allowed")]
    [TerraformProperty("remote_domain_info")]
    public partial TerraformList<TerraformBlock<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock>>? RemoteDomainInfo { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsOpensearchOutboundConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    [TerraformProperty("connection_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionStatus { get; }

}
