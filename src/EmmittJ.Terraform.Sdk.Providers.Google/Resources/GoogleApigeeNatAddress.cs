using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("ip_address");
        this.DeclareOutput("state");
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
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// Resource ID of the NAT address.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
