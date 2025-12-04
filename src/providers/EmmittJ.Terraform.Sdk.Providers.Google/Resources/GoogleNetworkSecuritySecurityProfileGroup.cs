using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecuritySecurityProfileGroup.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecuritySecurityProfileGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_security_profile_group Terraform resource.
/// Manages a google_network_security_security_profile_group resource.
/// </summary>
public partial class GoogleNetworkSecuritySecurityProfileGroup(string name) : TerraformResource("google_network_security_security_profile_group", name)
{
    /// <summary>
    /// Reference to a SecurityProfile with the CustomIntercept configuration.
    /// </summary>
    public TerraformValue<string>? CustomInterceptProfile
    {
        get => GetArgument<TerraformValue<string>>("custom_intercept_profile");
        set => SetArgument("custom_intercept_profile", value);
    }

    /// <summary>
    /// Reference to a SecurityProfile with the custom mirroring configuration for the SecurityProfileGroup.
    /// </summary>
    public TerraformValue<string>? CustomMirroringProfile
    {
        get => GetArgument<TerraformValue<string>>("custom_mirroring_profile");
        set => SetArgument("custom_mirroring_profile", value);
    }

    /// <summary>
    /// An optional description of the profile. The Max length is 512 characters.
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
    /// A map of key/value label pairs to assign to the resource.
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
    /// The location of the security profile group.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the security profile group resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the parent this security profile group belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Reference to a SecurityProfile with the threat prevention configuration for the SecurityProfileGroup.
    /// </summary>
    public TerraformValue<string>? ThreatPreventionProfile
    {
        get => GetArgument<TerraformValue<string>>("threat_prevention_profile");
        set => SetArgument("threat_prevention_profile", value);
    }

    /// <summary>
    /// Time the security profile group was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an up-to-date
    /// value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Time the security profile group was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecuritySecurityProfileGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecuritySecurityProfileGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
