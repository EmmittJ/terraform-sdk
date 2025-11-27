using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_interconnect_location Terraform data source.
/// Retrieves information about a google_compute_interconnect_location.
/// </summary>
public partial class GoogleComputeInterconnectLocationDataSource(string name) : TerraformDataSource("google_compute_interconnect_location", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
    {
        get => new TerraformReference<string>(this, "address");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => new TerraformReference<string>(this, "availability_zone");
    }

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string> City
    {
        get => new TerraformReference<string>(this, "city");
    }

    /// <summary>
    /// The continent attribute.
    /// </summary>
    public TerraformValue<string> Continent
    {
        get => new TerraformReference<string>(this, "continent");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The facility_provider attribute.
    /// </summary>
    public TerraformValue<string> FacilityProvider
    {
        get => new TerraformReference<string>(this, "facility_provider");
    }

    /// <summary>
    /// The facility_provider_facility_id attribute.
    /// </summary>
    public TerraformValue<string> FacilityProviderFacilityId
    {
        get => new TerraformReference<string>(this, "facility_provider_facility_id");
    }

    /// <summary>
    /// The peeringdb_facility_id attribute.
    /// </summary>
    public TerraformValue<string> PeeringdbFacilityId
    {
        get => new TerraformReference<string>(this, "peeringdb_facility_id");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
