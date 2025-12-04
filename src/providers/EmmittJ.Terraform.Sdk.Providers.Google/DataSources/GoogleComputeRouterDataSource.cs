using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_router Terraform data source.
/// Retrieves information about a google_compute_router.
/// </summary>
public partial class GoogleComputeRouterDataSource(string name) : TerraformDataSource("google_compute_router", name)
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
    /// Name of the resource. The name must be 1-63 characters long, and
    /// comply with RFC1035. Specifically, the name must be 1-63 characters
    /// long and match the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter, and all
    /// following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A reference to the network to which this router belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
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
    /// Region where the router resides.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// BGP information specific to this router.
    /// </summary>
    public TerraformList<TerraformMap<object>> Bgp
        => AsReference("bgp");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Indicates if a router is dedicated for use with encrypted VLAN
    /// attachments (interconnectAttachments).
    /// </summary>
    public TerraformValue<bool> EncryptedInterconnectRouter
        => AsReference("encrypted_interconnect_router");

    /// <summary>
    /// Keys used for MD5 authentication.
    /// </summary>
    public TerraformList<TerraformMap<object>> Md5AuthenticationKeys
        => AsReference("md5_authentication_keys");

    /// <summary>
    /// Additional params passed with the request, but not persisted as part of resource payload
    /// </summary>
    public TerraformList<TerraformMap<object>> ParamsAttribute
        => AsReference("params");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

}
