using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cloud_kms_config in GoogleIntegrationsClient.
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsClientCloudKmsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_kms_config";

    /// <summary>
    /// A Cloud KMS key is a named object containing one or more key versions, along
    /// with metadata for the key. A key exists on exactly one key ring tied to a
    /// specific location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// Each version of a key contains key material used for encryption or signing.
    /// A key&#39;s version is represented by an integer, starting at 1. To decrypt data
    /// or verify a signature, you must use the same key version that was used to
    /// encrypt or sign the data.
    /// </summary>
    public TerraformValue<string>? KeyVersion
    {
        get => GetArgument<TerraformValue<string>>("key_version");
        set => SetArgument("key_version", value);
    }

    /// <summary>
    /// Location name of the key ring, e.g. &amp;quot;us-west1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsLocation is required")]
    public required TerraformValue<string> KmsLocation
    {
        get => GetArgument<TerraformValue<string>>("kms_location");
        set => SetArgument("kms_location", value);
    }

    /// <summary>
    /// The Google Cloud project id of the project where the kms key stored. If empty,
    /// the kms key is stored at the same project as customer&#39;s project and ecrypted
    /// with CMEK, otherwise, the kms key is stored in the tenant project and
    /// encrypted with GMEK.
    /// </summary>
    public TerraformValue<string>? KmsProjectId
    {
        get => GetArgument<TerraformValue<string>>("kms_project_id");
        set => SetArgument("kms_project_id", value);
    }

    /// <summary>
    /// A key ring organizes keys in a specific Google Cloud location and allows you to
    /// manage access control on groups of keys. A key ring&#39;s name does not need to be
    /// unique across a Google Cloud project, but must be unique within a given location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsRing is required")]
    public required TerraformValue<string> KmsRing
    {
        get => GetArgument<TerraformValue<string>>("kms_ring");
        set => SetArgument("kms_ring", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIntegrationsClient.
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationsClientTimeoutsBlock : TerraformBlock
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
/// Represents a google_integrations_client Terraform resource.
/// Manages a google_integrations_client resource.
/// </summary>
public partial class GoogleIntegrationsClient(string name) : TerraformResource("google_integrations_client", name)
{
    /// <summary>
    /// Indicates if sample integrations should be created along with provisioning.
    /// </summary>
    public TerraformValue<bool>? CreateSampleIntegrations
    {
        get => GetArgument<TerraformValue<bool>>("create_sample_integrations");
        set => SetArgument("create_sample_integrations", value);
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
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// User input run-as service account, if empty, will bring up a new default service account.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? RunAsServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("run_as_service_account");
        set => SetArgument("run_as_service_account", value);
    }

    /// <summary>
    /// CloudKmsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudKmsConfig block(s) allowed")]
    public TerraformList<GoogleIntegrationsClientCloudKmsConfigBlock>? CloudKmsConfig
    {
        get => GetArgument<TerraformList<GoogleIntegrationsClientCloudKmsConfigBlock>>("cloud_kms_config");
        set => SetArgument("cloud_kms_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIntegrationsClientTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIntegrationsClientTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
