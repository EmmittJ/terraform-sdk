using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The number of CPU cores to enable for the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    [TerraformPropertyName("compute_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ComputeCount { get; set; }

    /// <summary>
    /// The compute model of the DbSystem.
    /// Possible values:
    /// ECPU
    /// OCPU
    /// </summary>
    [TerraformPropertyName("compute_model")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ComputeModel { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "compute_model");

    /// <summary>
    /// The data storage size in GB that is currently available to DbSystems.
    /// </summary>
    [TerraformPropertyName("data_storage_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "data_storage_size_gb");

    /// <summary>
    /// The database edition of the DbSystem.
    /// Possible values:
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// ENTERPRISE_EDITION_HIGH_PERFORMANCE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseEdition is required")]
    [TerraformPropertyName("database_edition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseEdition { get; set; }

    /// <summary>
    /// The host domain name of the DbSystem.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Domain { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "domain");

    /// <summary>
    /// The hostname of the DbSystem.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Hostname => new TerraformReferenceProperty<TerraformProperty<string>>("", "hostname");

    /// <summary>
    /// Prefix for DB System host names.
    /// </summary>
    [TerraformPropertyName("hostname_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostnamePrefix { get; set; }

    /// <summary>
    /// The initial data storage size in GB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDataStorageSizeGb is required")]
    [TerraformPropertyName("initial_data_storage_size_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> InitialDataStorageSizeGb { get; set; }

    /// <summary>
    /// The license model of the DbSystem.
    /// Possible values:
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    [TerraformPropertyName("license_model")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseModel { get; set; }

    /// <summary>
    /// State of the DbSystem.
    /// Possible values:
    /// PROVISIONING
    /// AVAILABLE
    /// UPDATING
    /// TERMINATING
    /// TERMINATED
    /// FAILED
    /// MIGRATED
    /// MAINTENANCE_IN_PROGRESS
    /// NEEDS_ATTENTION
    /// UPGRADING
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>("", "lifecycle_state");

    /// <summary>
    /// The memory size in GB.
    /// </summary>
    [TerraformPropertyName("memory_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MemorySizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "memory_size_gb");

    /// <summary>
    /// The number of nodes in the DbSystem.
    /// </summary>
    [TerraformPropertyName("node_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NodeCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "node_count");

    /// <summary>
    /// OCID of the DbSystem.
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>("", "ocid");

    /// <summary>
    /// The private IP address of the DbSystem.
    /// </summary>
    [TerraformPropertyName("private_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip");

    /// <summary>
    /// The reco/redo storage size in GB.
    /// </summary>
    [TerraformPropertyName("reco_storage_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> RecoStorageSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "reco_storage_size_gb");

    /// <summary>
    /// Shape of DB System.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformPropertyName("shape")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Shape { get; set; }

    /// <summary>
    /// SSH public keys to be stored with the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    [TerraformPropertyName("ssh_public_keys")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SshPublicKeys { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseDbSystemTimeoutsBlock : ITerraformBlock
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
/// Manages a google_oracle_database_db_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseDbSystem : TerraformResource
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
    [TerraformPropertyName("db_system_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DbSystemId { get; set; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The display name for the System db. The name does not have to
    /// be unique within your project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The GCP Oracle zone where Oracle DbSystem is hosted.
    /// Example: us-east4-b-r2.
    /// If not specified, the system will pick a zone based on availability.
    /// </summary>
    [TerraformPropertyName("gcp_oracle_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GcpOracleZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcp_oracle_zone");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The labels or tags associated with the DbSystem.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the DbSystem.
    /// Format: projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the OdbSubnet.
    /// </summary>
    [TerraformPropertyName("odb_network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OdbNetwork { get; set; }

    /// <summary>
    /// The name of the OdbSubnet associated with the DbSystem for IP
    /// allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbSubnet is required")]
    [TerraformPropertyName("odb_subnet")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OdbSubnet { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformPropertyName("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseDbSystemPropertiesBlock>>? Properties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseDbSystemTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The date and time that the DbSystem was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The ID of the subscription entitlement associated with the DbSystem
    /// </summary>
    [TerraformPropertyName("entitlement_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EntitlementId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "entitlement_id");

    /// <summary>
    /// Identifier. The name of the DbSystem resource in the following format:
    /// projects/{project}/locations/{region}/dbSystems/{db_system}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// HTTPS link to OCI resources exposed to Customer via UI Interface.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "oci_url");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
