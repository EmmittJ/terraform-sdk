using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudsearch_domain_service_access_policy resource.
/// </summary>
public class AwsCloudsearchDomainServiceAccessPolicy : TerraformResource
{
    public AwsCloudsearchDomainServiceAccessPolicy(string name) : base("aws_cloudsearch_domain_service_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public string? AccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policy")?.Value;
        set => this.WithProperty("access_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
