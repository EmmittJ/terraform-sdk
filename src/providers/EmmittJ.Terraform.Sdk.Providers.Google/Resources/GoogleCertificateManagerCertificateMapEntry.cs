using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleCertificateManagerCertificateMapEntry.
/// Nesting mode: single
/// </summary>
public class GoogleCertificateManagerCertificateMapEntryTimeoutsBlock : TerraformBlock
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
/// Represents a google_certificate_manager_certificate_map_entry Terraform resource.
/// Manages a google_certificate_manager_certificate_map_entry resource.
/// </summary>
public partial class GoogleCertificateManagerCertificateMapEntry(string name) : TerraformResource("google_certificate_manager_certificate_map_entry", name)
{
    /// <summary>
    /// A set of Certificates defines for the given hostname.
    /// There can be defined up to fifteen certificates in each Certificate Map Entry.
    /// Each certificate must match pattern projects/*/locations/*/certificates/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificates is required")]
    public TerraformList<string>? Certificates
    {
        get => GetArgument<TerraformList<string>>("certificates");
        set => SetArgument("certificates", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A Hostname (FQDN, e.g. example.com) or a wildcard hostname expression (*.example.com)
    /// for a set of hostnames with common suffix. Used as Server Name Indication (SNI) for
    /// selecting a proper certificate.
    /// </summary>
    public TerraformValue<string>? Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
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
    /// Set of labels associated with a Certificate Map Entry.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
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
    /// A map entry that is inputted into the certificate map
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Map is required")]
    public required TerraformValue<string> Map
    {
        get => GetArgument<TerraformValue<string>>("map");
        set => SetArgument("map", value);
    }

    /// <summary>
    /// A predefined matcher for particular cases, other than SNI selection
    /// </summary>
    public TerraformValue<string>? Matcher
    {
        get => GetArgument<TerraformValue<string>>("matcher");
        set => SetArgument("matcher", value);
    }

    /// <summary>
    /// A user-defined name of the Certificate Map Entry. Certificate Map Entry
    /// names must be unique globally and match pattern
    /// &#39;projects/*/locations/*/certificateMaps/*/certificateMapEntries/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// Creation timestamp of a Certificate Map Entry. Timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// A serving state of this Certificate Map Entry.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Update timestamp of a Certificate Map Entry. Timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCertificateManagerCertificateMapEntryTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCertificateManagerCertificateMapEntryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
