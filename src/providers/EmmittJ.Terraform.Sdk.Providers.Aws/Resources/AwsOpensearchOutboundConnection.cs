using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_properties in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionConnectionPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>("", "endpoint");

}

/// <summary>
/// Block type for local_domain_info in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionLocalDomainInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    [TerraformPropertyName("owner_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OwnerId { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Region { get; set; }

}

/// <summary>
/// Block type for remote_domain_info in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionRemoteDomainInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    [TerraformPropertyName("owner_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OwnerId { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Region { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOpensearchOutboundConnectionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_opensearch_outbound_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchOutboundConnection : TerraformResource
{
    public AwsOpensearchOutboundConnection(string name) : base("aws_opensearch_outbound_connection", name)
    {
    }

    /// <summary>
    /// The accept_connection attribute.
    /// </summary>
    [TerraformPropertyName("accept_connection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AcceptConnection { get; set; }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionAlias is required")]
    [TerraformPropertyName("connection_alias")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionAlias { get; set; }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformPropertyName("connection_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ConnectionMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_mode");

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
    /// Block for connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionProperties block(s) allowed")]
    [TerraformPropertyName("connection_properties")]
    public TerraformList<TerraformBlock<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>>? ConnectionProperties { get; set; } = new();

    /// <summary>
    /// Block for local_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDomainInfo block(s) allowed")]
    [TerraformPropertyName("local_domain_info")]
    public TerraformList<TerraformBlock<AwsOpensearchOutboundConnectionLocalDomainInfoBlock>>? LocalDomainInfo { get; set; } = new();

    /// <summary>
    /// Block for remote_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RemoteDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteDomainInfo block(s) allowed")]
    [TerraformPropertyName("remote_domain_info")]
    public TerraformList<TerraformBlock<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock>>? RemoteDomainInfo { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOpensearchOutboundConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    [TerraformPropertyName("connection_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_status");

}
