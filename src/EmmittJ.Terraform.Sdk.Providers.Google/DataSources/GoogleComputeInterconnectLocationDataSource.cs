using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_interconnect_location.
/// </summary>
public class GoogleComputeInterconnectLocationDataSource : TerraformDataSource
{
    public GoogleComputeInterconnectLocationDataSource(string name) : base("google_compute_interconnect_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("city");
        this.DeclareOutput("continent");
        this.DeclareOutput("description");
        this.DeclareOutput("facility_provider");
        this.DeclareOutput("facility_provider_facility_id");
        this.DeclareOutput("peeringdb_facility_id");
        this.DeclareOutput("self_link");
        this.DeclareOutput("status");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The address attribute.
    /// </summary>
    public TerraformExpression Address => this["address"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformExpression City => this["city"];

    /// <summary>
    /// The continent attribute.
    /// </summary>
    public TerraformExpression Continent => this["continent"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The facility_provider attribute.
    /// </summary>
    public TerraformExpression FacilityProvider => this["facility_provider"];

    /// <summary>
    /// The facility_provider_facility_id attribute.
    /// </summary>
    public TerraformExpression FacilityProviderFacilityId => this["facility_provider_facility_id"];

    /// <summary>
    /// The peeringdb_facility_id attribute.
    /// </summary>
    public TerraformExpression PeeringdbFacilityId => this["peeringdb_facility_id"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
