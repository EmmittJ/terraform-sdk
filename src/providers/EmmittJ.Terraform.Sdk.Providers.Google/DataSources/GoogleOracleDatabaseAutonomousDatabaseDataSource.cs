using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_autonomous_database.
/// </summary>
public partial class GoogleOracleDatabaseAutonomousDatabaseDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseAutonomousDatabaseDataSource(string name) : base("google_oracle_database_autonomous_database", name)
    {
    }

    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformProperty("autonomous_database_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AdminPassword { get; }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    [TerraformProperty("cidr")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Cidr { get; }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    [TerraformProperty("database")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Database { get; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    [TerraformProperty("entitlement_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EntitlementId { get; }

    /// <summary>
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformProperty("odb_network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OdbNetwork { get; }

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformProperty("odb_subnet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OdbSubnet { get; }

    /// <summary>
    /// The properties of an Autonomous Database.
    /// </summary>
    [TerraformProperty("properties")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Properties { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
