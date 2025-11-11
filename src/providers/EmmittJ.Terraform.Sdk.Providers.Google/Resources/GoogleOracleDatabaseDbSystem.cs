using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOracleDatabaseDbSystemPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of CPU cores to enable for the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformProperty("compute_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> ComputeCount { get; set; }

    /// <summary>
    /// The compute model of the DbSystem.
    /// Possible values:
    /// ECPU
    /// OCPU
    /// </summary>
    [TerraformProperty("compute_model")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ComputeModel { get; set; }

    /// <summary>
    /// The data storage size in GB that is currently available to DbSystems.
    /// </summary>
    [TerraformProperty("data_storage_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DataStorageSizeGb { get; set; }

    /// <summary>
    /// The database edition of the DbSystem.
    /// Possible values:
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// ENTERPRISE_EDITION_HIGH_PERFORMANCE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseEdition is required")]
    [TerraformProperty("database_edition")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseEdition { get; set; }

    /// <summary>
    /// The host domain name of the DbSystem.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Domain { get; set; }


    /// <summary>
    /// Prefix for DB System host names.
    /// </summary>
    [TerraformProperty("hostname_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostnamePrefix { get; set; }

    /// <summary>
    /// The initial data storage size in GB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDataStorageSizeGb is required")]
    [TerraformProperty("initial_data_storage_size_gb")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> InitialDataStorageSizeGb { get; set; }

    /// <summary>
    /// The license model of the DbSystem.
    /// Possible values:
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformProperty("license_model")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseModel { get; set; }


    /// <summary>
    /// The memory size in GB.
    /// </summary>
    [TerraformProperty("memory_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MemorySizeGb { get; set; }

    /// <summary>
    /// The number of nodes in the DbSystem.
    /// </summary>
    [TerraformProperty("node_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> NodeCount { get; set; }


    /// <summary>
    /// The private IP address of the DbSystem.
    /// </summary>
    [TerraformProperty("private_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateIp { get; set; }

    /// <summary>
    /// The reco/redo storage size in GB.
    /// </summary>
    [TerraformProperty("reco_storage_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> RecoStorageSizeGb { get; set; }

    /// <summary>
    /// Shape of DB System.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformProperty("shape")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Shape { get; set; }

    /// <summary>
    /// SSH public keys to be stored with the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformProperty("ssh_public_keys")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? SshPublicKeys { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOracleDatabaseDbSystemTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_oracle_database_db_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOracleDatabaseDbSystem : TerraformResource
{
    public GoogleOracleDatabaseDbSystem(string name) : base("google_oracle_database_db_system", name)
    {
    }

    /// <summary>
    /// The ID of the DbSystem to create. This value is
    /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
    /// 63 characters in length. The value must start with a letter and end with a
    /// letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbSystemId is required")]
    [TerraformProperty("db_system_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DbSystemId { get; set; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The display name for the System db. The name does not have to
    /// be unique within your project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The GCP Oracle zone where Oracle DbSystem is hosted.
    /// Example: us-east4-b-r2.
    /// If not specified, the system will pick a zone based on availability.
    /// </summary>
    [TerraformProperty("gcp_oracle_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> GcpOracleZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels or tags associated with the DbSystem.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the DbSystem.
    /// Format: projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the OdbSubnet.
    /// </summary>
    [TerraformProperty("odb_network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OdbNetwork { get; set; }

    /// <summary>
    /// The name of the OdbSubnet associated with the DbSystem for IP
    /// allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbSubnet is required")]
    [TerraformProperty("odb_subnet")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OdbSubnet { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformProperty("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseDbSystemPropertiesBlock>>? Properties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseDbSystemTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The date and time that the DbSystem was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The ID of the subscription entitlement associated with the DbSystem
    /// </summary>
    [TerraformProperty("entitlement_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EntitlementId { get; }

    /// <summary>
    /// Identifier. The name of the DbSystem resource in the following format:
    /// projects/{project}/locations/{region}/dbSystems/{db_system}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// HTTPS link to OCI resources exposed to Customer via UI Interface.
    /// </summary>
    [TerraformProperty("oci_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OciUrl { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
