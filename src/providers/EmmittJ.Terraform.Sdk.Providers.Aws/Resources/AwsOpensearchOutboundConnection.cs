using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_properties in AwsOpensearchOutboundConnection.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionConnectionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_properties";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// CrossClusterSearch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CrossClusterSearch block(s) allowed")]
    public TerraformList<AwsOpensearchOutboundConnectionConnectionPropertiesBlockCrossClusterSearchBlock>? CrossClusterSearch
    {
        get => GetArgument<TerraformList<AwsOpensearchOutboundConnectionConnectionPropertiesBlockCrossClusterSearchBlock>>("cross_cluster_search");
        set => SetArgument("cross_cluster_search", value);
    }

}

/// <summary>
/// Block type for cross_cluster_search in AwsOpensearchOutboundConnectionConnectionPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionConnectionPropertiesBlockCrossClusterSearchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cross_cluster_search";

    /// <summary>
    /// The skip_unavailable attribute.
    /// </summary>
    public TerraformValue<string>? SkipUnavailable
    {
        get => GetArgument<TerraformValue<string>>("skip_unavailable");
        set => SetArgument("skip_unavailable", value);
    }

}


/// <summary>
/// Block type for local_domain_info in AwsOpensearchOutboundConnection.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionLocalDomainInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_domain_info";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    public required TerraformValue<string> OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for remote_domain_info in AwsOpensearchOutboundConnection.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionRemoteDomainInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "remote_domain_info";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    public required TerraformValue<string> OwnerId
    {
        get => GetArgument<TerraformValue<string>>("owner_id");
        set => SetArgument("owner_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsOpensearchOutboundConnection.
/// Nesting mode: single
/// </summary>
public class AwsOpensearchOutboundConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_opensearch_outbound_connection Terraform resource.
/// Manages a aws_opensearch_outbound_connection resource.
/// </summary>
public partial class AwsOpensearchOutboundConnection(string name) : TerraformResource("aws_opensearch_outbound_connection", name)
{
    /// <summary>
    /// The accept_connection attribute.
    /// </summary>
    public TerraformValue<bool>? AcceptConnection
    {
        get => GetArgument<TerraformValue<bool>>("accept_connection");
        set => SetArgument("accept_connection", value);
    }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionAlias is required")]
    public required TerraformValue<string> ConnectionAlias
    {
        get => GetArgument<TerraformValue<string>>("connection_alias");
        set => SetArgument("connection_alias", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionMode
    {
        get => GetArgument<TerraformValue<string>>("connection_mode");
        set => SetArgument("connection_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformValue<string> ConnectionStatus
        => AsReference("connection_status");

    /// <summary>
    /// ConnectionProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionProperties block(s) allowed")]
    public TerraformList<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>? ConnectionProperties
    {
        get => GetArgument<TerraformList<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>>("connection_properties");
        set => SetArgument("connection_properties", value);
    }

    /// <summary>
    /// LocalDomainInfo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDomainInfo block(s) allowed")]
    public required TerraformList<AwsOpensearchOutboundConnectionLocalDomainInfoBlock> LocalDomainInfo
    {
        get => GetRequiredArgument<TerraformList<AwsOpensearchOutboundConnectionLocalDomainInfoBlock>>("local_domain_info");
        set => SetArgument("local_domain_info", value);
    }

    /// <summary>
    /// RemoteDomainInfo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RemoteDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteDomainInfo block(s) allowed")]
    public required TerraformList<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock> RemoteDomainInfo
    {
        get => GetRequiredArgument<TerraformList<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock>>("remote_domain_info");
        set => SetArgument("remote_domain_info", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOpensearchOutboundConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOpensearchOutboundConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
