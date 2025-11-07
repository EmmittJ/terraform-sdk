using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_certificate_manager_certificate_map_entry resource.
/// </summary>
public class GoogleCertificateManagerCertificateMapEntry : TerraformResource
{
    public GoogleCertificateManagerCertificateMapEntry(string name) : base("google_certificate_manager_certificate_map_entry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A set of Certificates defines for the given hostname.
    /// There can be defined up to fifteen certificates in each Certificate Map Entry.
    /// Each certificate must match pattern projects/*/locations/*/certificates/*.
    /// </summary>
    public TerraformProperty<List<string>>? Certificates
    {
        get => GetProperty<TerraformProperty<List<string>>>("certificates");
        set => this.WithProperty("certificates", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A Hostname (FQDN, e.g. example.com) or a wildcard hostname expression (*.example.com)
    /// for a set of hostnames with common suffix. Used as Server Name Indication (SNI) for
    /// selecting a proper certificate.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => this.WithProperty("hostname", value);
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
    /// Set of labels associated with a Certificate Map Entry.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// A map entry that is inputted into the certificate map
    /// </summary>
    public TerraformProperty<string>? Map
    {
        get => GetProperty<TerraformProperty<string>>("map");
        set => this.WithProperty("map", value);
    }

    /// <summary>
    /// A predefined matcher for particular cases, other than SNI selection
    /// </summary>
    public TerraformProperty<string>? Matcher
    {
        get => GetProperty<TerraformProperty<string>>("matcher");
        set => this.WithProperty("matcher", value);
    }

    /// <summary>
    /// A user-defined name of the Certificate Map Entry. Certificate Map Entry
    /// names must be unique globally and match pattern
    /// &#39;projects/*/locations/*/certificateMaps/*/certificateMapEntries/*&#39;
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Creation timestamp of a Certificate Map Entry. Timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A serving state of this Certificate Map Entry.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Update timestamp of a Certificate Map Entry. Timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
