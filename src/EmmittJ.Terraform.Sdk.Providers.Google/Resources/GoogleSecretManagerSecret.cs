using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_secret_manager_secret resource.
/// </summary>
public class GoogleSecretManagerSecret : TerraformResource
{
    public GoogleSecretManagerSecret(string name) : base("google_secret_manager_secret", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Custom metadata about the secret.
    /// 
    /// Annotations are distinct from various forms of labels. Annotations exist to allow
    /// client tools to store their own state information without requiring a database.
    /// 
    /// Annotation keys must be between 1 and 63 characters long, have a UTF-8 encoding of
    /// maximum 128 bytes, begin and end with an alphanumeric character ([a-z0-9A-Z]), and
    /// may have dashes (-), underscores (_), dots (.), and alphanumerics in between these
    /// symbols.
    /// 
    /// The total size of annotation keys and values must be less than 16KiB.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Annotations
    {
        get => GetProperty<TerraformMapProperty<string>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the secret. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the secret will fail.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// Only one of &#39;expire_time&#39; or &#39;ttl&#39; can be provided.
    /// </summary>
    public TerraformProperty<string>? ExpireTime
    {
        get => GetProperty<TerraformProperty<string>>("expire_time");
        set => this.WithProperty("expire_time", value);
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
    /// The labels assigned to this Secret.
    /// 
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    /// and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    /// 
    /// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    /// and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    /// 
    /// No more than 64 labels can be assigned to a given resource.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
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
    /// This must be unique within the project.
    /// </summary>
    public TerraformProperty<string>? SecretId
    {
        get => GetProperty<TerraformProperty<string>>("secret_id");
        set => this.WithProperty("secret_id", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The TTL for the Secret.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// Only one of &#39;ttl&#39; or &#39;expire_time&#39; can be provided.
    /// </summary>
    public TerraformProperty<string>? Ttl
    {
        get => GetProperty<TerraformProperty<string>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// Mapping from version alias to version name.
    /// 
    /// A version alias is a string with a maximum length of 63 characters and can contain
    /// uppercase and lowercase letters, numerals, and the hyphen (-) and underscore (&#39;_&#39;)
    /// characters. An alias string must start with a letter and cannot be the string
    /// &#39;latest&#39; or &#39;NEW&#39;. No more than 50 aliases can be assigned to a given secret.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMapProperty<string>? VersionAliases
    {
        get => GetProperty<TerraformMapProperty<string>>("version_aliases");
        set => this.WithProperty("version_aliases", value);
    }

    /// <summary>
    /// Secret Version TTL after destruction request.
    /// This is a part of the delayed delete feature on Secret Version.
    /// For secret with versionDestroyTtl&amp;gt;0, version destruction doesn&#39;t happen immediately
    /// on calling destroy instead the version goes to a disabled state and
    /// the actual destruction happens after this TTL expires.
    /// </summary>
    public TerraformProperty<string>? VersionDestroyTtl
    {
        get => GetProperty<TerraformProperty<string>>("version_destroy_ttl");
        set => this.WithProperty("version_destroy_ttl", value);
    }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name of the Secret. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
