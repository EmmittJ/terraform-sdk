using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for psc_interface_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock : TerraformBlock
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
    public required TerraformProperty<string> NetworkAttachment
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network_attachment");
        set => WithProperty("network_attachment", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDatastreamPrivateConnectionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_peering_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// A free subnet for peering. (CIDR of /29)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnet is required")]
    public required TerraformProperty<string> Subnet
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet");
        set => WithProperty("subnet", value);
    }

    /// <summary>
    /// Fully qualified name of the VPC that Datastream will peer to.
    /// Format: projects/{project}/global/{networks}/{name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vpc is required")]
    public required TerraformProperty<string> Vpc
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpc");
        set => WithProperty("vpc", value);
    }

}

/// <summary>
/// Manages a google_datastream_private_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDatastreamPrivateConnection : TerraformResource
{
    public GoogleDatastreamPrivateConnection(string name) : base("google_datastream_private_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("error");
        this.WithOutput("name");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// If set to true, will skip validations.
    /// </summary>
    public TerraformProperty<bool>? CreateWithoutValidation
    {
        get => GetProperty<TerraformProperty<bool>>("create_without_validation");
        set => this.WithProperty("create_without_validation", value);
    }

    /// <summary>
    /// Display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Labels.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the location this private connection is located in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The private connectivity identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateConnectionId is required")]
    public required TerraformProperty<string> PrivateConnectionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_connection_id");
        set => this.WithProperty("private_connection_id", value);
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
    /// Block for psc_interface_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscInterfaceConfig block(s) allowed")]
    public List<GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock>? PscInterfaceConfig
    {
        get => GetProperty<List<GoogleDatastreamPrivateConnectionPscInterfaceConfigBlock>>("psc_interface_config");
        set => this.WithProperty("psc_interface_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDatastreamPrivateConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDatastreamPrivateConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcPeeringConfig block(s) allowed")]
    public List<GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock>? VpcPeeringConfig
    {
        get => GetProperty<List<GoogleDatastreamPrivateConnectionVpcPeeringConfigBlock>>("vpc_peering_config");
        set => this.WithProperty("vpc_peering_config", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The PrivateConnection error in case of failure.
    /// </summary>
    public TerraformExpression Error => this["error"];

    /// <summary>
    /// The resource&#39;s name.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// State of the PrivateConnection.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
