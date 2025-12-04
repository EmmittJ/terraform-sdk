using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for public_key in GoogleNetworkServicesEdgeCacheKeyset.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheKeysetPublicKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_key";

    /// <summary>
    /// The ID of the public key. The ID must be 1-63 characters long, and comply with RFC1035.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]*
    /// which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Set to true to have the CDN automatically manage this public key value.
    /// </summary>
    public TerraformValue<bool>? Managed
    {
        get => GetArgument<TerraformValue<bool>>("managed");
        set => SetArgument("managed", value);
    }

    /// <summary>
    /// The base64-encoded value of the Ed25519 public key. The base64 encoding can be padded (44 bytes) or unpadded (43 bytes).
    /// Representations or encodings of the public key other than this will be rejected with an error.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesEdgeCacheKeyset.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheKeysetTimeoutsBlock : TerraformBlock
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
/// Block type for validation_shared_keys in GoogleNetworkServicesEdgeCacheKeyset.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheKeysetValidationSharedKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation_shared_keys";

    /// <summary>
    /// The name of the secret version in Secret Manager.
    /// 
    /// The resource name of the secret version must be in the format &#39;projects/*/secrets/*/versions/*&#39; where the &#39;*&#39; values are replaced by the secrets themselves.
    /// The secrets must be at least 16 bytes large.  The recommended secret size depends on the signature algorithm you are using.
    /// * If you are using HMAC-SHA1, we suggest 20-byte secrets.
    /// * If you are using HMAC-SHA256, we suggest 32-byte secrets.
    /// See RFC 2104, Section 3 for more details on these recommendations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretVersion is required")]
    public required TerraformValue<string> SecretVersion
    {
        get => GetArgument<TerraformValue<string>>("secret_version");
        set => SetArgument("secret_version", value);
    }

}


/// <summary>
/// Represents a google_network_services_edge_cache_keyset Terraform resource.
/// Manages a google_network_services_edge_cache_keyset resource.
/// </summary>
public partial class GoogleNetworkServicesEdgeCacheKeyset(string name) : TerraformResource("google_network_services_edge_cache_keyset", name)
{
    /// <summary>
    /// A human-readable description of the resource.
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
    /// Set of label tags associated with the EdgeCache resource.
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
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// PublicKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PublicKey block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheKeysetPublicKeyBlock>? PublicKey
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheKeysetPublicKeyBlock>>("public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesEdgeCacheKeysetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesEdgeCacheKeysetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ValidationSharedKeys block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 ValidationSharedKeys block(s) allowed")]
    public TerraformList<GoogleNetworkServicesEdgeCacheKeysetValidationSharedKeysBlock>? ValidationSharedKeys
    {
        get => GetArgument<TerraformList<GoogleNetworkServicesEdgeCacheKeysetValidationSharedKeysBlock>>("validation_shared_keys");
        set => SetArgument("validation_shared_keys", value);
    }

}
