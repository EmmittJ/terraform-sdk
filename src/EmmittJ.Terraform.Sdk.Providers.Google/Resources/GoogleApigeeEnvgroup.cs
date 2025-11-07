using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_envgroup resource.
/// </summary>
public class GoogleApigeeEnvgroup : TerraformResource
{
    public GoogleApigeeEnvgroup(string name) : base("google_apigee_envgroup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Hostnames of the environment group.
    /// </summary>
    public TerraformProperty<List<string>>? Hostnames
    {
        get => GetProperty<TerraformProperty<List<string>>>("hostnames");
        set => this.WithProperty("hostnames", value);
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
    /// The resource ID of the environment group.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee environment group,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

}
