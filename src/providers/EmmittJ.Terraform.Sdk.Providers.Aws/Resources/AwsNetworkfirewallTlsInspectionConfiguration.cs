using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsNetworkfirewallTlsInspectionConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for tls_inspection_configuration in AwsNetworkfirewallTlsInspectionConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls_inspection_configuration";

    /// <summary>
    /// ServerCertificateConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlock>? ServerCertificateConfiguration
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlock>>("server_certificate_configuration");
        set => SetArgument("server_certificate_configuration", value);
    }

}

/// <summary>
/// Block type for server_certificate_configuration in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_certificate_configuration";

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateAuthorityArn
    {
        get => new TerraformReference<string>(this, "certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// CheckCertificateRevocationStatus block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockCheckCertificateRevocationStatusBlock>? CheckCertificateRevocationStatus
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockCheckCertificateRevocationStatusBlock>>("check_certificate_revocation_status");
        set => SetArgument("check_certificate_revocation_status", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// ServerCertificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockServerCertificateBlock>? ServerCertificate
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockServerCertificateBlock>>("server_certificate");
        set => SetArgument("server_certificate", value);
    }

}

/// <summary>
/// Block type for check_certificate_revocation_status in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockCheckCertificateRevocationStatusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "check_certificate_revocation_status";

    /// <summary>
    /// The revoked_status_action attribute.
    /// </summary>
    public TerraformValue<string>? RevokedStatusAction
    {
        get => new TerraformReference<string>(this, "revoked_status_action");
        set => SetArgument("revoked_status_action", value);
    }

    /// <summary>
    /// The unknown_status_action attribute.
    /// </summary>
    public TerraformValue<string>? UnknownStatusAction
    {
        get => new TerraformReference<string>(this, "unknown_status_action");
        set => SetArgument("unknown_status_action", value);
    }

}

/// <summary>
/// Block type for scope in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public required TerraformSet<double> Protocols
    {
        get => TerraformSet<double>.Lazy(ctx => new TerraformReference<TerraformSet<double>>(this, "protocols").ResolveNodes(ctx));
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// DestinationPorts block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockDestinationPortsBlock>? DestinationPorts
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockDestinationPortsBlock>>("destination_ports");
        set => SetArgument("destination_ports", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// SourcePorts block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockSourcePortsBlock>? SourcePorts
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockSourcePortsBlock>>("source_ports");
        set => SetArgument("source_ports", value);
    }

}

/// <summary>
/// Block type for destination in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The address_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressDefinition is required")]
    public required TerraformValue<string> AddressDefinition
    {
        get => new TerraformReference<string>(this, "address_definition");
        set => SetArgument("address_definition", value);
    }

}

/// <summary>
/// Block type for destination_ports in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockDestinationPortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_ports";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}

/// <summary>
/// Block type for source in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The address_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressDefinition is required")]
    public required TerraformValue<string> AddressDefinition
    {
        get => new TerraformReference<string>(this, "address_definition");
        set => SetArgument("address_definition", value);
    }

}

/// <summary>
/// Block type for source_ports in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockScopeBlockSourcePortsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_ports";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformValue<double> ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}

/// <summary>
/// Block type for server_certificate in AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlockServerCertificateConfigurationBlockServerCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_certificate";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string>? ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}


/// <summary>
/// Represents a aws_networkfirewall_tls_inspection_configuration Terraform resource.
/// Manages a aws_networkfirewall_tls_inspection_configuration resource.
/// </summary>
public partial class AwsNetworkfirewallTlsInspectionConfiguration(string name) : TerraformResource("aws_networkfirewall_tls_inspection_configuration", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_configuration").ResolveNodes(ctx));
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate_authority attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateAuthority
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate_authority").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The number_of_associations attribute.
    /// </summary>
    public TerraformValue<double> NumberOfAssociations
    {
        get => new TerraformReference<double>(this, "number_of_associations");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tls_inspection_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> TlsInspectionConfigurationId
    {
        get => new TerraformReference<string>(this, "tls_inspection_configuration_id");
    }

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformValue<string> UpdateToken
    {
        get => new TerraformReference<string>(this, "update_token");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkfirewallTlsInspectionConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TlsInspectionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock>? TlsInspectionConfiguration
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallTlsInspectionConfigurationTlsInspectionConfigurationBlock>>("tls_inspection_configuration");
        set => SetArgument("tls_inspection_configuration", value);
    }

}
