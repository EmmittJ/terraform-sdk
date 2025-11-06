using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_oracle_database_db_system resource.
/// </summary>
public class GoogleOracleDatabaseDbSystem : TerraformResource
{
    public GoogleOracleDatabaseDbSystem(string name) : base("google_oracle_database_db_system", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("entitlement_id");
        this.DeclareOutput("name");
        this.DeclareOutput("oci_url");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The ID of the DbSystem to create. This value is
    /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
    /// 63 characters in length. The value must start with a letter and end with a
    /// letter or a number.
    /// </summary>
    public string? DbSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_system_id")?.Value;
        set => this.WithProperty("db_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The display name for the System db. The name does not have to
    /// be unique within your project.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The GCP Oracle zone where Oracle DbSystem is hosted.
    /// Example: us-east4-b-r2.
    /// If not specified, the system will pick a zone based on availability.
    /// </summary>
    public string? GcpOracleZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gcp_oracle_zone")?.Value;
        set => this.WithProperty("gcp_oracle_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The labels or tags associated with the DbSystem.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the OdbNetwork associated with the DbSystem.
    /// Format: projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the OdbSubnet.
    /// </summary>
    public string? OdbNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("odb_network")?.Value;
        set => this.WithProperty("odb_network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the OdbSubnet associated with the DbSystem for IP
    /// allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    public string? OdbSubnet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("odb_subnet")?.Value;
        set => this.WithProperty("odb_subnet", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
