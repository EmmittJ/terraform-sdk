using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for certificate in AzurermKeyVaultCertificate.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Contents is required")]
    public required TerraformValue<string> Contents
    {
        get => GetRequiredArgument<TerraformValue<string>>("contents");
        set => SetArgument("contents", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

}


/// <summary>
/// Block type for certificate_policy in AzurermKeyVaultCertificate.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_policy";

    /// <summary>
    /// IssuerParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IssuerParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IssuerParameters block(s) allowed")]
    public required TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockIssuerParametersBlock> IssuerParameters
    {
        get => GetRequiredArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockIssuerParametersBlock>>("issuer_parameters");
        set => SetArgument("issuer_parameters", value);
    }

    /// <summary>
    /// KeyProperties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyProperties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KeyProperties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KeyProperties block(s) allowed")]
    public required TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockKeyPropertiesBlock> KeyProperties
    {
        get => GetRequiredArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockKeyPropertiesBlock>>("key_properties");
        set => SetArgument("key_properties", value);
    }

    /// <summary>
    /// LifetimeAction block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlock>? LifetimeAction
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlock>>("lifetime_action");
        set => SetArgument("lifetime_action", value);
    }

    /// <summary>
    /// SecretProperties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretProperties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecretProperties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretProperties block(s) allowed")]
    public required TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockSecretPropertiesBlock> SecretProperties
    {
        get => GetRequiredArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockSecretPropertiesBlock>>("secret_properties");
        set => SetArgument("secret_properties", value);
    }

    /// <summary>
    /// X509CertificateProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 X509CertificateProperties block(s) allowed")]
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlock>? X509CertificateProperties
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlock>>("x509_certificate_properties");
        set => SetArgument("x509_certificate_properties", value);
    }

}

/// <summary>
/// Block type for issuer_parameters in AzurermKeyVaultCertificateCertificatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockIssuerParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "issuer_parameters";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for key_properties in AzurermKeyVaultCertificateCertificatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockKeyPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_properties";

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformValue<string> Curve
    {
        get => GetArgument<TerraformValue<string>>("curve") ?? AsReference("curve");
        set => SetArgument("curve", value);
    }

    /// <summary>
    /// The exportable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exportable is required")]
    public required TerraformValue<bool> Exportable
    {
        get => GetRequiredArgument<TerraformValue<bool>>("exportable");
        set => SetArgument("exportable", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformValue<double> KeySize
    {
        get => GetArgument<TerraformValue<double>>("key_size") ?? AsReference("key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformValue<string> KeyType
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_type");
        set => SetArgument("key_type", value);
    }

    /// <summary>
    /// The reuse_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReuseKey is required")]
    public required TerraformValue<bool> ReuseKey
    {
        get => GetRequiredArgument<TerraformValue<bool>>("reuse_key");
        set => SetArgument("reuse_key", value);
    }

}

/// <summary>
/// Block type for lifetime_action in AzurermKeyVaultCertificateCertificatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifetime_action";

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public required TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlockTriggerBlock> Trigger
    {
        get => GetRequiredArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for action in AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformValue<string> ActionType
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_type");
        set => SetArgument("action_type", value);
    }

}

/// <summary>
/// Block type for trigger in AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockLifetimeActionBlockTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The days_before_expiry attribute.
    /// </summary>
    public TerraformValue<double>? DaysBeforeExpiry
    {
        get => GetArgument<TerraformValue<double>>("days_before_expiry");
        set => SetArgument("days_before_expiry", value);
    }

    /// <summary>
    /// The lifetime_percentage attribute.
    /// </summary>
    public TerraformValue<double>? LifetimePercentage
    {
        get => GetArgument<TerraformValue<double>>("lifetime_percentage");
        set => SetArgument("lifetime_percentage", value);
    }

}

/// <summary>
/// Block type for secret_properties in AzurermKeyVaultCertificateCertificatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockSecretPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret_properties";

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentType is required")]
    public required TerraformValue<string> ContentType
    {
        get => GetRequiredArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

}

/// <summary>
/// Block type for x509_certificate_properties in AzurermKeyVaultCertificateCertificatePolicyBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "x509_certificate_properties";

    /// <summary>
    /// The extended_key_usage attribute.
    /// </summary>
    public TerraformList<string> ExtendedKeyUsage
    {
        get => GetArgument<TerraformList<string>>("extended_key_usage") ?? AsReference("extended_key_usage");
        set => SetArgument("extended_key_usage", value);
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUsage is required")]
    public required TerraformSet<string> KeyUsage
    {
        get => GetRequiredArgument<TerraformSet<string>>("key_usage");
        set => SetArgument("key_usage", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    public required TerraformValue<string> Subject
    {
        get => GetRequiredArgument<TerraformValue<string>>("subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// The validity_in_months attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidityInMonths is required")]
    public required TerraformValue<double> ValidityInMonths
    {
        get => GetRequiredArgument<TerraformValue<double>>("validity_in_months");
        set => SetArgument("validity_in_months", value);
    }

    /// <summary>
    /// SubjectAlternativeNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeNames block(s) allowed")]
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlockSubjectAlternativeNamesBlock>? SubjectAlternativeNames
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlockSubjectAlternativeNamesBlock>>("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

}

/// <summary>
/// Block type for subject_alternative_names in AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlockX509CertificatePropertiesBlockSubjectAlternativeNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_alternative_names";

    /// <summary>
    /// The dns_names attribute.
    /// </summary>
    public TerraformSet<string>? DnsNames
    {
        get => GetArgument<TerraformSet<string>>("dns_names");
        set => SetArgument("dns_names", value);
    }

    /// <summary>
    /// The emails attribute.
    /// </summary>
    public TerraformSet<string>? Emails
    {
        get => GetArgument<TerraformSet<string>>("emails");
        set => SetArgument("emails", value);
    }

    /// <summary>
    /// The upns attribute.
    /// </summary>
    public TerraformSet<string>? Upns
    {
        get => GetArgument<TerraformSet<string>>("upns");
        set => SetArgument("upns", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKeyVaultCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_certificate Terraform resource.
/// Manages a azurerm_key_vault_certificate resource.
/// </summary>
public partial class AzurermKeyVaultCertificate(string name) : TerraformResource("azurerm_key_vault_certificate", name)
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateAttribute
        => AsReference("certificate_attribute");

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    public TerraformValue<string> CertificateData
        => AsReference("certificate_data");

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> CertificateDataBase64
        => AsReference("certificate_data_base64");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerId
        => AsReference("resource_manager_id");

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerVersionlessId
        => AsReference("resource_manager_versionless_id");

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformValue<string> SecretId
        => AsReference("secret_id");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessId
        => AsReference("versionless_id");

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessSecretId
        => AsReference("versionless_secret_id");

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public TerraformList<AzurermKeyVaultCertificateCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// CertificatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlock>? CertificatePolicy
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlock>>("certificate_policy");
        set => SetArgument("certificate_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
