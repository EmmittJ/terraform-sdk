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
        get => new TerraformReference<string>(this, "ca_pool");
        set => SetArgument("ca_pool", value);
    }

    /// <summary>
    /// Service Attachment for HTTP, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    public TerraformValue<string> HttpServiceAttachment
    {
        get => new TerraformReference<string>(this, "http_service_attachment");
    }

    /// <summary>
    /// &#39;Indicate if it&#39;s private instance.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrivate is required")]
    public required TerraformValue<bool> IsPrivate
    {
        get => new TerraformReference<bool>(this, "is_private");
        set => SetArgument("is_private", value);
    }

    /// <summary>
    /// Service Attachment for SSH, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    public TerraformValue<string> SshServiceAttachment
    {
        get => new TerraformReference<string>(this, "ssh_service_attachment");
    }

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
        get => new TerraformReference<bool>(this, "enabled");
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
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
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
    /// The name for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => new TerraformReference<string>(this, "instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Customer-managed encryption key name, in the format projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location for the Instance.
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
    /// Time the Instance was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of hostnames for this instance.
    /// </summary>
    public TerraformList<TerraformMap<object>> HostConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "host_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource name for the Instance.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The current state of the Instance.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Provides information about the current instance state.
    /// </summary>
    public TerraformValue<string> StateNote
    {
        get => new TerraformReference<string>(this, "state_note");
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
    /// Time the Instance was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

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
