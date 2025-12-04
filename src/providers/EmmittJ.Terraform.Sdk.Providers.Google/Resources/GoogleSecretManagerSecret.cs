using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for replication in GoogleSecretManagerSecret.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication";

    /// <summary>
    /// Auto block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Auto block(s) allowed")]
    public TerraformList<GoogleSecretManagerSecretReplicationBlockAutoBlock>? Auto
    {
        get => GetArgument<TerraformList<GoogleSecretManagerSecretReplicationBlockAutoBlock>>("auto");
        set => SetArgument("auto", value);
    }

    /// <summary>
    /// UserManaged block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManaged block(s) allowed")]
    public TerraformList<GoogleSecretManagerSecretReplicationBlockUserManagedBlock>? UserManaged
    {
        get => GetArgument<TerraformList<GoogleSecretManagerSecretReplicationBlockUserManagedBlock>>("user_managed");
        set => SetArgument("user_managed", value);
    }

}

/// <summary>
/// Block type for auto in GoogleSecretManagerSecretReplicationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretReplicationBlockAutoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto";

    /// <summary>
    /// CustomerManagedEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedEncryption block(s) allowed")]
    public TerraformList<GoogleSecretManagerSecretReplicationBlockAutoBlockCustomerManagedEncryptionBlock>? CustomerManagedEncryption
    {
        get => GetArgument<TerraformList<GoogleSecretManagerSecretReplicationBlockAutoBlockCustomerManagedEncryptionBlock>>("customer_managed_encryption");
        set => SetArgument("customer_managed_encryption", value);
    }

}

/// <summary>
/// Block type for customer_managed_encryption in GoogleSecretManagerSecretReplicationBlockAutoBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretReplicationBlockAutoBlockCustomerManagedEncryptionBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}

/// <summary>
/// Block type for user_managed in GoogleSecretManagerSecretReplicationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretReplicationBlockUserManagedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_managed";

    /// <summary>
    /// Replicas block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replicas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replicas block(s) required")]
    public required TerraformList<GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlock> Replicas
    {
        get => GetRequiredArgument<TerraformList<GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlock>>("replicas");
        set => SetArgument("replicas", value);
    }

}

/// <summary>
/// Block type for replicas in GoogleSecretManagerSecretReplicationBlockUserManagedBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replicas";

    /// <summary>
    /// The canonical IDs of the location to replicate data. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// CustomerManagedEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedEncryption block(s) allowed")]
    public TerraformList<GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlockCustomerManagedEncryptionBlock>? CustomerManagedEncryption
    {
        get => GetArgument<TerraformList<GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlockCustomerManagedEncryptionBlock>>("customer_managed_encryption");
        set => SetArgument("customer_managed_encryption", value);
    }

}

/// <summary>
/// Block type for customer_managed_encryption in GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlock.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretReplicationBlockUserManagedBlockReplicasBlockCustomerManagedEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_encryption";

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination secret.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for rotation in GoogleSecretManagerSecret.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretRotationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rotation";

    /// <summary>
    /// Timestamp in UTC at which the Secret is scheduled to rotate.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NextRotationTime
    {
        get => GetArgument<TerraformValue<string>>("next_rotation_time");
        set => SetArgument("next_rotation_time", value);
    }

    /// <summary>
    /// The Duration between rotation notifications. Must be in seconds and at least 3600s (1h) and at most 3153600000s (100 years).
    /// If rotationPeriod is set, &#39;next_rotation_time&#39; must be set. &#39;next_rotation_time&#39; will be advanced by this period when the service automatically sends rotation notifications.
    /// </summary>
    public TerraformValue<string>? RotationPeriod
    {
        get => GetArgument<TerraformValue<string>>("rotation_period");
        set => SetArgument("rotation_period", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSecretManagerSecret.
/// Nesting mode: single
/// </summary>
public class GoogleSecretManagerSecretTimeoutsBlock : TerraformBlock
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
/// Block type for topics in GoogleSecretManagerSecret.
/// Nesting mode: list
/// </summary>
public class GoogleSecretManagerSecretTopicsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topics";

    /// <summary>
    /// The resource name of the Pub/Sub topic that will be published to, in the following format: projects/*/topics/*.
    /// For publication to succeed, the Secret Manager Service Agent service account must have pubsub.publisher permissions on the topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a google_secret_manager_secret Terraform resource.
/// Manages a google_secret_manager_secret resource.
/// </summary>
public partial class GoogleSecretManagerSecret(string name) : TerraformResource("google_secret_manager_secret", name)
{
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
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the secret. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the secret will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// Only one of &#39;expire_time&#39; or &#39;ttl&#39; can be provided.
    /// </summary>
    public TerraformValue<string>? ExpireTime
    {
        get => GetArgument<TerraformValue<string>>("expire_time");
        set => SetArgument("expire_time", value);
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
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
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
    /// This must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The TTL for the Secret.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// Only one of &#39;ttl&#39; or &#39;expire_time&#39; can be provided.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => GetArgument<TerraformValue<string>>("ttl");
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
        get => GetArgument<TerraformMap<string>>("version_aliases");
        set => SetArgument("version_aliases", value);
    }

    /// <summary>
    /// Secret Version TTL after destruction request.
    /// This is a part of the delayed delete feature on Secret Version.
    /// For secret with versionDestroyTtl&amp;gt;0, version destruction doesn&#39;t happen immediately
    /// on calling destroy instead the version goes to a disabled state and
    /// the actual destruction happens after this TTL expires.
    /// </summary>
    public TerraformValue<string>? VersionDestroyTtl
    {
        get => GetArgument<TerraformValue<string>>("version_destroy_ttl");
        set => SetArgument("version_destroy_ttl", value);
    }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The resource name of the Secret. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Replication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Replication block(s) allowed")]
    public required TerraformList<GoogleSecretManagerSecretReplicationBlock> Replication
    {
        get => GetRequiredArgument<TerraformList<GoogleSecretManagerSecretReplicationBlock>>("replication");
        set => SetArgument("replication", value);
    }

    /// <summary>
    /// Rotation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rotation block(s) allowed")]
    public TerraformList<GoogleSecretManagerSecretRotationBlock>? Rotation
    {
        get => GetArgument<TerraformList<GoogleSecretManagerSecretRotationBlock>>("rotation");
        set => SetArgument("rotation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecretManagerSecretTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecretManagerSecretTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Topics block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleSecretManagerSecretTopicsBlock>? Topics
    {
        get => GetArgument<TerraformList<GoogleSecretManagerSecretTopicsBlock>>("topics");
        set => SetArgument("topics", value);
    }

}
