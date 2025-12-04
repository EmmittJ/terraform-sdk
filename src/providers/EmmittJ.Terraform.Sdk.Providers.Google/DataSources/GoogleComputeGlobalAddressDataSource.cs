using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_global_address Terraform data source.
/// Retrieves information about a google_compute_global_address.
/// </summary>
public partial class GoogleComputeGlobalAddressDataSource(string name) : TerraformDataSource("google_compute_global_address", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformValue<string> Address
        => AsReference("address");

    /// <summary>
    /// The address_type attribute.
    /// </summary>
    public TerraformValue<string> AddressType
        => AsReference("address_type");

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformValue<string> Network
        => AsReference("network");

    /// <summary>
    /// The network_tier attribute.
    /// </summary>
    public TerraformValue<string> NetworkTier
        => AsReference("network_tier");

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    public TerraformValue<double> PrefixLength
        => AsReference("prefix_length");

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    public TerraformValue<string> Purpose
        => AsReference("purpose");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The subnetwork attribute.
    /// </summary>
    public TerraformValue<string> Subnetwork
        => AsReference("subnetwork");

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformValue<string> Users
        => AsReference("users");

}
