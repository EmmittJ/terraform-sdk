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
        set => SetProperty("endpoint", value);
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
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    public required TerraformProperty<string> OwnerId
    {
        set => SetProperty("owner_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        set => SetProperty("region", value);
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
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwnerId is required")]
    public required TerraformProperty<string> OwnerId
    {
        set => SetProperty("owner_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        set => SetProperty("region", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_opensearch_outbound_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchOutboundConnection : TerraformResource
{
    public AwsOpensearchOutboundConnection(string name) : base("aws_opensearch_outbound_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("connection_status");
        SetOutput("accept_connection");
        SetOutput("connection_alias");
        SetOutput("connection_mode");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The accept_connection attribute.
    /// </summary>
    public TerraformProperty<bool> AcceptConnection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("accept_connection");
        set => SetProperty("accept_connection", value);
    }

    /// <summary>
    /// The connection_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionAlias is required")]
    public required TerraformProperty<string> ConnectionAlias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_alias");
        set => SetProperty("connection_alias", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_mode");
        set => SetProperty("connection_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for connection_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionProperties block(s) allowed")]
    public List<AwsOpensearchOutboundConnectionConnectionPropertiesBlock>? ConnectionProperties
    {
        set => SetProperty("connection_properties", value);
    }

    /// <summary>
    /// Block for local_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDomainInfo block(s) allowed")]
    public List<AwsOpensearchOutboundConnectionLocalDomainInfoBlock>? LocalDomainInfo
    {
        set => SetProperty("local_domain_info", value);
    }

    /// <summary>
    /// Block for remote_domain_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteDomainInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RemoteDomainInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RemoteDomainInfo block(s) allowed")]
    public List<AwsOpensearchOutboundConnectionRemoteDomainInfoBlock>? RemoteDomainInfo
    {
        set => SetProperty("remote_domain_info", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOpensearchOutboundConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformExpression ConnectionStatus => this["connection_status"];

}
