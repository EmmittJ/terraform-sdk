using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_managed_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerRegionalSecretCustomerManagedEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey used to encrypt secret payloads.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for rotation in .
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerRegionalSecretRotationBlock : TerraformBlock
{
    /// <summary>
    /// Timestamp in UTC at which the Secret is scheduled to rotate.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? NextRotationTime
    {
        get => GetProperty<TerraformProperty<string>>("next_rotation_time");
        set => WithProperty("next_rotation_time", value);
    }

    /// <summary>
    /// The Duration between rotation notifications. Must be in seconds and at least 3600s (1h)
    /// and at most 3153600000s (100 years). If rotationPeriod is set, &#39;next_rotation_time&#39; must
    /// be set. &#39;next_rotation_time&#39; will be advanced by this period when the service
    /// automatically sends rotation notifications.
    /// </summary>
    public TerraformProperty<string>? RotationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("rotation_period");
        set => WithProperty("rotation_period", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerRegionalSecretTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for topics in .
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerRegionalSecretTopicsBlock : TerraformBlock
{
    /// <summary>
    /// The resource name of the Pub/Sub topic that will be published to, in the following format:
    /// projects/*/topics/*. For publication to succeed, the Secret Manager Service
    /// Agent service account must have pubsub.publisher permissions on the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a google_secret_manager_regional_secret resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecretManagerRegionalSecret : TerraformResource
{
    public GoogleSecretManagerRegionalSecret(string name) : base("google_secret_manager_regional_secret", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_annotations");
        this.WithOutput("effective_labels");
        this.WithOutput("name");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// Custom metadata about the regional secret.
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
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the regional secret. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the federation will fail.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// Timestamp in UTC when the regional secret is scheduled to expire. This is always provided on
    /// output, regardless of what was sent on input. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with
    /// nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;. Only one of &#39;expire_time&#39; or &#39;ttl&#39; can be provided.
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
    /// The labels assigned to this regional secret.
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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the regional secret. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret_id");
        set => this.WithProperty("secret_id", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The TTL for the regional secret. A duration in seconds with up to nine fractional digits,
    /// terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Only one of &#39;ttl&#39; or &#39;expire_time&#39; can be provided.
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
    public Dictionary<string, TerraformProperty<string>>? VersionAliases
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("version_aliases");
        set => this.WithProperty("version_aliases", value);
    }

    /// <summary>
    /// Secret Version TTL after destruction request.
    /// This is a part of the delayed delete feature on Secret Version.
    /// For secret with versionDestroyTtl&amp;gt;0, version destruction doesn&#39;t happen immediately
    /// on calling destroy instead the version goes to a disabled state and
    /// the actual destruction happens after this TTL expires. It must be atleast 24h.
    /// </summary>
    public TerraformProperty<string>? VersionDestroyTtl
    {
        get => GetProperty<TerraformProperty<string>>("version_destroy_ttl");
        set => this.WithProperty("version_destroy_ttl", value);
    }

    /// <summary>
    /// Block for customer_managed_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedEncryption block(s) allowed")]
    public List<GoogleSecretManagerRegionalSecretCustomerManagedEncryptionBlock>? CustomerManagedEncryption
    {
        get => GetProperty<List<GoogleSecretManagerRegionalSecretCustomerManagedEncryptionBlock>>("customer_managed_encryption");
        set => this.WithProperty("customer_managed_encryption", value);
    }

    /// <summary>
    /// Block for rotation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rotation block(s) allowed")]
    public List<GoogleSecretManagerRegionalSecretRotationBlock>? Rotation
    {
        get => GetProperty<List<GoogleSecretManagerRegionalSecretRotationBlock>>("rotation");
        set => this.WithProperty("rotation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecretManagerRegionalSecretTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSecretManagerRegionalSecretTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for topics.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleSecretManagerRegionalSecretTopicsBlock>? Topics
    {
        get => GetProperty<List<GoogleSecretManagerRegionalSecretTopicsBlock>>("topics");
        set => this.WithProperty("topics", value);
    }

    /// <summary>
    /// The time at which the regional secret was created.
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
    /// The resource name of the regional secret. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/secrets/{{secret_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
