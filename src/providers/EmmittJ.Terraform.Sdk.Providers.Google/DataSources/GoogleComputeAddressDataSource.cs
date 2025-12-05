using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_address Terraform data source.
/// Retrieves information about a google_compute_address.
/// </summary>
public partial class GoogleComputeAddressDataSource(string name) : TerraformDataSource("google_compute_address", name)
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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
        => CreateReference("address");

    /// <summary>
    /// The address_type attribute.
    /// </summary>
    public TerraformValue<string> AddressType
        => CreateReference("address_type");

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformValue<string> Network
        => CreateReference("network");

    /// <summary>
    /// The network_tier attribute.
    /// </summary>
    public TerraformValue<string> NetworkTier
        => CreateReference("network_tier");

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    public TerraformValue<double> PrefixLength
        => CreateReference("prefix_length");

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    public TerraformValue<string> Purpose
        => CreateReference("purpose");

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

    /// <summary>
    /// The subnetwork attribute.
    /// </summary>
    public TerraformValue<string> Subnetwork
        => CreateReference("subnetwork");

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformValue<string> Users
        => CreateReference("users");

}
