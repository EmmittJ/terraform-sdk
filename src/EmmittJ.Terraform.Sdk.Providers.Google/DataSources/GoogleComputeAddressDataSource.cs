using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_address.
/// </summary>
public class GoogleComputeAddressDataSource : TerraformDataSource
{
    public GoogleComputeAddressDataSource(string name) : base("google_compute_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address");
        this.DeclareOutput("address_type");
        this.DeclareOutput("network");
        this.DeclareOutput("network_tier");
        this.DeclareOutput("prefix_length");
        this.DeclareOutput("purpose");
        this.DeclareOutput("self_link");
        this.DeclareOutput("status");
        this.DeclareOutput("subnetwork");
        this.DeclareOutput("users");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
