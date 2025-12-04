using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for connection_config in GoogleNetworkServicesMulticastDomain.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesMulticastDomainConnectionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_config";

    /// <summary>
    /// The VPC connection type.
    /// Possible values:
    /// NCC
    /// SAME_VPC
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionType is required")]
    public required TerraformValue<string> ConnectionType
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// The resource name of the
    /// [NCC](https://cloud.google.com/network-connectivity-center) hub.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/hubs/{hub}&#39;.
    /// </summary>
    public TerraformValue<string>? NccHub
    {
        get => GetArgument<TerraformValue<string>>("ncc_hub");
        set => SetArgument("ncc_hub", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkServicesMulticastDomain.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesMulticastDomainTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_services_multicast_domain Terraform resource.
/// Manages a google_network_services_multicast_domain resource.
/// </summary>
public partial class GoogleNetworkServicesMulticastDomain(string name) : TerraformResource("google_network_services_multicast_domain", name)
{
    /// <summary>
    /// The resource name of the multicast admin VPC network.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/networks/{network}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminNetwork is required")]
    public required TerraformValue<string> AdminNetwork
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_network");
        set => SetArgument("admin_network", value);
    }

    /// <summary>
    /// An optional text description of the multicast domain.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Labels as key-value pairs.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The multicast domain group this domain should be associated with.
    /// Use the following format:
    /// &#39;projects/{project}/locations/global/multicastDomainGroups/{multicast_domain_group}&#39;.
    /// </summary>
    public TerraformValue<string>? MulticastDomainGroup
    {
        get => GetArgument<TerraformValue<string>>("multicast_domain_group");
        set => SetArgument("multicast_domain_group", value);
    }

    /// <summary>
    /// A unique name for the multicast domain.
    /// The name is restricted to letters, numbers, and hyphen, with the first
    /// character a letter, and the last a letter or a number. The name must not
    /// exceed 48 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MulticastDomainId is required")]
    public required TerraformValue<string> MulticastDomainId
    {
        get => GetRequiredArgument<TerraformValue<string>>("multicast_domain_id");
        set => SetArgument("multicast_domain_id", value);
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
    /// [Output only] The timestamp when the multicast domain was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Identifier. The resource name of the multicast domain.
    /// Use the following format:
    /// &#39;projects/*/locations/global/multicastDomains/*&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// [Output only] The Google-generated UUID for the resource. This value is
    /// unique across all multicast domain resources. If a domain is deleted and
    /// another with the same name is created, the new domain is assigned a
    /// different unique_id.
    /// </summary>
    public TerraformValue<string> UniqueId
        => AsReference("unique_id");

    /// <summary>
    /// [Output only] The timestamp when the multicast domain was most recently
    /// updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ConnectionConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionConfig block(s) allowed")]
    public required TerraformList<GoogleNetworkServicesMulticastDomainConnectionConfigBlock> ConnectionConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkServicesMulticastDomainConnectionConfigBlock>>("connection_config");
        set => SetArgument("connection_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkServicesMulticastDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkServicesMulticastDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
