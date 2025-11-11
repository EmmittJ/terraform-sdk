using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for psc_interface_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Fully qualified name of the network attachment that Datastream will connect to.
    /// Format: projects/{project}/regions/{region}/networkAttachments/{name}
    /// 
    /// To get Datastream project for the accepted list:
    /// &#39;gcloud datastream private-connections create [PC ID] --location=[LOCATION] --network-attachment=[NA URI] --validate-only --display-name=[ANY STRING]&#39;
    /// Add Datastream project to the attachment accepted list:
    /// &#39;gcloud compute network-attachments update [NA URI] --region=[NA region] --producer-accept-list=[TP from prev command]&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkAttachment is required")]
    [TerraformProperty("network_attachment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NetworkAttachment { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDatastreamPrivateConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_peering_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// A free subnet for peering. (CIDR of /29)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    [TerraformProperty("subnet")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Subnet { get; set; }

    /// <summary>
    /// Fully qualified name of the VPC that Datastream will peer to.
    /// Format: projects/{project}/global/{networks}/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vpc is required")]
    [TerraformProperty("vpc")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Vpc { get; set; }

}

/// <summary>
/// Manages a google_datastream_private_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDatastreamPrivateConnection : TerraformResource
{
    public GoogleDatastreamPrivateConnection(string name) : base("google_datastream_private_connection", name)
    {
    }

    /// <summary>
    /// If set to true, will skip validations.
    /// </summary>
    [TerraformProperty("create_without_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateWithoutValidation { get; set; }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the location this private connection is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The private connectivity identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnectionId is required")]
    [TerraformProperty("private_connection_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateConnectionId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for psc_interface_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInterfaceConfig block(s) allowed")]
    [TerraformProperty("psc_interface_config")]
    public partial TerraformList<TerraformBlock<GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock>>? PscInterfaceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDatastreamPrivateConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConfig block(s) allowed")]
    [TerraformProperty("vpc_peering_config")]
    public partial TerraformList<TerraformBlock<GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock>>? VpcPeeringConfig { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The PrivateConnection error in case of failure.
    /// </summary>
    [TerraformProperty("error")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Error { get; }

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// State of the PrivateConnection.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
