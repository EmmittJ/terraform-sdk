using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_global_address.
/// </summary>
public class GoogleComputeGlobalAddressDataSource : TerraformDataSource
{
    public GoogleComputeGlobalAddressDataSource(string name) : base("google_compute_global_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address");
        SetOutput("address_type");
        SetOutput("network");
        SetOutput("network_tier");
        SetOutput("prefix_length");
        SetOutput("purpose");
        SetOutput("self_link");
        SetOutput("status");
        SetOutput("subnetwork");
        SetOutput("users");
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
    /// The address_type attribute.
    /// </summary>
    public TerraformExpression AddressType => this["address_type"];

    /// <summary>
    /// The network attribute.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// The network_tier attribute.
    /// </summary>
    public TerraformExpression NetworkTier => this["network_tier"];

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    public TerraformExpression PrefixLength => this["prefix_length"];

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    public TerraformExpression Purpose => this["purpose"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The subnetwork attribute.
    /// </summary>
    public TerraformExpression Subnetwork => this["subnetwork"];

    /// <summary>
    /// The users attribute.
    /// </summary>
    public TerraformExpression Users => this["users"];

}
