using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for spec in AwsAppmeshVirtualNode.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spec";

    /// <summary>
    /// Backend block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAppmeshVirtualNodeSpecBlockBackendBlock>? Backend
    {
        get => GetArgument<TerraformSet<AwsAppmeshVirtualNodeSpecBlockBackendBlock>>("backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// BackendDefaults block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackendDefaults block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlock>? BackendDefaults
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlock>>("backend_defaults");
        set => SetArgument("backend_defaults", value);
    }

    /// <summary>
    /// Listener block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlock>? Listener
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlock>>("listener");
        set => SetArgument("listener", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// ServiceDiscovery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDiscovery block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlock>? ServiceDiscovery
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlock>>("service_discovery");
        set => SetArgument("service_discovery", value);
    }

}

/// <summary>
/// Block type for backend in AwsAppmeshVirtualNodeSpecBlock.
/// Nesting mode: set
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend";

    /// <summary>
    /// VirtualService block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualService is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualService block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualService block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlock> VirtualService
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlock>>("virtual_service");
        set => SetArgument("virtual_service", value);
    }

}

/// <summary>
/// Block type for virtual_service in AwsAppmeshVirtualNodeSpecBlockBackendBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_service";

    /// <summary>
    /// The virtual_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualServiceName is required")]
    public required TerraformValue<string> VirtualServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_service_name");
        set => SetArgument("virtual_service_name", value);
    }

    /// <summary>
    /// ClientPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientPolicy block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlock>? ClientPolicy
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlock>>("client_policy");
        set => SetArgument("client_policy", value);
    }

}

/// <summary>
/// Block type for client_policy in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_policy";

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for tls in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// Validation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validation block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlock> Validation
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}

/// <summary>
/// Block type for certificate in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock : TerraformBlock
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
/// Block type for sds in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock : TerraformBlock
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
/// Block type for validation in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// SubjectAlternativeNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeNames block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// Trust block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trust is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trust block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trust block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock> Trust
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock>>("trust");
        set => SetArgument("trust", value);
    }

}

/// <summary>
/// Block type for subject_alternative_names in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock : TerraformBlock
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
/// Block type for trust in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust";

    /// <summary>
    /// Acm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Acm block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock>? Acm
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock>>("acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for acm in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock : TerraformBlock
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
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock : TerraformBlock
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
/// Block type for sds in AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendBlockVirtualServiceBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock : TerraformBlock
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
/// Block type for backend_defaults in AwsAppmeshVirtualNodeSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_defaults";

    /// <summary>
    /// ClientPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientPolicy block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlock>? ClientPolicy
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlock>>("client_policy");
        set => SetArgument("client_policy", value);
    }

}

/// <summary>
/// Block type for client_policy in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_policy";

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for tls in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// Validation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Validation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Validation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validation block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock> Validation
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}

/// <summary>
/// Block type for certificate in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockFileBlock : TerraformBlock
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
/// Block type for sds in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockCertificateBlockSdsBlock : TerraformBlock
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
/// Block type for validation in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// SubjectAlternativeNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeNames block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// Trust block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trust is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trust block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trust block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock> Trust
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock>>("trust");
        set => SetArgument("trust", value);
    }

}

/// <summary>
/// Block type for subject_alternative_names in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock : TerraformBlock
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
/// Block type for trust in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust";

    /// <summary>
    /// Acm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Acm block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock>? Acm
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock>>("acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for acm in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockAcmBlock : TerraformBlock
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
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockFileBlock : TerraformBlock
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
/// Block type for sds in AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockBackendDefaultsBlockClientPolicyBlockTlsBlockValidationBlockTrustBlockSdsBlock : TerraformBlock
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
/// Block type for listener in AwsAppmeshVirtualNodeSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "listener";

    /// <summary>
    /// ConnectionPool block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPool block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock>? ConnectionPool
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock>>("connection_pool");
        set => SetArgument("connection_pool", value);
    }

    /// <summary>
    /// HealthCheck block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheck block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockHealthCheckBlock>? HealthCheck
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockHealthCheckBlock>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// OutlierDetection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutlierDetection block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlock>? OutlierDetection
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlock>>("outlier_detection");
        set => SetArgument("outlier_detection", value);
    }

    /// <summary>
    /// PortMapping block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortMapping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortMapping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortMapping block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockPortMappingBlock> PortMapping
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockPortMappingBlock>>("port_mapping");
        set => SetArgument("port_mapping", value);
    }

    /// <summary>
    /// Timeout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timeout block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock>? Timeout
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for connection_pool in AwsAppmeshVirtualNodeSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_pool";

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// Http block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockHttpBlock>? Http
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockHttpBlock>>("http");
        set => SetArgument("http", value);
    }

    /// <summary>
    /// Http2 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockHttp2Block>? Http2
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockHttp2Block>>("http2");
        set => SetArgument("http2", value);
    }

    /// <summary>
    /// Tcp block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockTcpBlock>? Tcp
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockTcpBlock>>("tcp");
        set => SetArgument("tcp", value);
    }

}

/// <summary>
/// Block type for grpc in AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockGrpcBlock : TerraformBlock
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
/// Block type for http in AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockHttpBlock : TerraformBlock
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
/// Block type for http2 in AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockHttp2Block : TerraformBlock
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
/// Block type for tcp in AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockConnectionPoolBlockTcpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp";

    /// <summary>
    /// The max_connections attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxConnections is required")]
    public required TerraformValue<double> MaxConnections
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_connections");
        set => SetArgument("max_connections", value);
    }

}

/// <summary>
/// Block type for health_check in AwsAppmeshVirtualNodeSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockHealthCheckBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
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
/// Block type for outlier_detection in AwsAppmeshVirtualNodeSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outlier_detection";

    /// <summary>
    /// The max_ejection_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxEjectionPercent is required")]
    public required TerraformValue<double> MaxEjectionPercent
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_ejection_percent");
        set => SetArgument("max_ejection_percent", value);
    }

    /// <summary>
    /// The max_server_errors attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxServerErrors is required")]
    public required TerraformValue<double> MaxServerErrors
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_server_errors");
        set => SetArgument("max_server_errors", value);
    }

    /// <summary>
    /// BaseEjectionDuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseEjectionDuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BaseEjectionDuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseEjectionDuration block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlockBaseEjectionDurationBlock> BaseEjectionDuration
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlockBaseEjectionDurationBlock>>("base_ejection_duration");
        set => SetArgument("base_ejection_duration", value);
    }

    /// <summary>
    /// Interval block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Interval block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Interval block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlockIntervalBlock> Interval
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlockIntervalBlock>>("interval");
        set => SetArgument("interval", value);
    }

}

/// <summary>
/// Block type for base_ejection_duration in AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlockBaseEjectionDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "base_ejection_duration";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for interval in AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockOutlierDetectionBlockIntervalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interval";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for port_mapping in AwsAppmeshVirtualNodeSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockPortMappingBlock : TerraformBlock
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
/// Block type for timeout in AwsAppmeshVirtualNodeSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeout";

    /// <summary>
    /// Grpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grpc block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlock>? Grpc
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlock>>("grpc");
        set => SetArgument("grpc", value);
    }

    /// <summary>
    /// Http block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlock>? Http
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlock>>("http");
        set => SetArgument("http", value);
    }

    /// <summary>
    /// Http2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http2 block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2Block>? Http2
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2Block>>("http2");
        set => SetArgument("http2", value);
    }

    /// <summary>
    /// Tcp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tcp block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlock>? Tcp
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlock>>("tcp");
        set => SetArgument("tcp", value);
    }

}

/// <summary>
/// Block type for grpc in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

    /// <summary>
    /// PerRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRequest block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlockPerRequestBlock>? PerRequest
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlockPerRequestBlock>>("per_request");
        set => SetArgument("per_request", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for per_request in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockGrpcBlockPerRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_request";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for http in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

    /// <summary>
    /// PerRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRequest block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlockPerRequestBlock>? PerRequest
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlockPerRequestBlock>>("per_request");
        set => SetArgument("per_request", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for per_request in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttpBlockPerRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_request";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for http2 in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http2";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2BlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2BlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

    /// <summary>
    /// PerRequest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerRequest block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2BlockPerRequestBlock>? PerRequest
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2BlockPerRequestBlock>>("per_request");
        set => SetArgument("per_request", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2Block.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2BlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for per_request in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2Block.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockHttp2BlockPerRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_request";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tcp in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp";

    /// <summary>
    /// Idle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idle block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlockIdleBlock>? Idle
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlockIdleBlock>>("idle");
        set => SetArgument("idle", value);
    }

}

/// <summary>
/// Block type for idle in AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTimeoutBlockTcpBlockIdleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idle";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetRequiredArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetRequiredArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for tls in AwsAppmeshVirtualNodeSpecBlockListenerBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlock> Certificate
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// Validation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Validation block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlock>? Validation
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlock>>("validation");
        set => SetArgument("validation", value);
    }

}

/// <summary>
/// Block type for certificate in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// Acm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Acm block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockAcmBlock>? Acm
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockAcmBlock>>("acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for acm in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockAcmBlock : TerraformBlock
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
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockFileBlock : TerraformBlock
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
/// Block type for sds in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockCertificateBlockSdsBlock : TerraformBlock
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
/// Block type for validation in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation";

    /// <summary>
    /// SubjectAlternativeNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeNames block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// Trust block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trust is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trust block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trust block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlock> Trust
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlock>>("trust");
        set => SetArgument("trust", value);
    }

}

/// <summary>
/// Block type for subject_alternative_names in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock : TerraformBlock
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
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock> Match
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock>>("match");
        set => SetArgument("match", value);
    }

}

/// <summary>
/// Block type for match in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockSubjectAlternativeNamesBlockMatchBlock : TerraformBlock
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
/// Block type for trust in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

    /// <summary>
    /// Sds block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sds block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlockSdsBlock>? Sds
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlockSdsBlock>>("sds");
        set => SetArgument("sds", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlockFileBlock : TerraformBlock
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
/// Block type for sds in AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockListenerBlockTlsBlockValidationBlockTrustBlockSdsBlock : TerraformBlock
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
/// Block type for logging in AwsAppmeshVirtualNodeSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// AccessLog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLog block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlock>? AccessLog
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlock>>("access_log");
        set => SetArgument("access_log", value);
    }

}

/// <summary>
/// Block type for access_log in AwsAppmeshVirtualNodeSpecBlockLoggingBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_log";

    /// <summary>
    /// File block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 File block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlock>? File
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlock>>("file");
        set => SetArgument("file", value);
    }

}

/// <summary>
/// Block type for file in AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock>? Format
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock>>("format");
        set => SetArgument("format", value);
    }

}

/// <summary>
/// Block type for format in AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock : TerraformBlock
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
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

}

/// <summary>
/// Block type for json in AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockLoggingBlockAccessLogBlockFileBlockFormatBlockJsonBlock : TerraformBlock
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
/// Block type for service_discovery in AwsAppmeshVirtualNodeSpecBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_discovery";

    /// <summary>
    /// AwsCloudMap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsCloudMap block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlockAwsCloudMapBlock>? AwsCloudMap
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlockAwsCloudMapBlock>>("aws_cloud_map");
        set => SetArgument("aws_cloud_map", value);
    }

    /// <summary>
    /// Dns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dns block(s) allowed")]
    public TerraformList<AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlockDnsBlock>? Dns
    {
        get => GetArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlockDnsBlock>>("dns");
        set => SetArgument("dns", value);
    }

}

/// <summary>
/// Block type for aws_cloud_map in AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlockAwsCloudMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_cloud_map";

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformMap<string>? Attributes
    {
        get => GetArgument<TerraformMap<string>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

}

/// <summary>
/// Block type for dns in AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppmeshVirtualNodeSpecBlockServiceDiscoveryBlockDnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns";

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The ip_preference attribute.
    /// </summary>
    public TerraformValue<string>? IpPreference
    {
        get => GetArgument<TerraformValue<string>>("ip_preference");
        set => SetArgument("ip_preference", value);
    }

    /// <summary>
    /// The response_type attribute.
    /// </summary>
    public TerraformValue<string>? ResponseType
    {
        get => GetArgument<TerraformValue<string>>("response_type");
        set => SetArgument("response_type", value);
    }

}


/// <summary>
/// Represents a aws_appmesh_virtual_node Terraform resource.
/// Manages a aws_appmesh_virtual_node resource.
/// </summary>
public partial class AwsAppmeshVirtualNode(string name) : TerraformResource("aws_appmesh_virtual_node", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        get => GetArgument<TerraformValue<string>>("mesh_owner") ?? CreateReference("mesh_owner");
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => CreateReference("created_date");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedDate
        => CreateReference("last_updated_date");

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    public TerraformValue<string> ResourceOwner
        => CreateReference("resource_owner");

    /// <summary>
    /// Spec block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Spec is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Spec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spec block(s) allowed")]
    public required TerraformList<AwsAppmeshVirtualNodeSpecBlock> Spec
    {
        get => GetRequiredArgument<TerraformList<AwsAppmeshVirtualNodeSpecBlock>>("spec");
        set => SetArgument("spec", value);
    }

}
