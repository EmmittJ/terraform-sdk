using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for private_config in GoogleSecureSourceManagerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerInstancePrivateConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_config";

    /// <summary>
    /// CA pool resource, resource must in the format of &#39;projects/{project}/locations/{location}/caPools/{ca_pool}&#39;.
    /// </summary>
    public TerraformValue<string>? CaPool
    {
        get => GetArgument<TerraformValue<string>>("ca_pool");
        set => SetArgument("ca_pool", value);
    }

    /// <summary>
    /// Service Attachment for HTTP, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    public TerraformValue<string> HttpServiceAttachment
        => AsReference("http_service_attachment");

    /// <summary>
    /// &#39;Indicate if it&#39;s private instance.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrivate is required")]
    public required TerraformValue<bool> IsPrivate
    {
        get => GetRequiredArgument<TerraformValue<bool>>("is_private");
        set => SetArgument("is_private", value);
    }

    /// <summary>
    /// Service Attachment for SSH, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    public TerraformValue<string> SshServiceAttachment
        => AsReference("ssh_service_attachment");

}


/// <summary>
/// Block type for timeouts in GoogleSecureSourceManagerInstance.
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerInstanceTimeoutsBlock : TerraformBlock
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
/// Block type for workforce_identity_federation_config in GoogleSecureSourceManagerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workforce_identity_federation_config";

    /// <summary>
    /// &#39;Whether Workforce Identity Federation is enabled.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Represents a google_secure_source_manager_instance Terraform resource.
/// Manages a google_secure_source_manager_instance resource.
/// </summary>
public partial class GoogleSecureSourceManagerInstance(string name) : TerraformResource("google_secure_source_manager_instance", name)
{
    /// <summary>
    /// The deletion policy for the instance. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned, rather than deleted. Setting &#39;DELETE&#39; deletes the resource
    /// and all its contents. Setting &#39;PREVENT&#39; prevents the resource from accidental
    /// deletion by erroring out during plan.
    /// Default is &#39;PREVENT&#39;.  Possible values are:
    ///   * DELETE
    ///   * PREVENT
    ///   * ABANDON
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Customer-managed encryption key name, in the format projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Labels as key value pairs.
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
    /// The location for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// A list of hostnames for this instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> HostConfig
        => AsReference("host_config");

    /// <summary>
    /// The resource name for the Instance.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the Instance.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Provides information about the current instance state.
    /// </summary>
    public TerraformValue<string> StateNote
        => AsReference("state_note");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// PrivateConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConfig block(s) allowed")]
    public TerraformList<GoogleSecureSourceManagerInstancePrivateConfigBlock>? PrivateConfig
    {
        get => GetArgument<TerraformList<GoogleSecureSourceManagerInstancePrivateConfigBlock>>("private_config");
        set => SetArgument("private_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecureSourceManagerInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecureSourceManagerInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkforceIdentityFederationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceIdentityFederationConfig block(s) allowed")]
    public TerraformList<GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock>? WorkforceIdentityFederationConfig
    {
        get => GetArgument<TerraformList<GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock>>("workforce_identity_federation_config");
        set => SetArgument("workforce_identity_federation_config", value);
    }

}
