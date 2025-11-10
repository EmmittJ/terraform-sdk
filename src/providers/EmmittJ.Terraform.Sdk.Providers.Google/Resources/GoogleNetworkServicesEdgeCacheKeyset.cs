using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for public_key in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheKeysetPublicKeyBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the public key. The ID must be 1-63 characters long, and comply with RFC1035.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]*
    /// which means the first character must be a letter, and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetRequiredProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// Set to true to have the CDN automatically manage this public key value.
    /// </summary>
    public TerraformProperty<bool>? Managed
    {
        get => GetProperty<TerraformProperty<bool>>("managed");
        set => WithProperty("managed", value);
    }

    /// <summary>
    /// The base64-encoded value of the Ed25519 public key. The base64 encoding can be padded (44 bytes) or unpadded (43 bytes).
    /// Representations or encodings of the public key other than this will be rejected with an error.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesEdgeCacheKeysetTimeoutsBlock : TerraformBlock
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
/// Block type for validation_shared_keys in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesEdgeCacheKeysetValidationSharedKeysBlock : TerraformBlock
{
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
    public required TerraformProperty<string> SecretVersion
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret_version");
        set => WithProperty("secret_version", value);
    }

}

/// <summary>
/// Manages a google_network_services_edge_cache_keyset resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesEdgeCacheKeyset : TerraformResource
{
    public GoogleNetworkServicesEdgeCacheKeyset(string name) : base("google_network_services_edge_cache_keyset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("terraform_labels");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Set of label tags associated with the EdgeCache resource.
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
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Block for public_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 PublicKey block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheKeysetPublicKeyBlock>? PublicKey
    {
        get => GetProperty<List<GoogleNetworkServicesEdgeCacheKeysetPublicKeyBlock>>("public_key");
        set => this.WithProperty("public_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesEdgeCacheKeysetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkServicesEdgeCacheKeysetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for validation_shared_keys.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 ValidationSharedKeys block(s) allowed")]
    public List<GoogleNetworkServicesEdgeCacheKeysetValidationSharedKeysBlock>? ValidationSharedKeys
    {
        get => GetProperty<List<GoogleNetworkServicesEdgeCacheKeysetValidationSharedKeysBlock>>("validation_shared_keys");
        set => this.WithProperty("validation_shared_keys", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
