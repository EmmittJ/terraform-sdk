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
        SetOutput("address");
        SetOutput("availability_zone");
        SetOutput("city");
        SetOutput("continent");
        SetOutput("description");
        SetOutput("facility_provider");
        SetOutput("facility_provider_facility_id");
        SetOutput("peeringdb_facility_id");
        SetOutput("self_link");
        SetOutput("status");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
