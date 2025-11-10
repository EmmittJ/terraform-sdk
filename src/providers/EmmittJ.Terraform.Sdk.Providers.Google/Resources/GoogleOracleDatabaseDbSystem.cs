using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseDbSystemPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The number of CPU cores to enable for the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    public required TerraformProperty<double> ComputeCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("compute_count");
        set => WithProperty("compute_count", value);
    }

    /// <summary>
    /// The compute model of the DbSystem.
    /// Possible values:
    /// ECPU
    /// OCPU
    /// </summary>
    public TerraformProperty<string>? ComputeModel
    {
        get => GetProperty<TerraformProperty<string>>("compute_model");
        set => WithProperty("compute_model", value);
    }

    /// <summary>
    /// The data storage size in GB that is currently available to DbSystems.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_gb");
        set => WithProperty("data_storage_size_gb", value);
    }

    /// <summary>
    /// The database edition of the DbSystem.
    /// Possible values:
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// ENTERPRISE_EDITION_HIGH_PERFORMANCE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseEdition is required")]
    public required TerraformProperty<string> DatabaseEdition
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_edition");
        set => WithProperty("database_edition", value);
    }

    /// <summary>
    /// The host domain name of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// The hostname of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => WithProperty("hostname", value);
    }

    /// <summary>
    /// Prefix for DB System host names.
    /// </summary>
    public TerraformProperty<string>? HostnamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("hostname_prefix");
        set => WithProperty("hostname_prefix", value);
    }

    /// <summary>
    /// The initial data storage size in GB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDataStorageSizeGb is required")]
    public required TerraformProperty<double> InitialDataStorageSizeGb
    {
        get => GetRequiredProperty<TerraformProperty<double>>("initial_data_storage_size_gb");
        set => WithProperty("initial_data_storage_size_gb", value);
    }

    /// <summary>
    /// The license model of the DbSystem.
    /// Possible values:
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseModel is required")]
    public required TerraformProperty<string> LicenseModel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("license_model");
        set => WithProperty("license_model", value);
    }

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
    public TerraformProperty<string>? LifecycleState
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle_state");
        set => WithProperty("lifecycle_state", value);
    }

    /// <summary>
    /// The memory size in GB.
    /// </summary>
    public TerraformProperty<double>? MemorySizeGb
    {
        get => GetProperty<TerraformProperty<double>>("memory_size_gb");
        set => WithProperty("memory_size_gb", value);
    }

    /// <summary>
    /// The number of nodes in the DbSystem.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        get => GetProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// OCID of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        get => GetProperty<TerraformProperty<string>>("ocid");
        set => WithProperty("ocid", value);
    }

    /// <summary>
    /// The private IP address of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformProperty<string>>("private_ip");
        set => WithProperty("private_ip", value);
    }

    /// <summary>
    /// The reco/redo storage size in GB.
    /// </summary>
    public TerraformProperty<double>? RecoStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("reco_storage_size_gb");
        set => WithProperty("reco_storage_size_gb", value);
    }

    /// <summary>
    /// Shape of DB System.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        get => GetRequiredProperty<TerraformProperty<string>>("shape");
        set => WithProperty("shape", value);
    }

    /// <summary>
    /// SSH public keys to be stored with the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public List<TerraformProperty<string>>? SshPublicKeys
    {
        get => GetProperty<List<TerraformProperty<string>>>("ssh_public_keys");
        set => WithProperty("ssh_public_keys", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseDbSystemTimeoutsBlock : TerraformBlock
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
/// Manages a google_oracle_database_db_system resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseDbSystem : TerraformResource
{
    public GoogleOracleDatabaseDbSystem(string name) : base("google_oracle_database_db_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("entitlement_id");
        this.WithOutput("name");
        this.WithOutput("oci_url");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// The ID of the DbSystem to create. This value is
    /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
    /// 63 characters in length. The value must start with a letter and end with a
    /// letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbSystemId is required")]
    public required TerraformProperty<string> DbSystemId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("db_system_id");
        set => this.WithProperty("db_system_id", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The display name for the System db. The name does not have to
    /// be unique within your project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The GCP Oracle zone where Oracle DbSystem is hosted.
    /// Example: us-east4-b-r2.
    /// If not specified, the system will pick a zone based on availability.
    /// </summary>
    public TerraformProperty<string>? GcpOracleZone
    {
        get => GetProperty<TerraformProperty<string>>("gcp_oracle_zone");
        set => this.WithProperty("gcp_oracle_zone", value);
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
    /// The labels or tags associated with the DbSystem.
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the DbSystem.
    /// Format: projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the OdbSubnet.
    /// </summary>
    public TerraformProperty<string>? OdbNetwork
    {
        get => GetProperty<TerraformProperty<string>>("odb_network");
        set => this.WithProperty("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the DbSystem for IP
    /// allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbSubnet is required")]
    public required TerraformProperty<string> OdbSubnet
    {
        get => GetRequiredProperty<TerraformProperty<string>>("odb_subnet");
        set => this.WithProperty("odb_subnet", value);
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
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseDbSystemPropertiesBlock>? Properties
    {
        get => GetProperty<List<GoogleOracleDatabaseDbSystemPropertiesBlock>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseDbSystemTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOracleDatabaseDbSystemTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The date and time that the DbSystem was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The ID of the subscription entitlement associated with the DbSystem
    /// </summary>
    public TerraformExpression EntitlementId => this["entitlement_id"];

    /// <summary>
    /// Identifier. The name of the DbSystem resource in the following format:
    /// projects/{project}/locations/{region}/dbSystems/{db_system}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// HTTPS link to OCI resources exposed to Customer via UI Interface.
    /// </summary>
    public TerraformExpression OciUrl => this["oci_url"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
