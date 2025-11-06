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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    public string? ResponsePolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("response_policy_name")?.Value;
        set => this.WithProperty("response_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
