using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_key_ring_import_job resource.
/// </summary>
public class GoogleKmsKeyRingImportJob : TerraformResource
{
    public GoogleKmsKeyRingImportJob(string name) : base("google_kms_key_ring_import_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attestation");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("name");
        this.DeclareOutput("public_key");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
    /// </summary>
    public string? ImportJobId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("import_job_id")?.Value;
        set => this.WithProperty("import_job_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The wrapping method to be used for incoming key material. Possible values: [&amp;quot;RSA_OAEP_3072_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256&amp;quot;]
    /// </summary>
    public string? ImportMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("import_method")?.Value;
        set => this.WithProperty("import_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The KeyRing that this import job belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    public string? KeyRing
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_ring")?.Value;
        set => this.WithProperty("key_ring", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protection level of the ImportJob. This must match the protectionLevel of the
    /// versionTemplate on the CryptoKey you attempt to import into. Possible values: [&amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    public string? ProtectionLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protection_level")?.Value;
        set => this.WithProperty("protection_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Statement that was generated and signed by the key creator (for example, an HSM) at key creation time.
    /// Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only present if the chosen ImportMethod is one with a protection level of HSM.
    /// </summary>
    public TerraformExpression Attestation => this["attestation"];

    /// <summary>
    /// The time at which this resource is scheduled for expiration and can no longer be used.
    /// This is in RFC3339 text format.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The public key with which to wrap key material prior to import. Only returned if state is &#39;ACTIVE&#39;.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The current state of the ImportJob, indicating if it can be used.
    /// </summary>
    public TerraformExpression State => this["state"];

}
