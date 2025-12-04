using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for service_resolvers in GoogleKmsEkmConnection.
/// Nesting mode: list
/// </summary>
public class GoogleKmsEkmConnectionServiceResolversBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_resolvers";

    /// <summary>
    /// Optional. The filter applied to the endpoints of the resolved service. If no filter is specified, all endpoints will be considered. An endpoint will be chosen arbitrarily from the filtered list for each request. For endpoint filter syntax and examples, see https://cloud.google.com/service-directory/docs/reference/rpc/google.cloud.servicedirectory.v1#resolveservicerequest.
    /// </summary>
    public TerraformValue<string> EndpointFilter
    {
        get => GetArgument<TerraformValue<string>>("endpoint_filter") ?? AsReference("endpoint_filter");
        set => SetArgument("endpoint_filter", value);
    }

    /// <summary>
    /// Required. The hostname of the EKM replica used at TLS and HTTP layers.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// Required. The resource name of the Service Directory service pointing to an EKM replica, in the format projects/*/locations/*/namespaces/*/services/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceDirectoryService is required")]
    public required TerraformValue<string> ServiceDirectoryService
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_directory_service");
        set => SetArgument("service_directory_service", value);
    }

    /// <summary>
    /// ServerCertificates block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerCertificates is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServerCertificates block(s) required")]
    public required TerraformList<GoogleKmsEkmConnectionServiceResolversBlockServerCertificatesBlock> ServerCertificates
    {
        get => GetRequiredArgument<TerraformList<GoogleKmsEkmConnectionServiceResolversBlockServerCertificatesBlock>>("server_certificates");
        set => SetArgument("server_certificates", value);
    }

}

/// <summary>
/// Block type for server_certificates in GoogleKmsEkmConnectionServiceResolversBlock.
/// Nesting mode: list
/// </summary>
public class GoogleKmsEkmConnectionServiceResolversBlockServerCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_certificates";

    /// <summary>
    /// Output only. The issuer distinguished name in RFC 2253 format. Only present if parsed is true.
    /// </summary>
    public TerraformValue<string> Issuer
        => AsReference("issuer");

    /// <summary>
    /// Output only. The certificate is not valid after this time. Only present if parsed is true.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> NotAfterTime
        => AsReference("not_after_time");

    /// <summary>
    /// Output only. The certificate is not valid before this time. Only present if parsed is true.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> NotBeforeTime
        => AsReference("not_before_time");

    /// <summary>
    /// Output only. True if the certificate was parsed successfully.
    /// </summary>
    public TerraformValue<bool> Parsed
        => AsReference("parsed");

    /// <summary>
    /// Required. The raw certificate bytes in DER format. A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RawDer is required")]
    public required TerraformValue<string> RawDer
    {
        get => GetRequiredArgument<TerraformValue<string>>("raw_der");
        set => SetArgument("raw_der", value);
    }

    /// <summary>
    /// Output only. The certificate serial number as a hex string. Only present if parsed is true.
    /// </summary>
    public TerraformValue<string> SerialNumber
        => AsReference("serial_number");

    /// <summary>
    /// Output only. The SHA-256 certificate fingerprint as a hex string. Only present if parsed is true.
    /// </summary>
    public TerraformValue<string> Sha256Fingerprint
        => AsReference("sha256_fingerprint");

    /// <summary>
    /// Output only. The subject distinguished name in RFC 2253 format. Only present if parsed is true.
    /// </summary>
    public TerraformValue<string> Subject
        => AsReference("subject");

    /// <summary>
    /// Output only. The subject Alternative DNS names. Only present if parsed is true.
    /// </summary>
    public TerraformList<string> SubjectAlternativeDnsNames
    {
        get => GetArgument<TerraformList<string>>("subject_alternative_dns_names") ?? AsReference("subject_alternative_dns_names");
        set => SetArgument("subject_alternative_dns_names", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleKmsEkmConnection.
/// Nesting mode: single
/// </summary>
public class GoogleKmsEkmConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a google_kms_ekm_connection Terraform resource.
/// Manages a google_kms_ekm_connection resource.
/// </summary>
public partial class GoogleKmsEkmConnection(string name) : TerraformResource("google_kms_ekm_connection", name)
{
    /// <summary>
    /// Optional. Identifies the EKM Crypto Space that this EkmConnection maps to. Note: This field is required if KeyManagementMode is CLOUD_KMS.
    /// </summary>
    public TerraformValue<string> CryptoSpacePath
    {
        get => GetArgument<TerraformValue<string>>("crypto_space_path") ?? AsReference("crypto_space_path");
        set => SetArgument("crypto_space_path", value);
    }

    /// <summary>
    /// Optional. Etag of the currently stored EkmConnection.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => GetArgument<TerraformValue<string>>("etag") ?? AsReference("etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Optional. Describes who can perform control plane operations on the EKM. If unset, this defaults to MANUAL Default value: &amp;quot;MANUAL&amp;quot; Possible values: [&amp;quot;MANUAL&amp;quot;, &amp;quot;CLOUD_KMS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? KeyManagementMode
    {
        get => GetArgument<TerraformValue<string>>("key_management_mode");
        set => SetArgument("key_management_mode", value);
    }

    /// <summary>
    /// The location for the EkmConnection.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name for the EkmConnection.
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
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. The time at which the EkmConnection was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// ServiceResolvers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceResolvers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceResolvers block(s) required")]
    public required TerraformList<GoogleKmsEkmConnectionServiceResolversBlock> ServiceResolvers
    {
        get => GetRequiredArgument<TerraformList<GoogleKmsEkmConnectionServiceResolversBlock>>("service_resolvers");
        set => SetArgument("service_resolvers", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleKmsEkmConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleKmsEkmConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
