using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in GoogleComputeManagedSslCertificate.
/// Nesting mode: list
/// </summary>
public class GoogleComputeManagedSslCertificateManagedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed";

    /// <summary>
    /// Domains for which a managed SSL certificate will be valid.  Currently,
    /// there can be up to 100 domains in this list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domains is required")]
    public TerraformList<string>? Domains
    {
        get => GetArgument<TerraformList<string>>("domains");
        set => SetArgument("domains", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeManagedSslCertificate.
/// Nesting mode: single
/// </summary>
public class GoogleComputeManagedSslCertificateTimeoutsBlock : TerraformBlock
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
/// Represents a google_compute_managed_ssl_certificate Terraform resource.
/// Manages a google_compute_managed_ssl_certificate resource.
/// </summary>
public partial class GoogleComputeManagedSslCertificate(string name) : TerraformResource("google_compute_managed_ssl_certificate", name)
{
    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// 
    /// These are in the same namespace as the managed SSL certificates.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Enum field whose value is always &#39;MANAGED&#39; - used to signal to the API
    /// which type this is. Default value: &amp;quot;MANAGED&amp;quot; Possible values: [&amp;quot;MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> CertificateId
        => AsReference("certificate_id");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// Expire time of the certificate in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => AsReference("expire_time");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Domains associated with the certificate via Subject Alternative Name.
    /// </summary>
    public TerraformList<string> SubjectAlternativeNames
        => AsReference("subject_alternative_names");

    /// <summary>
    /// Managed block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    public TerraformList<GoogleComputeManagedSslCertificateManagedBlock>? Managed
    {
        get => GetArgument<TerraformList<GoogleComputeManagedSslCertificateManagedBlock>>("managed");
        set => SetArgument("managed", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeManagedSslCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeManagedSslCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
