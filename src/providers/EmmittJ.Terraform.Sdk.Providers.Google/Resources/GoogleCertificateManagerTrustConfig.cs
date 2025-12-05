using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for allowlisted_certificates in GoogleCertificateManagerTrustConfig.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "allowlisted_certificates";

    /// <summary>
    /// PEM certificate that is allowlisted. The certificate can be up to 5k bytes, and must be a parseable X.509 certificate.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemCertificate is required")]
    public required TerraformValue<string> PemCertificate
    {
        get => GetRequiredArgument<TerraformValue<string>>("pem_certificate");
        set => SetArgument("pem_certificate", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCertificateManagerTrustConfig.
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerTrustConfigTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for trust_stores in GoogleCertificateManagerTrustConfig.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerTrustConfigTrustStoresBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust_stores";

    /// <summary>
    /// IntermediateCas block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCertificateManagerTrustConfigTrustStoresBlockIntermediateCasBlock>? IntermediateCas
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerTrustConfigTrustStoresBlockIntermediateCasBlock>>("intermediate_cas");
        set => SetArgument("intermediate_cas", value);
    }

    /// <summary>
    /// TrustAnchors block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCertificateManagerTrustConfigTrustStoresBlockTrustAnchorsBlock>? TrustAnchors
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerTrustConfigTrustStoresBlockTrustAnchorsBlock>>("trust_anchors");
        set => SetArgument("trust_anchors", value);
    }

}

/// <summary>
/// Block type for intermediate_cas in GoogleCertificateManagerTrustConfigTrustStoresBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerTrustConfigTrustStoresBlockIntermediateCasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intermediate_cas";

    /// <summary>
    /// PEM intermediate certificate used for building up paths for validation.
    /// Each certificate provided in PEM format may occupy up to 5kB.
    /// </summary>
    public TerraformValue<string>? PemCertificate
    {
        get => GetArgument<TerraformValue<string>>("pem_certificate");
        set => SetArgument("pem_certificate", value);
    }

}

/// <summary>
/// Block type for trust_anchors in GoogleCertificateManagerTrustConfigTrustStoresBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCertificateManagerTrustConfigTrustStoresBlockTrustAnchorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trust_anchors";

    /// <summary>
    /// PEM root certificate of the PKI used for validation.
    /// Each certificate provided in PEM format may occupy up to 5kB.
    /// </summary>
    public TerraformValue<string>? PemCertificate
    {
        get => GetArgument<TerraformValue<string>>("pem_certificate");
        set => SetArgument("pem_certificate", value);
    }

}


/// <summary>
/// Represents a google_certificate_manager_trust_config Terraform resource.
/// Manages a google_certificate_manager_trust_config resource.
/// </summary>
public partial class GoogleCertificateManagerTrustConfig(string name) : TerraformResource("google_certificate_manager_trust_config", name)
{
    /// <summary>
    /// One or more paragraphs of text description of a trust config.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the trust config.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The trust config location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// A user-defined name of the trust config. Trust config names must be unique globally.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The creation timestamp of a TrustConfig.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The last update timestamp of a TrustConfig.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// AllowlistedCertificates block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock>? AllowlistedCertificates
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerTrustConfigAllowlistedCertificatesBlock>>("allowlisted_certificates");
        set => SetArgument("allowlisted_certificates", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCertificateManagerTrustConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCertificateManagerTrustConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrustStores block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCertificateManagerTrustConfigTrustStoresBlock>? TrustStores
    {
        get => GetArgument<TerraformList<GoogleCertificateManagerTrustConfigTrustStoresBlock>>("trust_stores");
        set => SetArgument("trust_stores", value);
    }

}
