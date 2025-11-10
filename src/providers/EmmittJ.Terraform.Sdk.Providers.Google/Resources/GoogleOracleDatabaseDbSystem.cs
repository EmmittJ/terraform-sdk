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
        set => SetProperty("compute_count", value);
    }

    /// <summary>
    /// The compute model of the DbSystem.
    /// Possible values:
    /// ECPU
    /// OCPU
    /// </summary>
    public TerraformProperty<string>? ComputeModel
    {
        set => SetProperty("compute_model", value);
    }

    /// <summary>
    /// The data storage size in GB that is currently available to DbSystems.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeGb
    {
        set => SetProperty("data_storage_size_gb", value);
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
        set => SetProperty("database_edition", value);
    }

    /// <summary>
    /// The host domain name of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The hostname of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// Prefix for DB System host names.
    /// </summary>
    public TerraformProperty<string>? HostnamePrefix
    {
        set => SetProperty("hostname_prefix", value);
    }

    /// <summary>
    /// The initial data storage size in GB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDataStorageSizeGb is required")]
    public required TerraformProperty<double> InitialDataStorageSizeGb
    {
        set => SetProperty("initial_data_storage_size_gb", value);
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
        set => SetProperty("license_model", value);
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
        set => SetProperty("lifecycle_state", value);
    }

    /// <summary>
    /// The memory size in GB.
    /// </summary>
    public TerraformProperty<double>? MemorySizeGb
    {
        set => SetProperty("memory_size_gb", value);
    }

    /// <summary>
    /// The number of nodes in the DbSystem.
    /// </summary>
    public TerraformProperty<double>? NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// OCID of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        set => SetProperty("ocid", value);
    }

    /// <summary>
    /// The private IP address of the DbSystem.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        set => SetProperty("private_ip", value);
    }

    /// <summary>
    /// The reco/redo storage size in GB.
    /// </summary>
    public TerraformProperty<double>? RecoStorageSizeGb
    {
        set => SetProperty("reco_storage_size_gb", value);
    }

    /// <summary>
    /// Shape of DB System.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        set => SetProperty("shape", value);
    }

    /// <summary>
    /// SSH public keys to be stored with the DbSystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKeys is required")]
    public List<TerraformProperty<string>>? SshPublicKeys
    {
        set => SetProperty("ssh_public_keys", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("entitlement_id");
        SetOutput("name");
        SetOutput("oci_url");
        SetOutput("terraform_labels");
        SetOutput("db_system_id");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("gcp_oracle_zone");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("odb_network");
        SetOutput("odb_subnet");
        SetOutput("project");
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
        get => GetRequiredOutput<TerraformProperty<string>>("db_system_id");
        set => SetProperty("db_system_id", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The display name for the System db. The name does not have to
    /// be unique within your project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The GCP Oracle zone where Oracle DbSystem is hosted.
    /// Example: us-east4-b-r2.
    /// If not specified, the system will pick a zone based on availability.
    /// </summary>
    public TerraformProperty<string> GcpOracleZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gcp_oracle_zone");
        set => SetProperty("gcp_oracle_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The labels or tags associated with the DbSystem.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the DbSystem.
    /// Format: projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the OdbSubnet.
    /// </summary>
    public TerraformProperty<string> OdbNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("odb_network");
        set => SetProperty("odb_network", value);
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the DbSystem for IP
    /// allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OdbSubnet is required")]
    public required TerraformProperty<string> OdbSubnet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("odb_subnet");
        set => SetProperty("odb_subnet", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseDbSystemPropertiesBlock>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseDbSystemTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
