using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_properties in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionConnectionPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => WithProperty("endpoint", value);
    }

}

/// <summary>
/// Block type for local_domain_info in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionLocalDomainInfoBlock : TerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    public required TerraformProperty<string> OwnerId
    {
        get => GetProperty<TerraformProperty<string>>("owner_id");
        set => WithProperty("owner_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

}

/// <summary>
/// Block type for remote_domain_info in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchOutboundConnectionRemoteDomainInfoBlock : TerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    public required TerraformProperty<string> OwnerId
    {
        get => GetProperty<TerraformProperty<string>>("owner_id");
        set => WithProperty("owner_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOpensearchOutboundConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_opensearch_outbound_connection resource.
/// </summary>
public class AwsOpensearchOutboundConnection : TerraformResource
{
    public AwsOpensearchOutboundConnection(string name) : base("aws_opensearch_outbound_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_status");
    }

    /// <summary>
    /// The accept_connection attribute.
    /// </summary>
    public TerraformProperty<bool>? AcceptConnection
    {
        get => GetProperty<TerraformProperty<bool>>("accept_connection");
        set => this.WithProperty("accept_connection", value);
    }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionAlias is required")]
    public required TerraformProperty<string> ConnectionAlias
    {
        get => GetProperty<TerraformProperty<string>>("connection_alias");
        set => this.WithProperty("connection_alias", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("connection_mode");
        set => this.WithProperty("connection_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionProperties block(s) allowed")]
    public List<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>? ConnectionProperties
    {
        get => GetProperty<List<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>>("connection_properties");
        set => this.WithProperty("connection_properties", value);
    }

    /// <summary>
    /// Block for local_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDomainInfo block(s) allowed")]
    public List<AwsOpensearchOutboundConnectionLocalDomainInfoBlock>? LocalDomainInfo
    {
        get => GetProperty<List<AwsOpensearchOutboundConnectionLocalDomainInfoBlock>>("local_domain_info");
        set => this.WithProperty("local_domain_info", value);
    }

    /// <summary>
    /// Block for remote_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RemoteDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteDomainInfo block(s) allowed")]
    public List<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock>? RemoteDomainInfo
    {
        get => GetProperty<List<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock>>("remote_domain_info");
        set => this.WithProperty("remote_domain_info", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOpensearchOutboundConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsOpensearchOutboundConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformExpression ConnectionStatus => this["connection_status"];

}
