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
    /// The address_type attribute.
    /// </summary>
    public TerraformValue<string> AddressType
    {
        get => new TerraformReference<string>(this, "address_type");
    }

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// The network_tier attribute.
    /// </summary>
    public TerraformValue<string> NetworkTier
    {
        get => new TerraformReference<string>(this, "network_tier");
    }

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    public TerraformValue<double> PrefixLength
    {
        get => new TerraformReference<double>(this, "prefix_length");
    }

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    public TerraformValue<string> Purpose
    {
        get => new TerraformReference<string>(this, "purpose");
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

    /// <summary>
    /// The subnetwork attribute.
    /// </summary>
    public TerraformValue<string> Subnetwork
    {
        get => new TerraformReference<string>(this, "subnetwork");
    }

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformValue<string> Users
    {
        get => new TerraformReference<string>(this, "users");
    }

}
