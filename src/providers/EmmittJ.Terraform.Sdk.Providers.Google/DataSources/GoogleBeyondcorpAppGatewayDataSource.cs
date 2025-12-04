using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_beyondcorp_app_gateway Terraform data source.
/// Retrieves information about a google_beyondcorp_app_gateway.
/// </summary>
public partial class GoogleBeyondcorpAppGatewayDataSource(string name) : TerraformDataSource("google_beyondcorp_app_gateway", name)
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
    /// ID of the AppGateway.
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
    /// The region of the AppGateway.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// A list of connections allocated for the Gateway.
    /// </summary>
    public TerraformList<TerraformMap<object>> AllocatedConnections
        => AsReference("allocated_connections");

    /// <summary>
    /// An arbitrary user-provided name for the AppGateway.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The type of hosting used by the AppGateway. Default value: &amp;quot;HOST_TYPE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;HOST_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;GCP_REGIONAL_MIG&amp;quot;]
    /// </summary>
    public TerraformValue<string> HostType
        => AsReference("host_type");

    /// <summary>
    /// Resource labels to represent user provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// Represents the different states of a AppGateway.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The type of network connectivity used by the AppGateway. Default value: &amp;quot;TYPE_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;TYPE_UNSPECIFIED&amp;quot;, &amp;quot;TCP_PROXY&amp;quot;]
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Server-defined URI for this resource.
    /// </summary>
    public TerraformValue<string> Uri
        => AsReference("uri");

}
