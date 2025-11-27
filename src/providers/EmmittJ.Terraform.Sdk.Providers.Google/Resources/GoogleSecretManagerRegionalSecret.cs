using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_managed_encryption in GoogleSecretManagerRegionalSecret.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerRegionalSecretCustomerManagedEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_encryption";

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey used to encrypt secret payloads.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for rotation in GoogleSecretManagerRegionalSecret.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerRegionalSecretRotationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rotation";

    /// <summary>
    /// Timestamp in UTC at which the Secret is scheduled to rotate.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NextRotationTime
    {
        get => new TerraformReference<string>(this, "next_rotation_time");
        set => SetArgument("next_rotation_time", value);
    }

    /// <summary>
    /// The Duration between rotation notifications. Must be in seconds and at least 3600s (1h)
    /// and at most 3153600000s (100 years). If rotationPeriod is set, &#39;next_rotation_time&#39; must
    /// be set. &#39;next_rotation_time&#39; will be advanced by this period when the service
    /// automatically sends rotation notifications.
    /// </summary>
    public TerraformValue<string>? RotationPeriod
    {
        get => new TerraformReference<string>(this, "rotation_period");
        set => SetArgument("rotation_period", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSecretManagerRegionalSecret.
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerRegionalSecretTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for topics in GoogleSecretManagerRegionalSecret.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerRegionalSecretTopicsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topics";

    /// <summary>
    /// The resource name of the Pub/Sub topic that will be published to, in the following format:
    /// projects/*/topics/*. For publication to succeed, the Secret Manager Service
    /// Agent service account must have pubsub.publisher permissions on the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a google_secret_manager_regional_secret Terraform resource.
/// Manages a google_secret_manager_regional_secret resource.
/// </summary>
public partial class GoogleSecretManagerRegionalSecret(string name) : TerraformResource("google_secret_manager_regional_secret", name)
{
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
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the regional secret. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the federation will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// Timestamp in UTC when the regional secret is scheduled to expire. This is always provided on
    /// output, regardless of what was sent on input. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with
    /// nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and
    /// &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;. Only one of &#39;expire_time&#39; or &#39;ttl&#39; can be provided.
    /// </summary>
    public TerraformValue<string> ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
        set => SetArgument("expire_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the regional secret. eg us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// This must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => new TerraformReference<string>(this, "secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The TTL for the regional secret. A duration in seconds with up to nine fractional digits,
    /// terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Only one of &#39;ttl&#39; or &#39;expire_time&#39; can be provided.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => new TerraformReference<string>(this, "ttl");
        set => SetArgument("ttl", value);
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
    public TerraformMap<string>? VersionAliases
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "version_aliases").ResolveNodes(ctx));
        set => SetArgument("version_aliases", value);
    }

    /// <summary>
    /// Secret Version TTL after destruction request.
    /// This is a part of the delayed delete feature on Secret Version.
    /// For secret with versionDestroyTtl&amp;gt;0, version destruction doesn&#39;t happen immediately
    /// on calling destroy instead the version goes to a disabled state and
    /// the actual destruction happens after this TTL expires. It must be atleast 24h.
    /// </summary>
    public TerraformValue<string>? VersionDestroyTtl
    {
        get => new TerraformReference<string>(this, "version_destroy_ttl");
        set => SetArgument("version_destroy_ttl", value);
    }

    /// <summary>
    /// The time at which the regional secret was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource name of the regional secret. Format:
    /// &#39;projects/{{project}}/locations/{{location}}/secrets/{{secret_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// CustomerManagedEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedEncryption block(s) allowed")]
    public TerraformList<GoogleSecretManagerRegionalSecretCustomerManagedEncryptionBlock>? CustomerManagedEncryption
    {
        get => GetArgument<TerraformList<GoogleSecretManagerRegionalSecretCustomerManagedEncryptionBlock>>("customer_managed_encryption");
        set => SetArgument("customer_managed_encryption", value);
    }

    /// <summary>
    /// Rotation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rotation block(s) allowed")]
    public TerraformList<GoogleSecretManagerRegionalSecretRotationBlock>? Rotation
    {
        get => GetArgument<TerraformList<GoogleSecretManagerRegionalSecretRotationBlock>>("rotation");
        set => SetArgument("rotation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecretManagerRegionalSecretTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecretManagerRegionalSecretTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Topics block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleSecretManagerRegionalSecretTopicsBlock>? Topics
    {
        get => GetArgument<TerraformList<GoogleSecretManagerRegionalSecretTopicsBlock>>("topics");
        set => SetArgument("topics", value);
    }

}
