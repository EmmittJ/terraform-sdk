using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_oracle_database_autonomous_database Terraform data source.
/// Retrieves information about a google_oracle_database_autonomous_database.
/// </summary>
public partial class GoogleOracleDatabaseAutonomousDatabaseDataSource(string name) : TerraformDataSource("google_oracle_database_autonomous_database", name)
{
    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    public required TerraformValue<string> AutonomousDatabaseId
    {
        get => new TerraformReference<string>(this, "autonomous_database_id");
        set => SetArgument("autonomous_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    public TerraformValue<string> AdminPassword
    {
        get => new TerraformReference<string>(this, "admin_password");
    }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    public TerraformValue<string> Cidr
    {
        get => new TerraformReference<string>(this, "cidr");
    }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    public TerraformValue<string> Database
    {
        get => new TerraformReference<string>(this, "database");
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    public TerraformValue<string> EntitlementId
    {
        get => new TerraformReference<string>(this, "entitlement_id");
    }

    /// <summary>
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    public TerraformValue<string> OdbNetwork
    {
        get => new TerraformReference<string>(this, "odb_network");
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public TerraformValue<string> OdbSubnet
    {
        get => new TerraformReference<string>(this, "odb_subnet");
    }

    /// <summary>
    /// The properties of an Autonomous Database.
    /// </summary>
    public TerraformList<TerraformMap<object>> Properties
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "properties").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

}
