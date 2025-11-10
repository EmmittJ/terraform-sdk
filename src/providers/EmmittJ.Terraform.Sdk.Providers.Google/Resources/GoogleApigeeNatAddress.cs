using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeNatAddressTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_apigee_nat_address resource.
/// </summary>
public class GoogleApigeeNatAddress : TerraformResource
{
    public GoogleApigeeNatAddress(string name) : base("google_apigee_nat_address", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("ip_address");
        this.WithOutput("state");
    }

    /// <summary>
    /// Flag that specifies whether the reserved NAT address should be activate.
    /// </summary>
    public TerraformProperty<bool>? Activate
    {
        get => GetProperty<TerraformProperty<bool>>("activate");
        set => this.WithProperty("activate", value);
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
    /// The Apigee instance associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/instances/{{instance_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// Resource ID of the NAT address.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeNatAddressTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeNatAddressTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The allocated NAT IP address.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

    /// <summary>
    /// State of the NAT IP address.
    /// </summary>
    public TerraformExpression State => this["state"];

}
