using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_kms_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsClientCloudKmsConfigBlock : TerraformBlock
{
    /// <summary>
    /// A Cloud KMS key is a named object containing one or more key versions, along
    /// with metadata for the key. A key exists on exactly one key ring tied to a
    /// specific location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// Each version of a key contains key material used for encryption or signing.
    /// A key&#39;s version is represented by an integer, starting at 1. To decrypt data
    /// or verify a signature, you must use the same key version that was used to
    /// encrypt or sign the data.
    /// </summary>
    public TerraformProperty<string>? KeyVersion
    {
        get => GetProperty<TerraformProperty<string>>("key_version");
        set => WithProperty("key_version", value);
    }

    /// <summary>
    /// Location name of the key ring, e.g. &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsLocation is required")]
    public required TerraformProperty<string> KmsLocation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_location");
        set => WithProperty("kms_location", value);
    }

    /// <summary>
    /// The Google Cloud project id of the project where the kms key stored. If empty,
    /// the kms key is stored at the same project as customer&#39;s project and ecrypted
    /// with CMEK, otherwise, the kms key is stored in the tenant project and
    /// encrypted with GMEK.
    /// </summary>
    public TerraformProperty<string>? KmsProjectId
    {
        get => GetProperty<TerraformProperty<string>>("kms_project_id");
        set => WithProperty("kms_project_id", value);
    }

    /// <summary>
    /// A key ring organizes keys in a specific Google Cloud location and allows you to
    /// manage access control on groups of keys. A key ring&#39;s name does not need to be
    /// unique across a Google Cloud project, but must be unique within a given location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsRing is required")]
    public required TerraformProperty<string> KmsRing
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_ring");
        set => WithProperty("kms_ring", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationsClientTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_integrations_client resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIntegrationsClient : TerraformResource
{
    public GoogleIntegrationsClient(string name) : base("google_integrations_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Indicates if sample integrations should be created along with provisioning.
    /// </summary>
    public TerraformProperty<bool>? CreateSampleIntegrations
    {
        get => GetProperty<TerraformProperty<bool>>("create_sample_integrations");
        set => this.WithProperty("create_sample_integrations", value);
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
    /// Location in which client needs to be provisioned.
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
    /// User input run-as service account, if empty, will bring up a new default service account.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? RunAsServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("run_as_service_account");
        set => this.WithProperty("run_as_service_account", value);
    }

    /// <summary>
    /// Block for cloud_kms_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudKmsConfig block(s) allowed")]
    public List<GoogleIntegrationsClientCloudKmsConfigBlock>? CloudKmsConfig
    {
        get => GetProperty<List<GoogleIntegrationsClientCloudKmsConfigBlock>>("cloud_kms_config");
        set => this.WithProperty("cloud_kms_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIntegrationsClientTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIntegrationsClientTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
