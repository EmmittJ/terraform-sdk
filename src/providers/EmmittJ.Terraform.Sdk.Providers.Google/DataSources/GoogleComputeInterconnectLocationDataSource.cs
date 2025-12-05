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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
        => CreateReference("address");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
        => CreateReference("availability_zone");

    /// <summary>
    /// The city attribute.
    /// </summary>
    public TerraformValue<string> City
        => CreateReference("city");

    /// <summary>
    /// The continent attribute.
    /// </summary>
    public TerraformValue<string> Continent
        => CreateReference("continent");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The facility_provider attribute.
    /// </summary>
    public TerraformValue<string> FacilityProvider
        => CreateReference("facility_provider");

    /// <summary>
    /// The facility_provider_facility_id attribute.
    /// </summary>
    public TerraformValue<string> FacilityProviderFacilityId
        => CreateReference("facility_provider_facility_id");

    /// <summary>
    /// The peeringdb_facility_id attribute.
    /// </summary>
    public TerraformValue<string> PeeringdbFacilityId
        => CreateReference("peeringdb_facility_id");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
