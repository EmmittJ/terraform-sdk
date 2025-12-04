using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleKmsKeyRingImportJob.
/// Nesting mode: single
/// </summary>
public class GoogleKmsKeyRingImportJobTimeoutsBlock : TerraformBlock
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
/// Represents a google_kms_key_ring_import_job Terraform resource.
/// Manages a google_kms_key_ring_import_job resource.
/// </summary>
public partial class GoogleKmsKeyRingImportJob(string name) : TerraformResource("google_kms_key_ring_import_job", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// It must be unique within a KeyRing and match the regular expression [a-zA-Z0-9_-]{1,63}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportJobId is required")]
    public required TerraformValue<string> ImportJobId
    {
        get => GetArgument<TerraformValue<string>>("import_job_id");
        set => SetArgument("import_job_id", value);
    }

    /// <summary>
    /// The wrapping method to be used for incoming key material. Possible values: [&amp;quot;RSA_OAEP_3072_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA1_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256_AES_256&amp;quot;, &amp;quot;RSA_OAEP_3072_SHA256&amp;quot;, &amp;quot;RSA_OAEP_4096_SHA256&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImportMethod is required")]
    public required TerraformValue<string> ImportMethod
    {
        get => GetArgument<TerraformValue<string>>("import_method");
        set => SetArgument("import_method", value);
    }

    /// <summary>
    /// The KeyRing that this import job belongs to.
    /// Format: &#39;&#39;projects/{{project}}/locations/{{location}}/keyRings/{{keyRing}}&#39;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRing is required")]
    public required TerraformValue<string> KeyRing
    {
        get => GetArgument<TerraformValue<string>>("key_ring");
        set => SetArgument("key_ring", value);
    }

    /// <summary>
    /// The protection level of the ImportJob. This must match the protectionLevel of the
    /// versionTemplate on the CryptoKey you attempt to import into. Possible values: [&amp;quot;SOFTWARE&amp;quot;, &amp;quot;HSM&amp;quot;, &amp;quot;EXTERNAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectionLevel is required")]
    public required TerraformValue<string> ProtectionLevel
    {
        get => GetArgument<TerraformValue<string>>("protection_level");
        set => SetArgument("protection_level", value);
    }

    /// <summary>
    /// Statement that was generated and signed by the key creator (for example, an HSM) at key creation time.
    /// Use this statement to verify attributes of the key as stored on the HSM, independently of Google.
    /// Only present if the chosen ImportMethod is one with a protection level of HSM.
    /// </summary>
    public TerraformList<TerraformMap<object>> Attestation
        => AsReference("attestation");

    /// <summary>
    /// The time at which this resource is scheduled for expiration and can no longer be used.
    /// This is in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> ExpireTime
        => AsReference("expire_time");

    /// <summary>
    /// The resource name for this ImportJob in the format projects/*/locations/*/keyRings/*/importJobs/*.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The public key with which to wrap key material prior to import. Only returned if state is &#39;ACTIVE&#39;.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicKey
        => AsReference("public_key");

    /// <summary>
    /// The current state of the ImportJob, indicating if it can be used.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleKmsKeyRingImportJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleKmsKeyRingImportJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
