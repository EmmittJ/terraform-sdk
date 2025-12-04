using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshVirtualGateway.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// BackendDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendDefaults block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlock>? BackendDefaults
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlock>>("backend_defaults");
        set => SetArgument("backend_defaults", value);
    }

    /// <summary>
    /// Listener block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Listener is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Listener block(s) required")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlock> Listener
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlock>>("listener");
        set => SetArgument("listener", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

}

/// <summary>
/// Block type for backend_defaults in AwsAppmeshVirtualGatewaySpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_defaults";

    /// <summary>
    /// ClientPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientPolicy block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlock>? ClientPolicy
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlock>>("client_policy");
        set => SetArgument("client_policy", value);
    }

}

/// <summary>
/// Block type for client_policy in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_policy";

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for tls in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls";

    /// <summary>
    /// The enforce attribute.
    /// </summary>
    public TerraformValue<bool>? Enforce
    {
        get => GetArgument<TerraformValue<bool>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// The ports attribute.
    /// </summary>
    public TerraformSet<double>? Ports
    {
        get => GetArgument<TerraformSet<double>>("ports");
        set => SetArgument("ports", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// Validation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validation block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock> Validation
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}

/// <summary>
/// Block type for certificate in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateChain is required")]
    public required TerraformValue<string> CertificateChain
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

}

/// <summary>
/// Block type for sds in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sds";

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for validation in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// SubjectAlternativeNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeNames block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// Trust block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trust is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trust block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trust block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock> Trust
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock>>("trust");
        set => SetArgument("trust", value);
    }

}

/// <summary>
/// Block type for subject_alternative_names in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_alternative_names";

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exact is required")]
    public required TerraformSet<string> Exact
    {
        get => GetRequiredArgument<TerraformSet<string>>("exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for trust in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust";

    /// <summary>
    /// Acm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Acm block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock>? Acm
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock>>("acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for acm in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acm";

    /// <summary>
    /// The certificate_authority_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArns is required")]
    public required TerraformSet<string> CertificateAuthorityArns
    {
        get => GetRequiredArgument<TerraformSet<string>>("certificate_authority_arns");
        set => SetArgument("certificate_authority_arns", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateChain is required")]
    public required TerraformValue<string> CertificateChain
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

}

/// <summary>
/// Block type for sds in AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sds";

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for listener in AwsAppmeshVirtualGatewaySpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "listener";

    /// <summary>
    /// ConnectionPool block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPool block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlock>? ConnectionPool
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlock>>("connection_pool");
        set => SetArgument("connection_pool", value);
    }

    /// <summary>
    /// HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockHealthCheckBlock>? HealthCheck
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockHealthCheckBlock>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// PortMapping block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortMapping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortMapping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortMapping block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockPortMappingBlock> PortMapping
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockPortMappingBlock>>("port_mapping");
        set => SetArgument("port_mapping", value);
    }

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for connection_pool in AwsAppmeshVirtualGatewaySpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_pool";

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// Http block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockHttpBlock>? Http
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockHttpBlock>>("http");
        set => SetArgument("http", value);
    }

    /// <summary>
    /// Http2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2 block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockHttp2Block>? Http2
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockHttp2Block>>("http2");
        set => SetArgument("http2", value);
    }

}

/// <summary>
/// Block type for grpc in AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// The max_requests attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRequests is required")]
    public required TerraformValue<double> MaxRequests
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_requests");
        set => SetArgument("max_requests", value);
    }

}

/// <summary>
/// Block type for http in AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockHttpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http";

    /// <summary>
    /// The max_connections attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConnections is required")]
    public required TerraformValue<double> MaxConnections
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_connections");
        set => SetArgument("max_connections", value);
    }

    /// <summary>
    /// The max_pending_requests attribute.
    /// </summary>
    public TerraformValue<double>? MaxPendingRequests
    {
        get => GetArgument<TerraformValue<double>>("max_pending_requests");
        set => SetArgument("max_pending_requests", value);
    }

}

/// <summary>
/// Block type for http2 in AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockConnectionPoolBlockHttp2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http2";

    /// <summary>
    /// The max_requests attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRequests is required")]
    public required TerraformValue<double> MaxRequests
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_requests");
        set => SetArgument("max_requests", value);
    }

}

/// <summary>
/// Block type for health_check in AwsAppmeshVirtualGatewaySpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockHealthCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_check";

    /// <summary>
    /// The healthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthyThreshold is required")]
    public required TerraformValue<double> HealthyThreshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("healthy_threshold");
        set => SetArgument("healthy_threshold", value);
    }

    /// <summary>
    /// The interval_millis attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalMillis is required")]
    public required TerraformValue<double> IntervalMillis
    {
        get => GetRequiredArgument<TerraformValue<double>>("interval_millis");
        set => SetArgument("interval_millis", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The timeout_millis attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeoutMillis is required")]
    public required TerraformValue<double> TimeoutMillis
    {
        get => GetRequiredArgument<TerraformValue<double>>("timeout_millis");
        set => SetArgument("timeout_millis", value);
    }

    /// <summary>
    /// The unhealthy_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnhealthyThreshold is required")]
    public required TerraformValue<double> UnhealthyThreshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("unhealthy_threshold");
        set => SetArgument("unhealthy_threshold", value);
    }

}

/// <summary>
/// Block type for port_mapping in AwsAppmeshVirtualGatewaySpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockPortMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_mapping";

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for tls in AwsAppmeshVirtualGatewaySpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Certificate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// Validation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validation block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlock>? Validation
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}

/// <summary>
/// Block type for certificate in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// Acm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Acm block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockAcmBlock>? Acm
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockAcmBlock>>("acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for acm in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockAcmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acm";

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateArn is required")]
    public required TerraformValue<string> CertificateArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_arn");
        set => SetArgument("certificate_arn", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateChain is required")]
    public required TerraformValue<string> CertificateChain
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateKey is required")]
    public required TerraformValue<string> PrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

}

/// <summary>
/// Block type for sds in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockCertificateBlockSdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sds";

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for validation in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// SubjectAlternativeNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeNames block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// Trust block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trust is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trust block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trust block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlock> Trust
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlock>>("trust");
        set => SetArgument("trust", value);
    }

}

/// <summary>
/// Block type for subject_alternative_names in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_alternative_names";

    /// <summary>
    /// Match block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Match is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Match block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Match block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match";

    /// <summary>
    /// The exact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exact is required")]
    public required TerraformSet<string> Exact
    {
        get => GetRequiredArgument<TerraformSet<string>>("exact");
        set => SetArgument("exact", value);
    }

}

/// <summary>
/// Block type for trust in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateChain is required")]
    public required TerraformValue<string> CertificateChain
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

}

/// <summary>
/// Block type for sds in AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockListenerBlockTlsBlockValidationBlockTrustBlockSdsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sds";

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    public required TerraformValue<string> SecretName
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_name");
        set => SetArgument("secret_name", value);
    }

}

/// <summary>
/// Block type for logging in AwsAppmeshVirtualGatewaySpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// AccessLog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLog block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlock>? AccessLog
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlock>>("access_log");
        set => SetArgument("access_log", value);
    }

}

/// <summary>
/// Block type for access_log in AwsAppmeshVirtualGatewaySpecBlockLoggingBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_log";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file";

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Format block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Format block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock>? Format
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock>>("format");
        set => SetArgument("format", value);
    }

}

/// <summary>
/// Block type for format in AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "format";

    /// <summary>
    /// The text attribute.
    /// </summary>
    public TerraformValue<string>? Text
    {
        get => GetArgument<TerraformValue<string>>("text");
        set => SetArgument("text", value);
    }

    /// <summary>
    /// Json block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

}

/// <summary>
/// Block type for json in AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualGatewaySpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlockJsonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_appmesh_virtual_gateway Terraform resource.
/// Manages a aws_appmesh_virtual_gateway resource.
/// </summary>
public partial class AwsAppmeshVirtualGateway(string name) : TerraformResource("aws_appmesh_virtual_gateway", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mesh_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshName is required")]
    public required TerraformValue<string> MeshName
    {
        get => GetRequiredArgument<TerraformValue<string>>("mesh_name");
        set => SetArgument("mesh_name", value);
    }

    /// <summary>
    /// The mesh_owner attribute.
    /// </summary>
    public TerraformValue<string> MeshOwner
    {
        get => GetArgument<TerraformValue<string>>("mesh_owner") ?? AsReference("mesh_owner");
        set => SetArgument("mesh_owner", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => AsReference("last_updated_date");

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
        => AsReference("resource_owner");

    /// <summary>
    /// Spec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualGatewaySpecBlock> Spec
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualGatewaySpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
