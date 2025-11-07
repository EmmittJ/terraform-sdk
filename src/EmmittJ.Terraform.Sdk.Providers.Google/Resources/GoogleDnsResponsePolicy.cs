using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dns_response_policy resource.
/// </summary>
public class GoogleDnsResponsePolicy : TerraformResource
{
    public GoogleDnsResponsePolicy(string name) : base("google_dns_response_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description of the response policy, such as &#39;My new response policy&#39;.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    public TerraformProperty<string>? ResponsePolicyName
    {
        get => GetProperty<TerraformProperty<string>>("response_policy_name");
        set => this.WithProperty("response_policy_name", value);
    }

}
