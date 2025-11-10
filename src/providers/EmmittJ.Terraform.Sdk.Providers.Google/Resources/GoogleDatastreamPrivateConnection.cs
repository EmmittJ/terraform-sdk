using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for psc_interface_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock : ITerraformBlock
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
    [TerraformPropertyName("network_attachment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkAttachment { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamPrivateConnectionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_peering_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A free subnet for peering. (CIDR of /29)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    [TerraformPropertyName("subnet")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Subnet { get; set; }

    /// <summary>
    /// Fully qualified name of the VPC that Datastream will peer to.
    /// Format: projects/{project}/global/{networks}/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vpc is required")]
    [TerraformPropertyName("vpc")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Vpc { get; set; }

}

/// <summary>
/// Manages a google_datastream_private_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatastreamPrivateConnection : TerraformResource
{
    public GoogleDatastreamPrivateConnection(string name) : base("google_datastream_private_connection", name)
    {
    }

    /// <summary>
    /// If set to true, will skip validations.
    /// </summary>
    [TerraformPropertyName("create_without_validation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateWithoutValidation { get; set; }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The name of the location this private connection is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The private connectivity identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnectionId is required")]
    [TerraformPropertyName("private_connection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateConnectionId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for psc_interface_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInterfaceConfig block(s) allowed")]
    [TerraformPropertyName("psc_interface_config")]
    public TerraformList<TerraformBlock<GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock>>? PscInterfaceConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDatastreamPrivateConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConfig block(s) allowed")]
    [TerraformPropertyName("vpc_peering_config")]
    public TerraformList<TerraformBlock<GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock>>? VpcPeeringConfig { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The PrivateConnection error in case of failure.
    /// </summary>
    [TerraformPropertyName("error")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Error => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "error");

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// State of the PrivateConnection.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
